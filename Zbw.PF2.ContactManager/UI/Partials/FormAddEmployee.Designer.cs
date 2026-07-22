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
        labelSalutation = new Label();
        boxSalutation = new ComboBox();
        labelFirstName = new Label();
        boxFirstName = new TextBox();
        boxLastName = new TextBox();
        labelLastName = new Label();
        boxBirthday = new TextBox();
        labelBirthday = new Label();
        labelSex = new Label();
        boxSex = new ComboBox();
        boxTitle = new ComboBox();
        labelTitle = new Label();
        boxStreet = new TextBox();
        labelStreetName = new Label();
        boxStreetNumber = new TextBox();
        labelStreetNumber = new Label();
        boxZipCode = new TextBox();
        labelZipCode = new Label();
        boxCity = new TextBox();
        labelCity = new Label();
        buttonCancel = new Button();
        buttonSave = new Button();
        boxPhoneNumberCompany = new TextBox();
        labelPhoneNumberCompany = new Label();
        boxPhoneNumberMobile = new TextBox();
        labelPhoneNumberPrivate = new Label();
        boxEmail = new TextBox();
        labelEmail = new Label();
        SuspendLayout();
        // 
        // labelSalutation
        // 
        labelSalutation.AutoSize = true;
        labelSalutation.Location = new Point(56, 115);
        labelSalutation.Name = "labelSalutation";
        labelSalutation.Size = new Size(80, 30);
        labelSalutation.TabIndex = 0;
        labelSalutation.Text = "Anrede";
        // 
        // boxSalutation
        // 
        boxSalutation.FormattingEnabled = true;
        boxSalutation.Items.AddRange(new object[] { "Herr", "Frau" });
        boxSalutation.Location = new Point(214, 112);
        boxSalutation.Name = "boxSalutation";
        boxSalutation.Size = new Size(242, 38);
        boxSalutation.TabIndex = 2;
        // 
        // labelFirstName
        // 
        labelFirstName.AutoSize = true;
        labelFirstName.Location = new Point(56, 189);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new Size(96, 30);
        labelFirstName.TabIndex = 3;
        labelFirstName.Text = "Vorname";
        // 
        // boxFirstName
        // 
        boxFirstName.Location = new Point(214, 189);
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
        // labelLastName
        // 
        labelLastName.AutoSize = true;
        labelLastName.Location = new Point(56, 272);
        labelLastName.Name = "labelLastName";
        labelLastName.Size = new Size(114, 30);
        labelLastName.TabIndex = 5;
        labelLastName.Text = "Nachname";
        // 
        // boxBirthday
        // 
        boxBirthday.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        boxBirthday.ForeColor = SystemColors.ScrollBar;
        boxBirthday.Location = new Point(214, 371);
        boxBirthday.Name = "boxBirthday";
        boxBirthday.Size = new Size(242, 35);
        boxBirthday.TabIndex = 8;
        boxBirthday.Text = "z.B. 01.02.2003";
        // 
        // labelBirthday
        // 
        labelBirthday.AutoSize = true;
        labelBirthday.Location = new Point(56, 371);
        labelBirthday.Name = "labelBirthday";
        labelBirthday.Size = new Size(115, 30);
        labelBirthday.TabIndex = 7;
        labelBirthday.Text = "Geburtstag";
        // 
        // labelSex
        // 
        labelSex.AutoSize = true;
        labelSex.Location = new Point(56, 457);
        labelSex.Name = "labelSex";
        labelSex.Size = new Size(114, 30);
        labelSex.TabIndex = 9;
        labelSex.Text = "Geschlecht";
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
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Location = new Point(56, 540);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(52, 30);
        labelTitle.TabIndex = 11;
        labelTitle.Text = "Titel";
        // 
        // boxStreet
        // 
        boxStreet.Location = new Point(214, 694);
        boxStreet.Name = "boxStreet";
        boxStreet.Size = new Size(242, 35);
        boxStreet.TabIndex = 14;
        // 
        // labelStreetName
        // 
        labelStreetName.AutoSize = true;
        labelStreetName.Location = new Point(56, 694);
        labelStreetName.Name = "labelStreetName";
        labelStreetName.Size = new Size(77, 30);
        labelStreetName.TabIndex = 13;
        labelStreetName.Text = "Strasse";
        // 
        // boxStreetNumber
        // 
        boxStreetNumber.Location = new Point(214, 777);
        boxStreetNumber.Name = "boxStreetNumber";
        boxStreetNumber.Size = new Size(242, 35);
        boxStreetNumber.TabIndex = 16;
        // 
        // labelStreetNumber
        // 
        labelStreetNumber.AutoSize = true;
        labelStreetNumber.Location = new Point(56, 777);
        labelStreetNumber.Name = "labelStreetNumber";
        labelStreetNumber.Size = new Size(47, 30);
        labelStreetNumber.TabIndex = 15;
        labelStreetNumber.Text = "Nr. ";
        // 
        // boxZipCode
        // 
        boxZipCode.Location = new Point(214, 865);
        boxZipCode.Name = "boxZipCode";
        boxZipCode.Size = new Size(242, 35);
        boxZipCode.TabIndex = 18;
        // 
        // labelZipCode
        // 
        labelZipCode.AutoSize = true;
        labelZipCode.Location = new Point(56, 865);
        labelZipCode.Name = "labelZipCode";
        labelZipCode.Size = new Size(118, 30);
        labelZipCode.TabIndex = 17;
        labelZipCode.Text = "Postleitzahl";
        // 
        // boxCity
        // 
        boxCity.Location = new Point(214, 955);
        boxCity.Name = "boxCity";
        boxCity.Size = new Size(242, 35);
        boxCity.TabIndex = 20;
        // 
        // labelCity
        // 
        labelCity.AutoSize = true;
        labelCity.Location = new Point(56, 955);
        labelCity.Name = "labelCity";
        labelCity.Size = new Size(43, 30);
        labelCity.TabIndex = 19;
        labelCity.Text = "Ort";
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(1533, 1063);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(150, 46);
        buttonCancel.TabIndex = 21;
        buttonCancel.Text = "Abbrechen";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += buttonCancel_Click;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(1750, 1063);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(150, 46);
        buttonSave.TabIndex = 22;
        buttonSave.Text = "Speichern";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // boxPhoneNumberCompany
        // 
        boxPhoneNumberCompany.Location = new Point(839, 112);
        boxPhoneNumberCompany.Name = "boxPhoneNumberCompany";
        boxPhoneNumberCompany.Size = new Size(242, 35);
        boxPhoneNumberCompany.TabIndex = 24;
        // 
        // labelPhoneNumberCompany
        // 
        labelPhoneNumberCompany.AutoSize = true;
        labelPhoneNumberCompany.Location = new Point(593, 112);
        labelPhoneNumberCompany.Name = "labelPhoneNumberCompany";
        labelPhoneNumberCompany.Size = new Size(189, 30);
        labelPhoneNumberCompany.TabIndex = 23;
        labelPhoneNumberCompany.Text = "Telefonnummer G. ";
        // 
        // boxPhoneNumberMobile
        // 
        boxPhoneNumberMobile.Location = new Point(839, 189);
        boxPhoneNumberMobile.Name = "boxPhoneNumberMobile";
        boxPhoneNumberMobile.Size = new Size(242, 35);
        boxPhoneNumberMobile.TabIndex = 26;
        // 
        // labelPhoneNumberPrivate
        // 
        labelPhoneNumberPrivate.AutoSize = true;
        labelPhoneNumberPrivate.Location = new Point(593, 189);
        labelPhoneNumberPrivate.Name = "labelPhoneNumberPrivate";
        labelPhoneNumberPrivate.Size = new Size(187, 30);
        labelPhoneNumberPrivate.TabIndex = 25;
        labelPhoneNumberPrivate.Text = "Telefonnummer P. ";
        // 
        // boxEmail
        // 
        boxEmail.Location = new Point(839, 272);
        boxEmail.Name = "boxEmail";
        boxEmail.Size = new Size(242, 35);
        boxEmail.TabIndex = 28;
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Location = new Point(593, 272);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(72, 30);
        labelEmail.TabIndex = 27;
        labelEmail.Text = "E-Mail";
        // 
        // FormAddEmployee
        // 
        BackColor = Color.White;
        ClientSize = new Size(2026, 1156);
        Controls.Add(boxEmail);
        Controls.Add(labelEmail);
        Controls.Add(boxPhoneNumberMobile);
        Controls.Add(labelPhoneNumberPrivate);
        Controls.Add(boxPhoneNumberCompany);
        Controls.Add(labelPhoneNumberCompany);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        Controls.Add(boxCity);
        Controls.Add(labelCity);
        Controls.Add(boxZipCode);
        Controls.Add(labelZipCode);
        Controls.Add(boxStreetNumber);
        Controls.Add(labelStreetNumber);
        Controls.Add(boxStreet);
        Controls.Add(labelStreetName);
        Controls.Add(boxTitle);
        Controls.Add(labelTitle);
        Controls.Add(boxSex);
        Controls.Add(labelSex);
        Controls.Add(boxBirthday);
        Controls.Add(labelBirthday);
        Controls.Add(boxLastName);
        Controls.Add(labelLastName);
        Controls.Add(boxFirstName);
        Controls.Add(labelFirstName);
        Controls.Add(boxSalutation);
        Controls.Add(labelSalutation);
        Name = "FormAddEmployee";
        Load += FormAddEmployee_Load;
        ResumeLayout(false);
        PerformLayout();

    }
    private TextBox boxCity;
    private Label labelCity;
    private Button buttonCancel;
    private Button buttonSave;
    private Label labelSalutation;
    private ComboBox boxSalutation;
    private Label labelFirstName;
    private TextBox boxFirstName;
    private TextBox boxLastName;
    private Label labelLastName;
    private TextBox boxBirthday;
    private Label labelBirthday;
    private Label labelSex;
    private ComboBox boxSex;
    private ComboBox boxTitle;
    private Label labelTitle;
    private TextBox boxStreet;
    private Label labelStreetName;
    private TextBox boxStreetNumber;
    private Label labelStreetNumber;
    private TextBox boxZipCode;
    private Label labelZipCode;
    private TextBox boxPhoneNumberCompany;
    private Label labelPhoneNumberCompany;
    private TextBox boxPhoneNumberMobile;
    private Label labelPhoneNumberPrivate;
    private TextBox boxEmail;
    private Label labelEmail;


    #endregion



}