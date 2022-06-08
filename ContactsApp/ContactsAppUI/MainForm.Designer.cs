namespace ContactsAppUI
{
    partial class MainForm
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
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
    this.editButton = new System.Windows.Forms.Button();
    this.addButton = new System.Windows.Forms.Button();
    this.deleteUser = new System.Windows.Forms.Button();
    this.menuStrip = new System.Windows.Forms.MenuStrip();
    this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.findLabel = new System.Windows.Forms.Label();
    this.findBox = new System.Windows.Forms.TextBox();
    this.surnameListBox = new System.Windows.Forms.ListBox();
    this.surnameLabel = new System.Windows.Forms.Label();
    this.nameLabel = new System.Windows.Forms.Label();
    this.birthdayLabel = new System.Windows.Forms.Label();
    this.phoneLabel = new System.Windows.Forms.Label();
    this.emailLabel = new System.Windows.Forms.Label();
    this.vkLabel = new System.Windows.Forms.Label();
    this.surnameBox = new System.Windows.Forms.TextBox();
    this.nameBox = new System.Windows.Forms.TextBox();
    this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
    this.phoneTextBox = new System.Windows.Forms.TextBox();
    this.emailTextBox = new System.Windows.Forms.TextBox();
    this.vkTextBox = new System.Windows.Forms.TextBox();
    this.menuStrip.SuspendLayout();
    this.SuspendLayout();
    // 
    // editButton
    // 
    this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
    this.editButton.Image = global::ContactsAppUI.Properties.Resources.ASX_Edit_grey_16x;
    this.editButton.Location = new System.Drawing.Point(34, 331);
    this.editButton.Name = "editButton";
    this.editButton.Size = new System.Drawing.Size(29, 23);
    this.editButton.TabIndex = 1;
    this.editButton.UseVisualStyleBackColor = true;
    // 
    // addButton
    // 
    this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
    this.addButton.Image = global::ContactsAppUI.Properties.Resources.AddUser_16x;
    this.addButton.Location = new System.Drawing.Point(4, 331);
    this.addButton.Name = "addButton";
    this.addButton.Size = new System.Drawing.Size(24, 23);
    this.addButton.TabIndex = 0;
    this.addButton.UseVisualStyleBackColor = true;
    // 
    // deleteUser
    // 
    this.deleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
    this.deleteUser.Image = global::ContactsAppUI.Properties.Resources.DeleteUser_16x;
    this.deleteUser.Location = new System.Drawing.Point(69, 331);
    this.deleteUser.Name = "deleteUser";
    this.deleteUser.Size = new System.Drawing.Size(24, 23);
    this.deleteUser.TabIndex = 2;
    this.deleteUser.UseVisualStyleBackColor = true;
    // 
    // menuStrip
    // 
    this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
    this.menuStrip.Location = new System.Drawing.Point(0, 0);
    this.menuStrip.Name = "menuStrip";
    this.menuStrip.Size = new System.Drawing.Size(600, 24);
    this.menuStrip.TabIndex = 3;
    this.menuStrip.Text = "menuStrip1";
    // 
    // fileToolStripMenuItem
    // 
    this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
    this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
    this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
    this.fileToolStripMenuItem.Text = "File";
    // 
    // exitToolStripMenuItem
    // 
    this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
    this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
    this.exitToolStripMenuItem.Text = "Exit";
    // 
    // editToolStripMenuItem
    // 
    this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
    this.editToolStripMenuItem.Name = "editToolStripMenuItem";
    this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
    this.editToolStripMenuItem.Text = "Edit";
    // 
    // addContactToolStripMenuItem
    // 
    this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
    this.addContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
    this.addContactToolStripMenuItem.Text = "Add Contact";
    // 
    // editContactToolStripMenuItem
    // 
    this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
    this.editContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
    this.editContactToolStripMenuItem.Text = "Edit Contact";
    // 
    // removeContactToolStripMenuItem
    // 
    this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
    this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
    this.removeContactToolStripMenuItem.Text = "Remove Contact";
    // 
    // helpToolStripMenuItem
    // 
    this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
    this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
    this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
    this.helpToolStripMenuItem.Text = "Help";
    // 
    // aboutToolStripMenuItem
    // 
    this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
    this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
    this.aboutToolStripMenuItem.Text = "About";
    // 
    // findLabel
    // 
    this.findLabel.AutoSize = true;
    this.findLabel.Location = new System.Drawing.Point(1, 27);
    this.findLabel.Name = "findLabel";
    this.findLabel.Size = new System.Drawing.Size(30, 13);
    this.findLabel.TabIndex = 4;
    this.findLabel.Text = "Find:";
    // 
    // findBox
    // 
    this.findBox.Location = new System.Drawing.Point(34, 24);
    this.findBox.Name = "findBox";
    this.findBox.Size = new System.Drawing.Size(162, 20);
    this.findBox.TabIndex = 5;
    // 
    // surnameListBox
    // 
    this.surnameListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
    | System.Windows.Forms.AnchorStyles.Left)));
    this.surnameListBox.FormattingEnabled = true;
    this.surnameListBox.Location = new System.Drawing.Point(4, 47);
    this.surnameListBox.Name = "surnameListBox";
    this.surnameListBox.Size = new System.Drawing.Size(192, 277);
    this.surnameListBox.TabIndex = 6;
    // 
    // surnameLabel
    // 
    this.surnameLabel.AutoSize = true;
    this.surnameLabel.Location = new System.Drawing.Point(213, 50);
    this.surnameLabel.Name = "surnameLabel";
    this.surnameLabel.Size = new System.Drawing.Size(52, 13);
    this.surnameLabel.TabIndex = 7;
    this.surnameLabel.Text = "Surname:";
    // 
    // nameLabel
    // 
    this.nameLabel.AutoSize = true;
    this.nameLabel.Location = new System.Drawing.Point(227, 76);
    this.nameLabel.Name = "nameLabel";
    this.nameLabel.Size = new System.Drawing.Size(38, 13);
    this.nameLabel.TabIndex = 8;
    this.nameLabel.Text = "Name:";
    // 
    // birthdayLabel
    // 
    this.birthdayLabel.AutoSize = true;
    this.birthdayLabel.Location = new System.Drawing.Point(217, 105);
    this.birthdayLabel.Name = "birthdayLabel";
    this.birthdayLabel.Size = new System.Drawing.Size(48, 13);
    this.birthdayLabel.TabIndex = 9;
    this.birthdayLabel.Text = "Birthday:";
    // 
    // phoneLabel
    // 
    this.phoneLabel.AutoSize = true;
    this.phoneLabel.Location = new System.Drawing.Point(224, 128);
    this.phoneLabel.Name = "phoneLabel";
    this.phoneLabel.Size = new System.Drawing.Size(41, 13);
    this.phoneLabel.TabIndex = 10;
    this.phoneLabel.Text = "Phone:";
    // 
    // emailLabel
    // 
    this.emailLabel.AutoSize = true;
    this.emailLabel.Location = new System.Drawing.Point(227, 154);
    this.emailLabel.Name = "emailLabel";
    this.emailLabel.Size = new System.Drawing.Size(38, 13);
    this.emailLabel.TabIndex = 11;
    this.emailLabel.Text = "E-mail:";
    // 
    // vkLabel
    // 
    this.vkLabel.AutoSize = true;
    this.vkLabel.Location = new System.Drawing.Point(220, 180);
    this.vkLabel.Name = "vkLabel";
    this.vkLabel.Size = new System.Drawing.Size(45, 13);
    this.vkLabel.TabIndex = 12;
    this.vkLabel.Text = "vk.com:";
    // 
    // surnameBox
    // 
    this.surnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
    | System.Windows.Forms.AnchorStyles.Right)));
    this.surnameBox.Location = new System.Drawing.Point(271, 47);
    this.surnameBox.Name = "surnameBox";
    this.surnameBox.ReadOnly = true;
    this.surnameBox.Size = new System.Drawing.Size(317, 20);
    this.surnameBox.TabIndex = 13;
    // 
    // nameBox
    // 
    this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
    | System.Windows.Forms.AnchorStyles.Right)));
    this.nameBox.Location = new System.Drawing.Point(271, 73);
    this.nameBox.Name = "nameBox";
    this.nameBox.ReadOnly = true;
    this.nameBox.Size = new System.Drawing.Size(317, 20);
    this.nameBox.TabIndex = 14;
    // 
    // birthdayDateTimePicker
    // 
    this.birthdayDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
    | System.Windows.Forms.AnchorStyles.Right)));
    this.birthdayDateTimePicker.Location = new System.Drawing.Point(271, 99);
    this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
    this.birthdayDateTimePicker.Size = new System.Drawing.Size(120, 20);
    this.birthdayDateTimePicker.TabIndex = 15;
    // 
    // phoneTextBox
    // 
    this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
    | System.Windows.Forms.AnchorStyles.Right)));
    this.phoneTextBox.Location = new System.Drawing.Point(271, 125);
    this.phoneTextBox.Name = "phoneTextBox";
    this.phoneTextBox.ReadOnly = true;
    this.phoneTextBox.Size = new System.Drawing.Size(317, 20);
    this.phoneTextBox.TabIndex = 16;
    // 
    // emailTextBox
    // 
    this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
    | System.Windows.Forms.AnchorStyles.Right)));
    this.emailTextBox.Location = new System.Drawing.Point(271, 151);
    this.emailTextBox.Name = "emailTextBox";
    this.emailTextBox.ReadOnly = true;
    this.emailTextBox.Size = new System.Drawing.Size(317, 20);
    this.emailTextBox.TabIndex = 17;
    // 
    // vkTextBox
    // 
    this.vkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
    | System.Windows.Forms.AnchorStyles.Right)));
    this.vkTextBox.Location = new System.Drawing.Point(271, 177);
    this.vkTextBox.Name = "vkTextBox";
    this.vkTextBox.ReadOnly = true;
    this.vkTextBox.Size = new System.Drawing.Size(317, 20);
    this.vkTextBox.TabIndex = 18;
    // 
    // MainForm
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(600, 366);
    this.Controls.Add(this.vkTextBox);
    this.Controls.Add(this.emailTextBox);
    this.Controls.Add(this.phoneTextBox);
    this.Controls.Add(this.birthdayDateTimePicker);
    this.Controls.Add(this.nameBox);
    this.Controls.Add(this.surnameBox);
    this.Controls.Add(this.vkLabel);
    this.Controls.Add(this.emailLabel);
    this.Controls.Add(this.phoneLabel);
    this.Controls.Add(this.birthdayLabel);
    this.Controls.Add(this.nameLabel);
    this.Controls.Add(this.surnameLabel);
    this.Controls.Add(this.surnameListBox);
    this.Controls.Add(this.findBox);
    this.Controls.Add(this.findLabel);
    this.Controls.Add(this.deleteUser);
    this.Controls.Add(this.editButton);
    this.Controls.Add(this.addButton);
    this.Controls.Add(this.menuStrip);
    //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
    this.Margin = new System.Windows.Forms.Padding(2);
    this.Name = "MainForm";
    this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
    this.Text = "ContactsApp";
    this.Load += new System.EventHandler(this.MainForm_Load);
    this.menuStrip.ResumeLayout(false);
    this.menuStrip.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();

}

#endregion

private System.Windows.Forms.Button addButton;
private System.Windows.Forms.Button editButton;
private System.Windows.Forms.Button deleteUser;
private System.Windows.Forms.MenuStrip menuStrip;
private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
private System.Windows.Forms.Label findLabel;
private System.Windows.Forms.TextBox findBox;
private System.Windows.Forms.ListBox surnameListBox;
private System.Windows.Forms.Label surnameLabel;
private System.Windows.Forms.Label nameLabel;
private System.Windows.Forms.Label birthdayLabel;
private System.Windows.Forms.Label phoneLabel;
private System.Windows.Forms.Label emailLabel;
private System.Windows.Forms.Label vkLabel;
private System.Windows.Forms.TextBox surnameBox;
private System.Windows.Forms.TextBox nameBox;
private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
private System.Windows.Forms.TextBox phoneTextBox;
private System.Windows.Forms.TextBox emailTextBox;
private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
private System.Windows.Forms.TextBox vkTextBox;
    }
}
