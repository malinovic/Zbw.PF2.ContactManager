namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormEmployeesPartial
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
        btnCreateNewEmployee = new Button();
        panel1 = new Panel();
        panel2 = new Panel();
        panel4 = new Panel();
        dgvEmployees = new DataGridView();
        contactManagerRepositoryBindingSource = new BindingSource(components);
        panelSearchHeader = new Panel();
        txtSearchEmployee = new TextBox();
        cmbStatusFilter = new ComboBox();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
        ((System.ComponentModel.ISupportInitialize)contactManagerRepositoryBindingSource).BeginInit();
        panelSearchHeader.SuspendLayout();
        SuspendLayout();
        // 
        // btnCreateNewEmployee
        // 
        btnCreateNewEmployee.Location = new Point(13, 13);
        btnCreateNewEmployee.Name = "btnCreateNewEmployee";
        btnCreateNewEmployee.Size = new Size(330, 62);
        btnCreateNewEmployee.TabIndex = 1;
        btnCreateNewEmployee.Text = "Neuer Mitarbeiter";
        btnCreateNewEmployee.UseVisualStyleBackColor = true;
        btnCreateNewEmployee.Click += BtnCreateNewEmployee_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnCreateNewEmployee);
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
        panel4.Controls.Add(dgvEmployees);
        panel4.Dock = DockStyle.Fill;
        panel4.Location = new Point(0, 90);
        panel4.Name = "panel4";
        panel4.Size = new Size(2167, 1159);
        panel4.TabIndex = 2;
        // 
        // dgvEmployees
        // 
        dgvEmployees.AllowUserToAddRows = false;
        dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvEmployees.AutoGenerateColumns = false;
        dgvEmployees.BackgroundColor = Color.White;
        dgvEmployees.BorderStyle = BorderStyle.None;
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEmployees.DataSource = contactManagerRepositoryBindingSource;
        dgvEmployees.GridColor = Color.Gainsboro;
        dgvEmployees.Location = new Point(0, 0);
        dgvEmployees.Name = "dgvEmployees";
        dgvEmployees.ReadOnly = true;
        dgvEmployees.RowHeadersVisible = false;
        dgvEmployees.RowHeadersWidth = 82;
        dgvEmployees.RowTemplate.Height = 48;
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEmployees.Size = new Size(2167, 1159);
        dgvEmployees.TabIndex = 0;
        // 
        // panelSearchHeader
        // 
        panelSearchHeader.BackColor = Color.White;
        panelSearchHeader.Controls.Add(txtSearchEmployee);
        panelSearchHeader.Controls.Add(cmbStatusFilter);
        panelSearchHeader.Dock = DockStyle.Top;
        panelSearchHeader.Location = new Point(0, 0);
        panelSearchHeader.Name = "panelSearchHeader";
        panelSearchHeader.Size = new Size(2167, 90);
        panelSearchHeader.TabIndex = 1;
        // 
        // txtSearchEmployee
        // 
        txtSearchEmployee.BorderStyle = BorderStyle.FixedSingle;
        txtSearchEmployee.Location = new Point(0, 24);
        txtSearchEmployee.Name = "txtSearchEmployee";
        txtSearchEmployee.PlaceholderText = "Suche nach Name, Personalnummer, Abteilung...";
        txtSearchEmployee.Size = new Size(724, 39);
        txtSearchEmployee.TabIndex = 0;
        txtSearchEmployee.TextChanged += TxtSearchEmployee_TextChanged;
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
        // FormEmployeesPartial
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(2167, 1342);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormEmployeesPartial";
        Text = "FormEmployeesPartial";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
        ((System.ComponentModel.ISupportInitialize)contactManagerRepositoryBindingSource).EndInit();
        panelSearchHeader.ResumeLayout(false);
        panelSearchHeader.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button btnCreateNewEmployee;
    private Panel panel1;
    private Panel panel2;
    private DataGridView dgvEmployees;
    private BindingSource contactManagerRepositoryBindingSource;
    private Panel panel4;
    private Panel panelSearchHeader;
    private TextBox txtSearchEmployee;
    private ComboBox cmbStatusFilter;
}