using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Core.Theme;

/// <summary>
///     Centralizes the styling applied to forms and controls so the UI has a consistent,
///     flat, modern look regardless of what the Windows Forms designer generates.
/// </summary>
internal static class ThemeManager
{
    internal static void ApplyFormStyles(Form form)
    {
        form.BackColor = Color.White;
    }

    /// <summary>
    ///     Configures a child form to be hosted embedded inside another form's content panel.
    /// </summary>
    /// <param name="form">The form to configure.</param>
    internal static void ApplyEmbeddedFormStyles(Form form)
    {
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
    }

    /// <summary>
    ///     Applies the bold, large-font style used for the main navigation label.
    /// </summary>
    /// <param name="label">The label to style.</param>
    internal static void ApplyNavLabelStyles(Label label)
    {
        label.Font = new Font(FontManager.InterRegular.FontFamily, 20F, FontStyle.Bold);
        label.ForeColor = Color.Black;
    }

    /// <summary>
    ///     Applies the default flat button style.
    /// </summary>
    /// <param name="button">The button to style.</param>
    internal static void ApplyButtonStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font(FontManager.InterRegular.FontFamily, 11F);
        button.BackColor = Color.White;
    }

    /// <summary>
    ///     Applies the flat style used for the currently active navigation button.
    /// </summary>
    /// <param name="button">The button to style.</param>
    internal static void ApplyNavButtonActiveStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Bold);
        button.BackColor = Color.LightGray;
        button.ForeColor = Color.Black;
        button.FlatAppearance.BorderSize = 0;
        button.Cursor = Cursors.Hand;
    }

    /// <summary>
    ///     Applies the flat style used for inactive navigation buttons.
    /// </summary>
    /// <param name="button">The button to style.</param>
    internal static void ApplyNavButtonStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Regular);
        button.BackColor = Color.White;
        button.ForeColor = Color.Black;
        button.FlatAppearance.BorderSize = 0;
        button.Cursor = Cursors.Hand;
    }

    /// <summary>
    ///     Applies the flat, modern look (borders, fonts, colors) used for data grids throughout the app.
    /// </summary>
    /// <param name="grid">The grid to style.</param>
    internal static void ApplyDataGridViewStyles(DataGridView grid)
    {
        grid.BorderStyle = BorderStyle.None;
        grid.BackgroundColor = Color.White;
        grid.GridColor = Color.Gainsboro;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        grid.EnableHeadersVisualStyles = false;
        grid.RowHeadersVisible = false;
        grid.MultiSelect = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        grid.ColumnHeadersHeight = 52;
        grid.RowTemplate.Height = 44;

        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;
        grid.ColumnHeadersDefaultCellStyle.Font = new Font(FontManager.InterRegular.FontFamily, 11F, FontStyle.Bold);
        grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(16, 0, 0, 0);
        grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
        grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.DimGray;
        grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

        grid.DefaultCellStyle.BackColor = Color.White;
        grid.DefaultCellStyle.ForeColor = Color.Black;
        grid.DefaultCellStyle.Font = new Font(FontManager.InterRegular.FontFamily, 11F, FontStyle.Regular);
        grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        grid.DefaultCellStyle.Padding = new Padding(16, 0, 0, 0);
        grid.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
        grid.DefaultCellStyle.SelectionForeColor = Color.Black;

        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
        grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Gainsboro;
        grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
    }

    /// <summary>
    ///     Colors the status combo box's background according to the selected <see cref="Status" />
    ///     (green for active, red for passive, white otherwise).
    /// </summary>
    /// <param name="boxStatus">The status combo box to color.</param>
    public static void ApplyStatusColor(ComboBox boxStatus)
    {
        if (boxStatus.SelectedItem is Status status)
        {
            boxStatus.BackColor = status switch
            {
                Status.Active => Color.LightGreen,
                Status.Passive => Color.LightCoral,
                _ => Color.White
            };
        }
        else
        {
            boxStatus.BackColor = Color.White;
        }
    }
}

