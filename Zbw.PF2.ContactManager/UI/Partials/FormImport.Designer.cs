namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormImport
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
        fdCsvImport = new OpenFileDialog();
        btnOpenFileDialog = new Button();
        lblFileName = new Label();
        btnStartImport = new Button();
        lblFileSize = new Label();
        pbImport = new ProgressBar();
        panel1 = new Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // fdCsvImport
        // 
        fdCsvImport.Filter = "CSV Dateien (*.csv)|*.csv";
        // 
        // btnOpenFileDialog
        // 
        btnOpenFileDialog.Location = new Point(18, 18);
        btnOpenFileDialog.Name = "btnOpenFileDialog";
        btnOpenFileDialog.Size = new Size(241, 52);
        btnOpenFileDialog.TabIndex = 0;
        btnOpenFileDialog.Text = "Datei auswählen";
        btnOpenFileDialog.UseVisualStyleBackColor = true;
        btnOpenFileDialog.Click += btnOpenFileDialog_Click;
        // 
        // lblFileName
        // 
        lblFileName.AutoSize = true;
        lblFileName.Location = new Point(18, 88);
        lblFileName.Name = "lblFileName";
        lblFileName.Size = new Size(0, 30);
        lblFileName.TabIndex = 1;
        // 
        // btnStartImport
        // 
        btnStartImport.Enabled = false;
        btnStartImport.Location = new Point(12, 390);
        btnStartImport.Name = "btnStartImport";
        btnStartImport.Size = new Size(172, 48);
        btnStartImport.TabIndex = 2;
        btnStartImport.Text = "Importieren";
        btnStartImport.UseVisualStyleBackColor = true;
        btnStartImport.Click += btnStartImport_Click;
        // 
        // lblFileSize
        // 
        lblFileSize.AutoSize = true;
        lblFileSize.Location = new Point(18, 129);
        lblFileSize.Name = "lblFileSize";
        lblFileSize.Size = new Size(0, 30);
        lblFileSize.TabIndex = 3;
        // 
        // pbImport
        // 
        pbImport.Location = new Point(280, 390);
        pbImport.Name = "pbImport";
        pbImport.Size = new Size(499, 40);
        pbImport.Style = ProgressBarStyle.Continuous;
        pbImport.TabIndex = 4;
        pbImport.Visible = false;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnOpenFileDialog);
        panel1.Controls.Add(lblFileName);
        panel1.Controls.Add(lblFileSize);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 365);
        panel1.TabIndex = 5;
        // 
        // FormImport
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        Controls.Add(pbImport);
        Controls.Add(btnStartImport);
        MaximizeBox = false;
        Name = "FormImport";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Mitarbeiter importieren";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private OpenFileDialog fdCsvImport;
    private Button btnOpenFileDialog;
    private Label lblFileName;
    private Button btnStartImport;
    private Label lblFileSize;
    private ProgressBar pbImport;
    private Panel panel1;
}