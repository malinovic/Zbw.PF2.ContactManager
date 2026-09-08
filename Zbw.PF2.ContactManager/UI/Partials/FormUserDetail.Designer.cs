namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormUserDetail
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
        boxUsername = new TextBox();
        boxName = new TextBox();
        boxPassword = new TextBox();
        buttonCancel = new Button();
        buttonSave = new Button();
        panelUsername = new Panel();
        panelUsernameLabel = new Panel();
        labelUsername = new Label();
        panelName = new Panel();
        panelNameLabel = new Panel();
        labelName = new Label();
        panelPassword = new Panel();
        panelPasswordLabel = new Panel();
        labelPassword = new Label();
        groupBox1 = new GroupBox();
        panel1 = new Panel();
        panelUsername.SuspendLayout();
        panelUsernameLabel.SuspendLayout();
        panelName.SuspendLayout();
        panelNameLabel.SuspendLayout();
        panelPassword.SuspendLayout();
        panelPasswordLabel.SuspendLayout();
        groupBox1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // boxUsername
        // 
        boxUsername.Dock = DockStyle.Bottom;
        boxUsername.Font = new Font("Segoe UI", 11F);
        boxUsername.Location = new Point(0, 63);
        boxUsername.Name = "boxUsername";
        boxUsername.Size = new Size(360, 27);
        boxUsername.TabIndex = 0;
        // 
        // boxName
        // 
        boxName.Dock = DockStyle.Bottom;
        boxName.Font = new Font("Segoe UI", 11F);
        boxName.Location = new Point(0, 63);
        boxName.Name = "boxName";
        boxName.Size = new Size(360, 27);
        boxName.TabIndex = 0;
        // 
        // boxPassword
        // 
        boxPassword.Dock = DockStyle.Bottom;
        boxPassword.Font = new Font("Segoe UI", 11F);
        boxPassword.Location = new Point(0, 63);
        boxPassword.Name = "boxPassword";
        boxPassword.Size = new Size(360, 27);
        boxPassword.TabIndex = 0;
        boxPassword.UseSystemPasswordChar = true;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(18, 15);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(170, 40);
        buttonCancel.TabIndex = 0;
        buttonCancel.Text = "Abbrechen";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += buttonCancel_Click;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(212, 15);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(170, 40);
        buttonSave.TabIndex = 1;
        buttonSave.Text = "Speichern";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // panelUsername
        // 
        panelUsername.Controls.Add(panelUsernameLabel);
        panelUsername.Controls.Add(boxUsername);
        panelUsername.Location = new Point(18, 40);
        panelUsername.Name = "panelUsername";
        panelUsername.Size = new Size(360, 90);
        panelUsername.TabIndex = 0;
        // 
        // panelUsernameLabel
        // 
        panelUsernameLabel.Controls.Add(labelUsername);
        panelUsernameLabel.Dock = DockStyle.Top;
        panelUsernameLabel.Location = new Point(0, 0);
        panelUsernameLabel.Name = "panelUsernameLabel";
        panelUsernameLabel.Size = new Size(360, 40);
        panelUsernameLabel.TabIndex = 0;
        // 
        // labelUsername
        // 
        labelUsername.AutoSize = true;
        labelUsername.Dock = DockStyle.Fill;
        labelUsername.Location = new Point(0, 0);
        labelUsername.Name = "labelUsername";
        labelUsername.Size = new Size(83, 15);
        labelUsername.TabIndex = 0;
        labelUsername.Text = "Benutzername";
        // 
        // panelName
        // 
        panelName.Controls.Add(panelNameLabel);
        panelName.Controls.Add(boxName);
        panelName.Location = new Point(18, 140);
        panelName.Name = "panelName";
        panelName.Size = new Size(360, 90);
        panelName.TabIndex = 1;
        // 
        // panelNameLabel
        // 
        panelNameLabel.Controls.Add(labelName);
        panelNameLabel.Dock = DockStyle.Top;
        panelNameLabel.Location = new Point(0, 0);
        panelNameLabel.Name = "panelNameLabel";
        panelNameLabel.Size = new Size(360, 40);
        panelNameLabel.TabIndex = 0;
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Dock = DockStyle.Fill;
        labelName.Location = new Point(0, 0);
        labelName.Name = "labelName";
        labelName.Size = new Size(39, 15);
        labelName.TabIndex = 0;
        labelName.Text = "Name";
        // 
        // panelPassword
        // 
        panelPassword.Controls.Add(panelPasswordLabel);
        panelPassword.Controls.Add(boxPassword);
        panelPassword.Location = new Point(18, 240);
        panelPassword.Name = "panelPassword";
        panelPassword.Size = new Size(360, 90);
        panelPassword.TabIndex = 2;
        // 
        // panelPasswordLabel
        // 
        panelPasswordLabel.Controls.Add(labelPassword);
        panelPasswordLabel.Dock = DockStyle.Top;
        panelPasswordLabel.Location = new Point(0, 0);
        panelPasswordLabel.Name = "panelPasswordLabel";
        panelPasswordLabel.Size = new Size(360, 40);
        panelPasswordLabel.TabIndex = 0;
        // 
        // labelPassword
        // 
        labelPassword.AutoSize = true;
        labelPassword.Dock = DockStyle.Fill;
        labelPassword.Location = new Point(0, 0);
        labelPassword.Name = "labelPassword";
        labelPassword.Size = new Size(54, 15);
        labelPassword.TabIndex = 0;
        labelPassword.Text = "Passwort";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(panelUsername);
        groupBox1.Controls.Add(panelName);
        groupBox1.Controls.Add(panelPassword);
        groupBox1.FlatStyle = FlatStyle.Flat;
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(396, 350);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Benutzerdaten";
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonCancel);
        panel1.Controls.Add(buttonSave);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 380);
        panel1.Name = "panel1";
        panel1.Size = new Size(420, 70);
        panel1.TabIndex = 1;
        // 
        // FormUserDetail
        // 
        AutoSize = true;
        BackColor = Color.White;
        ClientSize = new Size(420, 450);
        Controls.Add(groupBox1);
        Controls.Add(panel1);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormUserDetail";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Neuer Benutzer";
        panelUsername.ResumeLayout(false);
        panelUsername.PerformLayout();
        panelUsernameLabel.ResumeLayout(false);
        panelUsernameLabel.PerformLayout();
        panelName.ResumeLayout(false);
        panelName.PerformLayout();
        panelNameLabel.ResumeLayout(false);
        panelNameLabel.PerformLayout();
        panelPassword.ResumeLayout(false);
        panelPassword.PerformLayout();
        panelPasswordLabel.ResumeLayout(false);
        panelPasswordLabel.PerformLayout();
        groupBox1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TextBox boxUsername;
    private TextBox boxName;
    private TextBox boxPassword;
    private Button buttonCancel;
    private Button buttonSave;
    private Panel panelUsername;
    private Panel panelUsernameLabel;
    private Label labelUsername;
    private Panel panelName;
    private Panel panelNameLabel;
    private Label labelName;
    private Panel panelPassword;
    private Panel panelPasswordLabel;
    private Label labelPassword;
    private GroupBox groupBox1;
    private Panel panel1;
}
