using System.Windows.Forms;


namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormAddEmployee : Form
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
        panelEmployeeNumber = new Panel();
        panelEmployeeNumberLabel = new Panel();
        labelEmployeeNumber = new Label();
        boxEmployeeNumber = new TextBox();
        panelDepartment = new Panel();
        panelDepartmentLabel = new Panel();
        labelDepartment = new Label();
        boxDepartment = new TextBox();
        panelAhvNumber = new Panel();
        panelAhvNumberLabel = new Panel();
        labelAhvNumber = new Label();
        boxAhvNumber = new TextBox();
        panelNationality = new Panel();
        panelNationalityLabel = new Panel();
        labelNationality = new Label();
        boxNationality = new TextBox();
        panelEmploymentRate = new Panel();
        panelEmploymentRateLabel = new Panel();
        labelEmploymentRate = new Label();
        boxEmploymentRate = new TextBox();
        panelRole = new Panel();
        panelRoleLabel = new Panel();
        labelRole = new Label();
        boxRole = new TextBox();
        panelApprenticeshipYears = new Panel();
        panelApprenticeshipYearsLabel = new Panel();
        labelApprenticeshipYears = new Label();
        boxApprenticeshipYears = new TextBox();
        panelSeniorLevel = new Panel();
        panelSeniorLevelLabel = new Panel();
        labelSeniorLevel = new Label();
        boxSeniorLevel = new TextBox();
        panelWorkStreet = new Panel();
        panelWorkStreetLabel = new Panel();
        labelWorkStreet = new Label();
        boxWorkStreet = new TextBox();
        panelWorkStreetNumber = new Panel();
        panelWorkStreetNumberLabel = new Panel();
        labelWorkStreetNumber = new Label();
        boxWorkStreetNumber = new TextBox();
        panelWorkZipCode = new Panel();
        panelWorkZipCodeLabel = new Panel();
        labelWorkZipCode = new Label();
        boxWorkZipCode = new TextBox();
        panelWorkCity = new Panel();
        panelWorkCityLabel = new Panel();
        labelWorkCity = new Label();
        boxWorkCity = new TextBox();
        panelDateOfHire = new Panel();
        panelDateOfHireLabel = new Panel();
        labelDateOfHire = new Label();
        boxDateOfHire = new TextBox();
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
        panelEmployeeNumber.SuspendLayout();
        panelEmployeeNumberLabel.SuspendLayout();
        panelDepartment.SuspendLayout();
        panelDepartmentLabel.SuspendLayout();
        panelAhvNumber.SuspendLayout();
        panelAhvNumberLabel.SuspendLayout();
        panelNationality.SuspendLayout();
        panelNationalityLabel.SuspendLayout();
        panelEmploymentRate.SuspendLayout();
        panelEmploymentRateLabel.SuspendLayout();
        panelRole.SuspendLayout();
        panelRoleLabel.SuspendLayout();
        panelApprenticeshipYears.SuspendLayout();
        panelApprenticeshipYearsLabel.SuspendLayout();
        panelSeniorLevel.SuspendLayout();
        panelSeniorLevelLabel.SuspendLayout();
        panelWorkStreet.SuspendLayout();
        panelWorkStreetLabel.SuspendLayout();
        panelWorkStreetNumber.SuspendLayout();
        panelWorkStreetNumberLabel.SuspendLayout();
        panelWorkZipCode.SuspendLayout();
        panelWorkZipCodeLabel.SuspendLayout();
        panelWorkCity.SuspendLayout();
        panelWorkCityLabel.SuspendLayout();
        panelDateOfHire.SuspendLayout();
        panelDateOfHireLabel.SuspendLayout();
        panelStatus.SuspendLayout();
        panelStatusLabel.SuspendLayout();
        groupBox1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // boxSalutation
        // 
        boxSalutation.Dock = DockStyle.Bottom;
        boxSalutation.FormattingEnabled = true;
        boxSalutation.Items.AddRange(new object[] { "Herr", "Frau" });
        boxSalutation.Location = new Point(0, 61);
        boxSalutation.Name = "boxSalutation";
        boxSalutation.Size = new Size(528, 40);
        boxSalutation.TabIndex = 1;
        // 
        // boxFirstName
        // 
        boxFirstName.Dock = DockStyle.Bottom;
        boxFirstName.Location = new Point(0, 59);
        boxFirstName.Name = "boxFirstName";
        boxFirstName.Size = new Size(250, 39);
        boxFirstName.TabIndex = 1;
        // 
        // boxLastName
        // 
        boxLastName.Dock = DockStyle.Bottom;
        boxLastName.Location = new Point(0, 59);
        boxLastName.Name = "boxLastName";
        boxLastName.Size = new Size(250, 39);
        boxLastName.TabIndex = 1;
        // 
        // boxBirthday
        // 
        boxBirthday.BorderStyle = BorderStyle.FixedSingle;
        boxBirthday.Dock = DockStyle.Bottom;
        boxBirthday.Location = new Point(0, 62);
        boxBirthday.Name = "boxBirthday";
        boxBirthday.PlaceholderText = "z.B. 01.02.2003";
        boxBirthday.Size = new Size(250, 39);
        boxBirthday.TabIndex = 1;
        // 
        // boxSex
        // 
        boxSex.Dock = DockStyle.Bottom;
        boxSex.FormattingEnabled = true;
        boxSex.Location = new Point(0, 61);
        boxSex.Name = "boxSex";
        boxSex.Size = new Size(250, 40);
        boxSex.TabIndex = 1;
        // 
        // boxTitle
        // 
        boxTitle.Dock = DockStyle.Bottom;
        boxTitle.FormattingEnabled = true;
        boxTitle.Location = new Point(0, 61);
        boxTitle.Name = "boxTitle";
        boxTitle.Size = new Size(528, 40);
        boxTitle.TabIndex = 1;
        // 
        // boxStreet
        // 
        boxStreet.Dock = DockStyle.Bottom;
        boxStreet.Location = new Point(0, 59);
        boxStreet.Name = "boxStreet";
        boxStreet.Size = new Size(250, 39);
        boxStreet.TabIndex = 1;
        // 
        // boxStreetNumber
        // 
        boxStreetNumber.Dock = DockStyle.Bottom;
        boxStreetNumber.Location = new Point(0, 59);
        boxStreetNumber.Name = "boxStreetNumber";
        boxStreetNumber.PlaceholderText = "11a";
        boxStreetNumber.Size = new Size(250, 39);
        boxStreetNumber.TabIndex = 1;
        // 
        // boxZipCode
        // 
        boxZipCode.Dock = DockStyle.Bottom;
        boxZipCode.Location = new Point(0, 59);
        boxZipCode.Name = "boxZipCode";
        boxZipCode.PlaceholderText = "XXXX";
        boxZipCode.Size = new Size(250, 39);
        boxZipCode.TabIndex = 1;
        // 
        // boxCity
        // 
        boxCity.Dock = DockStyle.Bottom;
        boxCity.Location = new Point(0, 59);
        boxCity.Name = "boxCity";
        boxCity.Size = new Size(250, 39);
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
        boxPhoneNumberCompany.Location = new Point(0, 59);
        boxPhoneNumberCompany.Name = "boxPhoneNumberCompany";
        boxPhoneNumberCompany.PlaceholderText = "0761234567";
        boxPhoneNumberCompany.Size = new Size(528, 39);
        boxPhoneNumberCompany.TabIndex = 1;
        // 
        // boxPhoneNumberMobile
        // 
        boxPhoneNumberMobile.Dock = DockStyle.Bottom;
        boxPhoneNumberMobile.Location = new Point(0, 59);
        boxPhoneNumberMobile.Name = "boxPhoneNumberMobile";
        boxPhoneNumberMobile.PlaceholderText = "0761234567";
        boxPhoneNumberMobile.Size = new Size(528, 39);
        boxPhoneNumberMobile.TabIndex = 1;
        // 
        // boxEmail
        // 
        boxEmail.Dock = DockStyle.Bottom;
        boxEmail.Location = new Point(0, 59);
        boxEmail.Name = "boxEmail";
        boxEmail.PlaceholderText = "maxmustermann@gmail.com";
        boxEmail.Size = new Size(528, 39);
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
        labelSalutation.Size = new Size(91, 32);
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
        labelFirstName.Size = new Size(109, 32);
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
        labelLastName.Size = new Size(129, 32);
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
        labelBirthday.Size = new Size(131, 32);
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
        labelSex.Size = new Size(130, 32);
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
        labelTitle.Size = new Size(60, 32);
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
        labelStreet.Size = new Size(87, 32);
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
        labelStreetNumber.Size = new Size(52, 32);
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
        labelZipCode.Size = new Size(134, 32);
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
        labelCity.Size = new Size(48, 32);
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
        labelPhoneNumberCompany.Size = new Size(148, 32);
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
        labelPhoneNumberMobile.Size = new Size(118, 32);
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
        labelEmail.Size = new Size(82, 32);
        labelEmail.TabIndex = 0;
        labelEmail.Text = "E-Mail";
        // 
        // panelEmployeeNumber
        // 
        panelEmployeeNumber.Controls.Add(panelEmployeeNumberLabel);
        panelEmployeeNumber.Controls.Add(boxEmployeeNumber);
        panelEmployeeNumber.Location = new Point(670, 51);
        panelEmployeeNumber.Name = "panelEmployeeNumber";
        panelEmployeeNumber.Size = new Size(250, 98);
        panelEmployeeNumber.TabIndex = 1;
        // 
        // panelEmployeeNumberLabel
        // 
        panelEmployeeNumberLabel.Controls.Add(labelEmployeeNumber);
        panelEmployeeNumberLabel.Dock = DockStyle.Top;
        panelEmployeeNumberLabel.Location = new Point(0, 0);
        panelEmployeeNumberLabel.Name = "panelEmployeeNumberLabel";
        panelEmployeeNumberLabel.Size = new Size(250, 46);
        panelEmployeeNumberLabel.TabIndex = 0;
        // 
        // labelEmployeeNumber
        // 
        labelEmployeeNumber.AutoSize = true;
        labelEmployeeNumber.Dock = DockStyle.Fill;
        labelEmployeeNumber.Location = new Point(0, 0);
        labelEmployeeNumber.Name = "labelEmployeeNumber";
        labelEmployeeNumber.Size = new Size(159, 32);
        labelEmployeeNumber.TabIndex = 0;
        labelEmployeeNumber.Text = "Mitarbeiternr.";
        // 
        // boxEmployeeNumber
        // 
        boxEmployeeNumber.Dock = DockStyle.Bottom;
        boxEmployeeNumber.Enabled = false;
        boxEmployeeNumber.Location = new Point(0, 59);
        boxEmployeeNumber.Name = "boxEmployeeNumber";
        boxEmployeeNumber.Size = new Size(250, 39);
        boxEmployeeNumber.TabIndex = 1;
        // 
        // panelDepartment
        // 
        panelDepartment.Controls.Add(panelDepartmentLabel);
        panelDepartment.Controls.Add(boxDepartment);
        panelDepartment.Location = new Point(948, 51);
        panelDepartment.Name = "panelDepartment";
        panelDepartment.Size = new Size(250, 98);
        panelDepartment.TabIndex = 2;
        // 
        // panelDepartmentLabel
        // 
        panelDepartmentLabel.Controls.Add(labelDepartment);
        panelDepartmentLabel.Dock = DockStyle.Top;
        panelDepartmentLabel.Location = new Point(0, 0);
        panelDepartmentLabel.Name = "panelDepartmentLabel";
        panelDepartmentLabel.Size = new Size(250, 46);
        panelDepartmentLabel.TabIndex = 0;
        // 
        // labelDepartment
        // 
        labelDepartment.AutoSize = true;
        labelDepartment.Dock = DockStyle.Fill;
        labelDepartment.Location = new Point(0, 0);
        labelDepartment.Name = "labelDepartment";
        labelDepartment.Size = new Size(118, 32);
        labelDepartment.TabIndex = 0;
        labelDepartment.Text = "Abteilung";
        // 
        // boxDepartment
        // 
        boxDepartment.Dock = DockStyle.Bottom;
        boxDepartment.Location = new Point(0, 59);
        boxDepartment.Name = "boxDepartment";
        boxDepartment.Size = new Size(250, 39);
        boxDepartment.TabIndex = 1;
        // 
        // panelAhvNumber
        // 
        panelAhvNumber.Controls.Add(panelAhvNumberLabel);
        panelAhvNumber.Controls.Add(boxAhvNumber);
        panelAhvNumber.Location = new Point(670, 161);
        panelAhvNumber.Name = "panelAhvNumber";
        panelAhvNumber.Size = new Size(250, 98);
        panelAhvNumber.TabIndex = 3;
        // 
        // panelAhvNumberLabel
        // 
        panelAhvNumberLabel.Controls.Add(labelAhvNumber);
        panelAhvNumberLabel.Dock = DockStyle.Top;
        panelAhvNumberLabel.Location = new Point(0, 0);
        panelAhvNumberLabel.Name = "panelAhvNumberLabel";
        panelAhvNumberLabel.Size = new Size(250, 46);
        panelAhvNumberLabel.TabIndex = 0;
        // 
        // labelAhvNumber
        // 
        labelAhvNumber.AutoSize = true;
        labelAhvNumber.Dock = DockStyle.Fill;
        labelAhvNumber.Location = new Point(0, 0);
        labelAhvNumber.Name = "labelAhvNumber";
        labelAhvNumber.Size = new Size(166, 32);
        labelAhvNumber.TabIndex = 0;
        labelAhvNumber.Text = "AHV-Nummer";
        // 
        // boxAhvNumber
        // 
        boxAhvNumber.Dock = DockStyle.Bottom;
        boxAhvNumber.Location = new Point(0, 59);
        boxAhvNumber.Name = "boxAhvNumber";
        boxAhvNumber.PlaceholderText = "756.XXXX.XXXX.XXXX";
        boxAhvNumber.Size = new Size(250, 39);
        boxAhvNumber.TabIndex = 1;
        // 
        // panelNationality
        // 
        panelNationality.Controls.Add(panelNationalityLabel);
        panelNationality.Controls.Add(boxNationality);
        panelNationality.Location = new Point(948, 161);
        panelNationality.Name = "panelNationality";
        panelNationality.Size = new Size(250, 98);
        panelNationality.TabIndex = 4;
        // 
        // panelNationalityLabel
        // 
        panelNationalityLabel.Controls.Add(labelNationality);
        panelNationalityLabel.Dock = DockStyle.Top;
        panelNationalityLabel.Location = new Point(0, 0);
        panelNationalityLabel.Name = "panelNationalityLabel";
        panelNationalityLabel.Size = new Size(250, 46);
        panelNationalityLabel.TabIndex = 0;
        // 
        // labelNationality
        // 
        labelNationality.AutoSize = true;
        labelNationality.Dock = DockStyle.Fill;
        labelNationality.Location = new Point(0, 0);
        labelNationality.Name = "labelNationality";
        labelNationality.Size = new Size(138, 32);
        labelNationality.TabIndex = 0;
        labelNationality.Text = "Nationalität";
        // 
        // boxNationality
        // 
        boxNationality.Dock = DockStyle.Bottom;
        boxNationality.Location = new Point(0, 59);
        boxNationality.Name = "boxNationality";
        boxNationality.Size = new Size(250, 39);
        boxNationality.TabIndex = 1;
        // 
        // panelEmploymentRate
        // 
        panelEmploymentRate.Controls.Add(panelEmploymentRateLabel);
        panelEmploymentRate.Controls.Add(boxEmploymentRate);
        panelEmploymentRate.Location = new Point(670, 271);
        panelEmploymentRate.Name = "panelEmploymentRate";
        panelEmploymentRate.Size = new Size(250, 98);
        panelEmploymentRate.TabIndex = 5;
        // 
        // panelEmploymentRateLabel
        // 
        panelEmploymentRateLabel.Controls.Add(labelEmploymentRate);
        panelEmploymentRateLabel.Dock = DockStyle.Top;
        panelEmploymentRateLabel.Location = new Point(0, 0);
        panelEmploymentRateLabel.Name = "panelEmploymentRateLabel";
        panelEmploymentRateLabel.Size = new Size(250, 46);
        panelEmploymentRateLabel.TabIndex = 0;
        // 
        // labelEmploymentRate
        // 
        labelEmploymentRate.AutoSize = true;
        labelEmploymentRate.Dock = DockStyle.Fill;
        labelEmploymentRate.Location = new Point(0, 0);
        labelEmploymentRate.Name = "labelEmploymentRate";
        labelEmploymentRate.Size = new Size(224, 32);
        labelEmploymentRate.TabIndex = 0;
        labelEmploymentRate.Text = "Beschäftigungsgrad";
        // 
        // boxEmploymentRate
        // 
        boxEmploymentRate.Dock = DockStyle.Bottom;
        boxEmploymentRate.Location = new Point(0, 59);
        boxEmploymentRate.Name = "boxEmploymentRate";
        boxEmploymentRate.Size = new Size(250, 39);
        boxEmploymentRate.TabIndex = 1;
        // 
        // panelRole
        // 
        panelRole.Controls.Add(panelRoleLabel);
        panelRole.Controls.Add(boxRole);
        panelRole.Location = new Point(948, 271);
        panelRole.Name = "panelRole";
        panelRole.Size = new Size(250, 98);
        panelRole.TabIndex = 6;
        // 
        // panelRoleLabel
        // 
        panelRoleLabel.Controls.Add(labelRole);
        panelRoleLabel.Dock = DockStyle.Top;
        panelRoleLabel.Location = new Point(0, 0);
        panelRoleLabel.Name = "panelRoleLabel";
        panelRoleLabel.Size = new Size(250, 46);
        panelRoleLabel.TabIndex = 0;
        // 
        // labelRole
        // 
        labelRole.AutoSize = true;
        labelRole.Dock = DockStyle.Fill;
        labelRole.Location = new Point(0, 0);
        labelRole.Name = "labelRole";
        labelRole.Size = new Size(66, 32);
        labelRole.TabIndex = 0;
        labelRole.Text = "Rolle";
        // 
        // boxRole
        // 
        boxRole.Dock = DockStyle.Bottom;
        boxRole.Location = new Point(0, 59);
        boxRole.Name = "boxRole";
        boxRole.Size = new Size(250, 39);
        boxRole.TabIndex = 1;
        // 
        // panelApprenticeshipYears
        // 
        panelApprenticeshipYears.Controls.Add(panelApprenticeshipYearsLabel);
        panelApprenticeshipYears.Controls.Add(boxApprenticeshipYears);
        panelApprenticeshipYears.Location = new Point(670, 381);
        panelApprenticeshipYears.Name = "panelApprenticeshipYears";
        panelApprenticeshipYears.Size = new Size(250, 98);
        panelApprenticeshipYears.TabIndex = 7;
        // 
        // panelApprenticeshipYearsLabel
        // 
        panelApprenticeshipYearsLabel.Controls.Add(labelApprenticeshipYears);
        panelApprenticeshipYearsLabel.Dock = DockStyle.Top;
        panelApprenticeshipYearsLabel.Location = new Point(0, 0);
        panelApprenticeshipYearsLabel.Name = "panelApprenticeshipYearsLabel";
        panelApprenticeshipYearsLabel.Size = new Size(250, 46);
        panelApprenticeshipYearsLabel.TabIndex = 0;
        // 
        // labelApprenticeshipYears
        // 
        labelApprenticeshipYears.AutoSize = true;
        labelApprenticeshipYears.Dock = DockStyle.Fill;
        labelApprenticeshipYears.Location = new Point(0, 0);
        labelApprenticeshipYears.Name = "labelApprenticeshipYears";
        labelApprenticeshipYears.Size = new Size(163, 32);
        labelApprenticeshipYears.TabIndex = 0;
        labelApprenticeshipYears.Text = "Lehrlingsjahre";
        // 
        // boxApprenticeshipYears
        // 
        boxApprenticeshipYears.Dock = DockStyle.Bottom;
        boxApprenticeshipYears.Location = new Point(0, 59);
        boxApprenticeshipYears.Name = "boxApprenticeshipYears";
        boxApprenticeshipYears.Size = new Size(250, 39);
        boxApprenticeshipYears.TabIndex = 1;
        // 
        // panelSeniorLevel
        // 
        panelSeniorLevel.Controls.Add(panelSeniorLevelLabel);
        panelSeniorLevel.Controls.Add(boxSeniorLevel);
        panelSeniorLevel.Location = new Point(948, 381);
        panelSeniorLevel.Name = "panelSeniorLevel";
        panelSeniorLevel.Size = new Size(250, 98);
        panelSeniorLevel.TabIndex = 8;
        // 
        // panelSeniorLevelLabel
        // 
        panelSeniorLevelLabel.Controls.Add(labelSeniorLevel);
        panelSeniorLevelLabel.Dock = DockStyle.Top;
        panelSeniorLevelLabel.Location = new Point(0, 0);
        panelSeniorLevelLabel.Name = "panelSeniorLevelLabel";
        panelSeniorLevelLabel.Size = new Size(250, 46);
        panelSeniorLevelLabel.TabIndex = 0;
        // 
        // labelSeniorLevel
        // 
        labelSeniorLevel.AutoSize = true;
        labelSeniorLevel.Dock = DockStyle.Fill;
        labelSeniorLevel.Location = new Point(0, 0);
        labelSeniorLevel.Name = "labelSeniorLevel";
        labelSeniorLevel.Size = new Size(159, 32);
        labelSeniorLevel.TabIndex = 0;
        labelSeniorLevel.Text = "Seniorenlevel";
        // 
        // boxSeniorLevel
        // 
        boxSeniorLevel.Dock = DockStyle.Bottom;
        boxSeniorLevel.Location = new Point(0, 59);
        boxSeniorLevel.Name = "boxSeniorLevel";
        boxSeniorLevel.Size = new Size(250, 39);
        boxSeniorLevel.TabIndex = 1;
        // 
        // panelWorkStreet
        // 
        panelWorkStreet.Controls.Add(panelWorkStreetLabel);
        panelWorkStreet.Controls.Add(boxWorkStreet);
        panelWorkStreet.Location = new Point(670, 491);
        panelWorkStreet.Name = "panelWorkStreet";
        panelWorkStreet.Size = new Size(250, 98);
        panelWorkStreet.TabIndex = 9;
        // 
        // panelWorkStreetLabel
        // 
        panelWorkStreetLabel.Controls.Add(labelWorkStreet);
        panelWorkStreetLabel.Dock = DockStyle.Top;
        panelWorkStreetLabel.Location = new Point(0, 0);
        panelWorkStreetLabel.Name = "panelWorkStreetLabel";
        panelWorkStreetLabel.Size = new Size(250, 46);
        panelWorkStreetLabel.TabIndex = 0;
        // 
        // labelWorkStreet
        // 
        labelWorkStreet.AutoSize = true;
        labelWorkStreet.Dock = DockStyle.Fill;
        labelWorkStreet.Location = new Point(0, 0);
        labelWorkStreet.Name = "labelWorkStreet";
        labelWorkStreet.Size = new Size(115, 32);
        labelWorkStreet.TabIndex = 0;
        labelWorkStreet.Text = "Strasse G.";
        // 
        // boxWorkStreet
        // 
        boxWorkStreet.Dock = DockStyle.Bottom;
        boxWorkStreet.Location = new Point(0, 59);
        boxWorkStreet.Name = "boxWorkStreet";
        boxWorkStreet.Size = new Size(250, 39);
        boxWorkStreet.TabIndex = 1;
        // 
        // panelWorkStreetNumber
        // 
        panelWorkStreetNumber.Controls.Add(panelWorkStreetNumberLabel);
        panelWorkStreetNumber.Controls.Add(boxWorkStreetNumber);
        panelWorkStreetNumber.Location = new Point(948, 491);
        panelWorkStreetNumber.Name = "panelWorkStreetNumber";
        panelWorkStreetNumber.Size = new Size(250, 98);
        panelWorkStreetNumber.TabIndex = 10;
        // 
        // panelWorkStreetNumberLabel
        // 
        panelWorkStreetNumberLabel.Controls.Add(labelWorkStreetNumber);
        panelWorkStreetNumberLabel.Dock = DockStyle.Top;
        panelWorkStreetNumberLabel.Location = new Point(0, 0);
        panelWorkStreetNumberLabel.Name = "panelWorkStreetNumberLabel";
        panelWorkStreetNumberLabel.Size = new Size(250, 46);
        panelWorkStreetNumberLabel.TabIndex = 0;
        // 
        // labelWorkStreetNumber
        // 
        labelWorkStreetNumber.AutoSize = true;
        labelWorkStreetNumber.Dock = DockStyle.Fill;
        labelWorkStreetNumber.Location = new Point(0, 0);
        labelWorkStreetNumber.Name = "labelWorkStreetNumber";
        labelWorkStreetNumber.Size = new Size(193, 32);
        labelWorkStreetNumber.TabIndex = 0;
        labelWorkStreetNumber.Text = "Hausnr. Geschäft";
        // 
        // boxWorkStreetNumber
        // 
        boxWorkStreetNumber.Dock = DockStyle.Bottom;
        boxWorkStreetNumber.Location = new Point(0, 59);
        boxWorkStreetNumber.Name = "boxWorkStreetNumber";
        boxWorkStreetNumber.Size = new Size(250, 39);
        boxWorkStreetNumber.TabIndex = 1;
        // 
        // panelWorkZipCode
        // 
        panelWorkZipCode.Controls.Add(panelWorkZipCodeLabel);
        panelWorkZipCode.Controls.Add(boxWorkZipCode);
        panelWorkZipCode.Location = new Point(670, 601);
        panelWorkZipCode.Name = "panelWorkZipCode";
        panelWorkZipCode.Size = new Size(250, 98);
        panelWorkZipCode.TabIndex = 11;
        // 
        // panelWorkZipCodeLabel
        // 
        panelWorkZipCodeLabel.Controls.Add(labelWorkZipCode);
        panelWorkZipCodeLabel.Dock = DockStyle.Top;
        panelWorkZipCodeLabel.Location = new Point(0, 0);
        panelWorkZipCodeLabel.Name = "panelWorkZipCodeLabel";
        panelWorkZipCodeLabel.Size = new Size(250, 46);
        panelWorkZipCodeLabel.TabIndex = 0;
        // 
        // labelWorkZipCode
        // 
        labelWorkZipCode.AutoSize = true;
        labelWorkZipCode.Dock = DockStyle.Fill;
        labelWorkZipCode.Location = new Point(0, 0);
        labelWorkZipCode.Name = "labelWorkZipCode";
        labelWorkZipCode.Size = new Size(233, 32);
        labelWorkZipCode.TabIndex = 0;
        labelWorkZipCode.Text = "Postleitzahl Geschäft";
        // 
        // boxWorkZipCode
        // 
        boxWorkZipCode.Dock = DockStyle.Bottom;
        boxWorkZipCode.Location = new Point(0, 59);
        boxWorkZipCode.Name = "boxWorkZipCode";
        boxWorkZipCode.Size = new Size(250, 39);
        boxWorkZipCode.TabIndex = 1;
        // 
        // panelWorkCity
        // 
        panelWorkCity.Controls.Add(panelWorkCityLabel);
        panelWorkCity.Controls.Add(boxWorkCity);
        panelWorkCity.Location = new Point(948, 601);
        panelWorkCity.Name = "panelWorkCity";
        panelWorkCity.Size = new Size(250, 98);
        panelWorkCity.TabIndex = 12;
        // 
        // panelWorkCityLabel
        // 
        panelWorkCityLabel.Controls.Add(labelWorkCity);
        panelWorkCityLabel.Dock = DockStyle.Top;
        panelWorkCityLabel.Location = new Point(0, 0);
        panelWorkCityLabel.Name = "panelWorkCityLabel";
        panelWorkCityLabel.Size = new Size(250, 46);
        panelWorkCityLabel.TabIndex = 0;
        // 
        // labelWorkCity
        // 
        labelWorkCity.AutoSize = true;
        labelWorkCity.Dock = DockStyle.Fill;
        labelWorkCity.Location = new Point(0, 0);
        labelWorkCity.Name = "labelWorkCity";
        labelWorkCity.Size = new Size(147, 32);
        labelWorkCity.TabIndex = 0;
        labelWorkCity.Text = "Ort Geschäft";
        // 
        // boxWorkCity
        // 
        boxWorkCity.Dock = DockStyle.Bottom;
        boxWorkCity.Location = new Point(0, 59);
        boxWorkCity.Name = "boxWorkCity";
        boxWorkCity.Size = new Size(250, 39);
        boxWorkCity.TabIndex = 1;
        // 
        // panelDateOfHire
        // 
        panelDateOfHire.Controls.Add(panelDateOfHireLabel);
        panelDateOfHire.Controls.Add(boxDateOfHire);
        panelDateOfHire.Location = new Point(670, 711);
        panelDateOfHire.Name = "panelDateOfHire";
        panelDateOfHire.Size = new Size(250, 101);
        panelDateOfHire.TabIndex = 13;
        // 
        // panelDateOfHireLabel
        // 
        panelDateOfHireLabel.Controls.Add(labelDateOfHire);
        panelDateOfHireLabel.Dock = DockStyle.Top;
        panelDateOfHireLabel.Location = new Point(0, 0);
        panelDateOfHireLabel.Name = "panelDateOfHireLabel";
        panelDateOfHireLabel.Size = new Size(250, 46);
        panelDateOfHireLabel.TabIndex = 0;
        // 
        // labelDateOfHire
        // 
        labelDateOfHire.AutoSize = true;
        labelDateOfHire.Dock = DockStyle.Fill;
        labelDateOfHire.Location = new Point(0, 0);
        labelDateOfHire.Name = "labelDateOfHire";
        labelDateOfHire.Size = new Size(164, 32);
        labelDateOfHire.TabIndex = 0;
        labelDateOfHire.Text = "Eingestellt am";
        // 
        // boxDateOfHire
        // 
        boxDateOfHire.Dock = DockStyle.Bottom;
        boxDateOfHire.Location = new Point(0, 62);
        boxDateOfHire.Name = "boxDateOfHire";
        boxDateOfHire.Size = new Size(250, 39);
        boxDateOfHire.TabIndex = 1;
        // 
        // panelStatus
        // 
        panelStatus.Controls.Add(panelStatusLabel);
        panelStatus.Location = new Point(948, 711);
        panelStatus.Name = "panelStatus";
        panelStatus.Size = new Size(250, 101);
        panelStatus.TabIndex = 14;
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
        labelStatus.Size = new Size(78, 32);
        labelStatus.TabIndex = 0;
        labelStatus.Text = "Status";
        // 
        // boxStatus
        // 
        boxStatus.FormattingEnabled = true;
        boxStatus.Location = new Point(948, 771);
        boxStatus.Name = "boxStatus";
        boxStatus.Size = new Size(250, 40);
        boxStatus.TabIndex = 15;
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
        groupBox2.FlatStyle = FlatStyle.Flat;
        groupBox2.Location = new Point(647, 13);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(573, 836);
        groupBox2.TabIndex = 16;
        groupBox2.TabStop = false;
        groupBox2.Text = "Mitarbeiter-Informationen";
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonCancel);
        panel1.Controls.Add(buttonSave);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 1095);
        panel1.Name = "panel1";
        panel1.Size = new Size(1924, 95);
        panel1.TabIndex = 17;
        // 
        // FormAddEmployee
        // 
        AutoSize = true;
        BackColor = Color.White;
        ClientSize = new Size(1924, 1190);
        Controls.Add(boxStatus);
        Controls.Add(panelStatus);
        Controls.Add(panelDateOfHire);
        Controls.Add(panelWorkCity);
        Controls.Add(panelWorkZipCode);
        Controls.Add(panelWorkStreetNumber);
        Controls.Add(panelWorkStreet);
        Controls.Add(panelSeniorLevel);
        Controls.Add(panelApprenticeshipYears);
        Controls.Add(panelRole);
        Controls.Add(panelEmploymentRate);
        Controls.Add(panelNationality);
        Controls.Add(panelAhvNumber);
        Controls.Add(panelDepartment);
        Controls.Add(panelEmployeeNumber);
        Controls.Add(groupBox1);
        Controls.Add(groupBox2);
        Controls.Add(panel1);
        MaximizeBox = false;
        Name = "FormAddEmployee";
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
        panelEmployeeNumber.ResumeLayout(false);
        panelEmployeeNumber.PerformLayout();
        panelEmployeeNumberLabel.ResumeLayout(false);
        panelEmployeeNumberLabel.PerformLayout();
        panelDepartment.ResumeLayout(false);
        panelDepartment.PerformLayout();
        panelDepartmentLabel.ResumeLayout(false);
        panelDepartmentLabel.PerformLayout();
        panelAhvNumber.ResumeLayout(false);
        panelAhvNumber.PerformLayout();
        panelAhvNumberLabel.ResumeLayout(false);
        panelAhvNumberLabel.PerformLayout();
        panelNationality.ResumeLayout(false);
        panelNationality.PerformLayout();
        panelNationalityLabel.ResumeLayout(false);
        panelNationalityLabel.PerformLayout();
        panelEmploymentRate.ResumeLayout(false);
        panelEmploymentRate.PerformLayout();
        panelEmploymentRateLabel.ResumeLayout(false);
        panelEmploymentRateLabel.PerformLayout();
        panelRole.ResumeLayout(false);
        panelRole.PerformLayout();
        panelRoleLabel.ResumeLayout(false);
        panelRoleLabel.PerformLayout();
        panelApprenticeshipYears.ResumeLayout(false);
        panelApprenticeshipYears.PerformLayout();
        panelApprenticeshipYearsLabel.ResumeLayout(false);
        panelApprenticeshipYearsLabel.PerformLayout();
        panelSeniorLevel.ResumeLayout(false);
        panelSeniorLevel.PerformLayout();
        panelSeniorLevelLabel.ResumeLayout(false);
        panelSeniorLevelLabel.PerformLayout();
        panelWorkStreet.ResumeLayout(false);
        panelWorkStreet.PerformLayout();
        panelWorkStreetLabel.ResumeLayout(false);
        panelWorkStreetLabel.PerformLayout();
        panelWorkStreetNumber.ResumeLayout(false);
        panelWorkStreetNumber.PerformLayout();
        panelWorkStreetNumberLabel.ResumeLayout(false);
        panelWorkStreetNumberLabel.PerformLayout();
        panelWorkZipCode.ResumeLayout(false);
        panelWorkZipCode.PerformLayout();
        panelWorkZipCodeLabel.ResumeLayout(false);
        panelWorkZipCodeLabel.PerformLayout();
        panelWorkCity.ResumeLayout(false);
        panelWorkCity.PerformLayout();
        panelWorkCityLabel.ResumeLayout(false);
        panelWorkCityLabel.PerformLayout();
        panelDateOfHire.ResumeLayout(false);
        panelDateOfHire.PerformLayout();
        panelDateOfHireLabel.ResumeLayout(false);
        panelDateOfHireLabel.PerformLayout();
        panelStatus.ResumeLayout(false);
        panelStatusLabel.ResumeLayout(false);
        panelStatusLabel.PerformLayout();
        groupBox1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);

    }
    private TextBox boxCity;
    private Button buttonCancel;
    private Button buttonSave;
    private ComboBox boxSalutation;
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




    private Label labelSalutation;
    private Panel panelFirstName;
    private Label labelFirstName;
    private Panel panelLastName;
    private Label labelLastName;
    private Panel panelBirthday;
    private Label labelBirthday;
    private Panel panelSex;
    private Label labelSex;
    private Panel panelTitle;
    private Label labelTitle;
    private Panel panelStreet;
    private Label labelStreet;
    private Panel panelStreetNumber;
    private Label labelStreetNumber;
    private Panel panelZipCode;
    private Label labelZipCode;
    private Panel panelCity;
    private Label labelCity;
    private Panel panelPhoneNumberCompany;
    private Label labelPhoneNumberCompany;
    private Panel panelPhoneNumberMobile;
    private Label labelPhoneNumberMobile;
    private Panel panelEmail;
    private Label labelEmail;
    private Panel panelEmployeeNumber;
    private Label labelEmployeeNumber;
    private TextBox boxEmployeeNumber;
    private Panel panelDepartment;
    private Label labelDepartment;
    private TextBox boxDepartment;
    private Panel panelAhvNumber;
    private Label labelAhvNumber;
    private TextBox boxAhvNumber;
    private Panel panelNationality;
    private Label labelNationality;
    private TextBox boxNationality;
    private Panel panelEmploymentRate;
    private Label labelEmploymentRate;
    private TextBox boxEmploymentRate;
    private Panel panelRole;
    private Label labelRole;
    private TextBox boxRole;
    private Panel panelApprenticeshipYears;
    private Label labelApprenticeshipYears;
    private TextBox boxApprenticeshipYears;
    private Panel panelSeniorLevel;
    private Label labelSeniorLevel;
    private TextBox boxSeniorLevel;
    private Panel panelWorkStreet;
    private Label labelWorkStreet;
    private TextBox boxWorkStreet;
    private Panel panelWorkStreetNumber;
    private Label labelWorkStreetNumber;
    private TextBox boxWorkStreetNumber;
    private Panel panelWorkZipCode;
    private Label labelWorkZipCode;
    private TextBox boxWorkZipCode;
    private Panel panelWorkCity;
    private Label labelWorkCity;
    private TextBox boxWorkCity;
    private Panel panelDateOfHire;
    private Label labelDateOfHire;
    private TextBox boxDateOfHire;
    private Panel panelStatus;
    private Label labelStatus;
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
    private Panel panelEmployeeNumberLabel;
    private Panel panelDepartmentLabel;
    private Panel panelAhvNumberLabel;
    private Panel panelNationalityLabel;
    private Panel panelEmploymentRateLabel;
    private Panel panelRoleLabel;
    private Panel panelApprenticeshipYearsLabel;
    private Panel panelSeniorLevelLabel;
    private Panel panelWorkStreetLabel;
    private Panel panelWorkStreetNumberLabel;
    private Panel panelWorkZipCodeLabel;
    private Panel panelWorkCityLabel;
    private Panel panelDateOfHireLabel;
    private Panel panelStatusLabel;
    private GroupBox groupBox2;
    private Panel panel1;
}
