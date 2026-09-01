namespace Zbw.PF2.ContactManager.UI.Partials;

partial class FormUsersPartial
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
        components = new System.ComponentModel.Container();
        btnCreateNewUser = new Button();
        panel1 = new Panel();
        panel2 = new Panel();
        dgvUsers = new DataGridView();
        usersBindingSource = new BindingSource(components);
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
        ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
        SuspendLayout();
        //
        // btnCreateNewUser
        //
        btnCreateNewUser.Location = new Point(13, 13);
        btnCreateNewUser.Name = "btnCreateNewUser";
        btnCreateNewUser.Size = new Size(330, 62);
        btnCreateNewUser.TabIndex = 1;
        btnCreateNewUser.Text = "Neuer Benutzer";
        btnCreateNewUser.UseVisualStyleBackColor = true;
        btnCreateNewUser.Click += BtnCreateNewUser_Click;
        //
        // panel1
        //
        panel1.Controls.Add(btnCreateNewUser);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 1249);
        panel1.Name = "panel1";
        panel1.Size = new Size(2167, 93);
        panel1.TabIndex = 2;
        //
        // panel2
        //
        panel2.Controls.Add(dgvUsers);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(2167, 1249);
        panel2.TabIndex = 3;
        //
        // dgvUsers
        //
        dgvUsers.AllowUserToAddRows = false;
        dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvUsers.AutoGenerateColumns = false;
        dgvUsers.BackgroundColor = Color.White;
        dgvUsers.BorderStyle = BorderStyle.None;
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvUsers.DataSource = usersBindingSource;
        dgvUsers.GridColor = Color.Gainsboro;
        dgvUsers.Location = new Point(0, 0);
        dgvUsers.Name = "dgvUsers";
        dgvUsers.ReadOnly = true;
        dgvUsers.RowHeadersVisible = false;
        dgvUsers.RowHeadersWidth = 82;
        dgvUsers.RowTemplate.Height = 48;
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvUsers.Size = new Size(2167, 1249);
        dgvUsers.TabIndex = 0;
        //
        // FormUsersPartial
        //
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(2167, 1342);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormUsersPartial";
        Text = "FormUsersPartial";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
        ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button btnCreateNewUser;
    private Panel panel1;
    private Panel panel2;
    private DataGridView dgvUsers;
    private BindingSource usersBindingSource;
}
