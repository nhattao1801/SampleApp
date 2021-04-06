
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mn_bar = new System.Windows.Forms.MenuStrip();
            this.tool_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_import = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_export = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_lang = new System.Windows.Forms.ToolStripMenuItem();
            this.item_japanese = new System.Windows.Forms.ToolStripMenuItem();
            this.item_eng = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_themes = new System.Windows.Forms.ToolStripMenuItem();
            this.item_font = new System.Windows.Forms.ToolStripMenuItem();
            this.font_small = new System.Windows.Forms.ToolStripMenuItem();
            this.font_big = new System.Windows.Forms.ToolStripMenuItem();
            this.font_normal = new System.Windows.Forms.ToolStripMenuItem();
            this.item_color = new System.Windows.Forms.ToolStripMenuItem();
            this.cl_pink = new System.Windows.Forms.ToolStripMenuItem();
            this.cl_blue = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_suwe = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(56, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(56, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password\r\n";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Cancel.Location = new System.Drawing.Point(373, 213);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 35);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Login.Location = new System.Drawing.Point(247, 213);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(71, 35);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "OK";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(168, 161);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(276, 20);
            this.txt_password.TabIndex = 10;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(168, 110);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(276, 20);
            this.txt_username.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(164, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Please enter user name and password";
            // 
            // mn_bar
            // 
            this.mn_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_file,
            this.tool_edit,
            this.tool_setting});
            this.mn_bar.Location = new System.Drawing.Point(0, 0);
            this.mn_bar.Name = "mn_bar";
            this.mn_bar.Size = new System.Drawing.Size(581, 24);
            this.mn_bar.TabIndex = 13;
            this.mn_bar.Text = "File";
            // 
            // tool_file
            // 
            this.tool_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_import,
            this.mn_export});
            this.tool_file.Name = "tool_file";
            this.tool_file.Size = new System.Drawing.Size(37, 20);
            this.tool_file.Text = "File";
            // 
            // mn_import
            // 
            this.mn_import.Name = "mn_import";
            this.mn_import.Size = new System.Drawing.Size(188, 22);
            this.mn_import.Text = "Import from file Excel";
            // 
            // mn_export
            // 
            this.mn_export.Name = "mn_export";
            this.mn_export.Size = new System.Drawing.Size(188, 22);
            this.mn_export.Text = "Export to file Excel";
            // 
            // tool_edit
            // 
            this.tool_edit.Name = "tool_edit";
            this.tool_edit.Size = new System.Drawing.Size(39, 20);
            this.tool_edit.Text = "Edit";
            // 
            // tool_setting
            // 
            this.tool_setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_lang,
            this.mn_themes,
            this.mn_suwe});
            this.tool_setting.Name = "tool_setting";
            this.tool_setting.Size = new System.Drawing.Size(56, 20);
            this.tool_setting.Text = "Setting";
            // 
            // mn_lang
            // 
            this.mn_lang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_japanese,
            this.item_eng});
            this.mn_lang.Name = "mn_lang";
            this.mn_lang.Size = new System.Drawing.Size(154, 22);
            this.mn_lang.Text = "Languages";
            this.mn_lang.Click += new System.EventHandler(this.mn_lang_Click);
            // 
            // item_japanese
            // 
            this.item_japanese.Name = "item_japanese";
            this.item_japanese.Size = new System.Drawing.Size(121, 22);
            this.item_japanese.Text = "Japanese";
            // 
            // item_eng
            // 
            this.item_eng.Name = "item_eng";
            this.item_eng.Size = new System.Drawing.Size(121, 22);
            this.item_eng.Text = "English";
            // 
            // mn_themes
            // 
            this.mn_themes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_font,
            this.item_color});
            this.mn_themes.Name = "mn_themes";
            this.mn_themes.Size = new System.Drawing.Size(154, 22);
            this.mn_themes.Text = "Themes";
            // 
            // item_font
            // 
            this.item_font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font_small,
            this.font_big,
            this.font_normal});
            this.item_font.Name = "item_font";
            this.item_font.Size = new System.Drawing.Size(131, 22);
            this.item_font.Text = "Font";
            // 
            // font_small
            // 
            this.font_small.Name = "font_small";
            this.font_small.Size = new System.Drawing.Size(114, 22);
            this.font_small.Text = "Small";
            // 
            // font_big
            // 
            this.font_big.Name = "font_big";
            this.font_big.Size = new System.Drawing.Size(114, 22);
            this.font_big.Text = "Big";
            // 
            // font_normal
            // 
            this.font_normal.Name = "font_normal";
            this.font_normal.Size = new System.Drawing.Size(114, 22);
            this.font_normal.Text = "Normal";
            // 
            // item_color
            // 
            this.item_color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cl_pink,
            this.cl_blue});
            this.item_color.Name = "item_color";
            this.item_color.Size = new System.Drawing.Size(131, 22);
            this.item_color.Text = "Back Color";
            this.item_color.Click += new System.EventHandler(this.item_color_Click);
            // 
            // cl_pink
            // 
            this.cl_pink.Name = "cl_pink";
            this.cl_pink.Size = new System.Drawing.Size(97, 22);
            this.cl_pink.Text = "Pink";
            this.cl_pink.Click += new System.EventHandler(this.cl_pink_Click);
            // 
            // cl_blue
            // 
            this.cl_blue.Name = "cl_blue";
            this.cl_blue.Size = new System.Drawing.Size(97, 22);
            this.cl_blue.Text = "Bue";
            this.cl_blue.Click += new System.EventHandler(this.cl_blue_Click);
            // 
            // mn_suwe
            // 
            this.mn_suwe.Name = "mn_suwe";
            this.mn_suwe.Size = new System.Drawing.Size(154, 22);
            this.mn_suwe.Text = "Subject Weight";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 308);
            this.Controls.Add(this.mn_bar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Happy Testing - Training management - v1.0.0";
            this.mn_bar.ResumeLayout(false);
            this.mn_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip mn_bar;
        private System.Windows.Forms.ToolStripMenuItem tool_file;
        private System.Windows.Forms.ToolStripMenuItem mn_import;
        private System.Windows.Forms.ToolStripMenuItem mn_export;
        private System.Windows.Forms.ToolStripMenuItem tool_edit;
        private System.Windows.Forms.ToolStripMenuItem tool_setting;
        private System.Windows.Forms.ToolStripMenuItem mn_lang;
        private System.Windows.Forms.ToolStripMenuItem item_japanese;
        private System.Windows.Forms.ToolStripMenuItem item_eng;
        private System.Windows.Forms.ToolStripMenuItem mn_themes;
        private System.Windows.Forms.ToolStripMenuItem item_font;
        private System.Windows.Forms.ToolStripMenuItem item_color;
        private System.Windows.Forms.ToolStripMenuItem mn_suwe;
        private System.Windows.Forms.ToolStripMenuItem font_small;
        private System.Windows.Forms.ToolStripMenuItem font_big;
        private System.Windows.Forms.ToolStripMenuItem font_normal;
        private System.Windows.Forms.ToolStripMenuItem cl_pink;
        private System.Windows.Forms.ToolStripMenuItem cl_blue;
    }
}

