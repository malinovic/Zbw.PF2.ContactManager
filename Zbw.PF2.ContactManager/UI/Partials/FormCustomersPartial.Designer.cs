namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormCustomersPartial
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        btnCreateNewCustomers = new Button();
        panel1 = new Panel();
        panel2 = new Panel();
        panel4 = new Panel();
        dgvCustomers = new DataGridView();
        contactManagerRepositoryBindingSource = new BindingSource(components);
        panelSearchHeader = new Panel();
        txtSearchCustomers = new TextBox();
        cmbStatusFilter = new ComboBox();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
        ((System.ComponentModel.ISupportInitialize)contactManagerRepositoryBindingSource).BeginInit();
        panelSearchHeader.SuspendLayout();
        SuspendLayout();
        // 
        // btnCreateNewCustomers
        // 
        btnCreateNewCustomers.Location = new Point(13, 13);
        btnCreateNewCustomers.Name = "btnCreateNewCustomers";
        btnCreateNewCustomers.Size = new Size(330, 62);
        btnCreateNewCustomers.TabIndex = 1;
        btnCreateNewCustomers.Text = "Neuer Kunde";
        btnCreateNewCustomers.UseVisualStyleBackColor = true;
        btnCreateNewCustomers.Click += btnCreateNewCustomer_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnCreateNewCustomers);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 1249);
        panel1.Name = "panel1";
        panel1.Size = new Size(2167, 93);
        panel1.TabIndex = 2;
        // 
        // panel2
        // 
        panel2.Controls.Add(panel4);
        panel2.Controls.Add(panelSearchHeader);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(2167, 1249);
        panel2.TabIndex = 3;
        // 
        // panel4
        // 
        panel4.Controls.Add(dgvCustomers);
        panel4.Dock = DockStyle.Fill;
        panel4.Location = new Point(0, 90);
        panel4.Name = "panel4";
        panel4.Size = new Size(2167, 1159);
        panel4.TabIndex = 2;
        // 
        // dgvCustomers
        // 
        dgvCustomers.AllowUserToAddRows = false;
        dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvCustomers.AutoGenerateColumns = false;
        dgvCustomers.BackgroundColor = Color.White;
        dgvCustomers.BorderStyle = BorderStyle.None;
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomers.DataSource = contactManagerRepositoryBindingSource;
        dgvCustomers.GridColor = Color.Gainsboro;
        dgvCustomers.Location = new Point(0, 0);
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.ReadOnly = true;
        dgvCustomers.RowHeadersVisible = false;
        dgvCustomers.RowHeadersWidth = 82;
        dgvCustomers.RowTemplate.Height = 48;
        dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCustomers.Size = new Size(2167, 1159);
        dgvCustomers.TabIndex = 0;
        // 
        // panelSearchHeader
        // 
        panelSearchHeader.BackColor = Color.White;
        panelSearchHeader.Controls.Add(txtSearchCustomers);
        panelSearchHeader.Controls.Add(cmbStatusFilter);
        panelSearchHeader.Dock = DockStyle.Top;
        panelSearchHeader.Location = new Point(0, 0);
        panelSearchHeader.Name = "panelSearchHeader";
        panelSearchHeader.Size = new Size(2167, 90);
        panelSearchHeader.TabIndex = 1;
        // 
        // txtSearchCustomers
        // 
        txtSearchCustomers.BorderStyle = BorderStyle.FixedSingle;
        txtSearchCustomers.Location = new Point(0, 24);
        txtSearchCustomers.Name = "txtSearchCustomers";
        txtSearchCustomers.PlaceholderText = "Suche nach Name, Personalnummer, Abteilung...";
        txtSearchCustomers.Size = new Size(724, 39);
        txtSearchCustomers.TabIndex = 0;
        txtSearchCustomers.TextChanged += TxtSearchCustomer_TextChanged;
        // 
        // cmbStatusFilter
        // 
        cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatusFilter.FormattingEnabled = true;
        cmbStatusFilter.Location = new Point(748, 24);
        cmbStatusFilter.Name = "cmbStatusFilter";
        cmbStatusFilter.Size = new Size(220, 40);
        cmbStatusFilter.TabIndex = 1;
        cmbStatusFilter.SelectedIndexChanged += CmbStatusFilter_SelectedIndexChanged;
        // 
        // FormCustomersPartial
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(2167, 1342);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormCustomersPartial";
        Text = "FormCustomersPartial";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
        ((System.ComponentModel.ISupportInitialize)contactManagerRepositoryBindingSource).EndInit();
        panelSearchHeader.ResumeLayout(false);
        panelSearchHeader.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button btnCreateNewCustomers;
    private Panel panel1;
    private Panel panel2;
    private DataGridView dgvCustomers;
    private BindingSource contactManagerRepositoryBindingSource;
    private Panel panel4;
    private Panel panelSearchHeader;
    private TextBox txtSearchCustomers;
    private ComboBox cmbStatusFilter;
}
