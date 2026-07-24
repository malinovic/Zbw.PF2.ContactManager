using Microsoft.VisualBasic;

using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormAddEmployee : Form
{

    public FormAddEmployee()
    {
        InitializeComponent();



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




    private void buttonSave_Click(object sender, EventArgs e)
    {

        Salutation selectedSalutation = (Salutation)boxSalutation.SelectedItem;
        Sex selectedSex = (Sex)boxSex.SelectedItem;
        Title selectedTitle = (Title)boxTitle.SelectedItem;

        Employee employee = new Employee()
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

        };

        FormAddEmployee.ActiveForm.Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        FormAddEmployee.ActiveForm.Close();
    }




}

