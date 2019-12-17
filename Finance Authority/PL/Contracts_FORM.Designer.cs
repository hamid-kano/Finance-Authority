namespace Finance_Authority.PL
{
    partial class Contracts_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contracts_FORM));
            this.Contracts_exit = new MetroFramework.Controls.MetroButton();
            this.Contracts_Details = new MetroFramework.Controls.MetroButton();
            this.Contracts_Gridview = new MetroFramework.Controls.MetroGrid();
            this.Contracts_Date_Start = new MetroFramework.Controls.MetroDateTime();
            this.Contracts_Date_end = new MetroFramework.Controls.MetroDateTime();
            this.Contracts_Search_All = new MetroFramework.Controls.MetroTextBox();
            this.Contracts_Date_last = new MetroFramework.Controls.MetroDateTime();
            this.Contracts_Date_first = new MetroFramework.Controls.MetroDateTime();
            this.Contracts_Print = new MetroFramework.Controls.MetroButton();
            this.Contracts_Notes = new MetroFramework.Controls.MetroTextBox();
            this.Contracts_Type1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.update = new MetroFramework.Controls.MetroButton();
            this.Contracts_Type = new MetroFramework.Controls.MetroComboBox();
            this.Contracts_Comb_Contract_statue = new MetroFramework.Controls.MetroComboBox();
            this.Contracts_Employee = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Contracts_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Contracts_exit
            // 
            this.Contracts_exit.Highlight = true;
            this.Contracts_exit.Location = new System.Drawing.Point(680, 504);
            this.Contracts_exit.Name = "Contracts_exit";
            this.Contracts_exit.Size = new System.Drawing.Size(87, 37);
            this.Contracts_exit.TabIndex = 12;
            this.Contracts_exit.Text = "خروج";
            this.Contracts_exit.UseSelectable = true;
            this.Contracts_exit.Click += new System.EventHandler(this.Contracts_exit_Click);
            // 
            // Contracts_Details
            // 
            this.Contracts_Details.Enabled = false;
            this.Contracts_Details.Highlight = true;
            this.Contracts_Details.Location = new System.Drawing.Point(462, 504);
            this.Contracts_Details.Name = "Contracts_Details";
            this.Contracts_Details.Size = new System.Drawing.Size(87, 37);
            this.Contracts_Details.TabIndex = 7;
            this.Contracts_Details.Text = "تفاصيل";
            this.Contracts_Details.UseSelectable = true;
            this.Contracts_Details.Click += new System.EventHandler(this.Contracts_Details_Click);
            // 
            // Contracts_Gridview
            // 
            this.Contracts_Gridview.AllowUserToAddRows = false;
            this.Contracts_Gridview.AllowUserToDeleteRows = false;
            this.Contracts_Gridview.AllowUserToResizeRows = false;
            this.Contracts_Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Contracts_Gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Contracts_Gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Contracts_Gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Contracts_Gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Contracts_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Contracts_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Contracts_Gridview.DefaultCellStyle = dataGridViewCellStyle5;
            this.Contracts_Gridview.EnableHeadersVisualStyles = false;
            this.Contracts_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Contracts_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Contracts_Gridview.Location = new System.Drawing.Point(268, 107);
            this.Contracts_Gridview.Name = "Contracts_Gridview";
            this.Contracts_Gridview.ReadOnly = true;
            this.Contracts_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Contracts_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Contracts_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Contracts_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Contracts_Gridview.Size = new System.Drawing.Size(669, 383);
            this.Contracts_Gridview.TabIndex = 50;
            this.Contracts_Gridview.Click += new System.EventHandler(this.Contracts_Gridview_Click);
            // 
            // Contracts_Date_Start
            // 
            this.Contracts_Date_Start.Enabled = false;
            this.Contracts_Date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Contracts_Date_Start.Location = new System.Drawing.Point(94, 161);
            this.Contracts_Date_Start.MinimumSize = new System.Drawing.Size(0, 29);
            this.Contracts_Date_Start.Name = "Contracts_Date_Start";
            this.Contracts_Date_Start.RightToLeftLayout = true;
            this.Contracts_Date_Start.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Date_Start.TabIndex = 1;
            // 
            // Contracts_Date_end
            // 
            this.Contracts_Date_end.Enabled = false;
            this.Contracts_Date_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Contracts_Date_end.Location = new System.Drawing.Point(94, 215);
            this.Contracts_Date_end.MinimumSize = new System.Drawing.Size(0, 29);
            this.Contracts_Date_end.Name = "Contracts_Date_end";
            this.Contracts_Date_end.RightToLeftLayout = true;
            this.Contracts_Date_end.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Date_end.TabIndex = 2;
            // 
            // Contracts_Search_All
            // 
            // 
            // 
            // 
            this.Contracts_Search_All.CustomButton.Image = null;
            this.Contracts_Search_All.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.Contracts_Search_All.CustomButton.Name = "";
            this.Contracts_Search_All.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Contracts_Search_All.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Contracts_Search_All.CustomButton.TabIndex = 1;
            this.Contracts_Search_All.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Contracts_Search_All.CustomButton.UseSelectable = true;
            this.Contracts_Search_All.CustomButton.Visible = false;
            this.Contracts_Search_All.Lines = new string[0];
            this.Contracts_Search_All.Location = new System.Drawing.Point(406, 63);
            this.Contracts_Search_All.MaxLength = 32767;
            this.Contracts_Search_All.Name = "Contracts_Search_All";
            this.Contracts_Search_All.PasswordChar = '\0';
            this.Contracts_Search_All.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Contracts_Search_All.SelectedText = "";
            this.Contracts_Search_All.SelectionLength = 0;
            this.Contracts_Search_All.SelectionStart = 0;
            this.Contracts_Search_All.ShortcutsEnabled = true;
            this.Contracts_Search_All.Size = new System.Drawing.Size(158, 23);
            this.Contracts_Search_All.TabIndex = 13;
            this.Contracts_Search_All.UseSelectable = true;
            this.Contracts_Search_All.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Contracts_Search_All.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Contracts_Search_All.TextChanged += new System.EventHandler(this.Contracts_Search_All_TextChanged);
            // 
            // Contracts_Date_last
            // 
            this.Contracts_Date_last.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Contracts_Date_last.Location = new System.Drawing.Point(744, 70);
            this.Contracts_Date_last.MinimumSize = new System.Drawing.Size(0, 29);
            this.Contracts_Date_last.Name = "Contracts_Date_last";
            this.Contracts_Date_last.RightToLeftLayout = true;
            this.Contracts_Date_last.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Date_last.TabIndex = 15;
            this.Contracts_Date_last.ValueChanged += new System.EventHandler(this.Contracts_Date_last_ValueChanged);
            // 
            // Contracts_Date_first
            // 
            this.Contracts_Date_first.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Contracts_Date_first.Location = new System.Drawing.Point(744, 24);
            this.Contracts_Date_first.MinimumSize = new System.Drawing.Size(0, 29);
            this.Contracts_Date_first.Name = "Contracts_Date_first";
            this.Contracts_Date_first.RightToLeftLayout = true;
            this.Contracts_Date_first.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Date_first.TabIndex = 14;
            this.Contracts_Date_first.ValueChanged += new System.EventHandler(this.Contracts_Date_first_ValueChanged);
            // 
            // Contracts_Print
            // 
            this.Contracts_Print.Highlight = true;
            this.Contracts_Print.Location = new System.Drawing.Point(572, 504);
            this.Contracts_Print.Name = "Contracts_Print";
            this.Contracts_Print.Size = new System.Drawing.Size(87, 37);
            this.Contracts_Print.TabIndex = 11;
            this.Contracts_Print.Text = "طباعة";
            this.Contracts_Print.UseSelectable = true;
            this.Contracts_Print.Click += new System.EventHandler(this.Contracts_Print_Click);
            // 
            // Contracts_Notes
            // 
            // 
            // 
            // 
            this.Contracts_Notes.CustomButton.Image = null;
            this.Contracts_Notes.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.Contracts_Notes.CustomButton.Name = "";
            this.Contracts_Notes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Contracts_Notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Contracts_Notes.CustomButton.TabIndex = 1;
            this.Contracts_Notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Contracts_Notes.CustomButton.UseSelectable = true;
            this.Contracts_Notes.CustomButton.Visible = false;
            this.Contracts_Notes.Enabled = false;
            this.Contracts_Notes.Lines = new string[0];
            this.Contracts_Notes.Location = new System.Drawing.Point(94, 323);
            this.Contracts_Notes.MaxLength = 32767;
            this.Contracts_Notes.Name = "Contracts_Notes";
            this.Contracts_Notes.PasswordChar = '\0';
            this.Contracts_Notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Contracts_Notes.SelectedText = "";
            this.Contracts_Notes.SelectionLength = 0;
            this.Contracts_Notes.SelectionStart = 0;
            this.Contracts_Notes.ShortcutsEnabled = true;
            this.Contracts_Notes.Size = new System.Drawing.Size(163, 23);
            this.Contracts_Notes.TabIndex = 192;
            this.Contracts_Notes.UseSelectable = true;
            this.Contracts_Notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Contracts_Notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Contracts_Type1
            // 
            this.Contracts_Type1.AutoSize = true;
            this.Contracts_Type1.Location = new System.Drawing.Point(9, 111);
            this.Contracts_Type1.Name = "Contracts_Type1";
            this.Contracts_Type1.Size = new System.Drawing.Size(58, 19);
            this.Contracts_Type1.TabIndex = 219;
            this.Contracts_Type1.Text = "نوع العقد";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 165);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 220;
            this.metroLabel1.Text = "تاريخ البداية";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 219);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 221;
            this.metroLabel2.Text = "تاريخ النهاية";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(649, 34);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 222;
            this.metroLabel3.Text = "تاريخ البداية";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(650, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 223;
            this.metroLabel4.Text = "تاريخ النهاية";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(344, 63);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 224;
            this.metroLabel5.Text = "بحث عام";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(10, 321);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 225;
            this.metroLabel6.Text = "الملاحظات";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(8, 375);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(81, 19);
            this.metroLabel7.TabIndex = 226;
            this.metroLabel7.Text = "اسم الموظف";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(8, 273);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(66, 19);
            this.metroLabel8.TabIndex = 227;
            this.metroLabel8.Text = "حالة العقود";
            // 
            // update
            // 
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.update.Location = new System.Drawing.Point(584, 55);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(33, 31);
            this.update.TabIndex = 264;
            this.update.UseSelectable = true;
            // 
            // Contracts_Type
            // 
            this.Contracts_Type.Enabled = false;
            this.Contracts_Type.FormattingEnabled = true;
            this.Contracts_Type.ItemHeight = 23;
            this.Contracts_Type.Items.AddRange(new object[] {
            "خبرة",
            "مؤقت",
            "أختصاص"});
            this.Contracts_Type.Location = new System.Drawing.Point(94, 117);
            this.Contracts_Type.Name = "Contracts_Type";
            this.Contracts_Type.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Type.TabIndex = 266;
            this.Contracts_Type.UseSelectable = true;
            // 
            // Contracts_Comb_Contract_statue
            // 
            this.Contracts_Comb_Contract_statue.Enabled = false;
            this.Contracts_Comb_Contract_statue.FormattingEnabled = true;
            this.Contracts_Comb_Contract_statue.ItemHeight = 23;
            this.Contracts_Comb_Contract_statue.Items.AddRange(new object[] {
            "منتهي",
            "غير منتهي"});
            this.Contracts_Comb_Contract_statue.Location = new System.Drawing.Point(93, 275);
            this.Contracts_Comb_Contract_statue.Name = "Contracts_Comb_Contract_statue";
            this.Contracts_Comb_Contract_statue.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Comb_Contract_statue.TabIndex = 267;
            this.Contracts_Comb_Contract_statue.UseSelectable = true;
            // 
            // Contracts_Employee
            // 
            // 
            // 
            // 
            this.Contracts_Employee.CustomButton.Image = null;
            this.Contracts_Employee.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.Contracts_Employee.CustomButton.Name = "";
            this.Contracts_Employee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Contracts_Employee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Contracts_Employee.CustomButton.TabIndex = 1;
            this.Contracts_Employee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Contracts_Employee.CustomButton.UseSelectable = true;
            this.Contracts_Employee.CustomButton.Visible = false;
            this.Contracts_Employee.Enabled = false;
            this.Contracts_Employee.Lines = new string[0];
            this.Contracts_Employee.Location = new System.Drawing.Point(94, 377);
            this.Contracts_Employee.MaxLength = 32767;
            this.Contracts_Employee.Name = "Contracts_Employee";
            this.Contracts_Employee.PasswordChar = '\0';
            this.Contracts_Employee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Contracts_Employee.SelectedText = "";
            this.Contracts_Employee.SelectionLength = 0;
            this.Contracts_Employee.SelectionStart = 0;
            this.Contracts_Employee.ShortcutsEnabled = true;
            this.Contracts_Employee.Size = new System.Drawing.Size(163, 23);
            this.Contracts_Employee.TabIndex = 268;
            this.Contracts_Employee.UseSelectable = true;
            this.Contracts_Employee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Contracts_Employee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Contracts_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 556);
            this.Controls.Add(this.Contracts_Employee);
            this.Controls.Add(this.Contracts_Comb_Contract_statue);
            this.Controls.Add(this.Contracts_Type);
            this.Controls.Add(this.update);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Contracts_Type1);
            this.Controls.Add(this.Contracts_Notes);
            this.Controls.Add(this.Contracts_Print);
            this.Controls.Add(this.Contracts_Date_last);
            this.Controls.Add(this.Contracts_Date_first);
            this.Controls.Add(this.Contracts_Search_All);
            this.Controls.Add(this.Contracts_Date_end);
            this.Controls.Add(this.Contracts_Date_Start);
            this.Controls.Add(this.Contracts_exit);
            this.Controls.Add(this.Contracts_Details);
            this.Controls.Add(this.Contracts_Gridview);
            this.Name = "Contracts_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العقود";
            ((System.ComponentModel.ISupportInitialize)(this.Contracts_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Contracts_exit;
        private MetroFramework.Controls.MetroButton Contracts_Details;
        private MetroFramework.Controls.MetroGrid Contracts_Gridview;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_Start;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_end;
        private MetroFramework.Controls.MetroTextBox Contracts_Search_All;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_last;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_first;
        private MetroFramework.Controls.MetroButton Contracts_Print;
        private MetroFramework.Controls.MetroTextBox Contracts_Notes;
        private MetroFramework.Controls.MetroLabel Contracts_Type1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton update;
        private MetroFramework.Controls.MetroComboBox Contracts_Type;
        private MetroFramework.Controls.MetroComboBox Contracts_Comb_Contract_statue;
        private MetroFramework.Controls.MetroTextBox Contracts_Employee;
    }
}