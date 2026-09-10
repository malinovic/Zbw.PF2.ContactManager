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
        groupBox2 = new GroupBox();
        richTextBox1 = new RichTextBox();
        panelCustomerNumber = new Panel();
        panelCustomerNumberLabel = new Panel();
        labelCustomerNumber = new Label();
        boxCustomerNumber = new TextBox();
        panelStatus = new Panel();
        panelStatusLabel = new Panel();
        labelStatus = new Label();
        boxStatus = new ComboBox();
        groupBox1 = new GroupBox();
        panelFirstName = new Panel();
        panelFirstNameLabel = new Panel();
        labelFirstName = new Label();
        boxFirstName = new TextBox();
        panelLastName = new Panel();
        panelLastNameLabel = new Panel();
        labelLastName = new Label();
        boxLastName = new TextBox();
        panel1 = new Panel();
        buttonCancel = new Button();
        buttonSave = new Button();
        groupBox2.SuspendLayout();
        panelCustomerNumber.SuspendLayout();
        panelCustomerNumberLabel.SuspendLayout();
        panelStatus.SuspendLayout();
        panelStatusLabel.SuspendLayout();
        groupBox1.SuspendLayout();
        panelFirstName.SuspendLayout();
        panelFirstNameLabel.SuspendLayout();
        panelLastName.SuspendLayout();
        panelLastNameLabel.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(richTextBox1);
        groupBox2.FlatStyle = FlatStyle.Flat;
        groupBox2.Location = new Point(647, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(573, 300);
        groupBox2.TabIndex = 10;
        groupBox2.TabStop = false;
        groupBox2.Text = "Kunden-Notizen";
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new Point(6, 22);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(561, 272);
        richTextBox1.TabIndex = 0;
        richTextBox1.Text = "";
        // 
        // panelCustomerNumber
        // 
        panelCustomerNumber.Controls.Add(panelCustomerNumberLabel);
        panelCustomerNumber.Controls.Add(boxCustomerNumber);
        panelCustomerNumber.Location = new Point(670, 50);
        panelCustomerNumber.Name = "panelCustomerNumber";
        panelCustomerNumber.Size = new Size(250, 98);
        panelCustomerNumber.TabIndex = 8;
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
        panelStatus.Location = new Point(948, 160);
        panelStatus.Name = "panelStatus";
        panelStatus.Size = new Size(250, 98);
        panelStatus.TabIndex = 9;
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
        groupBox1.Controls.Add(panelFirstName);
        groupBox1.Controls.Add(panelLastName);
        groupBox1.FlatStyle = FlatStyle.Flat;
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(610, 300);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "Ausgewählter Kunde:";
        // 
        // panelFirstName
        // 
        panelFirstName.Controls.Add(panelFirstNameLabel);
        panelFirstName.Controls.Add(boxFirstName);
        panelFirstName.Location = new Point(41, 63);
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
        // boxFirstName
        // 
        boxFirstName.Dock = DockStyle.Bottom;
        boxFirstName.Font = new Font("Segoe UI", 11F);
        boxFirstName.Location = new Point(0, 71);
        boxFirstName.Name = "boxFirstName";
        boxFirstName.Size = new Size(250, 27);
        boxFirstName.TabIndex = 1;
        // 
        // panelLastName
        // 
        panelLastName.Controls.Add(panelLastNameLabel);
        panelLastName.Controls.Add(boxLastName);
        panelLastName.Location = new Point(319, 63);
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
        // boxLastName
        // 
        boxLastName.Dock = DockStyle.Bottom;
        boxLastName.Font = new Font("Segoe UI", 11F);
        boxLastName.Location = new Point(0, 71);
        boxLastName.Name = "boxLastName";
        boxLastName.Size = new Size(250, 27);
        boxLastName.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonCancel);
        panel1.Controls.Add(buttonSave);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 915);
        panel1.Name = "panel1";
        panel1.Size = new Size(1924, 95);
        panel1.TabIndex = 11;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(1455, 22);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(221, 57);
        buttonCancel.TabIndex = 0;
        buttonCancel.Text = "Abbrechen";
        buttonCancel.UseVisualStyleBackColor = true;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(1692, 22);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(220, 57);
        buttonSave.TabIndex = 1;
        buttonSave.Text = "Speichern";
        buttonSave.UseVisualStyleBackColor = true;
        // 
        // FormCustomerNotes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1924, 1010);
        Controls.Add(groupBox2);
        Controls.Add(panelCustomerNumber);
        Controls.Add(panelStatus);
        Controls.Add(groupBox1);
        Controls.Add(panel1);
        Name = "FormCustomerNotes";
        Text = "FormCustomerNotes";
        groupBox2.ResumeLayout(false);
        panelCustomerNumber.ResumeLayout(false);
        panelCustomerNumber.PerformLayout();
        panelCustomerNumberLabel.ResumeLayout(false);
        panelCustomerNumberLabel.PerformLayout();
        panelStatus.ResumeLayout(false);
        panelStatusLabel.ResumeLayout(false);
        panelStatusLabel.PerformLayout();
        groupBox1.ResumeLayout(false);
        panelFirstName.ResumeLayout(false);
        panelFirstName.PerformLayout();
        panelFirstNameLabel.ResumeLayout(false);
        panelFirstNameLabel.PerformLayout();
        panelLastName.ResumeLayout(false);
        panelLastName.PerformLayout();
        panelLastNameLabel.ResumeLayout(false);
        panelLastNameLabel.PerformLayout();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox2;
    private Panel panelCustomerNumber;
    private Panel panelCustomerNumberLabel;
    private Label labelCustomerNumber;
    private TextBox boxCustomerNumber;
    private Panel panelStatus;
    private Panel panelStatusLabel;
    private Label labelStatus;
    private ComboBox boxStatus;
    private GroupBox groupBox1;
    private Panel panelFirstName;
    private Panel panelFirstNameLabel;
    private Label labelFirstName;
    private TextBox boxFirstName;
    private Panel panelLastName;
    private Panel panelLastNameLabel;
    private Label labelLastName;
    private TextBox boxLastName;
    private Panel panel1;
    private Button buttonCancel;
    private Button buttonSave;
    private RichTextBox richTextBox1;
}