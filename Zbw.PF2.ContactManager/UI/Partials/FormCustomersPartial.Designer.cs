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
        contactManagerRepositoryBindingSource = new BindingSource(components);
        ((System.ComponentModel.ISupportInitialize)contactManagerRepositoryBindingSource).BeginInit();
        SuspendLayout();
        // 
        // contactManagerRepositoryBindingSource
        // 
        contactManagerRepositoryBindingSource.DataSource = typeof(Data.Repository.ContactManagerRepository);
        // 
        // FormCustomersPartial
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.HotTrack;
        ClientSize = new Size(2114, 1234);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormCustomersPartial";
        Text = "FormCustomersPartial";
        ((System.ComponentModel.ISupportInitialize)contactManagerRepositoryBindingSource).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private BindingSource contactManagerRepositoryBindingSource;
}