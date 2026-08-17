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
        btnCreateNewEmployee = new Button();
        panel1 = new Panel();
        panel2 = new Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // btnCreateNewEmployee
        // 
        btnCreateNewEmployee.Location = new Point(12, 12);
        btnCreateNewEmployee.Name = "btnCreateNewEmployee";
        btnCreateNewEmployee.Size = new Size(305, 58);
        btnCreateNewEmployee.TabIndex = 1;
        btnCreateNewEmployee.Text = "Neuer Mitarbeiter";
        btnCreateNewEmployee.UseVisualStyleBackColor = true;
        btnCreateNewEmployee.Click += btnCreateNewEmployee_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnCreateNewEmployee);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 1171);
        panel1.Name = "panel1";
        panel1.Size = new Size(2000, 87);
        panel1.TabIndex = 2;
        // 
        // panel2
        // 
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(2000, 1171);
        panel2.TabIndex = 3;
        // 
        // FormEmployeesPartial
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(2000, 1258);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormEmployeesPartial";
        Text = "FormEmployeesPartial";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Button btnCreateNewEmployee;
    private Panel panel1;
    private Panel panel2;
}