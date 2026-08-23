using System.ComponentModel;
using System.Drawing.Drawing2D;

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
        button.Font = new Font("Arial", 11F);
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








    internal static void ApplyAddEmployeeLabelAndPanelStyles(Label label, Panel panel)
    {

        label.FlatStyle = FlatStyle.Flat;
        label.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Regular);
        label.ForeColor = Color.Black;
        label.BackColor = Color.Transparent;
        label.Padding = Padding.Empty;
        label.AutoSize = true;
        panel.BackColor = Color.Gainsboro;
        ResizePanelToLabel(label, panel, 1, 1);
        CenterLabelInPanel(label, panel);


    }

    private static void ResizePanelToLabel(
        Label label,
        Panel panel,
        int horizontalPadding = 8,
        int verticalPadding = 4)
    {

        label.AutoSize = true;
        Size labelSize = label.GetPreferredSize(Size.Empty);
        panel.AutoSize = false;
        panel.Dock = DockStyle.None;
        panel.Size = new Size(
        labelSize.Width + horizontalPadding * 2,
        labelSize.Height + verticalPadding * 2);

        label.Location = new Point(
        horizontalPadding,
        verticalPadding);
    }

    internal static void CenterLabelInPanel(
        Label label,
        Panel borderPanel)
    {
        label.Left = (borderPanel.ClientSize.Width - label.Width) / 2;
        label.Top = (borderPanel.ClientSize.Height - label.Height) / 2;
    }


    internal static void AlignComboBoxAndPanel(
    ComboBox comboBox,
    Panel panel,
    int horizontalDistance = 25)
    {
        comboBox.AutoSize = false;
        comboBox.Height = panel.Height;

        comboBox.Location = new Point(
        panel.Right + horizontalDistance,
        panel.Top);
    }


    internal static void AlignTextBoxAndPanel(
    TextBox textBox,
    Panel panel,
    int horizontalDistance = 50)
    {
        textBox.AutoSize = false;
        textBox.Height = panel.Height;

        textBox.Location = new Point(
        panel.Right + horizontalDistance,
        panel.Top);
    }

    internal static void AlignPanelsVertically(
    int verticalDistance,
    params Panel[] panels)
    {
        if (panels.Length == 0)
            return;

        int leftPosition = panels[0].Left;
        int currentTop = panels[0].Top;

        foreach (Panel panel in panels)
        {
            panel.Left = leftPosition;
            panel.Top = currentTop;

            currentTop = panel.Bottom + verticalDistance;
        }
    }

    internal static void AlignTextBoxesVertically(
    int horizontalDistance,
    params (TextBox textBox, Panel panel)[] controls)
    {
        if (controls.Length == 0)
            return;

        int leftPosition = controls[0].panel.Right + horizontalDistance;

        foreach ((TextBox textBox, Panel panel) in controls)
        {
            textBox.Left = leftPosition;
            textBox.Top = panel.Top;
        }
    }


    internal static void AlignComboBoxesVertically(
        int horizontalDistance,
        params (ComboBox comboBox, Panel panel)[] controls)
    {
        if (controls.Length == 0)
            return;

        int leftPosition = controls[0].panel.Right + horizontalDistance;

        foreach ((ComboBox comboBox, Panel panel) in controls)
        {
            comboBox.Left = leftPosition;
            comboBox.Top = panel.Top;
        }
    }







}

