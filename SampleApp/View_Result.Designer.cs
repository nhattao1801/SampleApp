
namespace SampleApp
{
    partial class View_Result
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
            this.btn_details = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selenium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OJTProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OJT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Select = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mn_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(713, 36);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(75, 23);
            this.btn_details.TabIndex = 3;
            this.btn_details.Text = "Details";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1-Feb-2021 ~  31-Mar-2021";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:   3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Meet and above:   2  (67%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Not meet:  1  (33%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trainers: Pham Van Mach, Le Ba Khanh Trinh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Manual,
            this.Selenium,
            this.TA,
            this.OJTProject,
            this.OJT,
            this.FinalPoint,
            this.Rating,
            this.Remarks});
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 357);
            this.dataGridView1.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Manual
            // 
            this.Manual.HeaderText = "Manual";
            this.Manual.Name = "Manual";
            // 
            // Selenium
            // 
            this.Selenium.HeaderText = "Selenium";
            this.Selenium.Name = "Selenium";
            // 
            // TA
            // 
            this.TA.HeaderText = "TA";
            this.TA.Name = "TA";
            // 
            // OJTProject
            // 
            this.OJTProject.HeaderText = "OJT Project";
            this.OJTProject.Name = "OJTProject";
            // 
            // OJT
            // 
            this.OJT.HeaderText = "OJT";
            this.OJT.Name = "OJT";
            // 
            // FinalPoint
            // 
            this.FinalPoint.HeaderText = "Final Point";
            this.FinalPoint.Name = "FinalPoint";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            // 
            // cb_Select
            // 
            this.cb_Select.FormattingEnabled = true;
            this.cb_Select.Location = new System.Drawing.Point(58, 38);
            this.cb_Select.Name = "cb_Select";
            this.cb_Select.Size = new System.Drawing.Size(148, 21);
            this.cb_Select.TabIndex = 11;
            // 
            // mn_bar
            // 
            this.mn_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_file,
            this.tool_edit,
            this.tool_setting});
            this.mn_bar.Location = new System.Drawing.Point(0, 0);
            this.mn_bar.Name = "mn_bar";
            this.mn_bar.Size = new System.Drawing.Size(857, 24);
            this.mn_bar.TabIndex = 14;
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
            // 
            // cl_pink
            // 
            this.cl_pink.Name = "cl_pink";
            this.cl_pink.Size = new System.Drawing.Size(97, 22);
            this.cl_pink.Text = "Pink";
            // 
            // cl_blue
            // 
            this.cl_blue.Name = "cl_blue";
            this.cl_blue.Size = new System.Drawing.Size(97, 22);
            this.cl_blue.Text = "Bue";
            // 
            // mn_suwe
            // 
            this.mn_suwe.Name = "mn_suwe";
            this.mn_suwe.Size = new System.Drawing.Size(154, 22);
            this.mn_suwe.Text = "Subject Weight";
            // 
            // View_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 469);
            this.Controls.Add(this.mn_bar);
            this.Controls.Add(this.cb_Select);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_details);
            this.Name = "View_Result";
            this.Text = "Happy Testing - Training management - v1.0.0";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mn_bar.ResumeLayout(false);
            this.mn_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selenium;
        private System.Windows.Forms.DataGridViewTextBoxColumn TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OJTProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn OJT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
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
        private System.Windows.Forms.ToolStripMenuItem font_small;
        private System.Windows.Forms.ToolStripMenuItem font_big;
        private System.Windows.Forms.ToolStripMenuItem font_normal;
        private System.Windows.Forms.ToolStripMenuItem item_color;
        private System.Windows.Forms.ToolStripMenuItem cl_pink;
        private System.Windows.Forms.ToolStripMenuItem cl_blue;
        private System.Windows.Forms.ToolStripMenuItem mn_suwe;
    }
}