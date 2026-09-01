using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Core.Validation;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Identity;
using Zbw.PF2.ContactManager.Service.Validation;
using Zbw.PF2.ContactManager.Validation.ValidationCustomer;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormCustomerDetail : Form
{
    private readonly CustomerValidatorService _customerValidator;
    private readonly IContactManagerRepository _repository;
    private readonly IIdentityService _identityService;

    /// <summary>
    ///     Opens the form for creating a new customer.
    /// </summary>
    public FormCustomerDetail()
    {
        InitializeComponent();

        _customerValidator = new();
        boxStatus.SelectedIndexChanged += boxStatus_SelectedIndexChanged;

        InitializeComboBoxes();
        RegisterEvents();
        SetupView();

        _repository = new ContactManagerRepository(new CSVRepository());
        _identityService = new IdentityService();

        boxCustomerNumber.Text = _identityService.GenerateCustomerId(_repository.GetCustomers());
    }

    private void InitializeComboBoxes()
    {
        boxSalutation.DataSource = Enum.GetValues<Salutation>();
        boxSex.DataSource = Enum.GetValues<Sex>();
        boxTitle.DataSource = Enum.GetValues<Title>();
        boxCustomerType.DataSource = Enum.GetValues<CustomerType>();
        boxStatus.DataSource = Enum.GetValues<Status>();

        boxSalutation.Format += (_, e) => e.Value = ((Salutation)e.ListItem!).ToGerman();
        boxSex.Format += (_, e) => e.Value = ((Sex)e.ListItem!).ToGerman();
        boxTitle.Format += (_, e) => e.Value = ((Title)e.ListItem!).ToGerman();
        boxCustomerType.Format += (_, e) => e.Value = ((CustomerType)e.ListItem!).ToGerman();
        boxStatus.Format += (_, e) => e.Value = ((Status)e.ListItem!).ToGerman();

        boxSalutation.SelectedIndex = -1;
        boxSex.SelectedIndex = -1;
        boxTitle.SelectedIndex = -1;
        boxCustomerType.SelectedIndex = -1;
        boxStatus.SelectedIndex = -1;
    }

    private void RegisterEvents()
    {
        boxStatus.SelectedIndexChanged += boxStatus_SelectedIndexChanged;
    }

    private void SetupView()
    {
        Font = FontManager.InterRegular;

        ApplyModernFieldStyles(this);
        SetupStatusSection();

        ThemeManager.ApplyButtonStyles(buttonSave);
        ThemeManager.ApplyButtonStyles(buttonCancel);
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

    private void SetupStatusSection()
    {
        ThemeManager.ApplyStatusColor(boxStatus);
    }

    private CustomerInput ReadInput()
    {
        return new CustomerInput
        {
            Salutation =
            boxSalutation.SelectedItem is Salutation salutation
                ? salutation
                : null,

            FirstName = boxFirstName.Text.Trim(),
            LastName = boxLastName.Text.Trim(),
            Birthday = boxBirthday.Text.Trim(),

            Sex =
            boxSex.SelectedItem is Sex sex
                ? sex
                : null,

            Title =
            boxTitle.SelectedItem is Title title
                ? title
                : null,

            StreetName = boxStreet.Text.Trim(),
            StreetNumber = boxStreetNumber.Text.Trim(),
            ZipCode = boxZipCode.Text.Trim(),
            City = boxCity.Text.Trim(),
            PhoneNumberCompany = boxPhoneNumberCompany.Text.Trim(),
            PhoneNumberMobile = boxPhoneNumberMobile.Text.Trim(),
            Email = boxEmail.Text.Trim(),
            CustomerNumber = boxCustomerNumber.Text.Trim(),
            CustomerCompanyName = boxCustomerCompanyName.Text.Trim(),

            CustomerStatus =
            boxStatus.SelectedItem is Status status
                ? status
                : null,

            CustomerType =
            boxCustomerType.SelectedItem is CustomerType customerType
                ? customerType
                : null
        };
    }

    private static Customer CreateCustomer(CustomerInput input, int id)
    {
        return new Customer
        {
            Id = id,

            Salutation = input.Salutation!.Value,
            FirstName = input.FirstName,
            LastName = input.LastName,
            Birthday = DateOnly.Parse(input.Birthday!),
            Sex = input.Sex!.Value,
            Title = input.Title!.Value,

            Address = new Address()
            {
                StreetName = input.StreetName,
                StreetNumber = input.StreetNumber,
                ZipCode = int.Parse(input.ZipCode),
                City = input.City,
            },

            PhoneNumberCompany = input.PhoneNumberCompany,
            PhoneNumberMobile = input.PhoneNumberMobile,
            Email = input.Email,
            CustomerNumber = input.CustomerNumber,
            CustomerCompanyName = input.CustomerCompanyName,
            CustomerStatus = input.CustomerStatus!.Value,
            CustomerType = input.CustomerType!.Value,
        };
    }

    private void boxStatus_SelectedIndexChanged(
        object? sender,
        EventArgs e)
    {
        ThemeManager.ApplyStatusColor(boxStatus);
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        CustomerInput input = ReadInput();

        ValidationResult result = _customerValidator.Validate(input);

        if (!result.IsValid)
        {
            MessageBox.Show(string.Join(Environment.NewLine, result.Errors.Select(error => $"• {error.Message}")),
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        Customer customer = CreateCustomer(input, 0);

        _repository.AddCustomer(customer);
        MessageBox.Show("Kunde wurde erfolgreich gespeichert");

        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult confirmation = MessageBox.Show(
            "Wollen sie wirklich abbrechen? Ungespeicherte Änderungen gehen verloren.",
            "Abbrechen?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        Close();
    }
}