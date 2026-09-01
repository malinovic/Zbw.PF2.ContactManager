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
        panelCustomerNumber = new System.Windows.Forms.Panel();
        panelCustomerNumberLabel = new System.Windows.Forms.Panel();
        labelCustomerNumber = new System.Windows.Forms.Label();
        boxCustomerNumber = new System.Windows.Forms.TextBox();
        panelCustomerCompanyName = new System.Windows.Forms.Panel();
        panelCustomerCompanyNameLabel = new System.Windows.Forms.Panel();
        labelCustomerCompanyName = new System.Windows.Forms.Label();
        boxCustomerCompanyName = new System.Windows.Forms.TextBox();
        panelCustomerType = new System.Windows.Forms.Panel();
        panelCustomerTypeLabel = new System.Windows.Forms.Panel();
        labelCustomerType = new System.Windows.Forms.Label();
        boxCustomerType = new System.Windows.Forms.ComboBox();
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
        panelCustomerNumber.SuspendLayout();
        panelCustomerNumberLabel.SuspendLayout();
        panelCustomerCompanyName.SuspendLayout();
        panelCustomerCompanyNameLabel.SuspendLayout();
        panelCustomerType.SuspendLayout();
        panelCustomerTypeLabel.SuspendLayout();
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
        boxFirstName.Font = new System.Drawing.Font("Segoe UI", 11F);
        boxFirstName.Location = new System.Drawing.Point(0, 63);
        boxFirstName.Name = "boxFirstName";
        boxFirstName.Size = new System.Drawing.Size(250, 35);
        boxFirstName.TabIndex = 1;
        // 
        // boxLastName
        // 
        boxLastName.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxLastName.Font = new System.Drawing.Font("Segoe UI", 11F);
        boxLastName.Location = new System.Drawing.Point(0, 63);
        boxLastName.Name = "boxLastName";
        boxLastName.Size = new System.Drawing.Size(250, 35);
        boxLastName.TabIndex = 1;
        // 
        // boxBirthday
        // 
        boxBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        boxBirthday.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxBirthday.Font = new System.Drawing.Font("Segoe UI", 11F);
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
        boxStreet.Font = new System.Drawing.Font("Segoe UI", 11F);
        boxStreet.Location = new System.Drawing.Point(0, 63);
        boxStreet.Name = "boxStreet";
        boxStreet.Size = new System.Drawing.Size(250, 35);
        boxStreet.TabIndex = 1;
        // 
        // boxStreetNumber
        // 
        boxStreetNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxStreetNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
        boxStreetNumber.Location = new System.Drawing.Point(0, 63);
        boxStreetNumber.Name = "boxStreetNumber";
        boxStreetNumber.PlaceholderText = "11a";
        boxStreetNumber.Size = new System.Drawing.Size(250, 35);
        boxStreetNumber.TabIndex = 1;
        // 
        // boxZipCode
        // 
        boxZipCode.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxZipCode.Font = new System.Drawing.Font("Segoe UI", 11F);
        boxZipCode.Location = new System.Drawing.Point(0, 63);
        boxZipCode.Name = "boxZipCode";
        boxZipCode.PlaceholderText = "XXXX";
        boxZipCode.Size = new System.Drawing.Size(250, 35);
        boxZipCode.TabIndex = 1;
        // 
        // boxCity
        // 
        boxCity.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxCity.Font = new System.Drawing.Font("Segoe UI", 11F);
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
        boxPhoneNumberCompany.Font = new System.Drawing.Font("Segoe UI", 11F);
        boxPhoneNumberCompany.Location = new System.Drawing.Point(0, 63);
        boxPhoneNumberCompany.Name = "boxPhoneNumberCompany";
        boxPhoneNumberCompany.PlaceholderText = "0761234567";
        boxPhoneNumberCompany.Size = new System.Drawing.Size(528, 35);
        boxPhoneNumberCompany.TabIndex = 1;
        // 
        // boxPhoneNumberMobile
        // 
        boxPhoneNumberMobile.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxPhoneNumberMobile.Font = new System.Drawing.Font("Segoe UI", 11F);
        boxPhoneNumberMobile.Location = new System.Drawing.Point(0, 63);
        boxPhoneNumberMobile.Name = "boxPhoneNumberMobile";
        boxPhoneNumberMobile.PlaceholderText = "0761234567";
        boxPhoneNumberMobile.Size = new System.Drawing.Size(528, 35);
        boxPhoneNumberMobile.TabIndex = 1;
        // 
        // boxEmail
        // 
        boxEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
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
        // panelCustomerNumber
        // 
        panelCustomerNumber.Controls.Add(panelCustomerNumberLabel);
        panelCustomerNumber.Controls.Add(boxCustomerNumber);
        panelCustomerNumber.Location = new System.Drawing.Point(670, 51);
        panelCustomerNumber.Name = "panelCustomerNumber";
        panelCustomerNumber.Size = new System.Drawing.Size(250, 98);
        panelCustomerNumber.TabIndex = 1;
        // 
        // panelCustomerNumberLabel
        // 
        panelCustomerNumberLabel.Controls.Add(labelCustomerNumber);
        panelCustomerNumberLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelCustomerNumberLabel.Location = new System.Drawing.Point(0, 0);
        panelCustomerNumberLabel.Name = "panelCustomerNumberLabel";
        panelCustomerNumberLabel.Size = new System.Drawing.Size(250, 46);
        panelCustomerNumberLabel.TabIndex = 0;
        // 
        // labelCustomerNumber
        // 
        labelCustomerNumber.AutoSize = true;
        labelCustomerNumber.Dock = System.Windows.Forms.DockStyle.Fill;
        labelCustomerNumber.Location = new System.Drawing.Point(0, 0);
        labelCustomerNumber.Name = "labelCustomerNumber";
        labelCustomerNumber.Size = new System.Drawing.Size(139, 30);
        labelCustomerNumber.TabIndex = 0;
        labelCustomerNumber.Text = "Kundennr.";
        // 
        // boxCustomerNumber
        // 
        boxCustomerNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxCustomerNumber.Enabled = false;
        boxCustomerNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
        boxCustomerNumber.Location = new System.Drawing.Point(0, 63);
        boxCustomerNumber.Name = "boxCustomerNumber";
        boxCustomerNumber.Size = new System.Drawing.Size(250, 35);
        boxCustomerNumber.TabIndex = 1;
        // 
        // panelCustomerCompanyName
        // 
        panelCustomerCompanyName.Controls.Add(panelCustomerCompanyNameLabel);
        panelCustomerCompanyName.Controls.Add(boxCustomerCompanyName);
        panelCustomerCompanyName.Location = new System.Drawing.Point(948, 51);
        panelCustomerCompanyName.Name = "panelCustomerCompanyName";
        panelCustomerCompanyName.Size = new System.Drawing.Size(250, 98);
        panelCustomerCompanyName.TabIndex = 2;
        // 
        // panelCustomerCompanyNameLabel
        // 
        panelCustomerCompanyNameLabel.Controls.Add(labelCustomerCompanyName);
        panelCustomerCompanyNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelCustomerCompanyNameLabel.Location = new System.Drawing.Point(0, 0);
        panelCustomerCompanyNameLabel.Name = "panelCustomerCompanyNameLabel";
        panelCustomerCompanyNameLabel.Size = new System.Drawing.Size(250, 46);
        panelCustomerCompanyNameLabel.TabIndex = 0;
        // 
        // labelCustomerCompanyName
        // 
        labelCustomerCompanyName.AutoSize = true;
        labelCustomerCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
        labelCustomerCompanyName.Location = new System.Drawing.Point(0, 0);
        labelCustomerCompanyName.Name = "labelCustomerCompanyName";
        labelCustomerCompanyName.Size = new System.Drawing.Size(103, 30);
        labelCustomerCompanyName.TabIndex = 0;
        labelCustomerCompanyName.Text = "Firmenname";
        // 
        // boxCustomerCompanyName
        // 
        boxCustomerCompanyName.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxCustomerCompanyName.Font = new System.Drawing.Font("Segoe UI", 11F);
        boxCustomerCompanyName.Location = new System.Drawing.Point(0, 63);
        boxCustomerCompanyName.Name = "boxCustomerCompanyName";
        boxCustomerCompanyName.Size = new System.Drawing.Size(250, 35);
        boxCustomerCompanyName.TabIndex = 1;
        // 
        // panelCustomerType
        // 
        panelCustomerType.Controls.Add(panelCustomerTypeLabel);
        panelCustomerType.Controls.Add(boxCustomerType);
        panelCustomerType.Location = new System.Drawing.Point(670, 161);
        panelCustomerType.Name = "panelCustomerType";
        panelCustomerType.Size = new System.Drawing.Size(250, 98);
        panelCustomerType.TabIndex = 3;
        // 
        // panelCustomerTypeLabel
        // 
        panelCustomerTypeLabel.Controls.Add(labelCustomerType);
        panelCustomerTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
        panelCustomerTypeLabel.Location = new System.Drawing.Point(0, 0);
        panelCustomerTypeLabel.Name = "panelCustomerTypeLabel";
        panelCustomerTypeLabel.Size = new System.Drawing.Size(250, 46);
        panelCustomerTypeLabel.TabIndex = 0;
        // 
        // labelCustomerType
        // 
        labelCustomerType.AutoSize = true;
        labelCustomerType.Dock = System.Windows.Forms.DockStyle.Fill;
        labelCustomerType.Location = new System.Drawing.Point(0, 0);
        labelCustomerType.Name = "labelCustomerType";
        labelCustomerType.Size = new System.Drawing.Size(145, 30);
        labelCustomerType.TabIndex = 0;
        labelCustomerType.Text = "Kundentyp";
        // 
        // boxCustomerType
        // 
        boxCustomerType.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxCustomerType.FormattingEnabled = true;
        boxCustomerType.Location = new System.Drawing.Point(0, 63);
        boxCustomerType.Name = "boxCustomerType";
        boxCustomerType.Size = new System.Drawing.Size(250, 38);
        boxCustomerType.TabIndex = 1;
        // 
        // panelStatus
        // 
        panelStatus.Controls.Add(panelStatusLabel);
        panelStatus.Controls.Add(boxStatus);
        panelStatus.Location = new System.Drawing.Point(948, 161);
        panelStatus.Name = "panelStatus";
        panelStatus.Size = new System.Drawing.Size(250, 98);
        panelStatus.TabIndex = 4;
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
        boxStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
        boxStatus.FormattingEnabled = true;
        boxStatus.Location = new System.Drawing.Point(0, 63);
        boxStatus.Name = "boxStatus";
        boxStatus.Size = new System.Drawing.Size(250, 38);
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
        groupBox2.Size = new System.Drawing.Size(573, 300);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Kunden-Informationen";
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonCancel);
        panel1.Controls.Add(buttonSave);
        panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(0, 1095);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1924, 95);
        panel1.TabIndex = 6;
        // 
        // FormCustomerDetail
        // 
        AutoSize = true;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(1924, 1190);
        Controls.Add(panelStatus);
        Controls.Add(panelCustomerType);
        Controls.Add(panelCustomerCompanyName);
        Controls.Add(panelCustomerNumber);
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
        panelCustomerNumber.ResumeLayout(false);
        panelCustomerNumber.PerformLayout();
        panelCustomerNumberLabel.ResumeLayout(false);
        panelCustomerNumberLabel.PerformLayout();
        panelCustomerCompanyName.ResumeLayout(false);
        panelCustomerCompanyName.PerformLayout();
        panelCustomerCompanyNameLabel.ResumeLayout(false);
        panelCustomerCompanyNameLabel.PerformLayout();
        panelCustomerType.ResumeLayout(false);
        panelCustomerTypeLabel.ResumeLayout(false);
        panelCustomerTypeLabel.PerformLayout();
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
    private Panel panelCustomerNumber;
    private System.Windows.Forms.Label labelCustomerNumber;
    private TextBox boxCustomerNumber;
    private Panel panelCustomerCompanyName;
    private System.Windows.Forms.Label labelCustomerCompanyName;
    private TextBox boxCustomerCompanyName;
    private Panel panelCustomerType;
    private System.Windows.Forms.Label labelCustomerType;
    private ComboBox boxCustomerType;
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
    private Panel panelCustomerCompanyNameLabel;
    private Panel panelCustomerTypeLabel;
    private Panel panelStatusLabel;
    private GroupBox groupBox2;
    private Panel panel1;
}