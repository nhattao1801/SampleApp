
namespace SampleApp
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.File = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importFromFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Setting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.languagesJapaneseEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japaneseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalSmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.File.SuspendLayout();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromFileExcelToolStripMenuItem,
            this.exportToFileExcelToolStripMenuItem});
            this.File.Name = "contextMenuStrip1";
            this.File.Size = new System.Drawing.Size(189, 48);
            // 
            // importFromFileExcelToolStripMenuItem
            // 
            this.importFromFileExcelToolStripMenuItem.Name = "importFromFileExcelToolStripMenuItem";
            this.importFromFileExcelToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.importFromFileExcelToolStripMenuItem.Text = "Import from file excel";
            // 
            // exportToFileExcelToolStripMenuItem
            // 
            this.exportToFileExcelToolStripMenuItem.Name = "exportToFileExcelToolStripMenuItem";
            this.exportToFileExcelToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exportToFileExcelToolStripMenuItem.Text = "Export to file excel";
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(61, 4);
            this.Edit.Text = "Edit";
            // 
            // Setting
            // 
            this.Setting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languagesJapaneseEnglishToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.subjectWeightToolStripMenuItem});
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(155, 70);
            this.Setting.Text = "Setting";
            // 
            // languagesJapaneseEnglishToolStripMenuItem
            // 
            this.languagesJapaneseEnglishToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.japaneseToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languagesJapaneseEnglishToolStripMenuItem.Name = "languagesJapaneseEnglishToolStripMenuItem";
            this.languagesJapaneseEnglishToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.languagesJapaneseEnglishToolStripMenuItem.Text = "Languages";
            this.languagesJapaneseEnglishToolStripMenuItem.Click += new System.EventHandler(this.languagesJapaneseEnglishToolStripMenuItem_Click);
            // 
            // japaneseToolStripMenuItem
            // 
            this.japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
            this.japaneseToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.japaneseToolStripMenuItem.Text = "Japanese";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontsizeToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // fontsizeToolStripMenuItem
            // 
            this.fontsizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalSmallToolStripMenuItem,
            this.bigToolStripMenuItem,
            this.smallToolStripMenuItem});
            this.fontsizeToolStripMenuItem.Name = "fontsizeToolStripMenuItem";
            this.fontsizeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fontsizeToolStripMenuItem.Text = "Font-size";
            // 
            // normalSmallToolStripMenuItem
            // 
            this.normalSmallToolStripMenuItem.Name = "normalSmallToolStripMenuItem";
            this.normalSmallToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalSmallToolStripMenuItem.Text = "Normal";
            this.normalSmallToolStripMenuItem.Click += new System.EventHandler(this.normalSmallToolStripMenuItem_Click);
            // 
            // bigToolStripMenuItem
            // 
            this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
            this.bigToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.bigToolStripMenuItem.Text = "Big";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.smallToolStripMenuItem.Text = "Small";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blackToolStripMenuItem.Text = "Black";
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // subjectWeightToolStripMenuItem
            // 
            this.subjectWeightToolStripMenuItem.Name = "subjectWeightToolStripMenuItem";
            this.subjectWeightToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.subjectWeightToolStripMenuItem.Text = "Subject Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(97, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(97, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password\r\n";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(411, 256);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 35);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Login.Location = new System.Drawing.Point(59, 256);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(127, 35);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "OK";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(216, 159);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(224, 20);
            this.txt_password.TabIndex = 10;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(216, 108);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(224, 20);
            this.txt_username.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 338);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Happy Testing - Training management - v1.0.0";
            this.File.ResumeLayout(false);
            this.Setting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip File;
        private System.Windows.Forms.ToolStripMenuItem importFromFileExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToFileExcelToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Edit;
        private System.Windows.Forms.ContextMenuStrip Setting;
        private System.Windows.Forms.ToolStripMenuItem languagesJapaneseEnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontsizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalSmallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem subjectWeightToolStripMenuItem;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
    }
}

