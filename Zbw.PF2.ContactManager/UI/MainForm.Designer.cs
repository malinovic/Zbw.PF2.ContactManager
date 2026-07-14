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
        PnlNavTitle = new Panel();
        NavTitle = new Label();
        BtnNavDashboard = new Button();
        BtnNavCustomers = new Button();
        BtnNavEmployees = new Button();
        PnlContentView = new Panel();
        FlpSideNav.SuspendLayout();
        PnlNavTitle.SuspendLayout();
        SuspendLayout();
        // 
        // FlpSideNav
        // 
        FlpSideNav.BackColor = Color.White;
        FlpSideNav.Controls.Add(PnlNavTitle);
        FlpSideNav.Controls.Add(BtnNavDashboard);
        FlpSideNav.Controls.Add(BtnNavCustomers);
        FlpSideNav.Controls.Add(BtnNavEmployees);
        FlpSideNav.Dock = DockStyle.Left;
        FlpSideNav.Location = new Point(0, 0);
        FlpSideNav.Name = "FlpSideNav";
        FlpSideNav.Size = new Size(551, 1445);
        FlpSideNav.TabIndex = 0;
        // 
        // PnlNavTitle
        // 
        PnlNavTitle.Controls.Add(NavTitle);
        PnlNavTitle.Location = new Point(3, 3);
        PnlNavTitle.Name = "PnlNavTitle";
        PnlNavTitle.Size = new Size(548, 133);
        PnlNavTitle.TabIndex = 4;
        // 
        // NavTitle
        // 
        NavTitle.AutoSize = true;
        NavTitle.Location = new Point(31, 50);
        NavTitle.Name = "NavTitle";
        NavTitle.Size = new Size(213, 36);
        NavTitle.TabIndex = 0;
        NavTitle.Text = "Contact Manager";
        // 
        // BtnNavDashboard
        // 
        BtnNavDashboard.BackColor = Color.White;
        BtnNavDashboard.FlatStyle = FlatStyle.Flat;
        BtnNavDashboard.ForeColor = SystemColors.ControlText;
        BtnNavDashboard.Image = Properties.Resources.home;
        BtnNavDashboard.ImageAlign = ContentAlignment.MiddleLeft;
        BtnNavDashboard.Location = new Point(3, 142);
        BtnNavDashboard.Name = "BtnNavDashboard";
        BtnNavDashboard.Padding = new Padding(50, 0, 0, 0);
        BtnNavDashboard.Size = new Size(545, 92);
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
        BtnNavCustomers.Location = new Point(3, 240);
        BtnNavCustomers.Name = "BtnNavCustomers";
        BtnNavCustomers.Padding = new Padding(50, 0, 0, 0);
        BtnNavCustomers.Size = new Size(545, 92);
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
        BtnNavEmployees.Location = new Point(3, 338);
        BtnNavEmployees.Name = "BtnNavEmployees";
        BtnNavEmployees.Padding = new Padding(50, 0, 0, 0);
        BtnNavEmployees.Size = new Size(545, 92);
        BtnNavEmployees.TabIndex = 2;
        BtnNavEmployees.Text = "          Mitarbeiter";
        BtnNavEmployees.TextAlign = ContentAlignment.MiddleLeft;
        BtnNavEmployees.UseVisualStyleBackColor = false;
        BtnNavEmployees.Click += BtnNavEmployees_Click;
        // 
        // PnlContentView
        // 
        PnlContentView.Dock = DockStyle.Fill;
        PnlContentView.Location = new Point(551, 0);
        PnlContentView.Name = "PnlContentView";
        PnlContentView.Size = new Size(1788, 1445);
        PnlContentView.TabIndex = 1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(14F, 36F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2339, 1445);
        Controls.Add(PnlContentView);
        Controls.Add(FlpSideNav);
        Font = new Font("Segoe UI", 11F);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        Name = "MainForm";
        Text = "Contact Manager";
        WindowState = FormWindowState.Maximized;
        FlpSideNav.ResumeLayout(false);
        PnlNavTitle.ResumeLayout(false);
        PnlNavTitle.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private FlowLayoutPanel FlpSideNav;
    private Button BtnNavDashboard;
    private Panel PnlContentView;
    private Button BtnNavEmployees;
    private Button BtnNavCustomers;
    private Panel PnlNavTitle;
    private Label NavTitle;
}