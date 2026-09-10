namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormCustomerNotes
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
        groupBoxCustomer = new GroupBox();
        panelFirstName = new Panel();
        labelFirstNameValue = new Label();
        labelFirstName = new Label();
        panelLastName = new Panel();
        labelLastNameValue = new Label();
        labelLastName = new Label();
        panelCustomerNumber = new Panel();
        labelCustomerNumberValue = new Label();
        labelCustomerNumber = new Label();
        panelStatus = new Panel();
        labelStatusValue = new Label();
        labelStatus = new Label();
        groupBoxNotes = new GroupBox();
        richTextBox1 = new RichTextBox();
        panel1 = new Panel();
        buttonCancel = new Button();
        buttonSave = new Button();
        groupBoxCustomer.SuspendLayout();
        panelFirstName.SuspendLayout();
        panelLastName.SuspendLayout();
        panelCustomerNumber.SuspendLayout();
        panelStatus.SuspendLayout();
        groupBoxNotes.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBoxCustomer
        // 
        groupBoxCustomer.Controls.Add(panelFirstName);
        groupBoxCustomer.Controls.Add(panelLastName);
        groupBoxCustomer.Controls.Add(panelCustomerNumber);
        groupBoxCustomer.Controls.Add(panelStatus);
        groupBoxCustomer.FlatStyle = FlatStyle.Flat;
        groupBoxCustomer.Location = new Point(12, 12);
        groupBoxCustomer.Name = "groupBoxCustomer";
        groupBoxCustomer.Size = new Size(600, 205);
        groupBoxCustomer.TabIndex = 0;
        groupBoxCustomer.TabStop = false;
        groupBoxCustomer.Text = "Ausgewählter Kunde";
        // 
        // panelFirstName
        // 
        panelFirstName.Controls.Add(labelFirstNameValue);
        panelFirstName.Controls.Add(labelFirstName);
        panelFirstName.Location = new Point(20, 35);
        panelFirstName.Name = "panelFirstName";
        panelFirstName.Size = new Size(260, 70);
        panelFirstName.TabIndex = 0;
        // 
        // labelFirstNameValue
        // 
        labelFirstNameValue.Dock = DockStyle.Fill;
        labelFirstNameValue.Location = new Point(0, 15);
        labelFirstNameValue.Name = "labelFirstNameValue";
        labelFirstNameValue.Size = new Size(260, 55);
        labelFirstNameValue.TabIndex = 1;
        // 
        // labelFirstName
        // 
        labelFirstName.AutoSize = true;
        labelFirstName.Dock = DockStyle.Top;
        labelFirstName.Location = new Point(0, 0);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new Size(54, 15);
        labelFirstName.TabIndex = 0;
        labelFirstName.Text = "Vorname";
        // 
        // panelLastName
        // 
        panelLastName.Controls.Add(labelLastNameValue);
        panelLastName.Controls.Add(labelLastName);
        panelLastName.Location = new Point(300, 35);
        panelLastName.Name = "panelLastName";
        panelLastName.Size = new Size(260, 70);
        panelLastName.TabIndex = 1;
        // 
        // labelLastNameValue
        // 
        labelLastNameValue.Dock = DockStyle.Fill;
        labelLastNameValue.Location = new Point(0, 15);
        labelLastNameValue.Name = "labelLastNameValue";
        labelLastNameValue.Size = new Size(260, 55);
        labelLastNameValue.TabIndex = 1;
        // 
        // labelLastName
        // 
        labelLastName.AutoSize = true;
        labelLastName.Dock = DockStyle.Top;
        labelLastName.Location = new Point(0, 0);
        labelLastName.Name = "labelLastName";
        labelLastName.Size = new Size(65, 15);
        labelLastName.TabIndex = 0;
        labelLastName.Text = "Nachname";
        // 
        // panelCustomerNumber
        // 
        panelCustomerNumber.Controls.Add(labelCustomerNumberValue);
        panelCustomerNumber.Controls.Add(labelCustomerNumber);
        panelCustomerNumber.Location = new Point(20, 115);
        panelCustomerNumber.Name = "panelCustomerNumber";
        panelCustomerNumber.Size = new Size(260, 70);
        panelCustomerNumber.TabIndex = 2;
        // 
        // labelCustomerNumberValue
        // 
        labelCustomerNumberValue.Dock = DockStyle.Fill;
        labelCustomerNumberValue.Location = new Point(0, 15);
        labelCustomerNumberValue.Name = "labelCustomerNumberValue";
        labelCustomerNumberValue.Size = new Size(260, 55);
        labelCustomerNumberValue.TabIndex = 1;
        // 
        // labelCustomerNumber
        // 
        labelCustomerNumber.AutoSize = true;
        labelCustomerNumber.Dock = DockStyle.Top;
        labelCustomerNumber.Location = new Point(0, 0);
        labelCustomerNumber.Name = "labelCustomerNumber";
        labelCustomerNumber.Size = new Size(62, 15);
        labelCustomerNumber.TabIndex = 0;
        labelCustomerNumber.Text = "Kundennr.";
        // 
        // panelStatus
        // 
        panelStatus.Controls.Add(labelStatusValue);
        panelStatus.Controls.Add(labelStatus);
        panelStatus.Location = new Point(300, 115);
        panelStatus.Name = "panelStatus";
        panelStatus.Size = new Size(260, 70);
        panelStatus.TabIndex = 3;
        // 
        // labelStatusValue
        // 
        labelStatusValue.Dock = DockStyle.Fill;
        labelStatusValue.Location = new Point(0, 15);
        labelStatusValue.Name = "labelStatusValue";
        labelStatusValue.Size = new Size(260, 55);
        labelStatusValue.TabIndex = 1;
        // 
        // labelStatus
        // 
        labelStatus.AutoSize = true;
        labelStatus.Dock = DockStyle.Top;
        labelStatus.Location = new Point(0, 0);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(39, 15);
        labelStatus.TabIndex = 0;
        labelStatus.Text = "Status";
        // 
        // groupBoxNotes
        // 
        groupBoxNotes.Controls.Add(richTextBox1);
        groupBoxNotes.FlatStyle = FlatStyle.Flat;
        groupBoxNotes.Location = new Point(12, 229);
        groupBoxNotes.Name = "groupBoxNotes";
        groupBoxNotes.Size = new Size(600, 260);
        groupBoxNotes.TabIndex = 1;
        groupBoxNotes.TabStop = false;
        groupBoxNotes.Text = "Kunden-Notizen";
        // 
        // richTextBox1
        // 
        richTextBox1.Dock = DockStyle.Fill;
        richTextBox1.Location = new Point(3, 19);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(594, 238);
        richTextBox1.TabIndex = 0;
        richTextBox1.Text = "";
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonCancel);
        panel1.Controls.Add(buttonSave);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 501);
        panel1.Name = "panel1";
        panel1.Size = new Size(624, 55);
        panel1.TabIndex = 2;
        // 
        // buttonCancel
        // 
        buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonCancel.Location = new Point(392, 10);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(110, 35);
        buttonCancel.TabIndex = 0;
        buttonCancel.Text = "Abbrechen";
        buttonCancel.UseVisualStyleBackColor = true;
        // 
        // buttonSave
        // 
        buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonSave.Location = new Point(512, 10);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(110, 35);
        buttonSave.TabIndex = 1;
        buttonSave.Text = "Speichern";
        buttonSave.UseVisualStyleBackColor = true;
        // 
        // FormCustomerNotes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(624, 556);
        Controls.Add(groupBoxNotes);
        Controls.Add(groupBoxCustomer);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormCustomerNotes";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Kunden-Notizen";
        groupBoxCustomer.ResumeLayout(false);
        panelFirstName.ResumeLayout(false);
        panelFirstName.PerformLayout();
        panelLastName.ResumeLayout(false);
        panelLastName.PerformLayout();
        panelCustomerNumber.ResumeLayout(false);
        panelCustomerNumber.PerformLayout();
        panelStatus.ResumeLayout(false);
        panelStatus.PerformLayout();
        groupBoxNotes.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxCustomer;
    private Panel panelFirstName;
    private Label labelFirstNameValue;
    private Label labelFirstName;
    private Panel panelLastName;
    private Label labelLastNameValue;
    private Label labelLastName;
    private Panel panelCustomerNumber;
    private Label labelCustomerNumberValue;
    private Label labelCustomerNumber;
    private Panel panelStatus;
    private Label labelStatusValue;
    private Label labelStatus;
    private GroupBox groupBoxNotes;
    private RichTextBox richTextBox1;
    private Panel panel1;
    private Button buttonCancel;
    private Button buttonSave;
}
