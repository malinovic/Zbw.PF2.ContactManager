using System.ComponentModel;

namespace Zbw.PF2.ContactManager.UI;

partial class FormLogin
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormLogin));
        btnLogin = new Button();
        lblUsername = new Label();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        lblPassword = new Label();
        SuspendLayout();
        // 
        // btnLogin
        // 
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Location = new Point(32, 176);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(260, 32);
        btnLogin.TabIndex = 4;
        btnLogin.Text = "Anmelden";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(32, 32);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(83, 15);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Benutzername";
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(32, 52);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(260, 23);
        txtUsername.TabIndex = 1;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(32, 122);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(260, 23);
        txtPassword.TabIndex = 3;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(32, 102);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(54, 15);
        lblPassword.TabIndex = 2;
        lblPassword.Text = "Passwort";
        // 
        // FormLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(324, 232);
        Controls.Add(txtPassword);
        Controls.Add(lblPassword);
        Controls.Add(txtUsername);
        Controls.Add(lblUsername);
        Controls.Add(btnLogin);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnLogin;
    private Label lblUsername;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Label lblPassword;
}