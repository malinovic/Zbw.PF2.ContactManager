using System.Windows.Forms;


namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormCustomerDetail : Form
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
        boxSalutation = new ComboBox();
        boxFirstName = new TextBox();
        boxLastName = new TextBox();
        boxBirthday = new TextBox();
        boxSex = new ComboBox();
        boxTitle = new ComboBox();
        boxStreet = new TextBox();
        boxStreetNumber = new TextBox();
        boxZipCode = new TextBox();
        boxCity = new TextBox();
        buttonCancel = new Button();
        buttonSave = new Button();
        boxPhoneNumberCompany = new TextBox();
        boxPhoneNumberMobile = new TextBox();
        boxEmail = new TextBox();
        panelSalutation = new Panel();
        panelSalutationLabel = new Panel();
        labelSalutation = new Label();
        panelFirstName = new Panel();
        panelFirstNameLabel = new Panel();
        labelFirstName = new Label();
        panelLastName = new Panel();
        panelLastNameLabel = new Panel();
        labelLastName = new Label();
        panelBirthday = new Panel();
        panelBirthdayLabel = new Panel();
        labelBirthday = new Label();
        panelSex = new Panel();
        panelSexLabel = new Panel();
        labelSex = new Label();
        panelTitle = new Panel();
        panelTitleLabel = new Panel();
        labelTitle = new Label();
        panelStreet = new Panel();
        panelStreetLabel = new Panel();
        labelStreet = new Label();
        panelStreetNumber = new Panel();
        panelStreetNumberLabel = new Panel();
        labelStreetNumber = new Label();
        panelZipCode = new Panel();
        panelZipCodeLabel = new Panel();
        labelZipCode = new Label();
        panelCity = new Panel();
        panelCityLabel = new Panel();
        labelCity = new Label();
        panelPhoneNumberCompany = new Panel();
        panelPhoneNumberCompanyLabel = new Panel();
        labelPhoneNumberCompany = new Label();
        panelPhoneNumberMobile = new Panel();
        panelPhoneNumberMobileLabel = new Panel();
        labelPhoneNumberMobile = new Label();
        panelEmail = new Panel();
        panelEmailLabel = new Panel();
        labelEmail = new Label();
        panelCustomerNumber = new Panel();
        panelCustomerNumberLabel = new Panel();
        labelCustomerNumber = new Label();
        boxCustomerNumber = new TextBox();
        panelStatus = new Panel();
        panelStatusLabel = new Panel();
        labelStatus = new Label();
        boxStatus = new ComboBox();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        panel1 = new Panel();
        panelSalutation.SuspendLayout();
        panelSalutationLabel.SuspendLayout();
        panelFirstName.SuspendLayout();
        panelFirstNameLabel.SuspendLayout();
        panelLastName.SuspendLayout();
        panelLastNameLabel.SuspendLayout();
        panelBirthday.SuspendLayout();
        panelBirthdayLabel.SuspendLayout();
        panelSex.SuspendLayout();
        panelSexLabel.SuspendLayout();
        panelTitle.SuspendLayout();
        panelTitleLabel.SuspendLayout();
        panelStreet.SuspendLayout();
        panelStreetLabel.SuspendLayout();
        panelStreetNumber.SuspendLayout();
        panelStreetNumberLabel.SuspendLayout();
        panelZipCode.SuspendLayout();
        panelZipCodeLabel.SuspendLayout();
        panelCity.SuspendLayout();
        panelCityLabel.SuspendLayout();
        panelPhoneNumberCompany.SuspendLayout();
        panelPhoneNumberCompanyLabel.SuspendLayout();
        panelPhoneNumberMobile.SuspendLayout();
        panelPhoneNumberMobileLabel.SuspendLayout();
        panelEmail.SuspendLayout();
        panelEmailLabel.SuspendLayout();
        panelCustomerNumber.SuspendLayout();
        panelCustomerNumberLabel.SuspendLayout();
        panelStatus.SuspendLayout();
        panelStatusLabel.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // boxSalutation
        // 
        boxSalutation.Dock = DockStyle.Bottom;
        boxSalutation.DropDownStyle = ComboBoxStyle.DropDownList;
        boxSalutation.FormattingEnabled = true;
        boxSalutation.Items.AddRange(new object[] { "Herr", "Frau" });
        boxSalutation.Location = new Point(0, 78);
        boxSalutation.Name = "boxSalutation";
        boxSalutation.Size = new Size(528, 23);
        boxSalutation.TabIndex = 1;
        // 
        // boxFirstName
        // 
        boxFirstName.Dock = DockStyle.Bottom;
        boxFirstName.Font = new Font("Segoe UI", 11F);
        boxFirstName.Location = new Point(0, 71);
        boxFirstName.Name = "boxFirstName";
        boxFirstName.Size = new Size(250, 27);
        boxFirstName.TabIndex = 1;
        // 
        // boxLastName
        // 
        boxLastName.Dock = DockStyle.Bottom;
        boxLastName.Font = new Font("Segoe UI", 11F);
        boxLastName.Location = new Point(0, 71);
        boxLastName.Name = "boxLastName";
        boxLastName.Size = new Size(250, 27);
        boxLastName.TabIndex = 1;
        // 
        // boxBirthday
        // 
        boxBirthday.BorderStyle = BorderStyle.FixedSingle;
        boxBirthday.Dock = DockStyle.Bottom;
        boxBirthday.Font = new Font("Segoe UI", 11F);
        boxBirthday.Location = new Point(0, 74);
        boxBirthday.Name = "boxBirthday";
        boxBirthday.PlaceholderText = "dd.MM.yyyy";
        boxBirthday.Size = new Size(250, 27);
        boxBirthday.TabIndex = 1;
        // 
        // boxSex
        // 
        boxSex.Dock = DockStyle.Bottom;
        boxSex.FormattingEnabled = true;
        boxSex.Location = new Point(0, 78);
        boxSex.Name = "boxSex";
        boxSex.Size = new Size(250, 23);
        boxSex.TabIndex = 1;
        // 
        // boxTitle
        // 
        boxTitle.Dock = DockStyle.Bottom;
        boxTitle.FormattingEnabled = true;
        boxTitle.Location = new Point(0, 78);
        boxTitle.Name = "boxTitle";
        boxTitle.Size = new Size(528, 23);
        boxTitle.TabIndex = 1;
        // 
        // boxStreet
        // 
        boxStreet.Dock = DockStyle.Bottom;
        boxStreet.Font = new Font("Segoe UI", 11F);
        boxStreet.Location = new Point(0, 71);
        boxStreet.Name = "boxStreet";
        boxStreet.Size = new Size(250, 27);
        boxStreet.TabIndex = 1;
        // 
        // boxStreetNumber
        // 
        boxStreetNumber.Dock = DockStyle.Bottom;
        boxStreetNumber.Font = new Font("Segoe UI", 11F);
        boxStreetNumber.Location = new Point(0, 71);
        boxStreetNumber.Name = "boxStreetNumber";
        boxStreetNumber.PlaceholderText = "11a";
        boxStreetNumber.Size = new Size(250, 27);
        boxStreetNumber.TabIndex = 1;
        // 
        // boxZipCode
        // 
        boxZipCode.Dock = DockStyle.Bottom;
        boxZipCode.Font = new Font("Segoe UI", 11F);
        boxZipCode.Location = new Point(0, 71);
        boxZipCode.Name = "boxZipCode";
        boxZipCode.PlaceholderText = "XXXX";
        boxZipCode.Size = new Size(250, 27);
        boxZipCode.TabIndex = 1;
        // 
        // boxCity
        // 
        boxCity.Dock = DockStyle.Bottom;
        boxCity.Font = new Font("Segoe UI", 11F);
        boxCity.Location = new Point(0, 71);
        boxCity.Name = "boxCity";
        boxCity.Size = new Size(250, 27);
        boxCity.TabIndex = 1;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(1455, 22);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(221, 57);
        buttonCancel.TabIndex = 0;
        buttonCancel.Text = "Abbrechen";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += buttonCancel_Click;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(1692, 22);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(220, 57);
        buttonSave.TabIndex = 1;
        buttonSave.Text = "Speichern";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // boxPhoneNumberCompany
        // 
        boxPhoneNumberCompany.Dock = DockStyle.Bottom;
        boxPhoneNumberCompany.Font = new Font("Segoe UI", 11F);
        boxPhoneNumberCompany.Location = new Point(0, 71);
        boxPhoneNumberCompany.Name = "boxPhoneNumberCompany";
        boxPhoneNumberCompany.PlaceholderText = "0761234567";
        boxPhoneNumberCompany.Size = new Size(528, 27);
        boxPhoneNumberCompany.TabIndex = 1;
        // 
        // boxPhoneNumberMobile
        // 
        boxPhoneNumberMobile.Dock = DockStyle.Bottom;
        boxPhoneNumberMobile.Font = new Font("Segoe UI", 11F);
        boxPhoneNumberMobile.Location = new Point(0, 71);
        boxPhoneNumberMobile.Name = "boxPhoneNumberMobile";
        boxPhoneNumberMobile.PlaceholderText = "0761234567";
        boxPhoneNumberMobile.Size = new Size(528, 27);
        boxPhoneNumberMobile.TabIndex = 1;
        // 
        // boxEmail
        // 
        boxEmail.Dock = DockStyle.Bottom;
        boxEmail.Font = new Font("Segoe UI", 11F);
        boxEmail.Location = new Point(0, 71);
        boxEmail.Name = "boxEmail";
        boxEmail.PlaceholderText = "maxmustermann@gmail.com";
        boxEmail.Size = new Size(528, 27);
        boxEmail.TabIndex = 1;
        // 
        // panelSalutation
        // 
        panelSalutation.Controls.Add(panelSalutationLabel);
        panelSalutation.Controls.Add(boxSalutation);
        panelSalutation.Location = new Point(41, 44);
        panelSalutation.Name = "panelSalutation";
        panelSalutation.Size = new Size(528, 101);
        panelSalutation.TabIndex = 0;
        // 
        // panelSalutationLabel
        // 
        panelSalutationLabel.Controls.Add(labelSalutation);
        panelSalutationLabel.Dock = DockStyle.Top;
        panelSalutationLabel.Location = new Point(0, 0);
        panelSalutationLabel.Name = "panelSalutationLabel";
        panelSalutationLabel.Size = new Size(528, 46);
        panelSalutationLabel.TabIndex = 0;
        // 
        // labelSalutation
        // 
        labelSalutation.AutoSize = true;
        labelSalutation.Dock = DockStyle.Fill;
        labelSalutation.Location = new Point(0, 0);
        labelSalutation.Name = "labelSalutation";
        labelSalutation.Size = new Size(45, 15);
        labelSalutation.TabIndex = 0;
        labelSalutation.Text = "Anrede";
        // 
        // panelFirstName
        // 
        panelFirstName.Controls.Add(panelFirstNameLabel);
        panelFirstName.Controls.Add(boxFirstName);
        panelFirstName.Location = new Point(41, 148);
        panelFirstName.Name = "panelFirstName";
        panelFirstName.Size = new Size(250, 98);
        panelFirstName.TabIndex = 1;
        // 
        // panelFirstNameLabel
        // 
        panelFirstNameLabel.Controls.Add(labelFirstName);
        panelFirstNameLabel.Dock = DockStyle.Top;
        panelFirstNameLabel.Location = new Point(0, 0);
        panelFirstNameLabel.Name = "panelFirstNameLabel";
        panelFirstNameLabel.Size = new Size(250, 46);
        panelFirstNameLabel.TabIndex = 0;
        // 
        // labelFirstName
        // 
        labelFirstName.AutoSize = true;
        labelFirstName.Dock = DockStyle.Fill;
        labelFirstName.Location = new Point(0, 0);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new Size(54, 15);
        labelFirstName.TabIndex = 0;
        labelFirstName.Text = "Vorname";
        // 
        // panelLastName
        // 
        panelLastName.Controls.Add(panelLastNameLabel);
        panelLastName.Controls.Add(boxLastName);
        panelLastName.Location = new Point(319, 148);
        panelLastName.Name = "panelLastName";
        panelLastName.Size = new Size(250, 98);
        panelLastName.TabIndex = 2;
        // 
        // panelLastNameLabel
        // 
        panelLastNameLabel.Controls.Add(labelLastName);
        panelLastNameLabel.Dock = DockStyle.Top;
        panelLastNameLabel.Location = new Point(0, 0);
        panelLastNameLabel.Name = "panelLastNameLabel";
        panelLastNameLabel.Size = new Size(250, 46);
        panelLastNameLabel.TabIndex = 0;
        // 
        // labelLastName
        // 
        labelLastName.AutoSize = true;
        labelLastName.Dock = DockStyle.Fill;
        labelLastName.Location = new Point(0, 0);
        labelLastName.Name = "labelLastName";
        labelLastName.Size = new Size(65, 15);
        labelLastName.TabIndex = 0;
        labelLastName.Text = "Nachname";
        // 
        // panelBirthday
        // 
        panelBirthday.Controls.Add(panelBirthdayLabel);
        panelBirthday.Controls.Add(boxBirthday);
        panelBirthday.Location = new Point(41, 258);
        panelBirthday.Name = "panelBirthday";
        panelBirthday.Size = new Size(250, 101);
        panelBirthday.TabIndex = 3;
        // 
        // panelBirthdayLabel
        // 
        panelBirthdayLabel.Controls.Add(labelBirthday);
        panelBirthdayLabel.Dock = DockStyle.Top;
        panelBirthdayLabel.Location = new Point(0, 0);
        panelBirthdayLabel.Name = "panelBirthdayLabel";
        panelBirthdayLabel.Size = new Size(250, 46);
        panelBirthdayLabel.TabIndex = 0;
        // 
        // labelBirthday
        // 
        labelBirthday.AutoSize = true;
        labelBirthday.Dock = DockStyle.Fill;
        labelBirthday.Location = new Point(0, 0);
        labelBirthday.Name = "labelBirthday";
        labelBirthday.Size = new Size(65, 15);
        labelBirthday.TabIndex = 0;
        labelBirthday.Text = "Geburtstag";
        // 
        // panelSex
        // 
        panelSex.Controls.Add(panelSexLabel);
        panelSex.Controls.Add(boxSex);
        panelSex.Location = new Point(319, 258);
        panelSex.Name = "panelSex";
        panelSex.Size = new Size(250, 101);
        panelSex.TabIndex = 4;
        // 
        // panelSexLabel
        // 
        panelSexLabel.Controls.Add(labelSex);
        panelSexLabel.Dock = DockStyle.Top;
        panelSexLabel.Location = new Point(0, 0);
        panelSexLabel.Name = "panelSexLabel";
        panelSexLabel.Size = new Size(250, 46);
        panelSexLabel.TabIndex = 0;
        // 
        // labelSex
        // 
        labelSex.AutoSize = true;
        labelSex.Dock = DockStyle.Fill;
        labelSex.Location = new Point(0, 0);
        labelSex.Name = "labelSex";
        labelSex.Size = new Size(65, 15);
        labelSex.TabIndex = 0;
        labelSex.Text = "Geschlecht";
        // 
        // panelTitle
        // 
        panelTitle.Controls.Add(panelTitleLabel);
        panelTitle.Controls.Add(boxTitle);
        panelTitle.Location = new Point(41, 371);
        panelTitle.Name = "panelTitle";
        panelTitle.Size = new Size(528, 101);
        panelTitle.TabIndex = 5;
        // 
        // panelTitleLabel
        // 
        panelTitleLabel.Controls.Add(labelTitle);
        panelTitleLabel.Dock = DockStyle.Top;
        panelTitleLabel.Location = new Point(0, 0);
        panelTitleLabel.Name = "panelTitleLabel";
        panelTitleLabel.Size = new Size(528, 46);
        panelTitleLabel.TabIndex = 0;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Dock = DockStyle.Fill;
        labelTitle.Location = new Point(0, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(30, 15);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Titel";
        // 
        // panelStreet
        // 
        panelStreet.Controls.Add(panelStreetLabel);
        panelStreet.Controls.Add(boxStreet);
        panelStreet.Location = new Point(41, 484);
        panelStreet.Name = "panelStreet";
        panelStreet.Size = new Size(250, 98);
        panelStreet.TabIndex = 6;
        // 
        // panelStreetLabel
        // 
        panelStreetLabel.Controls.Add(labelStreet);
        panelStreetLabel.Dock = DockStyle.Top;
        panelStreetLabel.Location = new Point(0, 0);
        panelStreetLabel.Name = "panelStreetLabel";
        panelStreetLabel.Size = new Size(250, 46);
        panelStreetLabel.TabIndex = 0;
        // 
        // labelStreet
        // 
        labelStreet.AutoSize = true;
        labelStreet.Dock = DockStyle.Fill;
        labelStreet.Location = new Point(0, 0);
        labelStreet.Name = "labelStreet";
        labelStreet.Size = new Size(43, 15);
        labelStreet.TabIndex = 0;
        labelStreet.Text = "Strasse";
        // 
        // panelStreetNumber
        // 
        panelStreetNumber.Controls.Add(panelStreetNumberLabel);
        panelStreetNumber.Controls.Add(boxStreetNumber);
        panelStreetNumber.Location = new Point(319, 484);
        panelStreetNumber.Name = "panelStreetNumber";
        panelStreetNumber.Size = new Size(250, 98);
        panelStreetNumber.TabIndex = 7;
        // 
        // panelStreetNumberLabel
        // 
        panelStreetNumberLabel.Controls.Add(labelStreetNumber);
        panelStreetNumberLabel.Dock = DockStyle.Top;
        panelStreetNumberLabel.Location = new Point(0, 0);
        panelStreetNumberLabel.Name = "panelStreetNumberLabel";
        panelStreetNumberLabel.Size = new Size(250, 46);
        panelStreetNumberLabel.TabIndex = 0;
        // 
        // labelStreetNumber
        // 
        labelStreetNumber.AutoSize = true;
        labelStreetNumber.Dock = DockStyle.Fill;
        labelStreetNumber.Location = new Point(0, 0);
        labelStreetNumber.Name = "labelStreetNumber";
        labelStreetNumber.Size = new Size(26, 15);
        labelStreetNumber.TabIndex = 0;
        labelStreetNumber.Text = "Nr. ";
        // 
        // panelZipCode
        // 
        panelZipCode.Controls.Add(panelZipCodeLabel);
        panelZipCode.Controls.Add(boxZipCode);
        panelZipCode.Location = new Point(41, 594);
        panelZipCode.Name = "panelZipCode";
        panelZipCode.Size = new Size(250, 98);
        panelZipCode.TabIndex = 8;
        // 
        // panelZipCodeLabel
        // 
        panelZipCodeLabel.Controls.Add(labelZipCode);
        panelZipCodeLabel.Dock = DockStyle.Top;
        panelZipCodeLabel.Location = new Point(0, 0);
        panelZipCodeLabel.Name = "panelZipCodeLabel";
        panelZipCodeLabel.Size = new Size(250, 46);
        panelZipCodeLabel.TabIndex = 0;
        // 
        // labelZipCode
        // 
        labelZipCode.AutoSize = true;
        labelZipCode.Dock = DockStyle.Fill;
        labelZipCode.Location = new Point(0, 0);
        labelZipCode.Name = "labelZipCode";
        labelZipCode.Size = new Size(67, 15);
        labelZipCode.TabIndex = 0;
        labelZipCode.Text = "Postleitzahl";
        // 
        // panelCity
        // 
        panelCity.Controls.Add(panelCityLabel);
        panelCity.Controls.Add(boxCity);
        panelCity.Location = new Point(319, 594);
        panelCity.Name = "panelCity";
        panelCity.Size = new Size(250, 98);
        panelCity.TabIndex = 9;
        // 
        // panelCityLabel
        // 
        panelCityLabel.Controls.Add(labelCity);
        panelCityLabel.Dock = DockStyle.Top;
        panelCityLabel.Location = new Point(0, 0);
        panelCityLabel.Name = "panelCityLabel";
        panelCityLabel.Size = new Size(250, 46);
        panelCityLabel.TabIndex = 0;
        // 
        // labelCity
        // 
        labelCity.AutoSize = true;
        labelCity.Dock = DockStyle.Fill;
        labelCity.Location = new Point(0, 0);
        labelCity.Name = "labelCity";
        labelCity.Size = new Size(24, 15);
        labelCity.TabIndex = 0;
        labelCity.Text = "Ort";
        // 
        // panelPhoneNumberCompany
        // 
        panelPhoneNumberCompany.Controls.Add(panelPhoneNumberCompanyLabel);
        panelPhoneNumberCompany.Controls.Add(boxPhoneNumberCompany);
        panelPhoneNumberCompany.Location = new Point(41, 704);
        panelPhoneNumberCompany.Name = "panelPhoneNumberCompany";
        panelPhoneNumberCompany.Size = new Size(528, 98);
        panelPhoneNumberCompany.TabIndex = 10;
        // 
        // panelPhoneNumberCompanyLabel
        // 
        panelPhoneNumberCompanyLabel.Controls.Add(labelPhoneNumberCompany);
        panelPhoneNumberCompanyLabel.Dock = DockStyle.Top;
        panelPhoneNumberCompanyLabel.Location = new Point(0, 0);
        panelPhoneNumberCompanyLabel.Name = "panelPhoneNumberCompanyLabel";
        panelPhoneNumberCompanyLabel.Size = new Size(528, 46);
        panelPhoneNumberCompanyLabel.TabIndex = 0;
        // 
        // labelPhoneNumberCompany
        // 
        labelPhoneNumberCompany.AutoSize = true;
        labelPhoneNumberCompany.Dock = DockStyle.Fill;
        labelPhoneNumberCompany.Location = new Point(0, 0);
        labelPhoneNumberCompany.Name = "labelPhoneNumberCompany";
        labelPhoneNumberCompany.Size = new Size(74, 15);
        labelPhoneNumberCompany.TabIndex = 0;
        labelPhoneNumberCompany.Text = "Tel. Geschäft";
        // 
        // panelPhoneNumberMobile
        // 
        panelPhoneNumberMobile.Controls.Add(panelPhoneNumberMobileLabel);
        panelPhoneNumberMobile.Controls.Add(boxPhoneNumberMobile);
        panelPhoneNumberMobile.Location = new Point(41, 814);
        panelPhoneNumberMobile.Name = "panelPhoneNumberMobile";
        panelPhoneNumberMobile.Size = new Size(528, 98);
        panelPhoneNumberMobile.TabIndex = 11;
        // 
        // panelPhoneNumberMobileLabel
        // 
        panelPhoneNumberMobileLabel.Controls.Add(labelPhoneNumberMobile);
        panelPhoneNumberMobileLabel.Dock = DockStyle.Top;
        panelPhoneNumberMobileLabel.Location = new Point(0, 0);
        panelPhoneNumberMobileLabel.Name = "panelPhoneNumberMobileLabel";
        panelPhoneNumberMobileLabel.Size = new Size(528, 46);
        panelPhoneNumberMobileLabel.TabIndex = 0;
        // 
        // labelPhoneNumberMobile
        // 
        labelPhoneNumberMobile.AutoSize = true;
        labelPhoneNumberMobile.Dock = DockStyle.Fill;
        labelPhoneNumberMobile.Location = new Point(0, 0);
        labelPhoneNumberMobile.Name = "labelPhoneNumberMobile";
        labelPhoneNumberMobile.Size = new Size(59, 15);
        labelPhoneNumberMobile.TabIndex = 0;
        labelPhoneNumberMobile.Text = "Tel. Mobil";
        // 
        // panelEmail
        // 
        panelEmail.Controls.Add(panelEmailLabel);
        panelEmail.Controls.Add(boxEmail);
        panelEmail.Location = new Point(41, 924);
        panelEmail.Name = "panelEmail";
        panelEmail.Size = new Size(528, 98);
        panelEmail.TabIndex = 12;
        // 
        // panelEmailLabel
        // 
        panelEmailLabel.Controls.Add(labelEmail);
        panelEmailLabel.Dock = DockStyle.Top;
        panelEmailLabel.Location = new Point(0, 0);
        panelEmailLabel.Name = "panelEmailLabel";
        panelEmailLabel.Size = new Size(528, 46);
        panelEmailLabel.TabIndex = 0;
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Dock = DockStyle.Fill;
        labelEmail.Location = new Point(0, 0);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(41, 15);
        labelEmail.TabIndex = 0;
        labelEmail.Text = "E-Mail";
        // 
        // panelCustomerNumber
        // 
        panelCustomerNumber.Controls.Add(panelCustomerNumberLabel);
        panelCustomerNumber.Controls.Add(boxCustomerNumber);
        panelCustomerNumber.Location = new Point(670, 51);
        panelCustomerNumber.Name = "panelCustomerNumber";
        panelCustomerNumber.Size = new Size(250, 98);
        panelCustomerNumber.TabIndex = 1;
        // 
        // panelCustomerNumberLabel
        // 
        panelCustomerNumberLabel.Controls.Add(labelCustomerNumber);
        panelCustomerNumberLabel.Dock = DockStyle.Top;
        panelCustomerNumberLabel.Location = new Point(0, 0);
        panelCustomerNumberLabel.Name = "panelCustomerNumberLabel";
        panelCustomerNumberLabel.Size = new Size(250, 46);
        panelCustomerNumberLabel.TabIndex = 0;
        // 
        // labelCustomerNumber
        // 
        labelCustomerNumber.AutoSize = true;
        labelCustomerNumber.Dock = DockStyle.Fill;
        labelCustomerNumber.Location = new Point(0, 0);
        labelCustomerNumber.Name = "labelCustomerNumber";
        labelCustomerNumber.Size = new Size(62, 15);
        labelCustomerNumber.TabIndex = 0;
        labelCustomerNumber.Text = "Kundennr.";
        // 
        // boxCustomerNumber
        // 
        boxCustomerNumber.Dock = DockStyle.Bottom;
        boxCustomerNumber.Enabled = false;
        boxCustomerNumber.Font = new Font("Segoe UI", 11F);
        boxCustomerNumber.Location = new Point(0, 71);
        boxCustomerNumber.Name = "boxCustomerNumber";
        boxCustomerNumber.Size = new Size(250, 27);
        boxCustomerNumber.TabIndex = 1;
        // 
        // panelStatus
        // 
        panelStatus.Controls.Add(panelStatusLabel);
        panelStatus.Controls.Add(boxStatus);
        panelStatus.Location = new Point(306, 38);
        panelStatus.Name = "panelStatus";
        panelStatus.Size = new Size(250, 98);
        panelStatus.TabIndex = 4;
        // 
        // panelStatusLabel
        // 
        panelStatusLabel.Controls.Add(labelStatus);
        panelStatusLabel.Dock = DockStyle.Top;
        panelStatusLabel.Location = new Point(0, 0);
        panelStatusLabel.Name = "panelStatusLabel";
        panelStatusLabel.Size = new Size(250, 46);
        panelStatusLabel.TabIndex = 0;
        // 
        // labelStatus
        // 
        labelStatus.AutoSize = true;
        labelStatus.Dock = DockStyle.Fill;
        labelStatus.Location = new Point(0, 0);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(39, 15);
        labelStatus.TabIndex = 0;
        labelStatus.Text = "Status";
        // 
        // boxStatus
        // 
        boxStatus.Dock = DockStyle.Bottom;
        boxStatus.FormattingEnabled = true;
        boxStatus.Location = new Point(0, 75);
        boxStatus.Name = "boxStatus";
        boxStatus.Size = new Size(250, 23);
        boxStatus.TabIndex = 1;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(panelSalutation);
        groupBox1.Controls.Add(panelFirstName);
        groupBox1.Controls.Add(panelLastName);
        groupBox1.Controls.Add(panelBirthday);
        groupBox1.Controls.Add(panelSex);
        groupBox1.Controls.Add(panelTitle);
        groupBox1.Controls.Add(panelStreet);
        groupBox1.Controls.Add(panelStreetNumber);
        groupBox1.Controls.Add(panelZipCode);
        groupBox1.Controls.Add(panelCity);
        groupBox1.Controls.Add(panelPhoneNumberCompany);
        groupBox1.Controls.Add(panelPhoneNumberMobile);
        groupBox1.Controls.Add(panelEmail);
        groupBox1.FlatStyle = FlatStyle.Flat;
        groupBox1.Location = new Point(12, 11);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(610, 1078);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Kontaktdaten";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(panelStatus);
        groupBox2.FlatStyle = FlatStyle.Flat;
        groupBox2.Location = new Point(647, 13);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(573, 161);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Kunden-Informationen";
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonCancel);
        panel1.Controls.Add(buttonSave);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 915);
        panel1.Name = "panel1";
        panel1.Size = new Size(1650, 95);
        panel1.TabIndex = 6;
        // 
        // FormCustomerDetail
        // 
        AutoSize = true;
        BackColor = Color.White;
        ClientSize = new Size(1650, 1010);
        Controls.Add(panelCustomerNumber);
        Controls.Add(groupBox1);
        Controls.Add(groupBox2);
        Controls.Add(panel1);
        MaximizeBox = false;
        Name = "FormCustomerDetail";
        panelSalutation.ResumeLayout(false);
        panelSalutationLabel.ResumeLayout(false);
        panelSalutationLabel.PerformLayout();
        panelFirstName.ResumeLayout(false);
        panelFirstName.PerformLayout();
        panelFirstNameLabel.ResumeLayout(false);
        panelFirstNameLabel.PerformLayout();
        panelLastName.ResumeLayout(false);
        panelLastName.PerformLayout();
        panelLastNameLabel.ResumeLayout(false);
        panelLastNameLabel.PerformLayout();
        panelBirthday.ResumeLayout(false);
        panelBirthday.PerformLayout();
        panelBirthdayLabel.ResumeLayout(false);
        panelBirthdayLabel.PerformLayout();
        panelSex.ResumeLayout(false);
        panelSexLabel.ResumeLayout(false);
        panelSexLabel.PerformLayout();
        panelTitle.ResumeLayout(false);
        panelTitleLabel.ResumeLayout(false);
        panelTitleLabel.PerformLayout();
        panelStreet.ResumeLayout(false);
        panelStreet.PerformLayout();
        panelStreetLabel.ResumeLayout(false);
        panelStreetLabel.PerformLayout();
        panelStreetNumber.ResumeLayout(false);
        panelStreetNumber.PerformLayout();
        panelStreetNumberLabel.ResumeLayout(false);
        panelStreetNumberLabel.PerformLayout();
        panelZipCode.ResumeLayout(false);
        panelZipCode.PerformLayout();
        panelZipCodeLabel.ResumeLayout(false);
        panelZipCodeLabel.PerformLayout();
        panelCity.ResumeLayout(false);
        panelCity.PerformLayout();
        panelCityLabel.ResumeLayout(false);
        panelCityLabel.PerformLayout();
        panelPhoneNumberCompany.ResumeLayout(false);
        panelPhoneNumberCompany.PerformLayout();
        panelPhoneNumberCompanyLabel.ResumeLayout(false);
        panelPhoneNumberCompanyLabel.PerformLayout();
        panelPhoneNumberMobile.ResumeLayout(false);
        panelPhoneNumberMobile.PerformLayout();
        panelPhoneNumberMobileLabel.ResumeLayout(false);
        panelPhoneNumberMobileLabel.PerformLayout();
        panelEmail.ResumeLayout(false);
        panelEmail.PerformLayout();
        panelEmailLabel.ResumeLayout(false);
        panelEmailLabel.PerformLayout();
        panelCustomerNumber.ResumeLayout(false);
        panelCustomerNumber.PerformLayout();
        panelCustomerNumberLabel.ResumeLayout(false);
        panelCustomerNumberLabel.PerformLayout();
        panelStatus.ResumeLayout(false);
        panelStatusLabel.ResumeLayout(false);
        panelStatusLabel.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }
    private TextBox boxCity;
    private Button buttonCancel;
    private Button buttonSave;
    private System.Windows.Forms.ComboBox boxSalutation;
    private TextBox boxFirstName;
    private TextBox boxLastName;
    private TextBox boxBirthday;
    private ComboBox boxSex;
    private ComboBox boxTitle;
    private TextBox boxStreet;
    private TextBox boxStreetNumber;
    private TextBox boxZipCode;
    private TextBox boxPhoneNumberCompany;
    private TextBox boxPhoneNumberMobile;
    private TextBox boxEmail;
    private Panel panelSalutation;

    #endregion




    private System.Windows.Forms.Label labelSalutation;
    private Panel panelFirstName;
    private System.Windows.Forms.Label labelFirstName;
    private Panel panelLastName;
    private System.Windows.Forms.Label labelLastName;
    private Panel panelBirthday;
    private System.Windows.Forms.Label labelBirthday;
    private Panel panelSex;
    private System.Windows.Forms.Label labelSex;
    private Panel panelTitle;
    private System.Windows.Forms.Label labelTitle;
    private Panel panelStreet;
    private System.Windows.Forms.Label labelStreet;
    private Panel panelStreetNumber;
    private System.Windows.Forms.Label labelStreetNumber;
    private Panel panelZipCode;
    private System.Windows.Forms.Label labelZipCode;
    private Panel panelCity;
    private System.Windows.Forms.Label labelCity;
    private Panel panelPhoneNumberCompany;
    private System.Windows.Forms.Label labelPhoneNumberCompany;
    private Panel panelPhoneNumberMobile;
    private System.Windows.Forms.Label labelPhoneNumberMobile;
    private Panel panelEmail;
    private System.Windows.Forms.Label labelEmail;
    private Panel panelCustomerNumber;
    private System.Windows.Forms.Label labelCustomerNumber;
    private TextBox boxCustomerNumber;
    private Panel panelStatus;
    private System.Windows.Forms.Label labelStatus;
    private ComboBox boxStatus;
    private GroupBox groupBox1;
    private Panel panelSalutationLabel;
    private Panel panelFirstNameLabel;
    private Panel panelLastNameLabel;
    private Panel panelBirthdayLabel;
    private Panel panelSexLabel;
    private Panel panelTitleLabel;
    private Panel panelStreetLabel;
    private Panel panelStreetNumberLabel;
    private Panel panelZipCodeLabel;
    private Panel panelCityLabel;
    private Panel panelPhoneNumberCompanyLabel;
    private Panel panelPhoneNumberMobileLabel;
    private Panel panelEmailLabel;
    private Panel panelCustomerNumberLabel;
    private Panel panelStatusLabel;
    private GroupBox groupBox2;
    private Panel panel1;
}