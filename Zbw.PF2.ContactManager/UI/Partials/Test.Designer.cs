namespace Zbw.PF2.ContactManager.UI.Partials;

partial class Test
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
        button1 = new Button();
        button2 = new Button();
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(1430, 854);
        button1.Name = "button1";
        button1.Size = new Size(150, 46);
        button1.TabIndex = 0;
        button1.Text = "BtnSave";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(1260, 857);
        button2.Name = "button2";
        button2.Size = new Size(150, 46);
        button2.TabIndex = 1;
        button2.Text = "BtnCancel";
        button2.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(808, 258);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(200, 39);
        textBox1.TabIndex = 2;
        // 
        // Test
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1650, 930);
        Controls.Add(textBox1);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "Test";
        Text = "Test";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private TextBox textBox1;
}