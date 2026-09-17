using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Core.Validation;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Identity;
using Zbw.PF2.ContactManager.Service.Validation;
using Zbw.PF2.ContactManager.Validation.ValidationCustomer;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormCustomerNotes : Form
{
    private readonly IContactManagerRepository _repository;
    private readonly Customer? _currectCustomer;
    private readonly User _currentUser;

    /// <summary>
    ///     Opens the form pre-filled for the given customer's notes.
    /// </summary>
    /// <param name="customer">The customer whose notes are being viewed.</param>
    /// <param name="currentUser">The currently logged-in user, recorded as the author of any new note.</param>
    public FormCustomerNotes(Customer? customer, User currentUser)
    {
        InitializeComponent();

        _repository = new ContactManagerRepository(new CSVRepository());
        _currectCustomer = customer;
        _currentUser = currentUser;

        PopulateCustomerInfo(customer);
        SetupView();
        LoadContactHistory();
    }

    private void PopulateCustomerInfo(Customer? customer)
    {
        labelFirstNameValue.Text = customer?.FirstName ?? string.Empty;
        labelLastNameValue.Text = customer?.LastName ?? string.Empty;
        labelCustomerNumberValue.Text = customer?.CustomerNumber ?? string.Empty;
        labelStatusValue.Text = customer is not null ? customer.CustomerStatus.ToGerman() : string.Empty;
    }

    private void SetupView()
    {
        Font = FontManager.InterRegular;

        ApplyModernFieldStyles(this);
        ApplyValueLabelStyle(labelFirstNameValue);
        ApplyValueLabelStyle(labelLastNameValue);
        ApplyValueLabelStyle(labelCustomerNumberValue);
        ApplyValueLabelStyle(labelStatusValue);

        ThemeManager.ApplyButtonStyles(buttonSave);
        ThemeManager.ApplyButtonStyles(buttonCancel);
    }

    /// <summary>
    ///     Reloads the contact history for the current customer, newest first, rendering each
    ///     entry as a stacked date-then-note card (rather than a Date/Note table) so the note text
    ///     has room to word-wrap instead of being squeezed into a single table row.
    /// </summary>
    private void LoadContactHistory()
    {
        flowHistory.SuspendLayout();
        flowHistory.Controls.Clear();

        if (_currectCustomer is null)
        {
            flowHistory.ResumeLayout();
            return;
        }

        Dictionary<int, string> authorNamesByUserId = _repository.GetUsers().ToDictionary(user => user.Id, user => user.Name);

        foreach (CustomerContact contact in _repository.GetCustomerContacts(_currectCustomer.Id))
        {
            string authorName = authorNamesByUserId.GetValueOrDefault(contact.CreatedByUserId, "Unbekannt");
            flowHistory.Controls.Add(CreateHistoryCard(contact, authorName));
        }

        flowHistory.ResumeLayout();
    }

    /// <summary>
    ///     Builds a single contact-history entry: the contact date and author on top, the note
    ///     text below it, word-wrapped to the card's width so long notes never overflow the panel
    ///     horizontally.
    /// </summary>
    private Panel CreateHistoryCard(CustomerContact contact, string authorName)
    {
        int cardWidth = flowHistory.ClientSize.Width - flowHistory.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth;
        const int cardPadding = 10;

        Panel card = new()
        {
            Width = cardWidth,
            BorderStyle = BorderStyle.FixedSingle,
            Margin = new Padding(0, 0, 0, 8),
            Padding = new Padding(cardPadding)
        };

        Label dateLabel = new()
        {
            AutoSize = true,
            Location = new Point(cardPadding, cardPadding),
            Text = $"{contact.ContactDate:dd.MM.yyyy HH:mm} von {authorName}",
            Font = new Font(FontManager.InterRegular.FontFamily, LabelFontSize, FontStyle.Bold),
            ForeColor = Color.DimGray
        };

        Label noteLabel = new()
        {
            AutoSize = true,
            Location = new Point(cardPadding, dateLabel.Bottom + 4),
            Text = contact.Note,
            Font = new Font(FontManager.InterRegular.FontFamily, FieldFontSize),
            ForeColor = Color.Black,
            MaximumSize = new Size(cardWidth - card.Padding.Horizontal, 0)
        };

        card.Controls.Add(dateLabel);
        card.Controls.Add(noteLabel);
        card.Height = noteLabel.Bottom + cardPadding;

        return card;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        string note = richTextBox1.Text.Trim();

        if (_currectCustomer is null || note.Length == 0)
        {
            return;
        }

        _repository.AddCustomerContact(new CustomerContact
        {
            CustomerId = _currectCustomer.Id,
            ContactDate = DateTime.Now,
            Note = note,
            CreatedByUserId = _currentUser.Id
        });

        richTextBox1.Clear();
        LoadContactHistory();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    ///     Restyles a read-only customer info value (e.g. the customer's first name) after the
    ///     generic label styling has been applied, since those values should read as normal text
    ///     rather than the small gray field captions.
    /// </summary>
    private static void ApplyValueLabelStyle(Label label)
    {
        label.Font = new Font(FontManager.InterRegular.FontFamily, FieldFontSize);
        label.ForeColor = Color.Black;
    }

    private const float FieldFontSize = 11F;
    private const float LabelFontSize = 8F;

    /// <summary>
    ///     Recursively applies a flat, modern look (borders, fonts, colors) to every input field,
    ///     label, and group box on the form. Field text is shrunk slightly and the input boxes are
    ///     grown to fill the space reserved for them so more text (e.g. a street name) fits on screen.
    /// </summary>
    private static void ApplyModernFieldStyles(Control root)
    {
        foreach (Control control in root.Controls)
        {
            switch (control)
            {
                case TextBox textBox:
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = new Font(FontManager.InterRegular.FontFamily, FieldFontSize);
                    EnlargeField(textBox);
                    break;
                case RichTextBox richTextBox:
                    // Without this, a RichTextBox inherits its parent GroupBox's bold caption
                    // font instead of the regular field font, since it has no case of its own.
                    richTextBox.BorderStyle = BorderStyle.FixedSingle;
                    richTextBox.Font = new Font(FontManager.InterRegular.FontFamily, FieldFontSize);
                    break;
                case ComboBox comboBox:
                    comboBox.FlatStyle = FlatStyle.Flat;
                    comboBox.Font = new Font(FontManager.InterRegular.FontFamily, FieldFontSize);
                    break;
                case Label label:
                    label.ForeColor = Color.DimGray;
                    label.Font = new Font(FontManager.InterRegular.FontFamily, LabelFontSize, FontStyle.Regular);
                    break;
                case GroupBox groupBox:
                    groupBox.FlatStyle = FlatStyle.Flat;
                    groupBox.Font = new Font(FontManager.InterRegular.FontFamily, 13F, FontStyle.Bold);
                    break;
            }

            ApplyModernFieldStyles(control);
        }
    }

    /// <summary>
    ///     Grows a bottom-docked field to fill the remaining space in its parent panel (i.e. the
    ///     panel height minus whatever is reserved by a top-docked label), instead of leaving a gap.
    /// </summary>
    private static void EnlargeField(Control field)
    {
        if (field.Dock != DockStyle.Bottom || field.Parent is null)
        {
            return;
        }

        int reservedTop = field.Parent.Controls
            .Cast<Control>()
            .Where(sibling => sibling != field && sibling.Dock == DockStyle.Top)
            .Sum(sibling => sibling.Height);

        int availableHeight = field.Parent.ClientSize.Height - reservedTop;

        if (availableHeight <= field.Height)
        {
            return;
        }

        if (field is TextBox textBox)
        {
            textBox.AutoSize = false;
        }

        field.Height = availableHeight;
    }

}
