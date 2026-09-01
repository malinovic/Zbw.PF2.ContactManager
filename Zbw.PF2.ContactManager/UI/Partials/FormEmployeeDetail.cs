using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Core.Validation;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Identity;
using Zbw.PF2.ContactManager.Service.Validation;
using Zbw.PF2.ContactManager.Validation.ValidationEmployee;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormEmployeeDetail : Form
{
    private readonly EmployeeValidatorService _employeeValidator;
    private readonly IContactManagerRepository _repository;
    private readonly IIdentityService _identityService;
    private readonly Employee? _editingEmployee;

    /// <summary>
    ///     Opens the form for creating a new employee.
    /// </summary>
    public FormEmployeeDetail() : this(null)
    {
    }

    /// <summary>
    ///     Opens the form pre-filled for editing an existing employee. Passing <c>null</c> keeps
    ///     the original "create new employee" behavior.
    /// </summary>
    public FormEmployeeDetail(Employee? employee)
    {
        InitializeComponent();

        _employeeValidator = new();
        boxStatus.SelectedIndexChanged += boxStatus_SelectedIndexChanged;


        InitializeComboBoxes();
        RegisterEvents();
        SetupView();


        _repository = new ContactManagerRepository(new CSVRepository());
        _identityService = new IdentityService();

        _editingEmployee = employee;
        if (employee is not null)
        {
            PopulateFields(employee);
            Text = "Mitarbeiter bearbeiten";
        }
        else
        {
            boxEmployeeNumber.Text = _identityService.GenerateEmployeeId(_repository.GetEmployees());
        }
    }

    private void PopulateFields(Employee employee)
    {
        boxSalutation.SelectedItem = employee.Salutation;
        boxFirstName.Text = employee.FirstName;
        boxLastName.Text = employee.LastName;
        boxBirthday.Text = employee.Birthday.ToShortDateString();
        boxSex.SelectedItem = employee.Sex;
        boxTitle.SelectedItem = employee.Title;

        boxStreet.Text = employee.Address.StreetName;
        boxStreetNumber.Text = employee.Address.StreetNumber;
        boxZipCode.Text = employee.Address.ZipCode.ToString();
        boxCity.Text = employee.Address.City;

        boxPhoneNumberCompany.Text = employee.PhoneNumberCompany;
        boxPhoneNumberMobile.Text = employee.PhoneNumberMobile;
        boxEmail.Text = employee.Email;

        boxEmployeeNumber.Text = employee.EmployeeNumber;
        boxDepartment.Text = employee.Department;
        boxAhvNumber.Text = employee.AhvNumber;
        boxNationality.Text = employee.Nationality;
        boxEmploymentRate.Text = employee.EmploymentRate.ToString();
        boxRole.Text = employee.Role;
        boxApprenticeshipYears.Text = employee.ApprenticeshipYears?.ToString() ?? string.Empty;
        boxSeniorLevel.Text = employee.SeniorLevel.ToString();

        boxWorkStreet.Text = employee.WorkAddress.StreetName;
        boxWorkStreetNumber.Text = employee.WorkAddress.StreetNumber;
        boxWorkZipCode.Text = employee.WorkAddress.ZipCode.ToString();
        boxWorkCity.Text = employee.WorkAddress.City;

        boxDateOfHire.Text = employee.DateOfHire.ToShortDateString();
        boxStatus.SelectedItem = employee.Status;
    }

    private void InitializeComboBoxes()
    {
        boxSalutation.DataSource = Enum.GetValues<Salutation>();
        boxSex.DataSource = Enum.GetValues<Sex>();
        boxTitle.DataSource = Enum.GetValues<Title>();
        boxStatus.DataSource = Enum.GetValues<Status>();

        boxSalutation.Format += (_, e) => e.Value = ((Salutation)e.ListItem!).ToGerman();
        boxSex.Format += (_, e) => e.Value = ((Sex)e.ListItem!).ToGerman();
        boxTitle.Format += (_, e) => e.Value = ((Title)e.ListItem!).ToGerman();
        boxStatus.Format += (_, e) => e.Value = ((Status)e.ListItem!).ToGerman();

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

        ThemeManager.ApplyModernFieldStyles(this);
        SetupStatusSection();

        ThemeManager.ApplyButtonStyles(buttonSave);
        ThemeManager.ApplyButtonStyles(buttonCancel);
    }

    private void SetupStatusSection()
    {
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

            EmploymentRate = int.TryParse(boxEmploymentRate.Text.Trim(), out int employmentRate)
                ? employmentRate
                : 0,

            Role = boxRole.Text.Trim(),

            ApprenticeshipYears = int.TryParse(boxApprenticeshipYears.Text.Trim(), out int apprenticeshipYears)
                 ? apprenticeshipYears
                 : null,

            EmployeeStatus =
            boxStatus.SelectedItem is Status status
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


    private static Employee CreateEmployee(EmployeeInput input, int id)
    {
        return new Employee
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
            EmploymentRate = input.EmploymentRate,
            Role = input.Role,
            ApprenticeshipYears = input.ApprenticeshipYears,
            DateOfTermination = input.DateOfTermination != null && input.DateOfTermination != "" ? DateOnly.Parse(input.DateOfTermination) : null,

            WorkAddress = new Address()
            {
                StreetName = input.WorkStreetName,
                StreetNumber = input.WorkStreetNumber,
                ZipCode = int.Parse(input.WorkZipCode),
                City = input.WorkCity,
            },
            Status = input.EmployeeStatus!.Value,
            SeniorLevel = input.EmployeeSeniorLevel!.Value,
            DateOfHire = DateOnly.Parse(input.DateOfHire!),
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

        int id = _editingEmployee?.Id ?? 0;
        var employee = CreateEmployee(input, id);

        if (_editingEmployee is null)
        {
            _repository.AddEmployee(employee);
            MessageBox.Show("Mitarbeiter wurde erfolgreich gespeichert");
        }
        else
        {
            _repository.UpdateEmployee(employee);
            MessageBox.Show("Mitarbeiter wurde erfolgreich aktualisiert");
        }

        Close();
    }


    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult confirmation = MessageBox.Show(
            $"Wollen sie wirklich abbrechen? Ungespeicherte Änderungen gehen verloren.",
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

