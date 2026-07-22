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
        SuspendLayout();
        // 
        // btnCreateNewEmployee
        // 
        btnCreateNewEmployee.Location = new Point(65, 1241);
        btnCreateNewEmployee.Name = "btnCreateNewEmployee";
        btnCreateNewEmployee.Size = new Size(424, 62);
        btnCreateNewEmployee.TabIndex = 1;
        btnCreateNewEmployee.Text = "Neuer Mitarbeiter";
        btnCreateNewEmployee.UseVisualStyleBackColor = true;
        btnCreateNewEmployee.Click += btnCreateNewEmployee_Click;
        // 
        // FormEmployeesPartial
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(2167, 1342);
        Controls.Add(btnCreateNewEmployee);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormEmployeesPartial";
        Text = "FormEmployeesPartial";
        ResumeLayout(false);
    }

    #endregion

    private Button btnCreateNewEmployee;
}