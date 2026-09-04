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
        btnCreateNewEmployee.Location = new Point(7, 6);
        btnCreateNewEmployee.Margin = new Padding(2, 1, 2, 1);
        btnCreateNewEmployee.Name = "btnCreateNewEmployee";
        btnCreateNewEmployee.Size = new Size(178, 29);
        btnCreateNewEmployee.TabIndex = 1;
        btnCreateNewEmployee.Text = "Neuer Mitarbeiter";
        btnCreateNewEmployee.UseVisualStyleBackColor = true;
        btnCreateNewEmployee.Click += BtnCreateNewEmployee_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnCreateNewEmployee);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(20, 480);
        panel1.Margin = new Padding(2, 1, 2, 1);
        panel1.Name = "panel1";
        panel1.Size = new Size(1127, 44);
        panel1.TabIndex = 2;
        // 
        // panel2
        // 
        panel2.Controls.Add(panel4);
        panel2.Controls.Add(panelSearchHeader);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(20, 20);
        panel2.Margin = new Padding(2, 1, 2, 1);
        panel2.Name = "panel2";
        panel2.Size = new Size(1127, 460);
        panel2.TabIndex = 3;
        // 
        // panel4
        // 
        panel4.Controls.Add(dgvEmployees);
        panel4.Dock = DockStyle.Fill;
        panel4.Location = new Point(0, 42);
        panel4.Margin = new Padding(2, 1, 2, 1);
        panel4.Name = "panel4";
        panel4.Size = new Size(1127, 418);
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
        dgvEmployees.Margin = new Padding(2, 1, 2, 1);
        dgvEmployees.Name = "dgvEmployees";
        dgvEmployees.ReadOnly = true;
        dgvEmployees.RowHeadersVisible = false;
        dgvEmployees.RowHeadersWidth = 82;
        dgvEmployees.RowTemplate.Height = 48;
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEmployees.Size = new Size(1127, 418);
        dgvEmployees.TabIndex = 0;
        // 
        // panelSearchHeader
        // 
        panelSearchHeader.BackColor = Color.White;
        panelSearchHeader.Controls.Add(txtSearchEmployee);
        panelSearchHeader.Controls.Add(cmbStatusFilter);
        panelSearchHeader.Dock = DockStyle.Top;
        panelSearchHeader.Location = new Point(0, 0);
        panelSearchHeader.Margin = new Padding(2, 1, 2, 1);
        panelSearchHeader.Name = "panelSearchHeader";
        panelSearchHeader.Size = new Size(1127, 42);
        panelSearchHeader.TabIndex = 1;
        // 
        // txtSearchEmployee
        // 
        txtSearchEmployee.BorderStyle = BorderStyle.FixedSingle;
        txtSearchEmployee.Location = new Point(0, 11);
        txtSearchEmployee.Margin = new Padding(2, 1, 2, 1);
        txtSearchEmployee.Name = "txtSearchEmployee";
        txtSearchEmployee.PlaceholderText = "Suche nach Name, Personalnummer, Abteilung...";
        txtSearchEmployee.Size = new Size(391, 23);
        txtSearchEmployee.TabIndex = 0;
        txtSearchEmployee.TextChanged += TxtSearchEmployee_TextChanged;
        // 
        // cmbStatusFilter
        // 
        cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatusFilter.FormattingEnabled = true;
        cmbStatusFilter.Location = new Point(403, 11);
        cmbStatusFilter.Margin = new Padding(2, 1, 2, 1);
        cmbStatusFilter.Name = "cmbStatusFilter";
        cmbStatusFilter.Size = new Size(120, 23);
        cmbStatusFilter.TabIndex = 1;
        cmbStatusFilter.SelectedIndexChanged += CmbStatusFilter_SelectedIndexChanged;
        // 
        // FormEmployeesPartial
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1167, 629);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(2, 1, 2, 1);
        Name = "FormEmployeesPartial";
        Padding = new Padding(20, 20, 20, 105);
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