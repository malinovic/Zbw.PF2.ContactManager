using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Service.Import;

namespace Zbw.PF2.ContactManager.UI.Partials;

/// <summary>
///     Lets the user pick a CSV file and import its rows as employees, showing progress and a
///     summary of valid/invalid records once the import completes.
/// </summary>
public partial class FormImport : Form
{

    private readonly IImportService _importService;

    /// <summary>
    ///     Initializes a new instance of <see cref="FormImport" />.
    /// </summary>
    public FormImport()
    {
        InitializeComponent();
        SetupView();

        _importService = new ImportService();
    }

    /// <summary>
    ///     Applies the shared button styling to the form's controls.
    /// </summary>
    private void SetupView()
    {
        ThemeManager.ApplyButtonStyles(btnOpenFileDialog);
        ThemeManager.ApplyButtonStyles(btnStartImport);
    }

    /// <summary>
    ///     Opens a file picker for the CSV to import and, once one is chosen, displays its file
    ///     info and enables the import button.
    /// </summary>
    private void btnOpenFileDialog_Click(object sender, EventArgs e)
    {
        var dialogResult = fdCsvImport.ShowDialog();

        if (dialogResult == DialogResult.OK)
        {
            _showFileInfo(fdCsvImport.FileName);
            btnStartImport.Enabled = true;
        }
    }

    /// <summary>
    ///     Displays the selected file's full path and size in the form.
    /// </summary>
    /// <param name="filePath">Full path to the selected CSV file.</param>
    private void _showFileInfo(string filePath)
    {
        var fileInfo = new FileInfo(filePath);
        lblFileName.Text = fileInfo.FullName;
        lblFileSize.Text = $"Dateigröße: {fileInfo.Length / (1024)} Kb";
    }

    /// <summary>
    ///     Runs the employee import against the selected CSV file, reports the result via a
    ///     message box, and closes the form.
    /// </summary>
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
