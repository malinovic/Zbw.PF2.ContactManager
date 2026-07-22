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

        boxSalutation.DataSource = Enum.GetValues<Salutation>();
        boxSex.DataSource = Enum.GetValues<Sex>();
        boxTitle.DataSource = Enum.GetValues<Title>();
        boxSalutation.SelectedIndex = -1;
        boxSex.SelectedIndex = -1;
        boxTitle.SelectedIndex = -1;
    }

    private void FormAddEmployee_Load(object sender, EventArgs e)
    {

    }




    private void buttonSave_Click(object sender, EventArgs e)
    {

        Salutation selectedSalutation = (Salutation)boxSalutation.SelectedItem;
        Sex selectedSex = (Sex)boxSex.SelectedItem;
        Title selectedTitle = (Title)boxTitle.SelectedItem;

        if (!int.TryParse(boxZipCode.Text, out int zipCode))
        {
            MessageBox.Show("Bitte eine gültige Postleitzahl eingeben.");
            return;
        }


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
                ZipCode = zipCode,
                City = boxCity.Text,
            },
            PhoneNumberCompany = boxPhoneNumberCompany.Text,
            PhoneNumberMobile = boxPhoneNumberMobile.Text,
            Email = boxEmail.Text,

        };
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        FormAddEmployee.ActiveForm.Close();
    }
}

