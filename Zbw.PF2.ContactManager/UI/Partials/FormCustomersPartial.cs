using Zbw.PF2.ContactManager.Data.Repository;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormCustomersPartial : Form
{
    private readonly IContactManagerRepository _repository;

    public FormCustomersPartial(IContactManagerRepository repository)
    {
        InitializeComponent();

        _repository = repository;
    }

    private void btnCreateNewCustomer_Click(object sender, EventArgs e)
    {
        var customerDetailForm = new FormCustomerDetail();

        customerDetailForm.Show();
    }
}