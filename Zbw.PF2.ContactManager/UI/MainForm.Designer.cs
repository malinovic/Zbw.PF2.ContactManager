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
        BtnNavKunden = new Button();
        button2 = new Button();
        SuspendLayout();
        // 
        // BtnNavKunden
        // 
        BtnNavKunden.BackColor = Color.FromArgb(193, 117, 43);
        BtnNavKunden.FlatStyle = FlatStyle.Flat;
        BtnNavKunden.ForeColor = Color.White;
        BtnNavKunden.Location = new Point(30, 35);
        BtnNavKunden.Name = "BtnNavKunden";
        BtnNavKunden.Size = new Size(440, 77);
        BtnNavKunden.TabIndex = 0;
        BtnNavKunden.Text = "Kunden";
        BtnNavKunden.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.FlatStyle = FlatStyle.Popup;
        button2.Location = new Point(30, 148);
        button2.Name = "button2";
        button2.Size = new Size(440, 77);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(14F, 36F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2339, 1445);
        Controls.Add(button2);
        Controls.Add(BtnNavKunden);
        Font = new Font("Segoe UI", 11F);
        Margin = new Padding(4);
        Name = "MainForm";
        ShowIcon = false;
        Text = "Contact Manager";
        ResumeLayout(false);
    }

    #endregion

    private Button BtnNavKunden;
    private Button button2;
}