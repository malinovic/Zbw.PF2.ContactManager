using System.Windows.Forms;


namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormEmployeeDetail : Form
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
        boxSalutation = new System.Windows.Forms.ComboBox();
        boxFirstName = new System.Windows.Forms.TextBox();
        boxLastName = new System.Windows.Forms.TextBox();
        boxBirthday = new System.Windows.Forms.TextBox();
        boxSex = new System.Windows.Forms.ComboBox();
        boxTitle = new System.Windows.Forms.ComboBox();
        boxStreet = new System.Windows.Forms.TextBox();
        boxStreetNumber = new System.Windows.Forms.TextBox();
        boxZipCode = new System.Windows.Forms.TextBox();
        boxCity = new System.Windows.Forms.TextBox();
        buttonCancel = new System.Windows.Forms.Button();
        buttonSave = new System.Windows.Forms.Button();
        boxPhoneNumberCompany = new System.Windows.Forms.TextBox();
        boxPhoneNumberMobile = new System.Windows.Forms.TextBox();
        boxEmail = new System.Windows.Forms.TextBox();
        panelSalutation = new System.Windows.Forms.Panel();
        panelSalutationLabel = new System.Windows.Forms.Panel();
        labelSalutation = new System.Windows.Forms.Label();
        panelFirstName = new System.Windows.Forms.Panel();
        panelFirstNameLabel = new System.Windows.Forms.Panel();
        labelFirstName = new System.Windows.Forms.Label();
        panelLastName = new System.Windows.Forms.Panel();
        panelLastNameLabel = new System.Windows.Forms.Panel();
        labelLastName = new System.Windows.Forms.Label();
        panelBirthday = new System.Windows.Forms.Panel();
        panelBirthdayLabel = new System.Windows.Forms.Panel();
        labelBirthday = new System.Windows.Forms.Label();
        panelSex = new System.Windows.Forms.Panel();
        panelSexLabel = new System.Windows.Forms.Panel();
        labelSex = new System.Windows.Forms.Label();
        panelTitle = new System.Windows.Forms.Panel();
        panelTitleLabel = new System.Windows.Forms.Panel();
        labelTitle = new System.Windows.Forms.Label();
        panelStreet = new System.Windows.Forms.Panel();
        panelStreetLabel = new System.Windows.Forms.Panel();
        labelStreet = new System.Windows.Forms.Label();
        panelStreetNumber = new System.Windows.Forms.Panel();
        panelStreetNumberLabel = new System.Windows.Forms.Panel();
        labelStreetNumber = new System.Windows.Forms.Label();
        panelZipCode = new System.Windows.Forms.Panel();
        panelZipCodeLabel = new System.Windows.Forms.Panel();
        labelZipCode = new System.Windows.Forms.Label();
        panelCity = new System.Windows.Forms.Panel();
        panelCityLabel = new System.Windows.Forms.Panel();
        labelCity = new System.Windows.Forms.Label();
        panelPhoneNumberCompany = new System.Windows.Forms.Panel();
        panelPhoneNumberCompanyLabel = new System.Windows.Forms.Panel();
        labelPhoneNumberCompany = new System.Windows.Forms.Label();
        panelPhoneNumberMobile = new System.Windows.Forms.Panel();
        panelPhoneNumberMobileLabel = new System.Windows.Forms.Panel();
        labelPhoneNumberMobile = new System.Windows.Forms.Label();
        panelEmail = new System.Windows.Forms.Panel();
        panelEmailLabel = new System.Windows.Forms.Panel();
        labelEmail = new System.Windows.Forms.Label();
        panelEmployeeNumber = new System.Windows.Forms.Panel();
        panelEmployeeNumberLabel = new System.Windows.Forms.Panel();
        labelEmployeeNumber = new System.Windows.Forms.Label();
        boxEmployeeNumber = new System.Windows.Forms.TextBox();
        panelDepartment = new System.Windows.Forms.Panel();
        panelDepartmentLabel = new System.Windows.Forms.Panel();
        labelDepartment = new System.Windows.Forms.Label();
        boxDepartment = new System.Windows.Forms.TextBox();
        panelAhvNumber = new System.Windows.Forms.Panel();
        panelAhvNumberLabel = new System.Windows.Forms.Panel();
        labelAhvNumber = new System.Windows.Forms.Label();
        boxAhvNumber = new System.Windows.Forms.TextBox();
        panelNationality = new System.Windows.Forms.Panel();
        panelNationalityLabel = new System.Windows.Forms.Panel();
        labelNationality = new System.Windows.Forms.Label();
        boxNationality = new System.Windows.Forms.TextBox();
        panelEmploymentRate = new System.Windows.Forms.Panel();
        panelEmploymentRateLabel = new System.Windows.Forms.Panel();
        labelEmploymentRate = new System.Windows.Forms.Label();
        boxEmploymentRate = new System.Windows.Forms.TextBox();
        panelRole = new System.Windows.Forms.Panel();
        panelRoleLabel = new System.Windows.Forms.Panel();
        labelRole = new System.Windows.Forms.Label();
        boxRole = new System.Windows.Forms.TextBox();
        panelApprenticeshipYears = new System.Windows.Forms.Panel();
        panelApprenticeshipYearsLabel = new System.Windows.Forms.Panel();
        labelApprenticeshipYears = new System.Windows.Forms.Label();
        boxApprenticeshipYears = new System.Windows.Forms.TextBox();
        panelSeniorLevel = new System.Windows.Forms.Panel();
        panelSeniorLevelLabel = new System.Windows.Forms.Panel();
        labelSeniorLevel = new System.Windows.Forms.Label();
        boxSeniorLevel = new System.Windows.Forms.TextBox();
        panelWorkStreet = new System.Windows.Forms.Panel();
        panelWorkStreetLabel = new System.Windows.Forms.Panel();
        labelWorkStreet = new System.Windows.Forms.Label();
        boxWorkStreet = new System.Windows.Forms.TextBox();
        panelWorkStreetNumber = new System.Windows.Forms.Panel();
        panelWorkStreetNumberLabel = new System.Windows.Forms.Panel();
        labelWorkStreetNumber = new System.Windows.Forms.Label();
        boxWorkStreetNumber = new System.Windows.Forms.TextBox();
        panelWorkZipCode = new System.Windows.Forms.Panel();
        panelWorkZipCodeLabel = new System.Windows.Forms.Panel();
        labelWorkZipCode = new System.Windows.Forms.Label();
        boxWorkZipCode = new System.Windows.Forms.TextBox();
        panelWorkCity = new System.Windows.Forms.Panel();
        panelWorkCityLabel = new System.Windows.Forms.Panel();
        labelWorkCity = new System.Windows.Forms.Label();
        boxWorkCity = new System.Windows.Forms.TextBox();
        panelDateOfHire = new System.Windows.Forms.Panel();
        panelDateOfHireLabel = new System.Windows.Forms.Panel();
        labelDateOfHire = new System.Windows.Forms.Label();
        boxDateOfHire = new System.Windows.Forms.TextBox();
        panelStatus = new System.Windows.Forms.Panel();
        panelStatusLabel = new System.Windows.Forms.Panel();
        labelStatus = new System.Windows.Forms.Label();
        boxStatus = new System.Windows.Forms.ComboBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        panel1 = new System.Windows.Forms.Panel();
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
        boxSalutation.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        boxSalutation.FormattingEnabled = true;
        boxSalutation.Items.AddRange(new object[] { "Herr", "Frau" });
        boxSalutation.Location = new System.Drawing.Point(0, 63);
        boxSalutation.Name = "boxSalutation";
        boxSalutation.Size = new System.Drawing.Size(528, 38);
        boxSalutation.TabIndex = 1;
        // 
        // boxFirstName
        // 
        boxFirstName.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxFirstName.Location = new System.Drawing.Point(0, 63);
        boxFirstName.Name = "boxFirstName";
        boxFirstName.Size = new System.Drawing.Size(250, 35);
        boxFirstName.TabIndex = 1;
        // 
        // boxLastName
        // 
        boxLastName.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxLastName.Location = new System.Drawing.Point(0, 63);
        boxLastName.Name = "boxLastName";
        boxLastName.Size = new System.Drawing.Size(250, 35);
        boxLastName.TabIndex = 1;
        // 
        // boxBirthday
        // 
        boxBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        boxBirthday.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxBirthday.Location = new System.Drawing.Point(0, 66);
        boxBirthday.Name = "boxBirthday";
        boxBirthday.PlaceholderText = "dd.MM.yyyy";
        boxBirthday.Size = new System.Drawing.Size(250, 35);
        boxBirthday.TabIndex = 1;
        // 
        // boxSex
        // 
        boxSex.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxSex.FormattingEnabled = true;
        boxSex.Location = new System.Drawing.Point(0, 63);
        boxSex.Name = "boxSex";
        boxSex.Size = new System.Drawing.Size(250, 38);
        boxSex.TabIndex = 1;
        // 
        // boxTitle
        // 
        boxTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxTitle.FormattingEnabled = true;
        boxTitle.Location = new System.Drawing.Point(0, 63);
        boxTitle.Name = "boxTitle";
        boxTitle.Size = new System.Drawing.Size(528, 38);
        boxTitle.TabIndex = 1;
        // 
        // boxStreet
        // 
        boxStreet.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxStreet.Location = new System.Drawing.Point(0, 63);
        boxStreet.Name = "boxStreet";
        boxStreet.Size = new System.Drawing.Size(250, 35);
        boxStreet.TabIndex = 1;
        // 
        // boxStreetNumber
        // 
        boxStreetNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxStreetNumber.Location = new System.Drawing.Point(0, 63);
        boxStreetNumber.Name = "boxStreetNumber";
        boxStreetNumber.PlaceholderText = "11a";
        boxStreetNumber.Size = new System.Drawing.Size(250, 35);
        boxStreetNumber.TabIndex = 1;
        // 
        // boxZipCode
        // 
        boxZipCode.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxZipCode.Location = new System.Drawing.Point(0, 63);
        boxZipCode.Name = "boxZipCode";
        boxZipCode.PlaceholderText = "XXXX";
        boxZipCode.Size = new System.Drawing.Size(250, 35);
        boxZipCode.TabIndex = 1;
        // 
        // boxCity
        // 
        boxCity.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxCity.Location = new System.Drawing.Point(0, 63);
        boxCity.Name = "boxCity";
        boxCity.Size = new System.Drawing.Size(250, 35);
        boxCity.TabIndex = 1;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new System.Drawing.Point(1455, 22);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new System.Drawing.Size(221, 57);
        buttonCancel.TabIndex = 0;
        buttonCancel.Text = "Abbrechen";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += buttonCancel_Click;
        // 
        // buttonSave
        // 
        buttonSave.Location = new System.Drawing.Point(1692, 22);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new System.Drawing.Size(220, 57);
        buttonSave.TabIndex = 1;
        buttonSave.Text = "Speichern";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // boxPhoneNumberCompany
        // 
        boxPhoneNumberCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxPhoneNumberCompany.Location = new System.Drawing.Point(0, 63);
        boxPhoneNumberCompany.Name = "boxPhoneNumberCompany";
        boxPhoneNumberCompany.PlaceholderText = "0761234567";
        boxPhoneNumberCompany.Size = new System.Drawing.Size(528, 35);
        boxPhoneNumberCompany.TabIndex = 1;
        // 
        // boxPhoneNumberMobile
        // 
        boxPhoneNumberMobile.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxPhoneNumberMobile.Location = new System.Drawing.Point(0, 63);
        boxPhoneNumberMobile.Name = "boxPhoneNumberMobile";
        boxPhoneNumberMobile.PlaceholderText = "0761234567";
        boxPhoneNumberMobile.Size = new System.Drawing.Size(528, 35);
        boxPhoneNumberMobile.TabIndex = 1;
        // 
        // boxEmail
        // 
        boxEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxEmail.Location = new System.Drawing.Point(0, 63);
        boxEmail.Name = "boxEmail";
        boxEmail.PlaceholderText = "maxmustermann@gmail.com";
        boxEmail.Size = new System.Drawing.Size(528, 35);
        boxEmail.TabIndex = 1;
        // 
        // panelSalutation
        // 
        panelSalutation.Controls.Add(panelSalutationLabel);
        panelSalutation.Controls.Add(boxSalutation);
        panelSalutation.Location = new System.Drawing.Point(41, 44);
        panelSalutation.Name = "panelSalutation";
        panelSalutation.Size = new System.Drawing.Size(528, 101);
        panelSalutation.TabIndex = 0;
        // 
        // panelSalutationLabel
        // 
        panelSalutationLabel.Controls.Add(labelSalutation);
        panelSalutationLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelSalutationLabel.Location = new System.Drawing.Point(0, 0);
        panelSalutationLabel.Name = "panelSalutationLabel";
        panelSalutationLabel.Size = new System.Drawing.Size(528, 46);
        panelSalutationLabel.TabIndex = 0;
        // 
        // labelSalutation
        // 
        labelSalutation.AutoSize = true;
        labelSalutation.Dock = System.Windows.Forms.DockStyle.Fill;
        labelSalutation.Location = new System.Drawing.Point(0, 0);
        labelSalutation.Name = "labelSalutation";
        labelSalutation.Size = new System.Drawing.Size(80, 30);
        labelSalutation.TabIndex = 0;
        labelSalutation.Text = "Anrede";
        // 
        // panelFirstName
        // 
        panelFirstName.Controls.Add(panelFirstNameLabel);
        panelFirstName.Controls.Add(boxFirstName);
        panelFirstName.Location = new System.Drawing.Point(41, 148);
        panelFirstName.Name = "panelFirstName";
        panelFirstName.Size = new System.Drawing.Size(250, 98);
        panelFirstName.TabIndex = 1;
        // 
        // panelFirstNameLabel
        // 
        panelFirstNameLabel.Controls.Add(labelFirstName);
        panelFirstNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelFirstNameLabel.Location = new System.Drawing.Point(0, 0);
        panelFirstNameLabel.Name = "panelFirstNameLabel";
        panelFirstNameLabel.Size = new System.Drawing.Size(250, 46);
        panelFirstNameLabel.TabIndex = 0;
        // 
        // labelFirstName
        // 
        labelFirstName.AutoSize = true;
        labelFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
        labelFirstName.Location = new System.Drawing.Point(0, 0);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new System.Drawing.Size(96, 30);
        labelFirstName.TabIndex = 0;
        labelFirstName.Text = "Vorname";
        // 
        // panelLastName
        // 
        panelLastName.Controls.Add(panelLastNameLabel);
        panelLastName.Controls.Add(boxLastName);
        panelLastName.Location = new System.Drawing.Point(319, 148);
        panelLastName.Name = "panelLastName";
        panelLastName.Size = new System.Drawing.Size(250, 98);
        panelLastName.TabIndex = 2;
        // 
        // panelLastNameLabel
        // 
        panelLastNameLabel.Controls.Add(labelLastName);
        panelLastNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelLastNameLabel.Location = new System.Drawing.Point(0, 0);
        panelLastNameLabel.Name = "panelLastNameLabel";
        panelLastNameLabel.Size = new System.Drawing.Size(250, 46);
        panelLastNameLabel.TabIndex = 0;
        // 
        // labelLastName
        // 
        labelLastName.AutoSize = true;
        labelLastName.Dock = System.Windows.Forms.DockStyle.Fill;
        labelLastName.Location = new System.Drawing.Point(0, 0);
        labelLastName.Name = "labelLastName";
        labelLastName.Size = new System.Drawing.Size(114, 30);
        labelLastName.TabIndex = 0;
        labelLastName.Text = "Nachname";
        // 
        // panelBirthday
        // 
        panelBirthday.Controls.Add(panelBirthdayLabel);
        panelBirthday.Controls.Add(boxBirthday);
        panelBirthday.Location = new System.Drawing.Point(41, 258);
        panelBirthday.Name = "panelBirthday";
        panelBirthday.Size = new System.Drawing.Size(250, 101);
        panelBirthday.TabIndex = 3;
        // 
        // panelBirthdayLabel
        // 
        panelBirthdayLabel.Controls.Add(labelBirthday);
        panelBirthdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelBirthdayLabel.Location = new System.Drawing.Point(0, 0);
        panelBirthdayLabel.Name = "panelBirthdayLabel";
        panelBirthdayLabel.Size = new System.Drawing.Size(250, 46);
        panelBirthdayLabel.TabIndex = 0;
        // 
        // labelBirthday
        // 
        labelBirthday.AutoSize = true;
        labelBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
        labelBirthday.Location = new System.Drawing.Point(0, 0);
        labelBirthday.Name = "labelBirthday";
        labelBirthday.Size = new System.Drawing.Size(115, 30);
        labelBirthday.TabIndex = 0;
        labelBirthday.Text = "Geburtstag";
        // 
        // panelSex
        // 
        panelSex.Controls.Add(panelSexLabel);
        panelSex.Controls.Add(boxSex);
        panelSex.Location = new System.Drawing.Point(319, 258);
        panelSex.Name = "panelSex";
        panelSex.Size = new System.Drawing.Size(250, 101);
        panelSex.TabIndex = 4;
        // 
        // panelSexLabel
        // 
        panelSexLabel.Controls.Add(labelSex);
        panelSexLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelSexLabel.Location = new System.Drawing.Point(0, 0);
        panelSexLabel.Name = "panelSexLabel";
        panelSexLabel.Size = new System.Drawing.Size(250, 46);
        panelSexLabel.TabIndex = 0;
        // 
        // labelSex
        // 
        labelSex.AutoSize = true;
        labelSex.Dock = System.Windows.Forms.DockStyle.Fill;
        labelSex.Location = new System.Drawing.Point(0, 0);
        labelSex.Name = "labelSex";
        labelSex.Size = new System.Drawing.Size(114, 30);
        labelSex.TabIndex = 0;
        labelSex.Text = "Geschlecht";
        // 
        // panelTitle
        // 
        panelTitle.Controls.Add(panelTitleLabel);
        panelTitle.Controls.Add(boxTitle);
        panelTitle.Location = new System.Drawing.Point(41, 371);
        panelTitle.Name = "panelTitle";
        panelTitle.Size = new System.Drawing.Size(528, 101);
        panelTitle.TabIndex = 5;
        // 
        // panelTitleLabel
        // 
        panelTitleLabel.Controls.Add(labelTitle);
        panelTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelTitleLabel.Location = new System.Drawing.Point(0, 0);
        panelTitleLabel.Name = "panelTitleLabel";
        panelTitleLabel.Size = new System.Drawing.Size(528, 46);
        panelTitleLabel.TabIndex = 0;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        labelTitle.Location = new System.Drawing.Point(0, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new System.Drawing.Size(52, 30);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Titel";
        // 
        // panelStreet
        // 
        panelStreet.Controls.Add(panelStreetLabel);
        panelStreet.Controls.Add(boxStreet);
        panelStreet.Location = new System.Drawing.Point(41, 484);
        panelStreet.Name = "panelStreet";
        panelStreet.Size = new System.Drawing.Size(250, 98);
        panelStreet.TabIndex = 6;
        // 
        // panelStreetLabel
        // 
        panelStreetLabel.Controls.Add(labelStreet);
        panelStreetLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelStreetLabel.Location = new System.Drawing.Point(0, 0);
        panelStreetLabel.Name = "panelStreetLabel";
        panelStreetLabel.Size = new System.Drawing.Size(250, 46);
        panelStreetLabel.TabIndex = 0;
        // 
        // labelStreet
        // 
        labelStreet.AutoSize = true;
        labelStreet.Dock = System.Windows.Forms.DockStyle.Fill;
        labelStreet.Location = new System.Drawing.Point(0, 0);
        labelStreet.Name = "labelStreet";
        labelStreet.Size = new System.Drawing.Size(77, 30);
        labelStreet.TabIndex = 0;
        labelStreet.Text = "Strasse";
        // 
        // panelStreetNumber
        // 
        panelStreetNumber.Controls.Add(panelStreetNumberLabel);
        panelStreetNumber.Controls.Add(boxStreetNumber);
        panelStreetNumber.Location = new System.Drawing.Point(319, 484);
        panelStreetNumber.Name = "panelStreetNumber";
        panelStreetNumber.Size = new System.Drawing.Size(250, 98);
        panelStreetNumber.TabIndex = 7;
        // 
        // panelStreetNumberLabel
        // 
        panelStreetNumberLabel.Controls.Add(labelStreetNumber);
        panelStreetNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelStreetNumberLabel.Location = new System.Drawing.Point(0, 0);
        panelStreetNumberLabel.Name = "panelStreetNumberLabel";
        panelStreetNumberLabel.Size = new System.Drawing.Size(250, 46);
        panelStreetNumberLabel.TabIndex = 0;
        // 
        // labelStreetNumber
        // 
        labelStreetNumber.AutoSize = true;
        labelStreetNumber.Dock = System.Windows.Forms.DockStyle.Fill;
        labelStreetNumber.Location = new System.Drawing.Point(0, 0);
        labelStreetNumber.Name = "labelStreetNumber";
        labelStreetNumber.Size = new System.Drawing.Size(47, 30);
        labelStreetNumber.TabIndex = 0;
        labelStreetNumber.Text = "Nr. ";
        // 
        // panelZipCode
        // 
        panelZipCode.Controls.Add(panelZipCodeLabel);
        panelZipCode.Controls.Add(boxZipCode);
        panelZipCode.Location = new System.Drawing.Point(41, 594);
        panelZipCode.Name = "panelZipCode";
        panelZipCode.Size = new System.Drawing.Size(250, 98);
        panelZipCode.TabIndex = 8;
        // 
        // panelZipCodeLabel
        // 
        panelZipCodeLabel.Controls.Add(labelZipCode);
        panelZipCodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelZipCodeLabel.Location = new System.Drawing.Point(0, 0);
        panelZipCodeLabel.Name = "panelZipCodeLabel";
        panelZipCodeLabel.Size = new System.Drawing.Size(250, 46);
        panelZipCodeLabel.TabIndex = 0;
        // 
        // labelZipCode
        // 
        labelZipCode.AutoSize = true;
        labelZipCode.Dock = System.Windows.Forms.DockStyle.Fill;
        labelZipCode.Location = new System.Drawing.Point(0, 0);
        labelZipCode.Name = "labelZipCode";
        labelZipCode.Size = new System.Drawing.Size(118, 30);
        labelZipCode.TabIndex = 0;
        labelZipCode.Text = "Postleitzahl";
        // 
        // panelCity
        // 
        panelCity.Controls.Add(panelCityLabel);
        panelCity.Controls.Add(boxCity);
        panelCity.Location = new System.Drawing.Point(319, 594);
        panelCity.Name = "panelCity";
        panelCity.Size = new System.Drawing.Size(250, 98);
        panelCity.TabIndex = 9;
        // 
        // panelCityLabel
        // 
        panelCityLabel.Controls.Add(labelCity);
        panelCityLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelCityLabel.Location = new System.Drawing.Point(0, 0);
        panelCityLabel.Name = "panelCityLabel";
        panelCityLabel.Size = new System.Drawing.Size(250, 46);
        panelCityLabel.TabIndex = 0;
        // 
        // labelCity
        // 
        labelCity.AutoSize = true;
        labelCity.Dock = System.Windows.Forms.DockStyle.Fill;
        labelCity.Location = new System.Drawing.Point(0, 0);
        labelCity.Name = "labelCity";
        labelCity.Size = new System.Drawing.Size(43, 30);
        labelCity.TabIndex = 0;
        labelCity.Text = "Ort";
        // 
        // panelPhoneNumberCompany
        // 
        panelPhoneNumberCompany.Controls.Add(panelPhoneNumberCompanyLabel);
        panelPhoneNumberCompany.Controls.Add(boxPhoneNumberCompany);
        panelPhoneNumberCompany.Location = new System.Drawing.Point(41, 704);
        panelPhoneNumberCompany.Name = "panelPhoneNumberCompany";
        panelPhoneNumberCompany.Size = new System.Drawing.Size(528, 98);
        panelPhoneNumberCompany.TabIndex = 10;
        // 
        // panelPhoneNumberCompanyLabel
        // 
        panelPhoneNumberCompanyLabel.Controls.Add(labelPhoneNumberCompany);
        panelPhoneNumberCompanyLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelPhoneNumberCompanyLabel.Location = new System.Drawing.Point(0, 0);
        panelPhoneNumberCompanyLabel.Name = "panelPhoneNumberCompanyLabel";
        panelPhoneNumberCompanyLabel.Size = new System.Drawing.Size(528, 46);
        panelPhoneNumberCompanyLabel.TabIndex = 0;
        // 
        // labelPhoneNumberCompany
        // 
        labelPhoneNumberCompany.AutoSize = true;
        labelPhoneNumberCompany.Dock = System.Windows.Forms.DockStyle.Fill;
        labelPhoneNumberCompany.Location = new System.Drawing.Point(0, 0);
        labelPhoneNumberCompany.Name = "labelPhoneNumberCompany";
        labelPhoneNumberCompany.Size = new System.Drawing.Size(130, 30);
        labelPhoneNumberCompany.TabIndex = 0;
        labelPhoneNumberCompany.Text = "Tel. Geschäft";
        // 
        // panelPhoneNumberMobile
        // 
        panelPhoneNumberMobile.Controls.Add(panelPhoneNumberMobileLabel);
        panelPhoneNumberMobile.Controls.Add(boxPhoneNumberMobile);
        panelPhoneNumberMobile.Location = new System.Drawing.Point(41, 814);
        panelPhoneNumberMobile.Name = "panelPhoneNumberMobile";
        panelPhoneNumberMobile.Size = new System.Drawing.Size(528, 98);
        panelPhoneNumberMobile.TabIndex = 11;
        // 
        // panelPhoneNumberMobileLabel
        // 
        panelPhoneNumberMobileLabel.Controls.Add(labelPhoneNumberMobile);
        panelPhoneNumberMobileLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelPhoneNumberMobileLabel.Location = new System.Drawing.Point(0, 0);
        panelPhoneNumberMobileLabel.Name = "panelPhoneNumberMobileLabel";
        panelPhoneNumberMobileLabel.Size = new System.Drawing.Size(528, 46);
        panelPhoneNumberMobileLabel.TabIndex = 0;
        // 
        // labelPhoneNumberMobile
        // 
        labelPhoneNumberMobile.AutoSize = true;
        labelPhoneNumberMobile.Dock = System.Windows.Forms.DockStyle.Fill;
        labelPhoneNumberMobile.Location = new System.Drawing.Point(0, 0);
        labelPhoneNumberMobile.Name = "labelPhoneNumberMobile";
        labelPhoneNumberMobile.Size = new System.Drawing.Size(102, 30);
        labelPhoneNumberMobile.TabIndex = 0;
        labelPhoneNumberMobile.Text = "Tel. Mobil";
        // 
        // panelEmail
        // 
        panelEmail.Controls.Add(panelEmailLabel);
        panelEmail.Controls.Add(boxEmail);
        panelEmail.Location = new System.Drawing.Point(41, 924);
        panelEmail.Name = "panelEmail";
        panelEmail.Size = new System.Drawing.Size(528, 98);
        panelEmail.TabIndex = 12;
        // 
        // panelEmailLabel
        // 
        panelEmailLabel.Controls.Add(labelEmail);
        panelEmailLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelEmailLabel.Location = new System.Drawing.Point(0, 0);
        panelEmailLabel.Name = "panelEmailLabel";
        panelEmailLabel.Size = new System.Drawing.Size(528, 46);
        panelEmailLabel.TabIndex = 0;
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Dock = System.Windows.Forms.DockStyle.Fill;
        labelEmail.Location = new System.Drawing.Point(0, 0);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new System.Drawing.Size(72, 30);
        labelEmail.TabIndex = 0;
        labelEmail.Text = "E-Mail";
        // 
        // panelEmployeeNumber
        // 
        panelEmployeeNumber.Controls.Add(panelEmployeeNumberLabel);
        panelEmployeeNumber.Controls.Add(boxEmployeeNumber);
        panelEmployeeNumber.Location = new System.Drawing.Point(670, 51);
        panelEmployeeNumber.Name = "panelEmployeeNumber";
        panelEmployeeNumber.Size = new System.Drawing.Size(250, 98);
        panelEmployeeNumber.TabIndex = 1;
        // 
        // panelEmployeeNumberLabel
        // 
        panelEmployeeNumberLabel.Controls.Add(labelEmployeeNumber);
        panelEmployeeNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelEmployeeNumberLabel.Location = new System.Drawing.Point(0, 0);
        panelEmployeeNumberLabel.Name = "panelEmployeeNumberLabel";
        panelEmployeeNumberLabel.Size = new System.Drawing.Size(250, 46);
        panelEmployeeNumberLabel.TabIndex = 0;
        // 
        // labelEmployeeNumber
        // 
        labelEmployeeNumber.AutoSize = true;
        labelEmployeeNumber.Dock = System.Windows.Forms.DockStyle.Fill;
        labelEmployeeNumber.Location = new System.Drawing.Point(0, 0);
        labelEmployeeNumber.Name = "labelEmployeeNumber";
        labelEmployeeNumber.Size = new System.Drawing.Size(139, 30);
        labelEmployeeNumber.TabIndex = 0;
        labelEmployeeNumber.Text = "Mitarbeiternr.";
        // 
        // boxEmployeeNumber
        // 
        boxEmployeeNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxEmployeeNumber.Enabled = false;
        boxEmployeeNumber.Location = new System.Drawing.Point(0, 63);
        boxEmployeeNumber.Name = "boxEmployeeNumber";
        boxEmployeeNumber.Size = new System.Drawing.Size(250, 35);
        boxEmployeeNumber.TabIndex = 1;
        // 
        // panelDepartment
        // 
        panelDepartment.Controls.Add(panelDepartmentLabel);
        panelDepartment.Controls.Add(boxDepartment);
        panelDepartment.Location = new System.Drawing.Point(948, 51);
        panelDepartment.Name = "panelDepartment";
        panelDepartment.Size = new System.Drawing.Size(250, 98);
        panelDepartment.TabIndex = 2;
        // 
        // panelDepartmentLabel
        // 
        panelDepartmentLabel.Controls.Add(labelDepartment);
        panelDepartmentLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelDepartmentLabel.Location = new System.Drawing.Point(0, 0);
        panelDepartmentLabel.Name = "panelDepartmentLabel";
        panelDepartmentLabel.Size = new System.Drawing.Size(250, 46);
        panelDepartmentLabel.TabIndex = 0;
        // 
        // labelDepartment
        // 
        labelDepartment.AutoSize = true;
        labelDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
        labelDepartment.Location = new System.Drawing.Point(0, 0);
        labelDepartment.Name = "labelDepartment";
        labelDepartment.Size = new System.Drawing.Size(103, 30);
        labelDepartment.TabIndex = 0;
        labelDepartment.Text = "Abteilung";
        // 
        // boxDepartment
        // 
        boxDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxDepartment.Location = new System.Drawing.Point(0, 63);
        boxDepartment.Name = "boxDepartment";
        boxDepartment.Size = new System.Drawing.Size(250, 35);
        boxDepartment.TabIndex = 1;
        // 
        // panelAhvNumber
        // 
        panelAhvNumber.Controls.Add(panelAhvNumberLabel);
        panelAhvNumber.Controls.Add(boxAhvNumber);
        panelAhvNumber.Location = new System.Drawing.Point(670, 161);
        panelAhvNumber.Name = "panelAhvNumber";
        panelAhvNumber.Size = new System.Drawing.Size(250, 98);
        panelAhvNumber.TabIndex = 3;
        // 
        // panelAhvNumberLabel
        // 
        panelAhvNumberLabel.Controls.Add(labelAhvNumber);
        panelAhvNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelAhvNumberLabel.Location = new System.Drawing.Point(0, 0);
        panelAhvNumberLabel.Name = "panelAhvNumberLabel";
        panelAhvNumberLabel.Size = new System.Drawing.Size(250, 46);
        panelAhvNumberLabel.TabIndex = 0;
        // 
        // labelAhvNumber
        // 
        labelAhvNumber.AutoSize = true;
        labelAhvNumber.Dock = System.Windows.Forms.DockStyle.Fill;
        labelAhvNumber.Location = new System.Drawing.Point(0, 0);
        labelAhvNumber.Name = "labelAhvNumber";
        labelAhvNumber.Size = new System.Drawing.Size(145, 30);
        labelAhvNumber.TabIndex = 0;
        labelAhvNumber.Text = "AHV-Nummer";
        // 
        // boxAhvNumber
        // 
        boxAhvNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxAhvNumber.Location = new System.Drawing.Point(0, 63);
        boxAhvNumber.Name = "boxAhvNumber";
        boxAhvNumber.PlaceholderText = "756.XXXX.XXXX.XXXX";
        boxAhvNumber.Size = new System.Drawing.Size(250, 35);
        boxAhvNumber.TabIndex = 1;
        // 
        // panelNationality
        // 
        panelNationality.Controls.Add(panelNationalityLabel);
        panelNationality.Controls.Add(boxNationality);
        panelNationality.Location = new System.Drawing.Point(948, 161);
        panelNationality.Name = "panelNationality";
        panelNationality.Size = new System.Drawing.Size(250, 98);
        panelNationality.TabIndex = 4;
        // 
        // panelNationalityLabel
        // 
        panelNationalityLabel.Controls.Add(labelNationality);
        panelNationalityLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelNationalityLabel.Location = new System.Drawing.Point(0, 0);
        panelNationalityLabel.Name = "panelNationalityLabel";
        panelNationalityLabel.Size = new System.Drawing.Size(250, 46);
        panelNationalityLabel.TabIndex = 0;
        // 
        // labelNationality
        // 
        labelNationality.AutoSize = true;
        labelNationality.Dock = System.Windows.Forms.DockStyle.Fill;
        labelNationality.Location = new System.Drawing.Point(0, 0);
        labelNationality.Name = "labelNationality";
        labelNationality.Size = new System.Drawing.Size(122, 30);
        labelNationality.TabIndex = 0;
        labelNationality.Text = "Nationalität";
        // 
        // boxNationality
        // 
        boxNationality.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxNationality.Location = new System.Drawing.Point(0, 63);
        boxNationality.Name = "boxNationality";
        boxNationality.Size = new System.Drawing.Size(250, 35);
        boxNationality.TabIndex = 1;
        // 
        // panelEmploymentRate
        // 
        panelEmploymentRate.Controls.Add(panelEmploymentRateLabel);
        panelEmploymentRate.Controls.Add(boxEmploymentRate);
        panelEmploymentRate.Location = new System.Drawing.Point(670, 271);
        panelEmploymentRate.Name = "panelEmploymentRate";
        panelEmploymentRate.Size = new System.Drawing.Size(250, 98);
        panelEmploymentRate.TabIndex = 5;
        // 
        // panelEmploymentRateLabel
        // 
        panelEmploymentRateLabel.Controls.Add(labelEmploymentRate);
        panelEmploymentRateLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelEmploymentRateLabel.Location = new System.Drawing.Point(0, 0);
        panelEmploymentRateLabel.Name = "panelEmploymentRateLabel";
        panelEmploymentRateLabel.Size = new System.Drawing.Size(250, 46);
        panelEmploymentRateLabel.TabIndex = 0;
        // 
        // labelEmploymentRate
        // 
        labelEmploymentRate.AutoSize = true;
        labelEmploymentRate.Dock = System.Windows.Forms.DockStyle.Fill;
        labelEmploymentRate.Location = new System.Drawing.Point(0, 0);
        labelEmploymentRate.Name = "labelEmploymentRate";
        labelEmploymentRate.Size = new System.Drawing.Size(196, 30);
        labelEmploymentRate.TabIndex = 0;
        labelEmploymentRate.Text = "Beschäftigungsgrad";
        // 
        // boxEmploymentRate
        // 
        boxEmploymentRate.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxEmploymentRate.Location = new System.Drawing.Point(0, 63);
        boxEmploymentRate.Name = "boxEmploymentRate";
        boxEmploymentRate.Size = new System.Drawing.Size(250, 35);
        boxEmploymentRate.TabIndex = 1;
        // 
        // panelRole
        // 
        panelRole.Controls.Add(panelRoleLabel);
        panelRole.Controls.Add(boxRole);
        panelRole.Location = new System.Drawing.Point(948, 271);
        panelRole.Name = "panelRole";
        panelRole.Size = new System.Drawing.Size(250, 98);
        panelRole.TabIndex = 6;
        // 
        // panelRoleLabel
        // 
        panelRoleLabel.Controls.Add(labelRole);
        panelRoleLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelRoleLabel.Location = new System.Drawing.Point(0, 0);
        panelRoleLabel.Name = "panelRoleLabel";
        panelRoleLabel.Size = new System.Drawing.Size(250, 46);
        panelRoleLabel.TabIndex = 0;
        // 
        // labelRole
        // 
        labelRole.AutoSize = true;
        labelRole.Dock = System.Windows.Forms.DockStyle.Fill;
        labelRole.Location = new System.Drawing.Point(0, 0);
        labelRole.Name = "labelRole";
        labelRole.Size = new System.Drawing.Size(58, 30);
        labelRole.TabIndex = 0;
        labelRole.Text = "Rolle";
        // 
        // boxRole
        // 
        boxRole.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxRole.Location = new System.Drawing.Point(0, 63);
        boxRole.Name = "boxRole";
        boxRole.Size = new System.Drawing.Size(250, 35);
        boxRole.TabIndex = 1;
        // 
        // panelApprenticeshipYears
        // 
        panelApprenticeshipYears.Controls.Add(panelApprenticeshipYearsLabel);
        panelApprenticeshipYears.Controls.Add(boxApprenticeshipYears);
        panelApprenticeshipYears.Location = new System.Drawing.Point(670, 381);
        panelApprenticeshipYears.Name = "panelApprenticeshipYears";
        panelApprenticeshipYears.Size = new System.Drawing.Size(250, 98);
        panelApprenticeshipYears.TabIndex = 7;
        // 
        // panelApprenticeshipYearsLabel
        // 
        panelApprenticeshipYearsLabel.Controls.Add(labelApprenticeshipYears);
        panelApprenticeshipYearsLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelApprenticeshipYearsLabel.Location = new System.Drawing.Point(0, 0);
        panelApprenticeshipYearsLabel.Name = "panelApprenticeshipYearsLabel";
        panelApprenticeshipYearsLabel.Size = new System.Drawing.Size(250, 46);
        panelApprenticeshipYearsLabel.TabIndex = 0;
        // 
        // labelApprenticeshipYears
        // 
        labelApprenticeshipYears.AutoSize = true;
        labelApprenticeshipYears.Dock = System.Windows.Forms.DockStyle.Fill;
        labelApprenticeshipYears.Location = new System.Drawing.Point(0, 0);
        labelApprenticeshipYears.Name = "labelApprenticeshipYears";
        labelApprenticeshipYears.Size = new System.Drawing.Size(142, 30);
        labelApprenticeshipYears.TabIndex = 0;
        labelApprenticeshipYears.Text = "Lehrlingsjahre";
        // 
        // boxApprenticeshipYears
        // 
        boxApprenticeshipYears.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxApprenticeshipYears.Location = new System.Drawing.Point(0, 63);
        boxApprenticeshipYears.Name = "boxApprenticeshipYears";
        boxApprenticeshipYears.Size = new System.Drawing.Size(250, 35);
        boxApprenticeshipYears.TabIndex = 1;
        // 
        // panelSeniorLevel
        // 
        panelSeniorLevel.Controls.Add(panelSeniorLevelLabel);
        panelSeniorLevel.Controls.Add(boxSeniorLevel);
        panelSeniorLevel.Location = new System.Drawing.Point(948, 381);
        panelSeniorLevel.Name = "panelSeniorLevel";
        panelSeniorLevel.Size = new System.Drawing.Size(250, 98);
        panelSeniorLevel.TabIndex = 8;
        // 
        // panelSeniorLevelLabel
        // 
        panelSeniorLevelLabel.Controls.Add(labelSeniorLevel);
        panelSeniorLevelLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelSeniorLevelLabel.Location = new System.Drawing.Point(0, 0);
        panelSeniorLevelLabel.Name = "panelSeniorLevelLabel";
        panelSeniorLevelLabel.Size = new System.Drawing.Size(250, 46);
        panelSeniorLevelLabel.TabIndex = 0;
        // 
        // labelSeniorLevel
        // 
        labelSeniorLevel.AutoSize = true;
        labelSeniorLevel.Dock = System.Windows.Forms.DockStyle.Fill;
        labelSeniorLevel.Location = new System.Drawing.Point(0, 0);
        labelSeniorLevel.Name = "labelSeniorLevel";
        labelSeniorLevel.Size = new System.Drawing.Size(136, 30);
        labelSeniorLevel.TabIndex = 0;
        labelSeniorLevel.Text = "Seniorenlevel";
        // 
        // boxSeniorLevel
        // 
        boxSeniorLevel.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxSeniorLevel.Location = new System.Drawing.Point(0, 63);
        boxSeniorLevel.Name = "boxSeniorLevel";
        boxSeniorLevel.Size = new System.Drawing.Size(250, 35);
        boxSeniorLevel.TabIndex = 1;
        // 
        // panelWorkStreet
        // 
        panelWorkStreet.Controls.Add(panelWorkStreetLabel);
        panelWorkStreet.Controls.Add(boxWorkStreet);
        panelWorkStreet.Location = new System.Drawing.Point(670, 491);
        panelWorkStreet.Name = "panelWorkStreet";
        panelWorkStreet.Size = new System.Drawing.Size(250, 98);
        panelWorkStreet.TabIndex = 9;
        // 
        // panelWorkStreetLabel
        // 
        panelWorkStreetLabel.Controls.Add(labelWorkStreet);
        panelWorkStreetLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelWorkStreetLabel.Location = new System.Drawing.Point(0, 0);
        panelWorkStreetLabel.Name = "panelWorkStreetLabel";
        panelWorkStreetLabel.Size = new System.Drawing.Size(250, 46);
        panelWorkStreetLabel.TabIndex = 0;
        // 
        // labelWorkStreet
        // 
        labelWorkStreet.AutoSize = true;
        labelWorkStreet.Dock = System.Windows.Forms.DockStyle.Fill;
        labelWorkStreet.Location = new System.Drawing.Point(0, 0);
        labelWorkStreet.Name = "labelWorkStreet";
        labelWorkStreet.Size = new System.Drawing.Size(102, 30);
        labelWorkStreet.TabIndex = 0;
        labelWorkStreet.Text = "Strasse G.";
        // 
        // boxWorkStreet
        // 
        boxWorkStreet.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxWorkStreet.Location = new System.Drawing.Point(0, 63);
        boxWorkStreet.Name = "boxWorkStreet";
        boxWorkStreet.Size = new System.Drawing.Size(250, 35);
        boxWorkStreet.TabIndex = 1;
        // 
        // panelWorkStreetNumber
        // 
        panelWorkStreetNumber.Controls.Add(panelWorkStreetNumberLabel);
        panelWorkStreetNumber.Controls.Add(boxWorkStreetNumber);
        panelWorkStreetNumber.Location = new System.Drawing.Point(948, 491);
        panelWorkStreetNumber.Name = "panelWorkStreetNumber";
        panelWorkStreetNumber.Size = new System.Drawing.Size(250, 98);
        panelWorkStreetNumber.TabIndex = 10;
        // 
        // panelWorkStreetNumberLabel
        // 
        panelWorkStreetNumberLabel.Controls.Add(labelWorkStreetNumber);
        panelWorkStreetNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelWorkStreetNumberLabel.Location = new System.Drawing.Point(0, 0);
        panelWorkStreetNumberLabel.Name = "panelWorkStreetNumberLabel";
        panelWorkStreetNumberLabel.Size = new System.Drawing.Size(250, 46);
        panelWorkStreetNumberLabel.TabIndex = 0;
        // 
        // labelWorkStreetNumber
        // 
        labelWorkStreetNumber.AutoSize = true;
        labelWorkStreetNumber.Dock = System.Windows.Forms.DockStyle.Fill;
        labelWorkStreetNumber.Location = new System.Drawing.Point(0, 0);
        labelWorkStreetNumber.Name = "labelWorkStreetNumber";
        labelWorkStreetNumber.Size = new System.Drawing.Size(171, 30);
        labelWorkStreetNumber.TabIndex = 0;
        labelWorkStreetNumber.Text = "Hausnr. Geschäft";
        // 
        // boxWorkStreetNumber
        // 
        boxWorkStreetNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxWorkStreetNumber.Location = new System.Drawing.Point(0, 63);
        boxWorkStreetNumber.Name = "boxWorkStreetNumber";
        boxWorkStreetNumber.Size = new System.Drawing.Size(250, 35);
        boxWorkStreetNumber.TabIndex = 1;
        // 
        // panelWorkZipCode
        // 
        panelWorkZipCode.Controls.Add(panelWorkZipCodeLabel);
        panelWorkZipCode.Controls.Add(boxWorkZipCode);
        panelWorkZipCode.Location = new System.Drawing.Point(670, 601);
        panelWorkZipCode.Name = "panelWorkZipCode";
        panelWorkZipCode.Size = new System.Drawing.Size(250, 98);
        panelWorkZipCode.TabIndex = 11;
        // 
        // panelWorkZipCodeLabel
        // 
        panelWorkZipCodeLabel.Controls.Add(labelWorkZipCode);
        panelWorkZipCodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelWorkZipCodeLabel.Location = new System.Drawing.Point(0, 0);
        panelWorkZipCodeLabel.Name = "panelWorkZipCodeLabel";
        panelWorkZipCodeLabel.Size = new System.Drawing.Size(250, 46);
        panelWorkZipCodeLabel.TabIndex = 0;
        // 
        // labelWorkZipCode
        // 
        labelWorkZipCode.AutoSize = true;
        labelWorkZipCode.Dock = System.Windows.Forms.DockStyle.Fill;
        labelWorkZipCode.Location = new System.Drawing.Point(0, 0);
        labelWorkZipCode.Name = "labelWorkZipCode";
        labelWorkZipCode.Size = new System.Drawing.Size(205, 30);
        labelWorkZipCode.TabIndex = 0;
        labelWorkZipCode.Text = "Postleitzahl Geschäft";
        // 
        // boxWorkZipCode
        // 
        boxWorkZipCode.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxWorkZipCode.Location = new System.Drawing.Point(0, 63);
        boxWorkZipCode.Name = "boxWorkZipCode";
        boxWorkZipCode.Size = new System.Drawing.Size(250, 35);
        boxWorkZipCode.TabIndex = 1;
        // 
        // panelWorkCity
        // 
        panelWorkCity.Controls.Add(panelWorkCityLabel);
        panelWorkCity.Controls.Add(boxWorkCity);
        panelWorkCity.Location = new System.Drawing.Point(948, 601);
        panelWorkCity.Name = "panelWorkCity";
        panelWorkCity.Size = new System.Drawing.Size(250, 98);
        panelWorkCity.TabIndex = 12;
        // 
        // panelWorkCityLabel
        // 
        panelWorkCityLabel.Controls.Add(labelWorkCity);
        panelWorkCityLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelWorkCityLabel.Location = new System.Drawing.Point(0, 0);
        panelWorkCityLabel.Name = "panelWorkCityLabel";
        panelWorkCityLabel.Size = new System.Drawing.Size(250, 46);
        panelWorkCityLabel.TabIndex = 0;
        // 
        // labelWorkCity
        // 
        labelWorkCity.AutoSize = true;
        labelWorkCity.Dock = System.Windows.Forms.DockStyle.Fill;
        labelWorkCity.Location = new System.Drawing.Point(0, 0);
        labelWorkCity.Name = "labelWorkCity";
        labelWorkCity.Size = new System.Drawing.Size(130, 30);
        labelWorkCity.TabIndex = 0;
        labelWorkCity.Text = "Ort Geschäft";
        // 
        // boxWorkCity
        // 
        boxWorkCity.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxWorkCity.Location = new System.Drawing.Point(0, 63);
        boxWorkCity.Name = "boxWorkCity";
        boxWorkCity.Size = new System.Drawing.Size(250, 35);
        boxWorkCity.TabIndex = 1;
        // 
        // panelDateOfHire
        // 
        panelDateOfHire.Controls.Add(panelDateOfHireLabel);
        panelDateOfHire.Controls.Add(boxDateOfHire);
        panelDateOfHire.Location = new System.Drawing.Point(670, 711);
        panelDateOfHire.Name = "panelDateOfHire";
        panelDateOfHire.Size = new System.Drawing.Size(250, 101);
        panelDateOfHire.TabIndex = 13;
        // 
        // panelDateOfHireLabel
        // 
        panelDateOfHireLabel.Controls.Add(labelDateOfHire);
        panelDateOfHireLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelDateOfHireLabel.Location = new System.Drawing.Point(0, 0);
        panelDateOfHireLabel.Name = "panelDateOfHireLabel";
        panelDateOfHireLabel.Size = new System.Drawing.Size(250, 46);
        panelDateOfHireLabel.TabIndex = 0;
        // 
        // labelDateOfHire
        // 
        labelDateOfHire.AutoSize = true;
        labelDateOfHire.Dock = System.Windows.Forms.DockStyle.Fill;
        labelDateOfHire.Location = new System.Drawing.Point(0, 0);
        labelDateOfHire.Name = "labelDateOfHire";
        labelDateOfHire.Size = new System.Drawing.Size(143, 30);
        labelDateOfHire.TabIndex = 0;
        labelDateOfHire.Text = "Eingestellt am";
        // 
        // boxDateOfHire
        // 
        boxDateOfHire.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxDateOfHire.Location = new System.Drawing.Point(0, 66);
        boxDateOfHire.Name = "boxDateOfHire";
        boxDateOfHire.PlaceholderText = "dd.MM.yyyy";
        boxDateOfHire.Size = new System.Drawing.Size(250, 35);
        boxDateOfHire.TabIndex = 1;
        // 
        // panelStatus
        // 
        panelStatus.Controls.Add(panelStatusLabel);
        panelStatus.Location = new System.Drawing.Point(948, 711);
        panelStatus.Name = "panelStatus";
        panelStatus.Size = new System.Drawing.Size(250, 101);
        panelStatus.TabIndex = 14;
        // 
        // panelStatusLabel
        // 
        panelStatusLabel.Controls.Add(labelStatus);
        panelStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelStatusLabel.Location = new System.Drawing.Point(0, 0);
        panelStatusLabel.Name = "panelStatusLabel";
        panelStatusLabel.Size = new System.Drawing.Size(250, 46);
        panelStatusLabel.TabIndex = 0;
        // 
        // labelStatus
        // 
        labelStatus.AutoSize = true;
        labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
        labelStatus.Location = new System.Drawing.Point(0, 0);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new System.Drawing.Size(69, 30);
        labelStatus.TabIndex = 0;
        labelStatus.Text = "Status";
        // 
        // boxStatus
        // 
        boxStatus.FormattingEnabled = true;
        boxStatus.Location = new System.Drawing.Point(948, 771);
        boxStatus.Name = "boxStatus";
        boxStatus.Size = new System.Drawing.Size(250, 38);
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
        groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        groupBox1.Location = new System.Drawing.Point(12, 11);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(610, 1078);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Kontaktdaten";
        // 
        // groupBox2
        // 
        groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        groupBox2.Location = new System.Drawing.Point(647, 13);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(573, 836);
        groupBox2.TabIndex = 16;
        groupBox2.TabStop = false;
        groupBox2.Text = "Mitarbeiter-Informationen";
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonCancel);
        panel1.Controls.Add(buttonSave);
        panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(0, 1095);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1924, 95);
        panel1.TabIndex = 17;
        // 
        // FormAddEmployee
        // 
        AutoSize = true;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(1924, 1190);
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
    private Panel panelEmployeeNumber;
    private System.Windows.Forms.Label labelEmployeeNumber;
    private TextBox boxEmployeeNumber;
    private Panel panelDepartment;
    private System.Windows.Forms.Label labelDepartment;
    private TextBox boxDepartment;
    private Panel panelAhvNumber;
    private System.Windows.Forms.Label labelAhvNumber;
    private TextBox boxAhvNumber;
    private Panel panelNationality;
    private System.Windows.Forms.Label labelNationality;
    private TextBox boxNationality;
    private Panel panelEmploymentRate;
    private System.Windows.Forms.Label labelEmploymentRate;
    private TextBox boxEmploymentRate;
    private Panel panelRole;
    private System.Windows.Forms.Label labelRole;
    private TextBox boxRole;
    private Panel panelApprenticeshipYears;
    private System.Windows.Forms.Label labelApprenticeshipYears;
    private TextBox boxApprenticeshipYears;
    private Panel panelSeniorLevel;
    private System.Windows.Forms.Label labelSeniorLevel;
    private TextBox boxSeniorLevel;
    private Panel panelWorkStreet;
    private System.Windows.Forms.Label labelWorkStreet;
    private TextBox boxWorkStreet;
    private Panel panelWorkStreetNumber;
    private System.Windows.Forms.Label labelWorkStreetNumber;
    private TextBox boxWorkStreetNumber;
    private Panel panelWorkZipCode;
    private System.Windows.Forms.Label labelWorkZipCode;
    private TextBox boxWorkZipCode;
    private Panel panelWorkCity;
    private System.Windows.Forms.Label labelWorkCity;
    private TextBox boxWorkCity;
    private Panel panelDateOfHire;
    private System.Windows.Forms.Label labelDateOfHire;
    private TextBox boxDateOfHire;
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