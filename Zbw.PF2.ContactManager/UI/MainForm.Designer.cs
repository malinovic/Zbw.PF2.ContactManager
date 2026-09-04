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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        FlpSideNav = new FlowLayoutPanel();
        BtnNavDashboard = new Button();
        BtnNavCustomers = new Button();
        BtnNavEmployees = new Button();
        BtnNavUsers = new Button();
        PnlContentView = new Panel();
        panel1 = new Panel();
        panel2 = new Panel();
        LblLoggedInAs = new Label();
        FlpSideNav.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // FlpSideNav
        // 
        FlpSideNav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        FlpSideNav.BackColor = Color.White;
        FlpSideNav.Controls.Add(BtnNavDashboard);
        FlpSideNav.Controls.Add(BtnNavCustomers);
        FlpSideNav.Controls.Add(BtnNavEmployees);
        FlpSideNav.Controls.Add(BtnNavUsers);
        FlpSideNav.FlowDirection = FlowDirection.TopDown;
        FlpSideNav.Location = new Point(0, 0);
        FlpSideNav.Name = "FlpSideNav";
        FlpSideNav.Size = new Size(400, 1421);
        FlpSideNav.TabIndex = 0;
        // 
        // BtnNavDashboard
        // 
        BtnNavDashboard.BackColor = Color.White;
        BtnNavDashboard.FlatStyle = FlatStyle.Flat;
        BtnNavDashboard.ForeColor = SystemColors.ControlText;
        BtnNavDashboard.Image = Properties.Resources.home;
        BtnNavDashboard.ImageAlign = ContentAlignment.MiddleLeft;
        BtnNavDashboard.Location = new Point(3, 3);
        BtnNavDashboard.Name = "BtnNavDashboard";
        BtnNavDashboard.Padding = new Padding(50, 0, 0, 0);
        BtnNavDashboard.Size = new Size(545, 50);
        BtnNavDashboard.TabIndex = 1;
        BtnNavDashboard.Text = "          Dashboard";
        BtnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
        BtnNavDashboard.UseVisualStyleBackColor = false;
        BtnNavDashboard.Click += BtnNavDashboard_Click;
        // 
        // BtnNavCustomers
        // 
        BtnNavCustomers.BackColor = Color.White;
        BtnNavCustomers.FlatStyle = FlatStyle.Flat;
        BtnNavCustomers.ForeColor = SystemColors.ControlText;
        BtnNavCustomers.Image = (Image)resources.GetObject("BtnNavCustomers.Image");
        BtnNavCustomers.ImageAlign = ContentAlignment.MiddleLeft;
        BtnNavCustomers.Location = new Point(3, 59);
        BtnNavCustomers.Name = "BtnNavCustomers";
        BtnNavCustomers.Padding = new Padding(50, 0, 0, 0);
        BtnNavCustomers.Size = new Size(545, 50);
        BtnNavCustomers.TabIndex = 3;
        BtnNavCustomers.Text = "          Kunden";
        BtnNavCustomers.TextAlign = ContentAlignment.MiddleLeft;
        BtnNavCustomers.UseVisualStyleBackColor = false;
        BtnNavCustomers.Click += BtnNavCustomers_Click;
        // 
        // BtnNavEmployees
        // 
        BtnNavEmployees.BackColor = Color.White;
        BtnNavEmployees.FlatStyle = FlatStyle.Flat;
        BtnNavEmployees.ForeColor = SystemColors.ControlText;
        BtnNavEmployees.Image = (Image)resources.GetObject("BtnNavEmployees.Image");
        BtnNavEmployees.ImageAlign = ContentAlignment.MiddleLeft;
        BtnNavEmployees.Location = new Point(3, 115);
        BtnNavEmployees.Name = "BtnNavEmployees";
        BtnNavEmployees.Padding = new Padding(50, 0, 0, 0);
        BtnNavEmployees.Size = new Size(448, 50);
        BtnNavEmployees.TabIndex = 2;
        BtnNavEmployees.Text = "          Mitarbeiter";
        BtnNavEmployees.TextAlign = ContentAlignment.MiddleLeft;
        BtnNavEmployees.UseVisualStyleBackColor = false;
        BtnNavEmployees.Click += BtnNavEmployees_Click;
        // 
        // BtnNavUsers
        // 
        BtnNavUsers.BackColor = Color.White;
        BtnNavUsers.FlatStyle = FlatStyle.Flat;
        BtnNavUsers.ForeColor = SystemColors.ControlText;
        BtnNavUsers.Image = (Image)resources.GetObject("BtnNavUsers.Image");
        BtnNavUsers.ImageAlign = ContentAlignment.MiddleLeft;
        BtnNavUsers.Location = new Point(3, 171);
        BtnNavUsers.Name = "BtnNavUsers";
        BtnNavUsers.Padding = new Padding(50, 0, 0, 0);
        BtnNavUsers.Size = new Size(545, 50);
        BtnNavUsers.TabIndex = 4;
        BtnNavUsers.Text = "          Benutzer";
        BtnNavUsers.TextAlign = ContentAlignment.MiddleLeft;
        BtnNavUsers.UseVisualStyleBackColor = false;
        BtnNavUsers.Click += BtnNavUsers_Click;
        // 
        // PnlContentView
        // 
        PnlContentView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        PnlContentView.Location = new Point(406, 0);
        PnlContentView.Name = "PnlContentView";
        PnlContentView.Size = new Size(1933, 1421);
        PnlContentView.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.BackColor = Color.White;
        panel1.Controls.Add(panel2);
        panel1.Controls.Add(LblLoggedInAs);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 1013);
        panel1.Name = "panel1";
        panel1.Size = new Size(1718, 40);
        panel1.TabIndex = 2;
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.ControlText;
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.MaximumSize = new Size(0, 1);
        panel2.Name = "panel2";
        panel2.Size = new Size(1718, 1);
        panel2.TabIndex = 1;
        // 
        // LblLoggedInAs
        // 
        LblLoggedInAs.AutoSize = true;
        LblLoggedInAs.Location = new Point(15, 11);
        LblLoggedInAs.Name = "LblLoggedInAs";
        LblLoggedInAs.Size = new Size(50, 20);
        LblLoggedInAs.TabIndex = 0;
        LblLoggedInAs.Text = "label1";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1718, 1053);
        Controls.Add(panel1);
        Controls.Add(PnlContentView);
        Controls.Add(FlpSideNav);
        Font = new Font("Segoe UI", 11F);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        Name = "MainForm";
        Text = "Contact Manager";
        WindowState = FormWindowState.Maximized;
        FlpSideNav.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private FlowLayoutPanel FlpSideNav;
    private Button BtnNavDashboard;
    private Panel PnlContentView;
    private Button BtnNavEmployees;
    private Button BtnNavCustomers;
    private Button BtnNavUsers;
    private Panel panel1;
    private Label LblLoggedInAs;
    private Panel panel2;
}