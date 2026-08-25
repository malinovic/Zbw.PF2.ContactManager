namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormDashboardPartial
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        panelStatTotal = new Panel();
        accentStatTotal = new Panel();
        labelStatTotalTitle = new Label();
        labelStatTotalValue = new Label();
        panelStatCustomers = new Panel();
        accentStatCustomers = new Panel();
        labelStatCustomersTitle = new Label();
        labelStatCustomersValue = new Label();
        panelStatEmployees = new Panel();
        accentStatEmployees = new Panel();
        labelStatEmployeesTitle = new Label();
        labelStatEmployeesValue = new Label();
        panelStatInactive = new Panel();
        accentStatInactive = new Panel();
        labelStatInactiveTitle = new Label();
        labelStatInactiveValue = new Label();
        panelRecentContacts = new Panel();
        listBoxRecentContacts = new ListBox();
        labelRecentContactsTitle = new Label();
        panelNeedsAttention = new Panel();
        panelMissingPhone = new Panel();
        labelMissingPhoneTitle = new Label();
        listBoxMissingPhone = new ListBox();
        panelDuplicates = new Panel();
        listBoxDuplicates = new ListBox();
        labelDuplicatesTitle = new Label();
        labelNeedsAttentionTitle = new Label();
        panelStatTotal.SuspendLayout();
        panelStatCustomers.SuspendLayout();
        panelStatEmployees.SuspendLayout();
        panelStatInactive.SuspendLayout();
        panelRecentContacts.SuspendLayout();
        panelNeedsAttention.SuspendLayout();
        panelMissingPhone.SuspendLayout();
        panelDuplicates.SuspendLayout();
        SuspendLayout();
        // 
        // panelStatTotal
        // 
        panelStatTotal.BackColor = Color.White;
        panelStatTotal.Controls.Add(accentStatTotal);
        panelStatTotal.Controls.Add(labelStatTotalTitle);
        panelStatTotal.Controls.Add(labelStatTotalValue);
        panelStatTotal.Location = new Point(28, 38);
        panelStatTotal.Margin = new Padding(1);
        panelStatTotal.Name = "panelStatTotal";
        panelStatTotal.Size = new Size(238, 83);
        panelStatTotal.TabIndex = 0;
        // 
        // accentStatTotal
        // 
        accentStatTotal.BackColor = Color.SteelBlue;
        accentStatTotal.Dock = DockStyle.Top;
        accentStatTotal.Location = new Point(0, 0);
        accentStatTotal.Margin = new Padding(1);
        accentStatTotal.Name = "accentStatTotal";
        accentStatTotal.Size = new Size(238, 2);
        accentStatTotal.TabIndex = 0;
        // 
        // labelStatTotalTitle
        // 
        labelStatTotalTitle.AutoSize = true;
        labelStatTotalTitle.Font = new Font("Segoe UI", 11F);
        labelStatTotalTitle.ForeColor = Color.Gray;
        labelStatTotalTitle.Location = new Point(12, 9);
        labelStatTotalTitle.Margin = new Padding(1, 0, 1, 0);
        labelStatTotalTitle.Name = "labelStatTotalTitle";
        labelStatTotalTitle.Size = new Size(142, 20);
        labelStatTotalTitle.TabIndex = 1;
        labelStatTotalTitle.Text = "KONTAKTE GESAMT";
        // 
        // labelStatTotalValue
        // 
        labelStatTotalValue.AutoSize = true;
        labelStatTotalValue.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
        labelStatTotalValue.Location = new Point(12, 21);
        labelStatTotalValue.Margin = new Padding(1, 0, 1, 0);
        labelStatTotalValue.Name = "labelStatTotalValue";
        labelStatTotalValue.Size = new Size(46, 54);
        labelStatTotalValue.TabIndex = 2;
        labelStatTotalValue.Text = "0";
        // 
        // panelStatCustomers
        // 
        panelStatCustomers.BackColor = Color.White;
        panelStatCustomers.Controls.Add(accentStatCustomers);
        panelStatCustomers.Controls.Add(labelStatCustomersTitle);
        panelStatCustomers.Controls.Add(labelStatCustomersValue);
        panelStatCustomers.Location = new Point(307, 38);
        panelStatCustomers.Margin = new Padding(1);
        panelStatCustomers.Name = "panelStatCustomers";
        panelStatCustomers.Size = new Size(238, 83);
        panelStatCustomers.TabIndex = 1;
        // 
        // accentStatCustomers
        // 
        accentStatCustomers.BackColor = Color.SeaGreen;
        accentStatCustomers.Dock = DockStyle.Top;
        accentStatCustomers.Location = new Point(0, 0);
        accentStatCustomers.Margin = new Padding(1);
        accentStatCustomers.Name = "accentStatCustomers";
        accentStatCustomers.Size = new Size(238, 2);
        accentStatCustomers.TabIndex = 0;
        // 
        // labelStatCustomersTitle
        // 
        labelStatCustomersTitle.AutoSize = true;
        labelStatCustomersTitle.Font = new Font("Segoe UI", 11F);
        labelStatCustomersTitle.ForeColor = Color.Gray;
        labelStatCustomersTitle.Location = new Point(12, 9);
        labelStatCustomersTitle.Margin = new Padding(1, 0, 1, 0);
        labelStatCustomersTitle.Name = "labelStatCustomersTitle";
        labelStatCustomersTitle.Size = new Size(121, 20);
        labelStatCustomersTitle.TabIndex = 1;
        labelStatCustomersTitle.Text = "AKTIVE KUNDEN";
        // 
        // labelStatCustomersValue
        // 
        labelStatCustomersValue.AutoSize = true;
        labelStatCustomersValue.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
        labelStatCustomersValue.Location = new Point(12, 21);
        labelStatCustomersValue.Margin = new Padding(1, 0, 1, 0);
        labelStatCustomersValue.Name = "labelStatCustomersValue";
        labelStatCustomersValue.Size = new Size(46, 54);
        labelStatCustomersValue.TabIndex = 2;
        labelStatCustomersValue.Text = "0";
        // 
        // panelStatEmployees
        // 
        panelStatEmployees.BackColor = Color.White;
        panelStatEmployees.Controls.Add(accentStatEmployees);
        panelStatEmployees.Controls.Add(labelStatEmployeesTitle);
        panelStatEmployees.Controls.Add(labelStatEmployeesValue);
        panelStatEmployees.Location = new Point(579, 38);
        panelStatEmployees.Margin = new Padding(1);
        panelStatEmployees.Name = "panelStatEmployees";
        panelStatEmployees.Size = new Size(238, 83);
        panelStatEmployees.TabIndex = 2;
        // 
        // accentStatEmployees
        // 
        accentStatEmployees.BackColor = Color.DarkGoldenrod;
        accentStatEmployees.Dock = DockStyle.Top;
        accentStatEmployees.Location = new Point(0, 0);
        accentStatEmployees.Margin = new Padding(1);
        accentStatEmployees.Name = "accentStatEmployees";
        accentStatEmployees.Size = new Size(238, 2);
        accentStatEmployees.TabIndex = 0;
        // 
        // labelStatEmployeesTitle
        // 
        labelStatEmployeesTitle.AutoSize = true;
        labelStatEmployeesTitle.Font = new Font("Segoe UI", 11F);
        labelStatEmployeesTitle.ForeColor = Color.Gray;
        labelStatEmployeesTitle.Location = new Point(12, 9);
        labelStatEmployeesTitle.Margin = new Padding(1, 0, 1, 0);
        labelStatEmployeesTitle.Name = "labelStatEmployeesTitle";
        labelStatEmployeesTitle.Size = new Size(150, 20);
        labelStatEmployeesTitle.TabIndex = 1;
        labelStatEmployeesTitle.Text = "AKTIVE MITARBEITER";
        // 
        // labelStatEmployeesValue
        // 
        labelStatEmployeesValue.AutoSize = true;
        labelStatEmployeesValue.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
        labelStatEmployeesValue.Location = new Point(12, 21);
        labelStatEmployeesValue.Margin = new Padding(1, 0, 1, 0);
        labelStatEmployeesValue.Name = "labelStatEmployeesValue";
        labelStatEmployeesValue.Size = new Size(46, 54);
        labelStatEmployeesValue.TabIndex = 2;
        labelStatEmployeesValue.Text = "0";
        // 
        // panelStatInactive
        // 
        panelStatInactive.BackColor = Color.White;
        panelStatInactive.Controls.Add(accentStatInactive);
        panelStatInactive.Controls.Add(labelStatInactiveTitle);
        panelStatInactive.Controls.Add(labelStatInactiveValue);
        panelStatInactive.Location = new Point(848, 38);
        panelStatInactive.Margin = new Padding(1);
        panelStatInactive.Name = "panelStatInactive";
        panelStatInactive.Size = new Size(238, 83);
        panelStatInactive.TabIndex = 3;
        // 
        // accentStatInactive
        // 
        accentStatInactive.BackColor = Color.Gray;
        accentStatInactive.Dock = DockStyle.Top;
        accentStatInactive.Location = new Point(0, 0);
        accentStatInactive.Margin = new Padding(1);
        accentStatInactive.Name = "accentStatInactive";
        accentStatInactive.Size = new Size(238, 2);
        accentStatInactive.TabIndex = 0;
        // 
        // labelStatInactiveTitle
        // 
        labelStatInactiveTitle.AutoSize = true;
        labelStatInactiveTitle.Font = new Font("Segoe UI", 11F);
        labelStatInactiveTitle.ForeColor = Color.Gray;
        labelStatInactiveTitle.Location = new Point(12, 9);
        labelStatInactiveTitle.Margin = new Padding(1, 0, 1, 0);
        labelStatInactiveTitle.Name = "labelStatInactiveTitle";
        labelStatInactiveTitle.Size = new Size(64, 20);
        labelStatInactiveTitle.TabIndex = 1;
        labelStatInactiveTitle.Text = "INAKTIV";
        // 
        // labelStatInactiveValue
        // 
        labelStatInactiveValue.AutoSize = true;
        labelStatInactiveValue.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
        labelStatInactiveValue.Location = new Point(12, 21);
        labelStatInactiveValue.Margin = new Padding(1, 0, 1, 0);
        labelStatInactiveValue.Name = "labelStatInactiveValue";
        labelStatInactiveValue.Size = new Size(46, 54);
        labelStatInactiveValue.TabIndex = 2;
        labelStatInactiveValue.Text = "0";
        // 
        // panelRecentContacts
        // 
        panelRecentContacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        panelRecentContacts.BackColor = Color.White;
        panelRecentContacts.Controls.Add(listBoxRecentContacts);
        panelRecentContacts.Controls.Add(labelRecentContactsTitle);
        panelRecentContacts.Location = new Point(28, 148);
        panelRecentContacts.Margin = new Padding(1);
        panelRecentContacts.Name = "panelRecentContacts";
        panelRecentContacts.Size = new Size(520, 538);
        panelRecentContacts.TabIndex = 4;
        // 
        // listBoxRecentContacts
        // 
        listBoxRecentContacts.BorderStyle = BorderStyle.None;
        listBoxRecentContacts.Font = new Font("Segoe UI", 12F);
        listBoxRecentContacts.Location = new Point(15, 54);
        listBoxRecentContacts.Margin = new Padding(1);
        listBoxRecentContacts.Name = "listBoxRecentContacts";
        listBoxRecentContacts.Size = new Size(484, 462);
        listBoxRecentContacts.TabIndex = 0;
        listBoxRecentContacts.SelectedIndexChanged += listBoxRecentContacts_SelectedIndexChanged;
        // 
        // labelRecentContactsTitle
        // 
        labelRecentContactsTitle.Dock = DockStyle.Top;
        labelRecentContactsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        labelRecentContactsTitle.Location = new Point(0, 0);
        labelRecentContactsTitle.Margin = new Padding(1, 0, 1, 0);
        labelRecentContactsTitle.Name = "labelRecentContactsTitle";
        labelRecentContactsTitle.Padding = new Padding(12, 8, 0, 0);
        labelRecentContactsTitle.Size = new Size(520, 53);
        labelRecentContactsTitle.TabIndex = 1;
        labelRecentContactsTitle.Text = "Zuletzt hinzugefügte Kontakte";
        // 
        // panelNeedsAttention
        // 
        panelNeedsAttention.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelNeedsAttention.BackColor = Color.White;
        panelNeedsAttention.Controls.Add(panelMissingPhone);
        panelNeedsAttention.Controls.Add(panelDuplicates);
        panelNeedsAttention.Controls.Add(labelNeedsAttentionTitle);
        panelNeedsAttention.Location = new Point(582, 148);
        panelNeedsAttention.Margin = new Padding(1);
        panelNeedsAttention.Name = "panelNeedsAttention";
        panelNeedsAttention.Size = new Size(826, 538);
        panelNeedsAttention.TabIndex = 5;
        // 
        // panelMissingPhone
        // 
        panelMissingPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelMissingPhone.Controls.Add(labelMissingPhoneTitle);
        panelMissingPhone.Controls.Add(listBoxMissingPhone);
        panelMissingPhone.Location = new Point(12, 72);
        panelMissingPhone.Margin = new Padding(1);
        panelMissingPhone.Name = "panelMissingPhone";
        panelMissingPhone.Size = new Size(803, 208);
        panelMissingPhone.TabIndex = 0;
        // 
        // labelMissingPhoneTitle
        // 
        labelMissingPhoneTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        labelMissingPhoneTitle.Location = new Point(-1, 7);
        labelMissingPhoneTitle.Margin = new Padding(1, 0, 1, 0);
        labelMissingPhoneTitle.Name = "labelMissingPhoneTitle";
        labelMissingPhoneTitle.Size = new Size(804, 38);
        labelMissingPhoneTitle.TabIndex = 1;
        labelMissingPhoneTitle.Text = "Kontakte ohne Telefonnummer";
        labelMissingPhoneTitle.Click += labelMissingPhoneTitle_Click;
        // 
        // listBoxMissingPhone
        // 
        listBoxMissingPhone.BorderStyle = BorderStyle.FixedSingle;
        listBoxMissingPhone.Font = new Font("Segoe UI", 11F);
        listBoxMissingPhone.Location = new Point(0, 46);
        listBoxMissingPhone.Margin = new Padding(1);
        listBoxMissingPhone.Name = "listBoxMissingPhone";
        listBoxMissingPhone.Size = new Size(801, 162);
        listBoxMissingPhone.TabIndex = 0;
        listBoxMissingPhone.SelectedIndexChanged += listBoxMissingPhone_SelectedIndexChanged;
        // 
        // panelDuplicates
        // 
        panelDuplicates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelDuplicates.Controls.Add(listBoxDuplicates);
        panelDuplicates.Controls.Add(labelDuplicatesTitle);
        panelDuplicates.Location = new Point(12, 313);
        panelDuplicates.Margin = new Padding(1);
        panelDuplicates.Name = "panelDuplicates";
        panelDuplicates.Size = new Size(803, 217);
        panelDuplicates.TabIndex = 1;
        // 
        // listBoxDuplicates
        // 
        listBoxDuplicates.BorderStyle = BorderStyle.FixedSingle;
        listBoxDuplicates.Font = new Font("Segoe UI", 11F);
        listBoxDuplicates.Location = new Point(0, 35);
        listBoxDuplicates.Margin = new Padding(1);
        listBoxDuplicates.Name = "listBoxDuplicates";
        listBoxDuplicates.Size = new Size(801, 182);
        listBoxDuplicates.TabIndex = 0;
        // 
        // labelDuplicatesTitle
        // 
        labelDuplicatesTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        labelDuplicatesTitle.Location = new Point(-1, 0);
        labelDuplicatesTitle.Margin = new Padding(1, 0, 1, 0);
        labelDuplicatesTitle.Name = "labelDuplicatesTitle";
        labelDuplicatesTitle.Size = new Size(803, 37);
        labelDuplicatesTitle.TabIndex = 1;
        labelDuplicatesTitle.Text = "Mögliche Duplikate erkannt";
        // 
        // labelNeedsAttentionTitle
        // 
        labelNeedsAttentionTitle.Dock = DockStyle.Top;
        labelNeedsAttentionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        labelNeedsAttentionTitle.ForeColor = Color.Firebrick;
        labelNeedsAttentionTitle.Location = new Point(0, 0);
        labelNeedsAttentionTitle.Margin = new Padding(1, 0, 1, 0);
        labelNeedsAttentionTitle.Name = "labelNeedsAttentionTitle";
        labelNeedsAttentionTitle.Padding = new Padding(12, 8, 0, 0);
        labelNeedsAttentionTitle.Size = new Size(826, 43);
        labelNeedsAttentionTitle.TabIndex = 2;
        labelNeedsAttentionTitle.Text = "Bedarf an Überprüfung";
        // 
        // FormDashboardPartial
        // 
        AutoScaleDimensions = new SizeF(6F, 12F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(240, 240, 240);
        ClientSize = new Size(1455, 711);
        Controls.Add(panelStatTotal);
        Controls.Add(panelStatCustomers);
        Controls.Add(panelStatEmployees);
        Controls.Add(panelStatInactive);
        Controls.Add(panelRecentContacts);
        Controls.Add(panelNeedsAttention);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(1);
        Name = "FormDashboardPartial";
        Text = "FormDashboardPartial";
        panelStatTotal.ResumeLayout(false);
        panelStatTotal.PerformLayout();
        panelStatCustomers.ResumeLayout(false);
        panelStatCustomers.PerformLayout();
        panelStatEmployees.ResumeLayout(false);
        panelStatEmployees.PerformLayout();
        panelStatInactive.ResumeLayout(false);
        panelStatInactive.PerformLayout();
        panelRecentContacts.ResumeLayout(false);
        panelNeedsAttention.ResumeLayout(false);
        panelMissingPhone.ResumeLayout(false);
        panelDuplicates.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelStatTotal;
    private Panel accentStatTotal;
    private Label labelStatTotalTitle;
    private Label labelStatTotalValue;

    private Panel panelStatCustomers;
    private Panel accentStatCustomers;
    private Label labelStatCustomersTitle;
    private Label labelStatCustomersValue;

    private Panel panelStatEmployees;
    private Panel accentStatEmployees;
    private Label labelStatEmployeesTitle;
    private Label labelStatEmployeesValue;

    private Panel panelStatInactive;
    private Panel accentStatInactive;
    private Label labelStatInactiveTitle;
    private Label labelStatInactiveValue;

    private Panel panelRecentContacts;
    private Label labelRecentContactsTitle;
    private ListBox listBoxRecentContacts;

    private Panel panelNeedsAttention;
    private Label labelNeedsAttentionTitle;

    private Panel panelMissingPhone;
    private Label labelMissingPhoneTitle;
    private ListBox listBoxMissingPhone;

    private Panel panelDuplicates;
    private Label labelDuplicatesTitle;
    private ListBox listBoxDuplicates;
}