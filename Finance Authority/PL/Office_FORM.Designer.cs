namespace Finance_Authority.PL
{
    partial class Office_FORM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Office_exit = new MetroFramework.Controls.MetroButton();
            this.Office_delete = new MetroFramework.Controls.MetroButton();
            this.Office_update = new MetroFramework.Controls.MetroButton();
            this.Office_add = new MetroFramework.Controls.MetroButton();
            this.Office_new = new MetroFramework.Controls.MetroButton();
            this.Office_Gridview = new MetroFramework.Controls.MetroGrid();
            this.Office_Name = new MetroFramework.Controls.MetroTextBox();
            this.Office_Notes = new MetroFramework.Controls.MetroTextBox();
            this.Office_CombAuthontic = new MetroFramework.Controls.MetroComboBox();
            this.Office_textsearch = new MetroFramework.Controls.MetroTextBox();
            this.Coin_Exc_Sy = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Office_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Office_exit
            // 
            this.Office_exit.Highlight = true;
            this.Office_exit.Location = new System.Drawing.Point(698, 377);
            this.Office_exit.Name = "Office_exit";
            this.Office_exit.Size = new System.Drawing.Size(87, 37);
            this.Office_exit.TabIndex = 7;
            this.Office_exit.Text = "خروج";
            this.Office_exit.UseSelectable = true;
            this.Office_exit.Click += new System.EventHandler(this.Office_exit_Click);
            // 
            // Office_delete
            // 
            this.Office_delete.Enabled = false;
            this.Office_delete.Highlight = true;
            this.Office_delete.Location = new System.Drawing.Point(586, 377);
            this.Office_delete.Name = "Office_delete";
            this.Office_delete.Size = new System.Drawing.Size(87, 37);
            this.Office_delete.TabIndex = 6;
            this.Office_delete.Text = "حذف";
            this.Office_delete.UseSelectable = true;
            this.Office_delete.Click += new System.EventHandler(this.Office_delete_Click);
            // 
            // Office_update
            // 
            this.Office_update.Enabled = false;
            this.Office_update.Highlight = true;
            this.Office_update.Location = new System.Drawing.Point(474, 377);
            this.Office_update.Name = "Office_update";
            this.Office_update.Size = new System.Drawing.Size(87, 37);
            this.Office_update.TabIndex = 5;
            this.Office_update.Text = "تعديل";
            this.Office_update.UseSelectable = true;
            this.Office_update.Click += new System.EventHandler(this.Office_update_Click);
            // 
            // Office_add
            // 
            this.Office_add.Enabled = false;
            this.Office_add.Highlight = true;
            this.Office_add.Location = new System.Drawing.Point(362, 377);
            this.Office_add.Name = "Office_add";
            this.Office_add.Size = new System.Drawing.Size(87, 37);
            this.Office_add.TabIndex = 4;
            this.Office_add.Text = "أضافة";
            this.Office_add.UseSelectable = true;
            this.Office_add.Click += new System.EventHandler(this.Office_add_Click_1);
            // 
            // Office_new
            // 
            this.Office_new.Highlight = true;
            this.Office_new.Location = new System.Drawing.Point(250, 377);
            this.Office_new.Name = "Office_new";
            this.Office_new.Size = new System.Drawing.Size(87, 37);
            this.Office_new.TabIndex = 3;
            this.Office_new.Text = "جديد";
            this.Office_new.UseSelectable = true;
            this.Office_new.Click += new System.EventHandler(this.Office_new_Click);
            // 
            // Office_Gridview
            // 
            this.Office_Gridview.AllowUserToAddRows = false;
            this.Office_Gridview.AllowUserToDeleteRows = false;
            this.Office_Gridview.AllowUserToResizeRows = false;
            this.Office_Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Office_Gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Office_Gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Office_Gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Office_Gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Office_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Office_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Office_Gridview.DefaultCellStyle = dataGridViewCellStyle5;
            this.Office_Gridview.EnableHeadersVisualStyles = false;
            this.Office_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Office_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Office_Gridview.Location = new System.Drawing.Point(267, 87);
            this.Office_Gridview.Name = "Office_Gridview";
            this.Office_Gridview.ReadOnly = true;
            this.Office_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Office_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Office_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Office_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Office_Gridview.Size = new System.Drawing.Size(540, 270);
            this.Office_Gridview.TabIndex = 52;
            this.Office_Gridview.Click += new System.EventHandler(this.Office_Gridview_Click);
            // 
            // Office_Name
            // 
            // 
            // 
            // 
            this.Office_Name.CustomButton.Image = null;
            this.Office_Name.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.Office_Name.CustomButton.Name = "";
            this.Office_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Office_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Office_Name.CustomButton.TabIndex = 1;
            this.Office_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Office_Name.CustomButton.UseSelectable = true;
            this.Office_Name.CustomButton.Visible = false;
            this.Office_Name.Lines = new string[0];
            this.Office_Name.Location = new System.Drawing.Point(89, 127);
            this.Office_Name.MaxLength = 32767;
            this.Office_Name.Name = "Office_Name";
            this.Office_Name.PasswordChar = '\0';
            this.Office_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Office_Name.SelectedText = "";
            this.Office_Name.SelectionLength = 0;
            this.Office_Name.SelectionStart = 0;
            this.Office_Name.ShortcutsEnabled = true;
            this.Office_Name.Size = new System.Drawing.Size(162, 23);
            this.Office_Name.TabIndex = 213;
            this.Office_Name.UseSelectable = true;
            this.Office_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Office_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Office_Notes
            // 
            // 
            // 
            // 
            this.Office_Notes.CustomButton.Image = null;
            this.Office_Notes.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.Office_Notes.CustomButton.Name = "";
            this.Office_Notes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Office_Notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Office_Notes.CustomButton.TabIndex = 1;
            this.Office_Notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Office_Notes.CustomButton.UseSelectable = true;
            this.Office_Notes.CustomButton.Visible = false;
            this.Office_Notes.Lines = new string[0];
            this.Office_Notes.Location = new System.Drawing.Point(87, 185);
            this.Office_Notes.MaxLength = 32767;
            this.Office_Notes.Name = "Office_Notes";
            this.Office_Notes.PasswordChar = '\0';
            this.Office_Notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Office_Notes.SelectedText = "";
            this.Office_Notes.SelectionLength = 0;
            this.Office_Notes.SelectionStart = 0;
            this.Office_Notes.ShortcutsEnabled = true;
            this.Office_Notes.Size = new System.Drawing.Size(162, 23);
            this.Office_Notes.TabIndex = 212;
            this.Office_Notes.UseSelectable = true;
            this.Office_Notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Office_Notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Office_CombAuthontic
            // 
            this.Office_CombAuthontic.FormattingEnabled = true;
            this.Office_CombAuthontic.ItemHeight = 23;
            this.Office_CombAuthontic.Location = new System.Drawing.Point(87, 232);
            this.Office_CombAuthontic.Name = "Office_CombAuthontic";
            this.Office_CombAuthontic.Size = new System.Drawing.Size(163, 29);
            this.Office_CombAuthontic.TabIndex = 214;
            this.Office_CombAuthontic.UseSelectable = true;
            // 
            // Office_textsearch
            // 
            // 
            // 
            // 
            this.Office_textsearch.CustomButton.Image = null;
            this.Office_textsearch.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.Office_textsearch.CustomButton.Name = "";
            this.Office_textsearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Office_textsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Office_textsearch.CustomButton.TabIndex = 1;
            this.Office_textsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Office_textsearch.CustomButton.UseSelectable = true;
            this.Office_textsearch.CustomButton.Visible = false;
            this.Office_textsearch.Lines = new string[0];
            this.Office_textsearch.Location = new System.Drawing.Point(371, 51);
            this.Office_textsearch.MaxLength = 32767;
            this.Office_textsearch.Name = "Office_textsearch";
            this.Office_textsearch.PasswordChar = '\0';
            this.Office_textsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Office_textsearch.SelectedText = "";
            this.Office_textsearch.SelectionLength = 0;
            this.Office_textsearch.SelectionStart = 0;
            this.Office_textsearch.ShortcutsEnabled = true;
            this.Office_textsearch.Size = new System.Drawing.Size(351, 23);
            this.Office_textsearch.TabIndex = 215;
            this.Office_textsearch.UseSelectable = true;
            this.Office_textsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Office_textsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Coin_Exc_Sy
            // 
            this.Coin_Exc_Sy.AutoSize = true;
            this.Coin_Exc_Sy.Location = new System.Drawing.Point(324, 51);
            this.Coin_Exc_Sy.Name = "Coin_Exc_Sy";
            this.Coin_Exc_Sy.Size = new System.Drawing.Size(41, 19);
            this.Coin_Exc_Sy.TabIndex = 222;
            this.Coin_Exc_Sy.Text = "البحث";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-2, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 223;
            this.metroLabel1.Text = "اسم المكتب";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-2, 189);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 224;
            this.metroLabel2.Text = "الملاحظات";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 242);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 225;
            this.metroLabel3.Text = "الهيئة";
            // 
            // Office_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 438);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Coin_Exc_Sy);
            this.Controls.Add(this.Office_textsearch);
            this.Controls.Add(this.Office_CombAuthontic);
            this.Controls.Add(this.Office_Name);
            this.Controls.Add(this.Office_Notes);
            this.Controls.Add(this.Office_exit);
            this.Controls.Add(this.Office_delete);
            this.Controls.Add(this.Office_update);
            this.Controls.Add(this.Office_add);
            this.Controls.Add(this.Office_new);
            this.Controls.Add(this.Office_Gridview);
            this.Name = "Office_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "المكاتب";
            ((System.ComponentModel.ISupportInitialize)(this.Office_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Office_exit;
        private MetroFramework.Controls.MetroButton Office_delete;
        private MetroFramework.Controls.MetroButton Office_update;
        private MetroFramework.Controls.MetroButton Office_add;
        private MetroFramework.Controls.MetroButton Office_new;
        private MetroFramework.Controls.MetroGrid Office_Gridview;
        private MetroFramework.Controls.MetroTextBox Office_Name;
        private MetroFramework.Controls.MetroTextBox Office_Notes;
        private MetroFramework.Controls.MetroComboBox Office_CombAuthontic;
        private MetroFramework.Controls.MetroTextBox Office_textsearch;
        private MetroFramework.Controls.MetroLabel Coin_Exc_Sy;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}