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

    private readonly Customer? _currectCustomer;


    
    public FormCustomerNotes() :this(null)
    {
    }
    

    /// <summary>
    ///     Opens the form pre-filled for editing an existing cutsomer. Passing <c>null</c> keeps
    ///     the original "create new customer" behavior.
    /// </summary>
    /// 


    public FormCustomerNotes(Customer? customer)
    {
        InitializeComponent();

        _currectCustomer = customer;

        PopulateCustomerInfo(customer);
        SetupView();
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
