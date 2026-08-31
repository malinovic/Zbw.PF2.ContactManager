using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Service.Import;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormImport : Form
{

    private readonly IImportService _importService;

    public FormImport()
    {
        InitializeComponent();
        SetupView();

        _importService = new ImportService();
    }

    private void SetupView()
    {
        ThemeManager.ApplyFormStyles(this);
        ThemeManager.ApplyButtonStyles(btnOpenFileDialog);
        ThemeManager.ApplyButtonStyles(btnStartImport);
    }

    private void btnOpenFileDialog_Click(object sender, EventArgs e)
    {
        var dialogResult = fdCsvImport.ShowDialog();

        if (dialogResult == DialogResult.OK)
        {
            _showFileInfo(fdCsvImport.FileName);
            btnStartImport.Enabled = true;
        }
    }

    private void _showFileInfo(string filePath)
    {
        var fileInfo = new FileInfo(filePath);
        lblFileName.Text = fileInfo.FullName;
        lblFileSize.Text = $"Dateigröße: {fileInfo.Length / (1024)} Kb";
    }

    private void btnStartImport_Click(object sender, EventArgs e)
    {
        pbImport.Maximum = _importService.GetTotalAmountOfRecords(fdCsvImport.FileName);

        pbImport.Visible = true;

        bool success = _importService.ImportEmployees(fdCsvImport.FileName, totalRecords: out int totalRecords, validRecords: out int validRecords, invalidRecords: out int invalidRecords, ref pbImport);

        if (success)
        {
            MessageBox.Show("Totale Datensätze: " + totalRecords + "\nGültige Datensätze: " + validRecords + "\nUngültige Datensätze: " + invalidRecords, "Import erfolgreich abgeschlossen");
        }
        else
        {
            MessageBox.Show("Import fehlgeschlagen. Bitte überprüfen Sie die Datei und versuchen Sie es erneut.");
        }

        this.Close();
    }
}
