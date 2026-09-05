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
        btnCreateNewCustomer = new Button();
        SuspendLayout();
        // 
        // btnCreateNewCustomer
        // 
        btnCreateNewCustomer.Location = new Point(65, 1241);
        btnCreateNewCustomer.Name = "btnCreateNewCustomer";
        btnCreateNewCustomer.Size = new Size(424, 62);
        btnCreateNewCustomer.TabIndex = 1;
        btnCreateNewCustomer.Text = "Neuer Kunde";
        btnCreateNewCustomer.UseVisualStyleBackColor = true;
        btnCreateNewCustomer.Click += btnCreateNewCustomer_Click;
        // 
        // FormCustomersPartial
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(2167, 1342);
        Controls.Add(btnCreateNewCustomer);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormCustomersPartial";
        Text = "FormCustomersPartial";
        ResumeLayout(false);
    }

    #endregion

    private Button btnCreateNewCustomer;
}