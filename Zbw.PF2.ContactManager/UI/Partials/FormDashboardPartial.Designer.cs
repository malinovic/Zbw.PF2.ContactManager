namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormDashboardPartial
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
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(140, 205);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(221, 103);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // FormDashboardPartial
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Brown;
        ClientSize = new System.Drawing.Size(2291, 1317);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "FormDashboardPartial";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    #endregion
}