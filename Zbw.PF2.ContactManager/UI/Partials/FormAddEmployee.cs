
using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Validation;
using Zbw.PF2.ContactManager.Validation.ValidationEmployee;
using Zbw.PF2.ContactManager.Data.Repository;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormAddEmployee : Form
{
    private readonly EmployeeValidator _employeeValidator;
    private readonly IContactManagerRepository _repository;

    public FormAddEmployee()
    {
        InitializeComponent();

        _employeeValidator = new EmployeeValidator();


        SetupView();

        boxSalutation.DataSource = Enum.GetValues<Salutation>();
        boxSex.DataSource = Enum.GetValues<Sex>();
        boxTitle.DataSource = Enum.GetValues<Title>();
        boxSalutation.SelectedIndex = -1;
        boxSex.SelectedIndex = -1;
        boxTitle.SelectedIndex = -1;
    }

    private void SetupView()
    {
        Font = FontManager.InterRegular;


        ThemeManager.AlignPanelsVertically(
            25,
            panelSalutation,
            panelFirstName,
            panelLastName,
            panelBirthday,
            panelSex,
            panelTitle,
            panelStreet,
            panelStreetNumber,
            panelZipCode,
            panelCity
            );

        ThemeManager.AlignTextBoxesVertically(
            75,
            (boxFirstName, panelFirstName),
            (boxLastName, panelLastName),
            (boxBirthday, panelBirthday),
            (boxStreet, panelStreet),
            (boxStreetNumber, panelStreetNumber),
            (boxZipCode, panelZipCode),
            (boxCity, panelCity)
            );

        ThemeManager.AlignComboBoxesVertically(
            75,
            (boxSalutation, panelSalutation),
            (boxSex, panelSex),
            (boxTitle, panelTitle)
            );

        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelSalutation, panelSalutation);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelFirstName, panelFirstName);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelLastName, panelLastName);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelBirthday, panelBirthday);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelSex, panelSex);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelTitle, panelTitle);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelStreet, panelStreet);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelStreetNumber, panelStreetNumber);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelZipCode, panelZipCode);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelCity, panelCity);



        ThemeManager.AlignPanelsVertically(
            25,
            panelPhoneNumberCompany,
            panelPhoneNumberMobile,
            panelEmail

            );

        ThemeManager.AlignTextBoxesVertically(
            100,
            (boxPhoneNumberCompany, panelPhoneNumberCompany),
            (boxPhoneNumberMobile, panelPhoneNumberMobile),
            (boxEmail, panelEmail)
            );


        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelPhoneNumberCompany, panelPhoneNumberCompany);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelPhoneNumberMobile, panelPhoneNumberMobile);
        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(labelEmail, panelEmail);
    }


    private void FormAddEmployee_Load(object sender, EventArgs e)
    {

    }


    private EmployeeInput ReadInput()
    {

        return new EmployeeInput
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

            PrivateStreetName = boxStreet.Text.Trim(),
            PrivateStreetNumber = boxStreetNumber.Text.Trim(),
            PrivateZipCode = boxZipCode.Text.Trim(),
            PrivateCity = boxCity.Text.Trim(),

            PhoneNumberCompany =
            boxPhoneNumberCompany.Text.Trim(),

            PhoneNumberMobile =
            boxPhoneNumberMobile.Text.Trim(),

            Email = boxEmail.Text.Trim()
        };
    }



    private void buttonSave_Click(object sender, EventArgs e)
    {

        EmployeeInput input = ReadInput();

        ValidationResult result = _employeeValidator.Validate(input);

        if (!result.IsValid)
        {
            Salutation = selectedSalutation,
            FirstName = boxFirstName.Text,
            LastName = boxLastName.Text,
            Birthday = DateOnly.Parse(boxBirthday.Text),
            Sex = selectedSex,
            Title = selectedTitle,
            Address = new Address()
            {
                StreetName = boxStreet.Text,
                StreetNumber = boxStreetNumber.Text,
                ZipCode = int.Parse(boxZipCode.Text),
                City = boxCity.Text,
            },
            PhoneNumberCompany = boxPhoneNumberCompany.Text,
            PhoneNumberMobile = boxPhoneNumberMobile.Text,
            Email = boxEmail.Text,
            EmployeeNumber = string.Empty,
            Department = string.Empty,
            AhvNumber = string.Empty,
            Nationality = string.Empty,
            EmployeeStatusMessage = string.Empty,
            EmployeeEmploymentRate = 0,
            Role = string.Empty,
            EmployeeApprenticeshipYears = 0,
            WorkAddress = new Address()
            {
                StreetName = boxStreet.Text,
                StreetNumber = boxStreetNumber.Text,
                ZipCode = int.Parse(boxZipCode.Text),
                City = boxCity.Text,
            },
            EmployeeStatus = Status.Active,
            EmployeeSeniorLevel = EmployeeSeniorLevel.Level0,
            EmployeeDateOfHire = DateOnly.FromDateTime(DateTime.Today),


        DialogResult = DialogResult.OK;
        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }




}

