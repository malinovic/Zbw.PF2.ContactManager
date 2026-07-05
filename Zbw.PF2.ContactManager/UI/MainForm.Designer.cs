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
        BtnNavCoworkers = new Button();
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
        // BtnNavCoworkers
        // 
        BtnNavCoworkers.FlatStyle = FlatStyle.Popup;
        BtnNavCoworkers.Location = new Point(30, 148);
        BtnNavCoworkers.Name = "BtnNavCoworkers";
        BtnNavCoworkers.Size = new Size(440, 77);
        BtnNavCoworkers.TabIndex = 1;
        BtnNavCoworkers.Text = "Mitarbeiter";
        BtnNavCoworkers.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(14F, 36F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2339, 1445);
        Controls.Add(BtnNavCoworkers);
        Controls.Add(BtnNavKunden);
        Font = new Font("Segoe UI", 11F);
        Margin = new Padding(4);
        Name = "MainForm";
        ShowIcon = false;
        Text = "Contact Manager";
        WindowState = FormWindowState.Maximized;
        ResumeLayout(false);
    }

    #endregion

    private Button BtnNavKunden;
    private Button BtnNavCoworkers;
}