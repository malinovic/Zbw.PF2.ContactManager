
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
        boxStatus.SelectedIndexChanged += boxStatus_SelectedIndexChanged;


        InitializeComboBoxes();
        RegisterEvents();
        SetupView();

    }

    private void InitializeComboBoxes()
    {
        boxSalutation.DataSource = Enum.GetValues<Salutation>();
        boxSex.DataSource = Enum.GetValues<Sex>();
        boxTitle.DataSource = Enum.GetValues<Title>();
        boxStatus.DataSource = Enum.GetValues<Status>();

        boxSalutation.SelectedIndex = -1;
        boxSex.SelectedIndex = -1;
        boxTitle.SelectedIndex = -1;
        boxStatus.SelectedIndex = -1;
    }

    private void RegisterEvents()
    {
        boxStatus.SelectedIndexChanged += boxStatus_SelectedIndexChanged;
    }

    private void SetupView()
    {
        Font = FontManager.InterRegular;


        SetupPersonalSection();
        SetupEmployeeSection();
        SetupStatusSection();

    }

    private void SetupPersonalSection()
    {
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
            panelCity,
            panelPhoneNumberCompany,
            panelPhoneNumberMobile,
            panelEmail
            );

        ThemeManager.AlignTextBoxesVertically(
            100,
            (boxFirstName, panelFirstName),
            (boxLastName, panelLastName),
            (boxBirthday, panelBirthday),
            (boxStreet, panelStreet),
            (boxStreetNumber, panelStreetNumber),
            (boxZipCode, panelZipCode),
            (boxCity, panelCity),
            (boxPhoneNumberCompany,panelPhoneNumberCompany),
            (boxPhoneNumberMobile, panelPhoneNumberMobile),
            (boxEmail, panelEmail)
        );

        ThemeManager.AlignComboBoxesVertically(
            100,
            (boxSalutation, panelSalutation),
            (boxSex, panelSex),
            (boxTitle, panelTitle)
        );

        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(
            (labelSalutation, panelSalutation),
            (labelFirstName, panelFirstName),
            (labelLastName, panelLastName),
            (labelBirthday, panelBirthday),
            (labelSex, panelSex),
            (labelTitle, panelTitle),
            (labelStreet, panelStreet),
            (labelStreetNumber, panelStreetNumber),
            (labelZipCode, panelZipCode),
            (labelCity, panelCity),
            (labelPhoneNumberCompany, panelPhoneNumberCompany),
            (labelPhoneNumberMobile, panelPhoneNumberMobile),
            (labelEmail, panelEmail)
        );
    }

    private void SetupEmployeeSection()
    {
        ThemeManager.AlignPanelsVertically(
            25,
            panelEmployeeNumber,
            panelDepartment,
            panelAhvNumber,
            panelNationality,
            panelEmploymentRate,
            panelRole,
            panelApprenticeshipYears,
            panelSeniorLevel,
            panelWorkStreet,
            panelWorkStreetNumber,
            panelWorkZipCode,
            panelWorkCity,
            panelDateOfHire
        );


        ThemeManager.AlignTextBoxesVertically(
            200,
            (boxEmployeeNumber, panelEmployeeNumber),
            (boxDepartment, panelDepartment),
            (boxAhvNumber, panelAhvNumber),
            (boxNationality, panelNationality),
            (boxEmploymentRate, panelEmploymentRate),
            (boxRole, panelRole),
            (boxApprenticeshipYears, panelApprenticeshipYears),
            (boxSeniorLevel, panelSeniorLevel),
            (boxWorkStreet, panelWorkStreet),
            (boxWorkStreetNumber, panelWorkStreetNumber),
            (boxWorkZipCode, panelWorkZipCode),
            (boxWorkCity, panelWorkCity),
            (boxDateOfHire, panelDateOfHire)
        );


        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(
            (labelEmployeeNumber, panelEmployeeNumber),
            (labelDepartment, panelDepartment),
            (labelAhvNumber, panelAhvNumber),
            (labelNationality, panelNationality),
            (labelEmploymentRate, panelEmploymentRate),
            (labelRole, panelRole),
            (labelApprenticeshipYears, panelApprenticeshipYears),
            (labelSeniorLevel, panelSeniorLevel),
            (labelWorkStreet, panelWorkStreet),
            (labelWorkStreetNumber, panelWorkStreetNumber),
            (labelWorkZipCode, panelWorkZipCode),
            (labelWorkCity, panelWorkCity),
            (labelDateOfHire, panelDateOfHire)
        );
    }

    private void SetupStatusSection()
    {
      
        panelStatus.Top = panelSalutation.Top;
        boxStatus.Top = boxSalutation.Top;

        ThemeManager.ApplyAddEmployeeLabelAndPanelStyles(
            labelStatus,
            panelStatus);

        ThemeManager.ApplyStatusColor(boxStatus);
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
            PhoneNumberCompany = boxPhoneNumberCompany.Text.Trim(),
            PhoneNumberMobile =
            boxPhoneNumberMobile.Text.Trim(),
            Email = boxEmail.Text.Trim(),
            EmployeeNumber = boxEmployeeNumber.Text.Trim(),
            Department = boxDepartment.Text.Trim(),
            AhvNumber = boxAhvNumber.Text.Trim(),
            Nationality = boxNationality.Text.Trim(),

            EmploymentRate =int.TryParse(boxEmploymentRate.Text.Trim(), out int employmentRate)
                ? employmentRate
                : 0,

            Role = boxRole.Text.Trim(),

            ApprenticeshipYears = int.TryParse(boxApprenticeshipYears.Text.Trim(), out int apprenticeshipYears)
                 ? apprenticeshipYears
                 : null,

            EmployeeStatus = Enum.TryParse<Status>(boxStatus.Text, true, out Status status)
                ? status
                : null,

            EmployeeSeniorLevel = Enum.TryParse<EmployeeSeniorLevel>(boxSeniorLevel.Text.Trim(), true, out EmployeeSeniorLevel seniorLevel)
                 ? seniorLevel
                 : null,

            DateOfHire = boxDateOfHire.Text.Trim(),
            WorkStreetName = boxWorkStreet.Text.Trim(),
            WorkStreetNumber = boxWorkStreetNumber.Text.Trim(),
            WorkZipCode = boxWorkZipCode.Text.Trim(),
            WorkCity = boxWorkCity.Text.Trim()
        };
    }


    private static Employee CreateEmployee(EmployeeInput input)
    {
        return new Employee
        {

            Salutation = input.Salutation!.Value,
            FirstName = input.FirstName,
            LastName = input.LastName,
            Birthday = input.Birthday!,
            Sex = input.Sex!.Value,
            Title = input.Title!.Value,

            Address = new Address()
            {
                StreetName = input.PrivateStreetName,
                StreetNumber = input.PrivateStreetNumber,
                ZipCode = int.Parse(input.PrivateZipCode),
                City = input.PrivateCity,
            },

            PhoneNumberCompany = input.PhoneNumberCompany,
            PhoneNumberMobile = input.PhoneNumberMobile,
            Email = input.Email,
            EmployeeNumber = input.EmployeeNumber,
            Department = input.Department,
            AhvNumber = input.AhvNumber,
            Nationality = input.Nationality,
            EmployeeEmploymentRate = input.EmploymentRate,
            Role = input.Role,
            EmployeeApprenticeshipYears = input.ApprenticeshipYears,
            EmployeeDateOfTermination = input.DateOfTermination,

            WorkAddress = new Address()
            {
                StreetName = input.PrivateStreetName,
                StreetNumber = input.PrivateStreetNumber,
                ZipCode = int.Parse(input.PrivateZipCode),
                City = input.PrivateCity,
            },

            EmployeeStatus = input.EmployeeStatus!.Value,
            EmployeeSeniorLevel = input.EmployeeSeniorLevel!.Value,
            EmployeeDateOfHire = input.DateOfHire!,
        };
    }

    private static void ShowValidationErrors(ValidationResult result)
    {
        string messages = string.Join(Environment.NewLine, result.Errors.Select(error => $"• {error.Message}"));

        MessageBox.Show( messages, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void boxStatus_SelectedIndexChanged(
        object? sender,
        EventArgs e)
    {
        ThemeManager.ApplyStatusColor(boxStatus);
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        EmployeeInput input = ReadInput();

        ValidationResult result = _employeeValidator.Validate(input);

        if (!result.IsValid)
        {
            MessageBox.Show(string.Join(Environment.NewLine, result.Errors.Select(error => $"• {error.Message}")),
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }
    }


    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FormAddEmployee_Load(object sender, EventArgs e)
    {

    }




}

