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
        panelSalutation.SuspendLayout();
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
        SuspendLayout();
        // 
        // boxSalutation
        // 
        boxSalutation.FormattingEnabled = true;
        boxSalutation.Items.AddRange(new object[] { "Herr", "Frau" });
        boxSalutation.Location = new Point(214, 112);
        boxSalutation.Name = "boxSalutation";
        boxSalutation.Size = new Size(242, 33);
        boxSalutation.TabIndex = 2;
        // 
        // boxFirstName
        // 
        boxFirstName.Location = new Point(214, 189);
        boxFirstName.Name = "boxFirstName";
        boxFirstName.Size = new Size(242, 31);
        boxFirstName.TabIndex = 4;
        // 
        // boxLastName
        // 
        boxLastName.Location = new Point(214, 272);
        boxLastName.Name = "boxLastName";
        boxLastName.Size = new Size(242, 31);
        boxLastName.TabIndex = 6;
        // 
        // boxBirthday
        // 
        boxBirthday.Location = new Point(214, 371);
        boxBirthday.Name = "boxBirthday";
        boxBirthday.Size = new Size(242, 31);
        boxBirthday.TabIndex = 8;
        boxBirthday.PlaceholderText = "z.B. 01.02.2003";
        // 
        // boxSex
        // 
        boxSex.FormattingEnabled = true;
        boxSex.Location = new Point(214, 457);
        boxSex.Name = "boxSex";
        boxSex.Size = new Size(242, 33);
        boxSex.TabIndex = 10;
        // 
        // boxTitle
        // 
        boxTitle.FormattingEnabled = true;
        boxTitle.Location = new Point(214, 540);
        boxTitle.Name = "boxTitle";
        boxTitle.Size = new Size(242, 33);
        boxTitle.TabIndex = 12;
        // 
        // boxStreet
        // 
        boxStreet.Location = new Point(214, 694);
        boxStreet.Name = "boxStreet";
        boxStreet.Size = new Size(242, 31);
        boxStreet.TabIndex = 14;
        // 
        // boxStreetNumber
        // 
        boxStreetNumber.Location = new Point(214, 777);
        boxStreetNumber.Name = "boxStreetNumber";
        boxStreetNumber.Size = new Size(242, 31);
        boxStreetNumber.TabIndex = 16;
        // 
        // boxZipCode
        // 
        boxZipCode.Location = new Point(214, 865);
        boxZipCode.Name = "boxZipCode";
        boxZipCode.Size = new Size(242, 31);
        boxZipCode.TabIndex = 18;
        // 
        // boxCity
        // 
        boxCity.Location = new Point(214, 955);
        boxCity.Name = "boxCity";
        boxCity.Size = new Size(242, 31);
        boxCity.TabIndex = 20;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(1384, 937);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(150, 46);
        buttonCancel.TabIndex = 21;
        buttonCancel.Text = "Abbrechen";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += buttonCancel_Click;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(1601, 937);
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
        boxPhoneNumberCompany.Size = new Size(242, 31);
        boxPhoneNumberCompany.TabIndex = 24;
        // 
        // boxPhoneNumberMobile
        // 
        boxPhoneNumberMobile.Location = new Point(839, 189);
        boxPhoneNumberMobile.Name = "boxPhoneNumberMobile";
        boxPhoneNumberMobile.Size = new Size(242, 31);
        boxPhoneNumberMobile.TabIndex = 26;
        // 
        // boxEmail
        // 
        boxEmail.Location = new Point(839, 272);
        boxEmail.Name = "boxEmail";
        boxEmail.Size = new Size(242, 31);
        boxEmail.TabIndex = 28;
        // 
        // panelSalutation
        // 
        panelSalutation.Controls.Add(labelSalutation);
        panelSalutation.Location = new Point(41, 90);
        panelSalutation.Name = "panelSalutation";
        panelSalutation.Size = new Size(111, 55);
        panelSalutation.TabIndex = 29;
        // 
        // labelSalutation
        // 
        labelSalutation.AutoSize = true;
        labelSalutation.Location = new Point(21, 15);
        labelSalutation.Name = "labelSalutation";
        labelSalutation.Size = new Size(69, 25);
        labelSalutation.TabIndex = 1;
        labelSalutation.Text = "Anrede";
        // 
        // panelFirstName
        // 
        panelFirstName.Controls.Add(labelFirstName);
        panelFirstName.Location = new Point(41, 178);
        panelFirstName.Name = "panelFirstName";
        panelFirstName.Size = new Size(111, 55);
        panelFirstName.TabIndex = 30;
        // 
        // labelFirstName
        // 
        labelFirstName.AutoSize = true;
        labelFirstName.Location = new Point(21, 15);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new Size(83, 25);
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
        labelLastName.Size = new Size(96, 25);
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
        labelBirthday.Size = new Size(100, 25);
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
        labelSex.Size = new Size(96, 25);
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
        labelTitle.Size = new Size(44, 25);
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
        labelStreet.Size = new Size(67, 25);
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
        labelStreetNumber.Size = new Size(40, 25);
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
        labelZipCode.Size = new Size(100, 25);
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
        labelCity.Size = new Size(38, 25);
        labelCity.TabIndex = 1;
        labelCity.Text = "Ort";
        // 
        // panelPhoneNumberCompany
        // 
        panelPhoneNumberCompany.Controls.Add(labelPhoneNumberCompany);
        panelPhoneNumberCompany.Location = new Point(657, 90);
        panelPhoneNumberCompany.Name = "panelPhoneNumberCompany";
        panelPhoneNumberCompany.Size = new Size(111, 55);
        panelPhoneNumberCompany.TabIndex = 30;
        // 
        // labelPhoneNumberCompany
        // 
        labelPhoneNumberCompany.AutoSize = true;
        labelPhoneNumberCompany.Location = new Point(21, 15);
        labelPhoneNumberCompany.Name = "labelPhoneNumberCompany";
        labelPhoneNumberCompany.Size = new Size(109, 25);
        labelPhoneNumberCompany.TabIndex = 1;
        labelPhoneNumberCompany.Text = "Tel. Geschäft";
        // 
        // panelPhoneNumberMobile
        // 
        panelPhoneNumberMobile.Controls.Add(labelPhoneNumberMobile);
        panelPhoneNumberMobile.Location = new Point(657, 178);
        panelPhoneNumberMobile.Name = "panelPhoneNumberMobile";
        panelPhoneNumberMobile.Size = new Size(111, 55);
        panelPhoneNumberMobile.TabIndex = 31;
        // 
        // labelPhoneNumberMobile
        // 
        labelPhoneNumberMobile.AutoSize = true;
        labelPhoneNumberMobile.Location = new Point(21, 15);
        labelPhoneNumberMobile.Name = "labelPhoneNumberMobile";
        labelPhoneNumberMobile.Size = new Size(87, 25);
        labelPhoneNumberMobile.TabIndex = 1;
        labelPhoneNumberMobile.Text = "Tel. Mobil";
        // 
        // panelEmail
        // 
        panelEmail.Controls.Add(labelEmail);
        panelEmail.Location = new Point(657, 257);
        panelEmail.Name = "panelEmail";
        panelEmail.Size = new Size(111, 55);
        panelEmail.TabIndex = 32;
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Location = new Point(21, 15);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(61, 25);
        labelEmail.TabIndex = 1;
        labelEmail.Text = "E-Mail";
        // 
        // FormAddEmployee
        // 
        BackColor = Color.White;
        ClientSize = new Size(1924, 1156);
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
        Controls.Add(panelFirstName);
        Controls.Add(panelSalutation);
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
        Controls.Add(boxFirstName);
        Controls.Add(boxSalutation);
        Name = "FormAddEmployee";
        Load += FormAddEmployee_Load;
        panelSalutation.ResumeLayout(false);
        panelSalutation.PerformLayout();
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
}