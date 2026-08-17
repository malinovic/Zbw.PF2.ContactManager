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
        labelFirstName = new Label();
        panelLastName = new Panel();
        labelLastName = new Label();
        panelBirthday = new Panel();
        labelBirthday = new Label();
        panelSex = new Panel();
        labelSex = new Label();
        panelTitle = new Panel();
        labelTitle = new Label();
        panelStreet = new Panel();
        labelStreet = new Label();
        panelStreetNumber = new Panel();
        labelStreetNumber = new Label();
        panelZipCode = new Panel();
        labelZipCode = new Label();
        panelCity = new Panel();
        labelCity = new Label();
        panelPhoneNumberCompany = new Panel();
        labelPhoneNumberCompany = new Label();
        panelPhoneNumberMobile = new Panel();
        labelPhoneNumberMobile = new Label();
        panelEmail = new Panel();
        labelEmail = new Label();
        panelEmployeeNumber = new Panel();
        labelEmployeeNumber = new Label();
        boxEmployeeNumber = new TextBox();
        panelDepartment = new Panel();
        labelDepartment = new Label();
        boxDepartment = new TextBox();
        panelAhvNumber = new Panel();
        labelAhvNumber = new Label();
        boxAhvNumber = new TextBox();
        panelNationality = new Panel();
        labelNationality = new Label();
        boxNationality = new TextBox();
        panelEmploymentRate = new Panel();
        labelEmploymentRate = new Label();
        boxEmploymentRate = new TextBox();
        panelRole = new Panel();
        labelRole = new Label();
        boxRole = new TextBox();
        panelApprenticeshipYears = new Panel();
        labelApprenticeshipYears = new Label();
        boxApprenticeshipYears = new TextBox();
        panelSeniorLevel = new Panel();
        labelSeniorLevel = new Label();
        boxSeniorLevel = new TextBox();
        panelWorkStreet = new Panel();
        labelWorkStreet = new Label();
        boxWorkStreet = new TextBox();
        panelWorkStreetNumber = new Panel();
        labelWorkStreetNumber = new Label();
        boxWorkStreetNumber = new TextBox();
        panelWorkZipCode = new Panel();
        labelWorkZipCode = new Label();
        boxWorkZipCode = new TextBox();
        panelWorkCity = new Panel();
        labelWorkCity = new Label();
        boxWorkCity = new TextBox();
        panelDateOfHire = new Panel();
        labelDateOfHire = new Label();
        boxDateOfHire = new TextBox();
        panelStatus = new Panel();
        labelStatus = new Label();
        boxStatus = new ComboBox();
        groupBox1 = new GroupBox();
        panelSalutation.SuspendLayout();
        panelSalutationLabel.SuspendLayout();
        panelFirstName.SuspendLayout();
        panelLastName.SuspendLayout();
        panelBirthday.SuspendLayout();
        panelSex.SuspendLayout();
        panelTitle.SuspendLayout();
        panelStreet.SuspendLayout();
        panelStreetNumber.SuspendLayout();
        panelZipCode.SuspendLayout();
        panelCity.SuspendLayout();
        panelPhoneNumberCompany.SuspendLayout();
        panelPhoneNumberMobile.SuspendLayout();
        panelEmail.SuspendLayout();
        panelEmployeeNumber.SuspendLayout();
        panelDepartment.SuspendLayout();
        panelAhvNumber.SuspendLayout();
        panelNationality.SuspendLayout();
        panelEmploymentRate.SuspendLayout();
        panelRole.SuspendLayout();
        panelApprenticeshipYears.SuspendLayout();
        panelSeniorLevel.SuspendLayout();
        panelWorkStreet.SuspendLayout();
        panelWorkStreetNumber.SuspendLayout();
        panelWorkZipCode.SuspendLayout();
        panelWorkCity.SuspendLayout();
        panelDateOfHire.SuspendLayout();
        panelStatus.SuspendLayout();
        SuspendLayout();
        // 
        // boxSalutation
        // 
        boxSalutation.Dock = DockStyle.Bottom;
        boxSalutation.FlatStyle = FlatStyle.Flat;
        boxSalutation.FormattingEnabled = true;
        boxSalutation.Items.AddRange(new object[] { "Herr", "Frau" });
        boxSalutation.Location = new Point(0, 63);
        boxSalutation.Name = "boxSalutation";
        boxSalutation.Size = new Size(468, 38);
        boxSalutation.TabIndex = 2;
        // 
        // boxFirstName
        // 
        boxFirstName.Location = new Point(214, 208);
        boxFirstName.Name = "boxFirstName";
        boxFirstName.Size = new Size(242, 35);
        boxFirstName.TabIndex = 4;
        // 
        // boxLastName
        // 
        boxLastName.Location = new Point(214, 272);
        boxLastName.Name = "boxLastName";
        boxLastName.Size = new Size(242, 35);
        boxLastName.TabIndex = 6;
        // 
        // boxBirthday
        // 
        boxBirthday.Location = new Point(214, 371);
        boxBirthday.Name = "boxBirthday";
        boxBirthday.PlaceholderText = "z.B. 01.02.2003";
        boxBirthday.Size = new Size(242, 35);
        boxBirthday.TabIndex = 8;
        // 
        // boxSex
        // 
        boxSex.FormattingEnabled = true;
        boxSex.Location = new Point(214, 457);
        boxSex.Name = "boxSex";
        boxSex.Size = new Size(242, 38);
        boxSex.TabIndex = 10;
        // 
        // boxTitle
        // 
        boxTitle.FormattingEnabled = true;
        boxTitle.Location = new Point(214, 540);
        boxTitle.Name = "boxTitle";
        boxTitle.Size = new Size(242, 38);
        boxTitle.TabIndex = 12;
        // 
        // boxStreet
        // 
        boxStreet.Location = new Point(214, 694);
        boxStreet.Name = "boxStreet";
        boxStreet.Size = new Size(242, 35);
        boxStreet.TabIndex = 14;
        // 
        // boxStreetNumber
        // 
        boxStreetNumber.Location = new Point(214, 777);
        boxStreetNumber.Name = "boxStreetNumber";
        boxStreetNumber.Size = new Size(242, 35);
        boxStreetNumber.TabIndex = 16;
        // 
        // boxZipCode
        // 
        boxZipCode.Location = new Point(214, 865);
        boxZipCode.Name = "boxZipCode";
        boxZipCode.Size = new Size(242, 35);
        boxZipCode.TabIndex = 18;
        // 
        // boxCity
        // 
        boxCity.Location = new Point(214, 955);
        boxCity.Name = "boxCity";
        boxCity.Size = new Size(242, 35);
        boxCity.TabIndex = 20;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(1381, 1246);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(167, 46);
        buttonCancel.TabIndex = 57;
        buttonCancel.Text = "Abbrechen";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += buttonCancel_Click;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(1598, 1246);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(150, 46);
        buttonSave.TabIndex = 56;
        buttonSave.Text = "Speichern";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // boxPhoneNumberCompany
        // 
        boxPhoneNumberCompany.Location = new Point(232, 1102);
        boxPhoneNumberCompany.Name = "boxPhoneNumberCompany";
        boxPhoneNumberCompany.Size = new Size(242, 35);
        boxPhoneNumberCompany.TabIndex = 24;
        // 
        // boxPhoneNumberMobile
        // 
        boxPhoneNumberMobile.Location = new Point(232, 1179);
        boxPhoneNumberMobile.Name = "boxPhoneNumberMobile";
        boxPhoneNumberMobile.Size = new Size(242, 35);
        boxPhoneNumberMobile.TabIndex = 26;
        // 
        // boxEmail
        // 
        boxEmail.Location = new Point(232, 1262);
        boxEmail.Name = "boxEmail";
        boxEmail.Size = new Size(242, 35);
        boxEmail.TabIndex = 28;
        // 
        // panelSalutation
        // 
        panelSalutation.Controls.Add(panelSalutationLabel);
        panelSalutation.Controls.Add(boxSalutation);
        panelSalutation.Location = new Point(41, 90);
        panelSalutation.Name = "panelSalutation";
        panelSalutation.Size = new Size(468, 101);
        panelSalutation.TabIndex = 29;
        // 
        // panelSalutationLabel
        // 
        panelSalutationLabel.Controls.Add(labelSalutation);
        panelSalutationLabel.Dock = DockStyle.Top;
        panelSalutationLabel.Location = new Point(0, 0);
        panelSalutationLabel.Name = "panelSalutationLabel";
        panelSalutationLabel.Size = new Size(468, 46);
        panelSalutationLabel.TabIndex = 3;
        // 
        // labelSalutation
        // 
        labelSalutation.AutoSize = true;
        labelSalutation.Dock = DockStyle.Fill;
        labelSalutation.Location = new Point(0, 0);
        labelSalutation.Name = "labelSalutation";
        labelSalutation.Size = new Size(80, 30);
        labelSalutation.TabIndex = 1;
        labelSalutation.Text = "Anrede";
        // 
        // panelFirstName
        // 
        panelFirstName.Controls.Add(labelFirstName);
        panelFirstName.Location = new Point(41, 197);
        panelFirstName.Name = "panelFirstName";
        panelFirstName.Size = new Size(111, 55);
        panelFirstName.TabIndex = 30;
        // 
        // labelFirstName
        // 
        labelFirstName.AutoSize = true;
        labelFirstName.Location = new Point(21, 34);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new Size(96, 30);
        labelFirstName.TabIndex = 1;
        labelFirstName.Text = "Vorname";
        // 
        // panelLastName
        // 
        panelLastName.Controls.Add(labelLastName);
        panelLastName.Location = new Point(41, 272);
        panelLastName.Name = "panelLastName";
        panelLastName.Size = new Size(111, 55);
        panelLastName.TabIndex = 31;
        // 
        // labelLastName
        // 
        labelLastName.AutoSize = true;
        labelLastName.Location = new Point(9, 15);
        labelLastName.Name = "labelLastName";
        labelLastName.Size = new Size(114, 30);
        labelLastName.TabIndex = 1;
        labelLastName.Text = "Nachname";
        // 
        // panelBirthday
        // 
        panelBirthday.Controls.Add(labelBirthday);
        panelBirthday.Location = new Point(41, 361);
        panelBirthday.Name = "panelBirthday";
        panelBirthday.Size = new Size(111, 55);
        panelBirthday.TabIndex = 31;
        // 
        // labelBirthday
        // 
        labelBirthday.AutoSize = true;
        labelBirthday.Location = new Point(7, 15);
        labelBirthday.Name = "labelBirthday";
        labelBirthday.Size = new Size(115, 30);
        labelBirthday.TabIndex = 1;
        labelBirthday.Text = "Geburtstag";
        // 
        // panelSex
        // 
        panelSex.Controls.Add(labelSex);
        panelSex.Location = new Point(47, 445);
        panelSex.Name = "panelSex";
        panelSex.Size = new Size(111, 55);
        panelSex.TabIndex = 31;
        // 
        // labelSex
        // 
        labelSex.AutoSize = true;
        labelSex.Location = new Point(8, 15);
        labelSex.Name = "labelSex";
        labelSex.Size = new Size(114, 30);
        labelSex.TabIndex = 1;
        labelSex.Text = "Geschlecht";
        // 
        // panelTitle
        // 
        panelTitle.Controls.Add(labelTitle);
        panelTitle.Location = new Point(47, 540);
        panelTitle.Name = "panelTitle";
        panelTitle.Size = new Size(111, 55);
        panelTitle.TabIndex = 32;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Location = new Point(21, 15);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(52, 30);
        labelTitle.TabIndex = 1;
        labelTitle.Text = "Titel";
        // 
        // panelStreet
        // 
        panelStreet.Controls.Add(labelStreet);
        panelStreet.Location = new Point(47, 681);
        panelStreet.Name = "panelStreet";
        panelStreet.Size = new Size(111, 55);
        panelStreet.TabIndex = 33;
        // 
        // labelStreet
        // 
        labelStreet.AutoSize = true;
        labelStreet.Location = new Point(21, 15);
        labelStreet.Name = "labelStreet";
        labelStreet.Size = new Size(77, 30);
        labelStreet.TabIndex = 1;
        labelStreet.Text = "Strasse";
        // 
        // panelStreetNumber
        // 
        panelStreetNumber.Controls.Add(labelStreetNumber);
        panelStreetNumber.Location = new Point(47, 766);
        panelStreetNumber.Name = "panelStreetNumber";
        panelStreetNumber.Size = new Size(111, 55);
        panelStreetNumber.TabIndex = 34;
        // 
        // labelStreetNumber
        // 
        labelStreetNumber.AutoSize = true;
        labelStreetNumber.Location = new Point(21, 15);
        labelStreetNumber.Name = "labelStreetNumber";
        labelStreetNumber.Size = new Size(47, 30);
        labelStreetNumber.TabIndex = 1;
        labelStreetNumber.Text = "Nr. ";
        // 
        // panelZipCode
        // 
        panelZipCode.Controls.Add(labelZipCode);
        panelZipCode.Location = new Point(47, 853);
        panelZipCode.Name = "panelZipCode";
        panelZipCode.Size = new Size(111, 55);
        panelZipCode.TabIndex = 35;
        // 
        // labelZipCode
        // 
        labelZipCode.AutoSize = true;
        labelZipCode.Location = new Point(21, 15);
        labelZipCode.Name = "labelZipCode";
        labelZipCode.Size = new Size(118, 30);
        labelZipCode.TabIndex = 1;
        labelZipCode.Text = "Postleitzahl";
        // 
        // panelCity
        // 
        panelCity.Controls.Add(labelCity);
        panelCity.Location = new Point(51, 943);
        panelCity.Name = "panelCity";
        panelCity.Size = new Size(111, 55);
        panelCity.TabIndex = 36;
        // 
        // labelCity
        // 
        labelCity.AutoSize = true;
        labelCity.Location = new Point(21, 15);
        labelCity.Name = "labelCity";
        labelCity.Size = new Size(43, 30);
        labelCity.TabIndex = 1;
        labelCity.Text = "Ort";
        // 
        // panelPhoneNumberCompany
        // 
        panelPhoneNumberCompany.Controls.Add(labelPhoneNumberCompany);
        panelPhoneNumberCompany.Location = new Point(50, 1080);
        panelPhoneNumberCompany.Name = "panelPhoneNumberCompany";
        panelPhoneNumberCompany.Size = new Size(111, 55);
        panelPhoneNumberCompany.TabIndex = 30;
        // 
        // labelPhoneNumberCompany
        // 
        labelPhoneNumberCompany.AutoSize = true;
        labelPhoneNumberCompany.Location = new Point(21, 15);
        labelPhoneNumberCompany.Name = "labelPhoneNumberCompany";
        labelPhoneNumberCompany.Size = new Size(130, 30);
        labelPhoneNumberCompany.TabIndex = 1;
        labelPhoneNumberCompany.Text = "Tel. Geschäft";
        // 
        // panelPhoneNumberMobile
        // 
        panelPhoneNumberMobile.Controls.Add(labelPhoneNumberMobile);
        panelPhoneNumberMobile.Location = new Point(50, 1168);
        panelPhoneNumberMobile.Name = "panelPhoneNumberMobile";
        panelPhoneNumberMobile.Size = new Size(111, 55);
        panelPhoneNumberMobile.TabIndex = 31;
        // 
        // labelPhoneNumberMobile
        // 
        labelPhoneNumberMobile.AutoSize = true;
        labelPhoneNumberMobile.Location = new Point(21, 15);
        labelPhoneNumberMobile.Name = "labelPhoneNumberMobile";
        labelPhoneNumberMobile.Size = new Size(102, 30);
        labelPhoneNumberMobile.TabIndex = 1;
        labelPhoneNumberMobile.Text = "Tel. Mobil";
        // 
        // panelEmail
        // 
        panelEmail.Controls.Add(labelEmail);
        panelEmail.Location = new Point(50, 1247);
        panelEmail.Name = "panelEmail";
        panelEmail.Size = new Size(111, 55);
        panelEmail.TabIndex = 32;
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Location = new Point(21, 15);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(72, 30);
        labelEmail.TabIndex = 1;
        labelEmail.Text = "E-Mail";
        // 
        // panelEmployeeNumber
        // 
        panelEmployeeNumber.Controls.Add(labelEmployeeNumber);
        panelEmployeeNumber.Location = new Point(826, 90);
        panelEmployeeNumber.Name = "panelEmployeeNumber";
        panelEmployeeNumber.Size = new Size(111, 55);
        panelEmployeeNumber.TabIndex = 34;
        // 
        // labelEmployeeNumber
        // 
        labelEmployeeNumber.AutoSize = true;
        labelEmployeeNumber.Location = new Point(4, 15);
        labelEmployeeNumber.Name = "labelEmployeeNumber";
        labelEmployeeNumber.Size = new Size(139, 30);
        labelEmployeeNumber.TabIndex = 1;
        labelEmployeeNumber.Text = "Mitarbeiternr.";
        // 
        // boxEmployeeNumber
        // 
        boxEmployeeNumber.Location = new Point(1008, 105);
        boxEmployeeNumber.Name = "boxEmployeeNumber";
        boxEmployeeNumber.Size = new Size(242, 35);
        boxEmployeeNumber.TabIndex = 33;
        // 
        // panelDepartment
        // 
        panelDepartment.Controls.Add(labelDepartment);
        panelDepartment.Location = new Point(826, 185);
        panelDepartment.Name = "panelDepartment";
        panelDepartment.Size = new Size(111, 55);
        panelDepartment.TabIndex = 36;
        // 
        // labelDepartment
        // 
        labelDepartment.AutoSize = true;
        labelDepartment.Location = new Point(21, 15);
        labelDepartment.Name = "labelDepartment";
        labelDepartment.Size = new Size(103, 30);
        labelDepartment.TabIndex = 1;
        labelDepartment.Text = "Abteilung";
        // 
        // boxDepartment
        // 
        boxDepartment.Location = new Point(1008, 200);
        boxDepartment.Name = "boxDepartment";
        boxDepartment.Size = new Size(242, 35);
        boxDepartment.TabIndex = 35;
        // 
        // panelAhvNumber
        // 
        panelAhvNumber.Controls.Add(labelAhvNumber);
        panelAhvNumber.Location = new Point(826, 339);
        panelAhvNumber.Name = "panelAhvNumber";
        panelAhvNumber.Size = new Size(111, 55);
        panelAhvNumber.TabIndex = 38;
        // 
        // labelAhvNumber
        // 
        labelAhvNumber.AutoSize = true;
        labelAhvNumber.Location = new Point(13, 15);
        labelAhvNumber.Name = "labelAhvNumber";
        labelAhvNumber.Size = new Size(145, 30);
        labelAhvNumber.TabIndex = 1;
        labelAhvNumber.Text = "AHV-Nummer";
        // 
        // boxAhvNumber
        // 
        boxAhvNumber.Location = new Point(1008, 354);
        boxAhvNumber.Name = "boxAhvNumber";
        boxAhvNumber.Size = new Size(242, 35);
        boxAhvNumber.TabIndex = 37;
        // 
        // panelNationality
        // 
        panelNationality.Controls.Add(labelNationality);
        panelNationality.Location = new Point(826, 447);
        panelNationality.Name = "panelNationality";
        panelNationality.Size = new Size(111, 55);
        panelNationality.TabIndex = 40;
        // 
        // labelNationality
        // 
        labelNationality.AutoSize = true;
        labelNationality.Location = new Point(21, 15);
        labelNationality.Name = "labelNationality";
        labelNationality.Size = new Size(122, 30);
        labelNationality.TabIndex = 1;
        labelNationality.Text = "Nationalität";
        // 
        // boxNationality
        // 
        boxNationality.Location = new Point(1008, 462);
        boxNationality.Name = "boxNationality";
        boxNationality.Size = new Size(242, 35);
        boxNationality.TabIndex = 39;
        // 
        // panelEmploymentRate
        // 
        panelEmploymentRate.Controls.Add(labelEmploymentRate);
        panelEmploymentRate.Location = new Point(826, 630);
        panelEmploymentRate.Name = "panelEmploymentRate";
        panelEmploymentRate.Size = new Size(111, 55);
        panelEmploymentRate.TabIndex = 44;
        // 
        // labelEmploymentRate
        // 
        labelEmploymentRate.AutoSize = true;
        labelEmploymentRate.Location = new Point(21, 15);
        labelEmploymentRate.Name = "labelEmploymentRate";
        labelEmploymentRate.Size = new Size(196, 30);
        labelEmploymentRate.TabIndex = 1;
        labelEmploymentRate.Text = "Beschäftigungsgrad";
        // 
        // boxEmploymentRate
        // 
        boxEmploymentRate.Location = new Point(1008, 645);
        boxEmploymentRate.Name = "boxEmploymentRate";
        boxEmploymentRate.Size = new Size(242, 35);
        boxEmploymentRate.TabIndex = 43;
        // 
        // panelRole
        // 
        panelRole.Controls.Add(labelRole);
        panelRole.Location = new Point(826, 730);
        panelRole.Name = "panelRole";
        panelRole.Size = new Size(111, 55);
        panelRole.TabIndex = 46;
        // 
        // labelRole
        // 
        labelRole.AutoSize = true;
        labelRole.Location = new Point(21, 15);
        labelRole.Name = "labelRole";
        labelRole.Size = new Size(58, 30);
        labelRole.TabIndex = 1;
        labelRole.Text = "Rolle";
        // 
        // boxRole
        // 
        boxRole.Location = new Point(1008, 745);
        boxRole.Name = "boxRole";
        boxRole.Size = new Size(242, 35);
        boxRole.TabIndex = 45;
        // 
        // panelApprenticeshipYears
        // 
        panelApprenticeshipYears.Controls.Add(labelApprenticeshipYears);
        panelApprenticeshipYears.Location = new Point(826, 830);
        panelApprenticeshipYears.Name = "panelApprenticeshipYears";
        panelApprenticeshipYears.Size = new Size(111, 55);
        panelApprenticeshipYears.TabIndex = 48;
        // 
        // labelApprenticeshipYears
        // 
        labelApprenticeshipYears.AutoSize = true;
        labelApprenticeshipYears.Location = new Point(21, 15);
        labelApprenticeshipYears.Name = "labelApprenticeshipYears";
        labelApprenticeshipYears.Size = new Size(142, 30);
        labelApprenticeshipYears.TabIndex = 1;
        labelApprenticeshipYears.Text = "Lehrlingsjahre";
        // 
        // boxApprenticeshipYears
        // 
        boxApprenticeshipYears.Location = new Point(1008, 845);
        boxApprenticeshipYears.Name = "boxApprenticeshipYears";
        boxApprenticeshipYears.Size = new Size(242, 35);
        boxApprenticeshipYears.TabIndex = 47;
        // 
        // panelSeniorLevel
        // 
        panelSeniorLevel.Controls.Add(labelSeniorLevel);
        panelSeniorLevel.Location = new Point(826, 910);
        panelSeniorLevel.Name = "panelSeniorLevel";
        panelSeniorLevel.Size = new Size(111, 55);
        panelSeniorLevel.TabIndex = 50;
        // 
        // labelSeniorLevel
        // 
        labelSeniorLevel.AutoSize = true;
        labelSeniorLevel.Location = new Point(22, 15);
        labelSeniorLevel.Name = "labelSeniorLevel";
        labelSeniorLevel.Size = new Size(136, 30);
        labelSeniorLevel.TabIndex = 1;
        labelSeniorLevel.Text = "Seniorenlevel";
        // 
        // boxSeniorLevel
        // 
        boxSeniorLevel.Location = new Point(1008, 925);
        boxSeniorLevel.Name = "boxSeniorLevel";
        boxSeniorLevel.Size = new Size(242, 35);
        boxSeniorLevel.TabIndex = 49;
        // 
        // panelWorkStreet
        // 
        panelWorkStreet.Controls.Add(labelWorkStreet);
        panelWorkStreet.Location = new Point(826, 1070);
        panelWorkStreet.Name = "panelWorkStreet";
        panelWorkStreet.Size = new Size(111, 55);
        panelWorkStreet.TabIndex = 52;
        // 
        // labelWorkStreet
        // 
        labelWorkStreet.AutoSize = true;
        labelWorkStreet.Location = new Point(21, 15);
        labelWorkStreet.Name = "labelWorkStreet";
        labelWorkStreet.Size = new Size(102, 30);
        labelWorkStreet.TabIndex = 1;
        labelWorkStreet.Text = "Strasse G.";
        // 
        // boxWorkStreet
        // 
        boxWorkStreet.Location = new Point(1008, 1085);
        boxWorkStreet.Name = "boxWorkStreet";
        boxWorkStreet.Size = new Size(242, 35);
        boxWorkStreet.TabIndex = 50;
        // 
        // panelWorkStreetNumber
        // 
        panelWorkStreetNumber.Controls.Add(labelWorkStreetNumber);
        panelWorkStreetNumber.Location = new Point(826, 1159);
        panelWorkStreetNumber.Name = "panelWorkStreetNumber";
        panelWorkStreetNumber.Size = new Size(111, 55);
        panelWorkStreetNumber.TabIndex = 54;
        // 
        // labelWorkStreetNumber
        // 
        labelWorkStreetNumber.AutoSize = true;
        labelWorkStreetNumber.Location = new Point(21, 15);
        labelWorkStreetNumber.Name = "labelWorkStreetNumber";
        labelWorkStreetNumber.Size = new Size(168, 30);
        labelWorkStreetNumber.TabIndex = 1;
        labelWorkStreetNumber.Text = "Hausnummer. G.";
        // 
        // boxWorkStreetNumber
        // 
        boxWorkStreetNumber.Location = new Point(1008, 1174);
        boxWorkStreetNumber.Name = "boxWorkStreetNumber";
        boxWorkStreetNumber.Size = new Size(242, 35);
        boxWorkStreetNumber.TabIndex = 51;
        // 
        // panelWorkZipCode
        // 
        panelWorkZipCode.Controls.Add(labelWorkZipCode);
        panelWorkZipCode.Location = new Point(826, 1247);
        panelWorkZipCode.Name = "panelWorkZipCode";
        panelWorkZipCode.Size = new Size(111, 55);
        panelWorkZipCode.TabIndex = 56;
        // 
        // labelWorkZipCode
        // 
        labelWorkZipCode.AutoSize = true;
        labelWorkZipCode.Location = new Point(21, 15);
        labelWorkZipCode.Name = "labelWorkZipCode";
        labelWorkZipCode.Size = new Size(143, 30);
        labelWorkZipCode.TabIndex = 1;
        labelWorkZipCode.Text = "Postleitzahl G.";
        // 
        // boxWorkZipCode
        // 
        boxWorkZipCode.Location = new Point(1008, 1262);
        boxWorkZipCode.Name = "boxWorkZipCode";
        boxWorkZipCode.Size = new Size(242, 35);
        boxWorkZipCode.TabIndex = 52;
        // 
        // panelWorkCity
        // 
        panelWorkCity.Controls.Add(labelWorkCity);
        panelWorkCity.Location = new Point(826, 1331);
        panelWorkCity.Name = "panelWorkCity";
        panelWorkCity.Size = new Size(111, 55);
        panelWorkCity.TabIndex = 58;
        // 
        // labelWorkCity
        // 
        labelWorkCity.AutoSize = true;
        labelWorkCity.Location = new Point(21, 15);
        labelWorkCity.Name = "labelWorkCity";
        labelWorkCity.Size = new Size(68, 30);
        labelWorkCity.TabIndex = 1;
        labelWorkCity.Text = "Ort G.";
        // 
        // boxWorkCity
        // 
        boxWorkCity.Location = new Point(1008, 1346);
        boxWorkCity.Name = "boxWorkCity";
        boxWorkCity.Size = new Size(242, 35);
        boxWorkCity.TabIndex = 53;
        // 
        // panelDateOfHire
        // 
        panelDateOfHire.Controls.Add(labelDateOfHire);
        panelDateOfHire.Location = new Point(826, 1405);
        panelDateOfHire.Name = "panelDateOfHire";
        panelDateOfHire.Size = new Size(176, 55);
        panelDateOfHire.TabIndex = 52;
        // 
        // labelDateOfHire
        // 
        labelDateOfHire.AutoSize = true;
        labelDateOfHire.Location = new Point(22, 15);
        labelDateOfHire.Name = "labelDateOfHire";
        labelDateOfHire.Size = new Size(154, 30);
        labelDateOfHire.TabIndex = 1;
        labelDateOfHire.Text = "Eingestellt am: ";
        // 
        // boxDateOfHire
        // 
        boxDateOfHire.Location = new Point(1008, 1420);
        boxDateOfHire.Name = "boxDateOfHire";
        boxDateOfHire.Size = new Size(242, 35);
        boxDateOfHire.TabIndex = 54;
        // 
        // panelStatus
        // 
        panelStatus.Controls.Add(labelStatus);
        panelStatus.Location = new Point(1267, 339);
        panelStatus.Name = "panelStatus";
        panelStatus.Size = new Size(111, 55);
        panelStatus.TabIndex = 54;
        // 
        // labelStatus
        // 
        labelStatus.AutoSize = true;
        labelStatus.Location = new Point(22, 15);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(69, 30);
        labelStatus.TabIndex = 1;
        labelStatus.Text = "Status";
        // 
        // boxStatus
        // 
        boxStatus.FormattingEnabled = true;
        boxStatus.Location = new Point(1434, 351);
        boxStatus.Name = "boxStatus";
        boxStatus.Size = new Size(242, 38);
        boxStatus.TabIndex = 55;
        // 
        // groupBox1
        // 
        groupBox1.FlatStyle = FlatStyle.Flat;
        groupBox1.Location = new Point(12, 15);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(550, 1468);
        groupBox1.TabIndex = 59;
        groupBox1.TabStop = false;
        groupBox1.Text = "Kontaktdaten";
        // 
        // FormAddEmployee
        // 
        BackColor = Color.White;
        ClientSize = new Size(1924, 1495);
        Controls.Add(boxFirstName);
        Controls.Add(panelFirstName);
        Controls.Add(panelSalutation);
        Controls.Add(boxStatus);
        Controls.Add(panelStatus);
        Controls.Add(panelDateOfHire);
        Controls.Add(boxDateOfHire);
        Controls.Add(panelWorkCity);
        Controls.Add(boxWorkCity);
        Controls.Add(panelWorkZipCode);
        Controls.Add(boxWorkZipCode);
        Controls.Add(panelWorkStreetNumber);
        Controls.Add(boxWorkStreetNumber);
        Controls.Add(panelWorkStreet);
        Controls.Add(boxWorkStreet);
        Controls.Add(panelSeniorLevel);
        Controls.Add(boxSeniorLevel);
        Controls.Add(panelApprenticeshipYears);
        Controls.Add(boxApprenticeshipYears);
        Controls.Add(panelRole);
        Controls.Add(boxRole);
        Controls.Add(panelEmploymentRate);
        Controls.Add(boxEmploymentRate);
        Controls.Add(panelNationality);
        Controls.Add(boxNationality);
        Controls.Add(panelAhvNumber);
        Controls.Add(boxAhvNumber);
        Controls.Add(panelDepartment);
        Controls.Add(boxDepartment);
        Controls.Add(panelEmployeeNumber);
        Controls.Add(boxEmployeeNumber);
        Controls.Add(panelEmail);
        Controls.Add(panelPhoneNumberMobile);
        Controls.Add(panelPhoneNumberCompany);
        Controls.Add(panelCity);
        Controls.Add(panelZipCode);
        Controls.Add(panelStreetNumber);
        Controls.Add(panelStreet);
        Controls.Add(panelTitle);
        Controls.Add(panelSex);
        Controls.Add(panelBirthday);
        Controls.Add(panelLastName);
        Controls.Add(boxEmail);
        Controls.Add(boxPhoneNumberMobile);
        Controls.Add(boxPhoneNumberCompany);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        Controls.Add(boxCity);
        Controls.Add(boxZipCode);
        Controls.Add(boxStreetNumber);
        Controls.Add(boxStreet);
        Controls.Add(boxTitle);
        Controls.Add(boxSex);
        Controls.Add(boxBirthday);
        Controls.Add(boxLastName);
        Controls.Add(groupBox1);
        Name = "FormAddEmployee";
        Load += FormAddEmployee_Load;
        panelSalutation.ResumeLayout(false);
        panelSalutationLabel.ResumeLayout(false);
        panelSalutationLabel.PerformLayout();
        panelFirstName.ResumeLayout(false);
        panelFirstName.PerformLayout();
        panelLastName.ResumeLayout(false);
        panelLastName.PerformLayout();
        panelBirthday.ResumeLayout(false);
        panelBirthday.PerformLayout();
        panelSex.ResumeLayout(false);
        panelSex.PerformLayout();
        panelTitle.ResumeLayout(false);
        panelTitle.PerformLayout();
        panelStreet.ResumeLayout(false);
        panelStreet.PerformLayout();
        panelStreetNumber.ResumeLayout(false);
        panelStreetNumber.PerformLayout();
        panelZipCode.ResumeLayout(false);
        panelZipCode.PerformLayout();
        panelCity.ResumeLayout(false);
        panelCity.PerformLayout();
        panelPhoneNumberCompany.ResumeLayout(false);
        panelPhoneNumberCompany.PerformLayout();
        panelPhoneNumberMobile.ResumeLayout(false);
        panelPhoneNumberMobile.PerformLayout();
        panelEmail.ResumeLayout(false);
        panelEmail.PerformLayout();
        panelEmployeeNumber.ResumeLayout(false);
        panelEmployeeNumber.PerformLayout();
        panelDepartment.ResumeLayout(false);
        panelDepartment.PerformLayout();
        panelAhvNumber.ResumeLayout(false);
        panelAhvNumber.PerformLayout();
        panelNationality.ResumeLayout(false);
        panelNationality.PerformLayout();
        panelEmploymentRate.ResumeLayout(false);
        panelEmploymentRate.PerformLayout();
        panelRole.ResumeLayout(false);
        panelRole.PerformLayout();
        panelApprenticeshipYears.ResumeLayout(false);
        panelApprenticeshipYears.PerformLayout();
        panelSeniorLevel.ResumeLayout(false);
        panelSeniorLevel.PerformLayout();
        panelWorkStreet.ResumeLayout(false);
        panelWorkStreet.PerformLayout();
        panelWorkStreetNumber.ResumeLayout(false);
        panelWorkStreetNumber.PerformLayout();
        panelWorkZipCode.ResumeLayout(false);
        panelWorkZipCode.PerformLayout();
        panelWorkCity.ResumeLayout(false);
        panelWorkCity.PerformLayout();
        panelDateOfHire.ResumeLayout(false);
        panelDateOfHire.PerformLayout();
        panelStatus.ResumeLayout(false);
        panelStatus.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

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
}