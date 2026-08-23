using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Core.Theme;

internal static class ThemeManager
{
    internal static void ApplyFormStyles(Form form)
    {
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
    }

    internal static void ApplyNavLabelStyles(Label label)
    {
        label.Font = new Font(FontManager.InterRegular.FontFamily, 20F, FontStyle.Bold);
        label.ForeColor = Color.Black;
    }

    internal static void ApplyButtonStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font(FontManager.InterRegular.FontFamily, 11F);
        button.BackColor = Color.White;
    }

    internal static void ApplyNavButtonActiveStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Bold);
        button.BackColor = Color.LightGray;
        button.ForeColor = Color.Black;
        button.FlatAppearance.BorderSize = 0;
        button.Cursor = Cursors.Hand;
    }

    internal static void ApplyNavButtonStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Regular);
        button.BackColor = Color.White;
        button.ForeColor = Color.Black;
        button.FlatAppearance.BorderSize = 0;
        button.Cursor = Cursors.Hand;
    }

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

