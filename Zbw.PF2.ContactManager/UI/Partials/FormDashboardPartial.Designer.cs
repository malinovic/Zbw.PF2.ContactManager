using Zbw.PF2.ContactManager.Core.Theme;

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
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        statsLayout = new TableLayoutPanel();

        panelStatTotal = new Panel();
        accentStatTotal = new Panel();
        labelStatTotalTitle = new Label();
        labelStatTotalValue = new Label();

        panelStatCustomers = new Panel();
        accentStatCustomers = new Panel();
        labelStatCustomersTitle = new Label();
        labelStatCustomersValue = new Label();

        panelStatEmployees = new Panel();
        accentStatEmployees = new Panel();
        labelStatEmployeesTitle = new Label();
        labelStatEmployeesValue = new Label();

        panelStatInactive = new Panel();
        accentStatInactive = new Panel();
        labelStatInactiveTitle = new Label();
        labelStatInactiveValue = new Label();

        bottomLayout = new TableLayoutPanel();

        panelRecentContacts = new Panel();
        recentContactsLayout = new TableLayoutPanel();
        labelRecentContactsTitle = new Label();
        listBoxRecentContacts = new ListBox();

        panelNeedsAttention = new Panel();
        needsAttentionLayout = new TableLayoutPanel();
        labelNeedsAttentionTitle = new Label();

        panelMissingPhone = new Panel();
        missingPhoneLayout = new TableLayoutPanel();
        labelMissingPhoneTitle = new Label();
        listBoxMissingPhone = new ListBox();

        panelDuplicates = new Panel();
        duplicatesLayout = new TableLayoutPanel();
        labelDuplicatesTitle = new Label();
        listBoxDuplicates = new ListBox();

        mainLayout.SuspendLayout();
        statsLayout.SuspendLayout();
        bottomLayout.SuspendLayout();
        panelStatTotal.SuspendLayout();
        panelStatCustomers.SuspendLayout();
        panelStatEmployees.SuspendLayout();
        panelStatInactive.SuspendLayout();
        panelRecentContacts.SuspendLayout();
        recentContactsLayout.SuspendLayout();
        panelNeedsAttention.SuspendLayout();
        needsAttentionLayout.SuspendLayout();
        panelMissingPhone.SuspendLayout();
        missingPhoneLayout.SuspendLayout();
        panelDuplicates.SuspendLayout();
        duplicatesLayout.SuspendLayout();
        SuspendLayout();

<<<<<<< Updated upstream
        //
        // mainLayout — äusserstes Raster: Zeile 1 = Statistik-Kacheln, Zeile 2 = Rest
        //
=======
>>>>>>> Stashed changes
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.ColumnCount = 1;
        mainLayout.RowCount = 2;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainLayout.Padding = new Padding(40);
        mainLayout.Controls.Add(statsLayout, 0, 0);
        mainLayout.Controls.Add(bottomLayout, 0, 1);
        mainLayout.Name = "mainLayout";

<<<<<<< Updated upstream
        //
        // statsLayout — 4 gleich breite Kacheln nebeneinander
        //
=======
>>>>>>> Stashed changes
        statsLayout.Dock = DockStyle.Fill;
        statsLayout.ColumnCount = 4;
        statsLayout.RowCount = 1;
        statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        statsLayout.Controls.Add(panelStatTotal, 0, 0);
        statsLayout.Controls.Add(panelStatCustomers, 1, 0);
        statsLayout.Controls.Add(panelStatEmployees, 2, 0);
        statsLayout.Controls.Add(panelStatInactive, 3, 0);
        statsLayout.Name = "statsLayout";

<<<<<<< Updated upstream
        //
        // panelStatTotal
        //
=======
>>>>>>> Stashed changes
        panelStatTotal.BackColor = Color.White;
        panelStatTotal.Dock = DockStyle.Fill;
        panelStatTotal.Margin = new Padding(10);
        panelStatTotal.Controls.Add(accentStatTotal);
        panelStatTotal.Controls.Add(labelStatTotalTitle);
        panelStatTotal.Controls.Add(labelStatTotalValue);
        panelStatTotal.Name = "panelStatTotal";

        accentStatTotal.BackColor = Color.SteelBlue;
        accentStatTotal.Dock = DockStyle.Top;
        accentStatTotal.Height = 4;
        accentStatTotal.Name = "accentStatTotal";

        labelStatTotalTitle.AutoSize = true;
<<<<<<< Updated upstream
        labelStatTotalTitle.Font = new Font("Segoe UI", 11F);
=======
        labelStatTotalTitle.Font = new Font(FontManager.InterRegular.FontFamily, 11F);
>>>>>>> Stashed changes
        labelStatTotalTitle.ForeColor = Color.Gray;
        labelStatTotalTitle.Location = new Point(20, 20);
        labelStatTotalTitle.Name = "labelStatTotalTitle";
        labelStatTotalTitle.Text = "KONTAKTE GESAMT";

        labelStatTotalValue.AutoSize = true;
<<<<<<< Updated upstream
        labelStatTotalValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
=======
        labelStatTotalValue.Font = new Font(FontManager.InterRegular.FontFamily, 28F, FontStyle.Bold);
>>>>>>> Stashed changes
        labelStatTotalValue.Location = new Point(20, 48);
        labelStatTotalValue.Name = "labelStatTotalValue";
        labelStatTotalValue.Text = "0";

<<<<<<< Updated upstream
        //
        // panelStatCustomers
        //
=======
>>>>>>> Stashed changes
        panelStatCustomers.BackColor = Color.White;
        panelStatCustomers.Dock = DockStyle.Fill;
        panelStatCustomers.Margin = new Padding(10);
        panelStatCustomers.Controls.Add(accentStatCustomers);
        panelStatCustomers.Controls.Add(labelStatCustomersTitle);
        panelStatCustomers.Controls.Add(labelStatCustomersValue);
        panelStatCustomers.Name = "panelStatCustomers";

        accentStatCustomers.BackColor = Color.SeaGreen;
        accentStatCustomers.Dock = DockStyle.Top;
        accentStatCustomers.Height = 4;
        accentStatCustomers.Name = "accentStatCustomers";

        labelStatCustomersTitle.AutoSize = true;
<<<<<<< Updated upstream
        labelStatCustomersTitle.Font = new Font("Segoe UI", 11F);
=======
        labelStatCustomersTitle.Font = new Font(FontManager.InterRegular.FontFamily, 11F);
>>>>>>> Stashed changes
        labelStatCustomersTitle.ForeColor = Color.Gray;
        labelStatCustomersTitle.Location = new Point(20, 20);
        labelStatCustomersTitle.Name = "labelStatCustomersTitle";
        labelStatCustomersTitle.Text = "AKTIVE KUNDEN";

        labelStatCustomersValue.AutoSize = true;
<<<<<<< Updated upstream
        labelStatCustomersValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
=======
        labelStatCustomersValue.Font = new Font(FontManager.InterRegular.FontFamily, 28F, FontStyle.Bold);
>>>>>>> Stashed changes
        labelStatCustomersValue.Location = new Point(20, 48);
        labelStatCustomersValue.Name = "labelStatCustomersValue";
        labelStatCustomersValue.Text = "0";

<<<<<<< Updated upstream
        //
        // panelStatEmployees
        //
=======
>>>>>>> Stashed changes
        panelStatEmployees.BackColor = Color.White;
        panelStatEmployees.Dock = DockStyle.Fill;
        panelStatEmployees.Margin = new Padding(10);
        panelStatEmployees.Controls.Add(accentStatEmployees);
        panelStatEmployees.Controls.Add(labelStatEmployeesTitle);
        panelStatEmployees.Controls.Add(labelStatEmployeesValue);
        panelStatEmployees.Name = "panelStatEmployees";

        accentStatEmployees.BackColor = Color.DarkGoldenrod;
        accentStatEmployees.Dock = DockStyle.Top;
        accentStatEmployees.Height = 4;
        accentStatEmployees.Name = "accentStatEmployees";

        labelStatEmployeesTitle.AutoSize = true;
<<<<<<< Updated upstream
        labelStatEmployeesTitle.Font = new Font("Segoe UI", 11F);
=======
        labelStatEmployeesTitle.Font = new Font(FontManager.InterRegular.FontFamily, 11F);
>>>>>>> Stashed changes
        labelStatEmployeesTitle.ForeColor = Color.Gray;
        labelStatEmployeesTitle.Location = new Point(20, 20);
        labelStatEmployeesTitle.Name = "labelStatEmployeesTitle";
        labelStatEmployeesTitle.Text = "AKTIVE MITARBEITER";

        labelStatEmployeesValue.AutoSize = true;
<<<<<<< Updated upstream
        labelStatEmployeesValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
=======
        labelStatEmployeesValue.Font = new Font(FontManager.InterRegular.FontFamily, 28F, FontStyle.Bold);
>>>>>>> Stashed changes
        labelStatEmployeesValue.Location = new Point(20, 48);
        labelStatEmployeesValue.Name = "labelStatEmployeesValue";
        labelStatEmployeesValue.Text = "0";

<<<<<<< Updated upstream
        //
        // panelStatInactive
        //
=======
>>>>>>> Stashed changes
        panelStatInactive.BackColor = Color.White;
        panelStatInactive.Dock = DockStyle.Fill;
        panelStatInactive.Margin = new Padding(10);
        panelStatInactive.Controls.Add(accentStatInactive);
        panelStatInactive.Controls.Add(labelStatInactiveTitle);
        panelStatInactive.Controls.Add(labelStatInactiveValue);
        panelStatInactive.Name = "panelStatInactive";

        accentStatInactive.BackColor = Color.Gray;
        accentStatInactive.Dock = DockStyle.Top;
        accentStatInactive.Height = 4;
        accentStatInactive.Name = "accentStatInactive";

        labelStatInactiveTitle.AutoSize = true;
<<<<<<< Updated upstream
        labelStatInactiveTitle.Font = new Font("Segoe UI", 11F);
=======
        labelStatInactiveTitle.Font = new Font(FontManager.InterRegular.FontFamily, 11F);
>>>>>>> Stashed changes
        labelStatInactiveTitle.ForeColor = Color.Gray;
        labelStatInactiveTitle.Location = new Point(20, 20);
        labelStatInactiveTitle.Name = "labelStatInactiveTitle";
        labelStatInactiveTitle.Text = "INAKTIV";

        labelStatInactiveValue.AutoSize = true;
<<<<<<< Updated upstream
        labelStatInactiveValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
=======
        labelStatInactiveValue.Font = new Font(FontManager.InterRegular.FontFamily, 28F, FontStyle.Bold);
>>>>>>> Stashed changes
        labelStatInactiveValue.Location = new Point(20, 48);
        labelStatInactiveValue.Name = "labelStatInactiveValue";
        labelStatInactiveValue.Text = "0";

<<<<<<< Updated upstream
        //
        // bottomLayout — links: zuletzt hinzugefügt, rechts: Bedarf an Überprüfung
        //
=======
>>>>>>> Stashed changes
        bottomLayout.Dock = DockStyle.Fill;
        bottomLayout.ColumnCount = 2;
        bottomLayout.RowCount = 1;
        bottomLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
        bottomLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        bottomLayout.Controls.Add(panelRecentContacts, 0, 0);
        bottomLayout.Controls.Add(panelNeedsAttention, 1, 0);
        bottomLayout.Name = "bottomLayout";

<<<<<<< Updated upstream
        //
        // panelRecentContacts — enthält ein 2-zeiliges Raster: Titel (fest) + Liste (füllt Rest)
        //
=======
>>>>>>> Stashed changes
        panelRecentContacts.BackColor = Color.White;
        panelRecentContacts.Dock = DockStyle.Fill;
        panelRecentContacts.Margin = new Padding(10);
        panelRecentContacts.Controls.Add(recentContactsLayout);
        panelRecentContacts.Name = "panelRecentContacts";

        recentContactsLayout.Dock = DockStyle.Fill;
        recentContactsLayout.ColumnCount = 1;
        recentContactsLayout.RowCount = 2;
        recentContactsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
        recentContactsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        recentContactsLayout.Controls.Add(labelRecentContactsTitle, 0, 0);
        recentContactsLayout.Controls.Add(listBoxRecentContacts, 0, 1);
        recentContactsLayout.Name = "recentContactsLayout";

        labelRecentContactsTitle.Dock = DockStyle.Fill;
<<<<<<< Updated upstream
        labelRecentContactsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
=======
        labelRecentContactsTitle.Font = new Font(FontManager.InterRegular.FontFamily, 14F, FontStyle.Bold);
>>>>>>> Stashed changes
        labelRecentContactsTitle.Padding = new Padding(20, 15, 0, 0);
        labelRecentContactsTitle.Name = "labelRecentContactsTitle";
        labelRecentContactsTitle.Text = "Zuletzt hinzugefügte Kontakte";

        listBoxRecentContacts.Dock = DockStyle.Fill;
        listBoxRecentContacts.Margin = new Padding(20, 0, 20, 20);
        listBoxRecentContacts.BorderStyle = BorderStyle.None;
<<<<<<< Updated upstream
        listBoxRecentContacts.Font = new Font("Segoe UI", 12F);
        listBoxRecentContacts.ItemHeight = 32;
        listBoxRecentContacts.Name = "listBoxRecentContacts";

        //
        // panelNeedsAttention — enthält ein 3-zeiliges Raster: Titel (fest), MissingPhone (50%), Duplicates (50%)
        //
=======
        listBoxRecentContacts.Font = new Font(FontManager.InterRegular.FontFamily, 12F);
        listBoxRecentContacts.ItemHeight = 32;
        listBoxRecentContacts.Name = "listBoxRecentContacts";

>>>>>>> Stashed changes
        panelNeedsAttention.BackColor = Color.White;
        panelNeedsAttention.Dock = DockStyle.Fill;
        panelNeedsAttention.Margin = new Padding(10);
        panelNeedsAttention.Controls.Add(needsAttentionLayout);
        panelNeedsAttention.Name = "panelNeedsAttention";

        needsAttentionLayout.Dock = DockStyle.Fill;
        needsAttentionLayout.ColumnCount = 1;
        needsAttentionLayout.RowCount = 3;
        needsAttentionLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
        needsAttentionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        needsAttentionLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        needsAttentionLayout.Controls.Add(labelNeedsAttentionTitle, 0, 0);
        needsAttentionLayout.Controls.Add(panelMissingPhone, 0, 1);
        needsAttentionLayout.Controls.Add(panelDuplicates, 0, 2);
        needsAttentionLayout.Name = "needsAttentionLayout";

        labelNeedsAttentionTitle.Dock = DockStyle.Fill;
<<<<<<< Updated upstream
        labelNeedsAttentionTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
=======
        labelNeedsAttentionTitle.Font = new Font(FontManager.InterRegular.FontFamily, 14F, FontStyle.Bold);
>>>>>>> Stashed changes
        labelNeedsAttentionTitle.Padding = new Padding(20, 15, 0, 0);
        labelNeedsAttentionTitle.Name = "labelNeedsAttentionTitle";
        labelNeedsAttentionTitle.Text = "Bedarf an Überprüfung";

<<<<<<< Updated upstream
        //
        // panelMissingPhone — 2-zeiliges Raster: Titel (fest) + Liste (füllt Rest)
        //
=======
>>>>>>> Stashed changes
        panelMissingPhone.Dock = DockStyle.Fill;
        panelMissingPhone.Padding = new Padding(20, 5, 20, 10);
        panelMissingPhone.Controls.Add(missingPhoneLayout);
        panelMissingPhone.Name = "panelMissingPhone";

        missingPhoneLayout.Dock = DockStyle.Fill;
        missingPhoneLayout.ColumnCount = 1;
        missingPhoneLayout.RowCount = 2;
        missingPhoneLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        missingPhoneLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        missingPhoneLayout.Controls.Add(labelMissingPhoneTitle, 0, 0);
        missingPhoneLayout.Controls.Add(listBoxMissingPhone, 0, 1);
        missingPhoneLayout.Name = "missingPhoneLayout";

        labelMissingPhoneTitle.Dock = DockStyle.Fill;
<<<<<<< Updated upstream
        labelMissingPhoneTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
=======
        labelMissingPhoneTitle.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Bold);
>>>>>>> Stashed changes
        labelMissingPhoneTitle.Name = "labelMissingPhoneTitle";
        labelMissingPhoneTitle.Text = "Kontakte ohne Telefonnummer";

        listBoxMissingPhone.Dock = DockStyle.Fill;
        listBoxMissingPhone.BorderStyle = BorderStyle.FixedSingle;
<<<<<<< Updated upstream
        listBoxMissingPhone.Font = new Font("Segoe UI", 11F);
        listBoxMissingPhone.ItemHeight = 28;
        listBoxMissingPhone.Name = "listBoxMissingPhone";

        //
        // panelDuplicates — 2-zeiliges Raster: Titel (fest) + Liste (füllt Rest)
        //
=======
        listBoxMissingPhone.Font = new Font(FontManager.InterRegular.FontFamily, 11F);
        listBoxMissingPhone.ItemHeight = 28;
        listBoxMissingPhone.Name = "listBoxMissingPhone";

>>>>>>> Stashed changes
        panelDuplicates.Dock = DockStyle.Fill;
        panelDuplicates.Padding = new Padding(20, 5, 20, 20);
        panelDuplicates.Controls.Add(duplicatesLayout);
        panelDuplicates.Name = "panelDuplicates";

        duplicatesLayout.Dock = DockStyle.Fill;
        duplicatesLayout.ColumnCount = 1;
        duplicatesLayout.RowCount = 2;
        duplicatesLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        duplicatesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        duplicatesLayout.Controls.Add(labelDuplicatesTitle, 0, 0);
        duplicatesLayout.Controls.Add(listBoxDuplicates, 0, 1);
        duplicatesLayout.Name = "duplicatesLayout";

        labelDuplicatesTitle.Dock = DockStyle.Fill;
<<<<<<< Updated upstream
        labelDuplicatesTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
=======
        labelDuplicatesTitle.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Bold);
>>>>>>> Stashed changes
        labelDuplicatesTitle.Name = "labelDuplicatesTitle";
        labelDuplicatesTitle.Text = "Mögliche Duplikate erkannt";

        listBoxDuplicates.Dock = DockStyle.Fill;
        listBoxDuplicates.BorderStyle = BorderStyle.FixedSingle;
<<<<<<< Updated upstream
        listBoxDuplicates.Font = new Font("Segoe UI", 11F);
        listBoxDuplicates.ItemHeight = 28;
        listBoxDuplicates.Name = "listBoxDuplicates";

        //
        // FormDashboardPartial
        //
=======
        listBoxDuplicates.Font = new Font(FontManager.InterRegular.FontFamily, 11F);
        listBoxDuplicates.ItemHeight = 28;
        listBoxDuplicates.Name = "listBoxDuplicates";

>>>>>>> Stashed changes
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(240, 240, 240);
        ClientSize = new Size(2291, 1317);
        Controls.Add(mainLayout);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormDashboardPartial";
        Text = "FormDashboardPartial";

        mainLayout.ResumeLayout(false);
        statsLayout.ResumeLayout(false);
        bottomLayout.ResumeLayout(false);
        panelStatTotal.ResumeLayout(false);
        panelStatTotal.PerformLayout();
        panelStatCustomers.ResumeLayout(false);
        panelStatCustomers.PerformLayout();
        panelStatEmployees.ResumeLayout(false);
        panelStatEmployees.PerformLayout();
        panelStatInactive.ResumeLayout(false);
        panelStatInactive.PerformLayout();
        panelRecentContacts.ResumeLayout(false);
        recentContactsLayout.ResumeLayout(false);
        panelNeedsAttention.ResumeLayout(false);
        needsAttentionLayout.ResumeLayout(false);
        panelMissingPhone.ResumeLayout(false);
        missingPhoneLayout.ResumeLayout(false);
        panelDuplicates.ResumeLayout(false);
        duplicatesLayout.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel mainLayout;
    private TableLayoutPanel statsLayout;
    private TableLayoutPanel bottomLayout;

    private Panel panelStatTotal;
    private Panel accentStatTotal;
    private Label labelStatTotalTitle;
    private Label labelStatTotalValue;

    private Panel panelStatCustomers;
    private Panel accentStatCustomers;
    private Label labelStatCustomersTitle;
    private Label labelStatCustomersValue;

    private Panel panelStatEmployees;
    private Panel accentStatEmployees;
    private Label labelStatEmployeesTitle;
    private Label labelStatEmployeesValue;

    private Panel panelStatInactive;
    private Panel accentStatInactive;
    private Label labelStatInactiveTitle;
    private Label labelStatInactiveValue;

    private Panel panelRecentContacts;
    private TableLayoutPanel recentContactsLayout;
    private Label labelRecentContactsTitle;
    private ListBox listBoxRecentContacts;

    private Panel panelNeedsAttention;
    private TableLayoutPanel needsAttentionLayout;
    private Label labelNeedsAttentionTitle;

    private Panel panelMissingPhone;
    private TableLayoutPanel missingPhoneLayout;
    private Label labelMissingPhoneTitle;
    private ListBox listBoxMissingPhone;

    private Panel panelDuplicates;
    private TableLayoutPanel duplicatesLayout;
    private Label labelDuplicatesTitle;
    private ListBox listBoxDuplicates;
}