namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormDashboardPartial
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        mainLayout = new TableLayoutPanel();
        panelEmployeesCard = new Panel();
        labelEmployeesCardTitle = new Label();
        labelEmployeesTotal = new Label();
        labelEmployeesActive = new Label();
        labelEmployeesInactive = new Label();
        panelCustomersCard = new Panel();
        labelCustomersCardTitle = new Label();
        labelCustomersTotal = new Label();
        labelCustomersActive = new Label();
        labelCustomersInactive = new Label();
        panelRecentEmployees = new Panel();
        listBoxRecentEmployees = new ListBox();
        labelRecentEmployeesTitle = new Label();
        panelRecentCustomers = new Panel();
        listBoxRecentCustomers = new ListBox();
        labelRecentCustomersTitle = new Label();
        mainLayout.SuspendLayout();
        panelEmployeesCard.SuspendLayout();
        panelCustomersCard.SuspendLayout();
        panelRecentEmployees.SuspendLayout();
        panelRecentCustomers.SuspendLayout();
        SuspendLayout();
        // 
        // mainLayout
        // 
        mainLayout.ColumnCount = 2;
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        mainLayout.Controls.Add(panelEmployeesCard, 0, 0);
        mainLayout.Controls.Add(panelCustomersCard, 1, 0);
        mainLayout.Controls.Add(panelRecentEmployees, 0, 1);
        mainLayout.Controls.Add(panelRecentCustomers, 1, 1);
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Location = new Point(0, 0);
        mainLayout.Margin = new Padding(1);
        mainLayout.Name = "mainLayout";
        mainLayout.Padding = new Padding(23, 19, 23, 19);
        mainLayout.RowCount = 2;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5175438F));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80.48245F));
        mainLayout.Size = new Size(1057, 494);
        mainLayout.TabIndex = 0;
        // 
        // panelEmployeesCard
        // 
        panelEmployeesCard.BackColor = Color.FromArgb(235, 241, 255);
        panelEmployeesCard.Controls.Add(labelEmployeesCardTitle);
        panelEmployeesCard.Controls.Add(labelEmployeesTotal);
        panelEmployeesCard.Controls.Add(labelEmployeesActive);
        panelEmployeesCard.Controls.Add(labelEmployeesInactive);
        panelEmployeesCard.Dock = DockStyle.Fill;
        panelEmployeesCard.Location = new Point(32, 27);
        panelEmployeesCard.Margin = new Padding(9, 8, 9, 8);
        panelEmployeesCard.Name = "panelEmployeesCard";
        panelEmployeesCard.Size = new Size(487, 73);
        panelEmployeesCard.TabIndex = 0;
        // 
        // labelEmployeesCardTitle
        // 
        labelEmployeesCardTitle.AutoSize = true;
        labelEmployeesCardTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        labelEmployeesCardTitle.ForeColor = Color.FromArgb(30, 60, 130);
        labelEmployeesCardTitle.Location = new Point(18, 11);
        labelEmployeesCardTitle.Margin = new Padding(1, 0, 1, 0);
        labelEmployeesCardTitle.Name = "labelEmployeesCardTitle";
        labelEmployeesCardTitle.Size = new Size(165, 37);
        labelEmployeesCardTitle.TabIndex = 0;
        labelEmployeesCardTitle.Text = "Mitarbeiter";
        // 
        // labelEmployeesTotal
        // 
        labelEmployeesTotal.AutoSize = true;
        labelEmployeesTotal.Font = new Font("Segoe UI", 16F);
        labelEmployeesTotal.Location = new Point(18, 41);
        labelEmployeesTotal.Margin = new Padding(1, 0, 1, 0);
        labelEmployeesTotal.Name = "labelEmployeesTotal";
        labelEmployeesTotal.Size = new Size(109, 30);
        labelEmployeesTotal.TabIndex = 1;
        labelEmployeesTotal.Text = "Gesamt: 0";
        // 
        // labelEmployeesActive
        // 
        labelEmployeesActive.AutoSize = true;
        labelEmployeesActive.Font = new Font("Segoe UI", 16F);
        labelEmployeesActive.ForeColor = Color.FromArgb(30, 140, 60);
        labelEmployeesActive.Location = new Point(18, 71);
        labelEmployeesActive.Margin = new Padding(1, 0, 1, 0);
        labelEmployeesActive.Name = "labelEmployeesActive";
        labelEmployeesActive.Size = new Size(84, 30);
        labelEmployeesActive.TabIndex = 2;
        labelEmployeesActive.Text = "Aktiv: 0";
        // 
        // labelEmployeesInactive
        // 
        labelEmployeesInactive.AutoSize = true;
        labelEmployeesInactive.Font = new Font("Segoe UI", 16F);
        labelEmployeesInactive.ForeColor = Color.FromArgb(160, 40, 40);
        labelEmployeesInactive.Location = new Point(18, 101);
        labelEmployeesInactive.Margin = new Padding(1, 0, 1, 0);
        labelEmployeesInactive.Name = "labelEmployeesInactive";
        labelEmployeesInactive.Size = new Size(99, 30);
        labelEmployeesInactive.TabIndex = 3;
        labelEmployeesInactive.Text = "Inaktiv: 0";
        // 
        // panelCustomersCard
        // 
        panelCustomersCard.BackColor = Color.FromArgb(235, 255, 240);
        panelCustomersCard.Controls.Add(labelCustomersCardTitle);
        panelCustomersCard.Controls.Add(labelCustomersTotal);
        panelCustomersCard.Controls.Add(labelCustomersActive);
        panelCustomersCard.Controls.Add(labelCustomersInactive);
        panelCustomersCard.Dock = DockStyle.Fill;
        panelCustomersCard.Location = new Point(537, 27);
        panelCustomersCard.Margin = new Padding(9, 8, 9, 8);
        panelCustomersCard.Name = "panelCustomersCard";
        panelCustomersCard.Size = new Size(488, 73);
        panelCustomersCard.TabIndex = 1;
        // 
        // labelCustomersCardTitle
        // 
        labelCustomersCardTitle.AutoSize = true;
        labelCustomersCardTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        labelCustomersCardTitle.ForeColor = Color.FromArgb(30, 110, 60);
        labelCustomersCardTitle.Location = new Point(18, 11);
        labelCustomersCardTitle.Margin = new Padding(1, 0, 1, 0);
        labelCustomersCardTitle.Name = "labelCustomersCardTitle";
        labelCustomersCardTitle.Size = new Size(115, 37);
        labelCustomersCardTitle.TabIndex = 0;
        labelCustomersCardTitle.Text = "Kunden";
        // 
        // labelCustomersTotal
        // 
        labelCustomersTotal.AutoSize = true;
        labelCustomersTotal.Font = new Font("Segoe UI", 16F);
        labelCustomersTotal.Location = new Point(18, 41);
        labelCustomersTotal.Margin = new Padding(1, 0, 1, 0);
        labelCustomersTotal.Name = "labelCustomersTotal";
        labelCustomersTotal.Size = new Size(109, 30);
        labelCustomersTotal.TabIndex = 1;
        labelCustomersTotal.Text = "Gesamt: 0";
        // 
        // labelCustomersActive
        // 
        labelCustomersActive.AutoSize = true;
        labelCustomersActive.Font = new Font("Segoe UI", 16F);
        labelCustomersActive.ForeColor = Color.FromArgb(30, 140, 60);
        labelCustomersActive.Location = new Point(18, 71);
        labelCustomersActive.Margin = new Padding(1, 0, 1, 0);
        labelCustomersActive.Name = "labelCustomersActive";
        labelCustomersActive.Size = new Size(84, 30);
        labelCustomersActive.TabIndex = 2;
        labelCustomersActive.Text = "Aktiv: 0";
        // 
        // labelCustomersInactive
        // 
        labelCustomersInactive.AutoSize = true;
        labelCustomersInactive.Font = new Font("Segoe UI", 16F);
        labelCustomersInactive.ForeColor = Color.FromArgb(160, 40, 40);
        labelCustomersInactive.Location = new Point(18, 101);
        labelCustomersInactive.Margin = new Padding(1, 0, 1, 0);
        labelCustomersInactive.Name = "labelCustomersInactive";
        labelCustomersInactive.Size = new Size(99, 30);
        labelCustomersInactive.TabIndex = 3;
        labelCustomersInactive.Text = "Inaktiv: 0";
        // 
        // panelRecentEmployees
        // 
        panelRecentEmployees.Controls.Add(listBoxRecentEmployees);
        panelRecentEmployees.Controls.Add(labelRecentEmployeesTitle);
        panelRecentEmployees.Dock = DockStyle.Fill;
        panelRecentEmployees.Location = new Point(32, 116);
        panelRecentEmployees.Margin = new Padding(9, 8, 9, 8);
        panelRecentEmployees.Name = "panelRecentEmployees";
        panelRecentEmployees.Size = new Size(487, 351);
        panelRecentEmployees.TabIndex = 2;
        // 
        // listBoxRecentEmployees
        // 
        listBoxRecentEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        listBoxRecentEmployees.Font = new Font("Segoe UI", 13F);
        listBoxRecentEmployees.Location = new Point(5, 44);
        listBoxRecentEmployees.Margin = new Padding(1);
        listBoxRecentEmployees.Name = "listBoxRecentEmployees";
        listBoxRecentEmployees.Size = new Size(481, 280);
        listBoxRecentEmployees.TabIndex = 0;
        // 
        // labelRecentEmployeesTitle
        // 
        labelRecentEmployeesTitle.AutoSize = true;
        labelRecentEmployeesTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        labelRecentEmployeesTitle.Location = new Point(5, 4);
        labelRecentEmployeesTitle.Margin = new Padding(1, 0, 1, 0);
        labelRecentEmployeesTitle.Name = "labelRecentEmployeesTitle";
        labelRecentEmployeesTitle.Size = new Size(274, 28);
        labelRecentEmployeesTitle.TabIndex = 1;
        labelRecentEmployeesTitle.Text = "Zuletzt erfasste Mitarbeiter";
        // 
        // panelRecentCustomers
        // 
        panelRecentCustomers.Controls.Add(listBoxRecentCustomers);
        panelRecentCustomers.Controls.Add(labelRecentCustomersTitle);
        panelRecentCustomers.Dock = DockStyle.Fill;
        panelRecentCustomers.Location = new Point(537, 116);
        panelRecentCustomers.Margin = new Padding(9, 8, 9, 8);
        panelRecentCustomers.Name = "panelRecentCustomers";
        panelRecentCustomers.Size = new Size(488, 351);
        panelRecentCustomers.TabIndex = 3;
        // 
        // listBoxRecentCustomers
        // 
        listBoxRecentCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        listBoxRecentCustomers.Font = new Font("Segoe UI", 13F);
        listBoxRecentCustomers.Location = new Point(5, 44);
        listBoxRecentCustomers.Margin = new Padding(1);
        listBoxRecentCustomers.Name = "listBoxRecentCustomers";
        listBoxRecentCustomers.Size = new Size(483, 280);
        listBoxRecentCustomers.TabIndex = 0;
        // 
        // labelRecentCustomersTitle
        // 
        labelRecentCustomersTitle.AutoSize = true;
        labelRecentCustomersTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        labelRecentCustomersTitle.Location = new Point(5, 4);
        labelRecentCustomersTitle.Margin = new Padding(1, 0, 1, 0);
        labelRecentCustomersTitle.Name = "labelRecentCustomersTitle";
        labelRecentCustomersTitle.Size = new Size(238, 28);
        labelRecentCustomersTitle.TabIndex = 1;
        labelRecentCustomersTitle.Text = "Zuletzt erfasste Kunden";
        // 
        // FormDashboardPartial
        // 
        AutoScaleDimensions = new SizeF(6F, 12F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1057, 494);
        Controls.Add(mainLayout);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(1);
        Name = "FormDashboardPartial";
        Text = "FormDashboardPartial";
        mainLayout.ResumeLayout(false);
        panelEmployeesCard.ResumeLayout(false);
        panelEmployeesCard.PerformLayout();
        panelCustomersCard.ResumeLayout(false);
        panelCustomersCard.PerformLayout();
        panelRecentEmployees.ResumeLayout(false);
        panelRecentEmployees.PerformLayout();
        panelRecentCustomers.ResumeLayout(false);
        panelRecentCustomers.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel mainLayout;

    private Panel panelEmployeesCard;
    private Label labelEmployeesCardTitle;
    private Label labelEmployeesTotal;
    private Label labelEmployeesActive;
    private Label labelEmployeesInactive;

    private Panel panelCustomersCard;
    private Label labelCustomersCardTitle;
    private Label labelCustomersTotal;
    private Label labelCustomersActive;
    private Label labelCustomersInactive;

    private Panel panelRecentEmployees;
    private Label labelRecentEmployeesTitle;
    private ListBox listBoxRecentEmployees;

    private Panel panelRecentCustomers;
    private Label labelRecentCustomersTitle;
    private ListBox listBoxRecentCustomers;
}