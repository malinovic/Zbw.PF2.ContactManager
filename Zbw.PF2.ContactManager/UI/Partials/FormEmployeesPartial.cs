using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormEmployeesPartial : Form
{
    public FormEmployeesPartial()
    {
        InitializeComponent();
    }

    private void btnCreateNewEmployee_Click(object sender, EventArgs e)
    {
        var f = new FormAddEmployee();

        f.Show();
    }
}
