using Zbw.PF2.ContactManager.Core.Theme;

namespace Zbw.PF2.ContactManager.UI;

partial class MainForm
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
        BtnTest = new Button();
        SuspendLayout();
        // 
        // BtnTest
        // 
        BtnTest.Location = new Point(321, 827);
        BtnTest.Name = "BtnTest";
        BtnTest.Size = new Size(200, 60);
        BtnTest.TabIndex = 0;
        BtnTest.Text = "Speichern";
        BtnTest.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1598, 918);
        Controls.Add(BtnTest);
        Name = "MainForm";
        Text = "MainForm";
        ResumeLayout(false);
    }

    #endregion

    private Button BtnTest;
}