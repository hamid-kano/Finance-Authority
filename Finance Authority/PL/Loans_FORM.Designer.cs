namespace Finance_Authority.PL
{
    partial class Loans_FORM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loans_FORM));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Loans_Fexit = new MetroFramework.Controls.MetroButton();
            this.Loans_delete = new MetroFramework.Controls.MetroButton();
            this.Loans_update = new MetroFramework.Controls.MetroButton();
            this.Loans_add = new MetroFramework.Controls.MetroButton();
            this.Loans_new = new MetroFramework.Controls.MetroButton();
            this.Loans_Gridview = new MetroFramework.Controls.MetroGrid();
            this.Loans_Date = new MetroFramework.Controls.MetroDateTime();
            this.Loans_Date_Start = new MetroFramework.Controls.MetroDateTime();
            this.Loans_Comb_Budget = new MetroFramework.Controls.MetroComboBox();
            this.Loans_Comb_Department = new MetroFramework.Controls.MetroComboBox();
            this.Loans_Comb_Employ = new MetroFramework.Controls.MetroComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Loans_Search_Budget = new MetroFramework.Controls.MetroComboBox();
            this.Loans_Print = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Loans_Notes = new MetroFramework.Controls.MetroTextBox();
            this.Loans_Amont = new MetroFramework.Controls.MetroTextBox();
            this.Loans_Search_All = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.update = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loans_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Loans_Fexit
            // 
            this.Loans_Fexit.Highlight = true;
            this.Loans_Fexit.Location = new System.Drawing.Point(820, 479);
            this.Loans_Fexit.Name = "Loans_Fexit";
            this.Loans_Fexit.Size = new System.Drawing.Size(87, 37);
            this.Loans_Fexit.TabIndex = 12;
            this.Loans_Fexit.Text = "خروج";
            this.Loans_Fexit.UseSelectable = true;
            this.Loans_Fexit.Click += new System.EventHandler(this.Loans_Fexit_Click);
            // 
            // Loans_delete
            // 
            this.Loans_delete.Enabled = false;
            this.Loans_delete.Highlight = true;
            this.Loans_delete.Location = new System.Drawing.Point(600, 479);
            this.Loans_delete.Name = "Loans_delete";
            this.Loans_delete.Size = new System.Drawing.Size(87, 37);
            this.Loans_delete.TabIndex = 10;
            this.Loans_delete.Text = "حذف";
            this.Loans_delete.UseSelectable = true;
            this.Loans_delete.Click += new System.EventHandler(this.Loans_delete_Click);
            // 
            // Loans_update
            // 
            this.Loans_update.Enabled = false;
            this.Loans_update.Highlight = true;
            this.Loans_update.Location = new System.Drawing.Point(490, 479);
            this.Loans_update.Name = "Loans_update";
            this.Loans_update.Size = new System.Drawing.Size(87, 37);
            this.Loans_update.TabIndex = 9;
            this.Loans_update.Text = "تعديل";
            this.Loans_update.UseSelectable = true;
            this.Loans_update.Click += new System.EventHandler(this.Loans_update_Click);
            // 
            // Loans_add
            // 
            this.Loans_add.Enabled = false;
            this.Loans_add.Highlight = true;
            this.Loans_add.Location = new System.Drawing.Point(380, 479);
            this.Loans_add.Name = "Loans_add";
            this.Loans_add.Size = new System.Drawing.Size(87, 37);
            this.Loans_add.TabIndex = 8;
            this.Loans_add.Text = "أضافة";
            this.Loans_add.UseSelectable = true;
            this.Loans_add.Click += new System.EventHandler(this.Loans_add_Click);
            // 
            // Loans_new
            // 
            this.Loans_new.Highlight = true;
            this.Loans_new.Location = new System.Drawing.Point(270, 479);
            this.Loans_new.Name = "Loans_new";
            this.Loans_new.Size = new System.Drawing.Size(87, 37);
            this.Loans_new.TabIndex = 7;
            this.Loans_new.Text = "جديد";
            this.Loans_new.UseSelectable = true;
            this.Loans_new.Click += new System.EventHandler(this.Loans_new_Click);
            // 
            // Loans_Gridview
            // 
            this.Loans_Gridview.AllowUserToAddRows = false;
            this.Loans_Gridview.AllowUserToDeleteRows = false;
            this.Loans_Gridview.AllowUserToResizeRows = false;
            this.Loans_Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Loans_Gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Loans_Gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Loans_Gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Loans_Gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Loans_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Loans_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Loans_Gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.Loans_Gridview.EnableHeadersVisualStyles = false;
            this.Loans_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Loans_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Loans_Gridview.Location = new System.Drawing.Point(296, 90);
            this.Loans_Gridview.Name = "Loans_Gridview";
            this.Loans_Gridview.ReadOnly = true;
            this.Loans_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Loans_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Loans_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Loans_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Loans_Gridview.Size = new System.Drawing.Size(652, 377);
            this.Loans_Gridview.TabIndex = 50;
            this.Loans_Gridview.Click += new System.EventHandler(this.Loans_Gridview_Click);
            // 
            // Loans_Date
            // 
            this.Loans_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Loans_Date.Location = new System.Drawing.Point(127, 184);
            this.Loans_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.Loans_Date.Name = "Loans_Date";
            this.Loans_Date.Size = new System.Drawing.Size(163, 29);
            this.Loans_Date.TabIndex = 2;
            // 
            // Loans_Date_Start
            // 
            this.Loans_Date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Loans_Date_Start.Location = new System.Drawing.Point(127, 230);
            this.Loans_Date_Start.MinimumSize = new System.Drawing.Size(0, 29);
            this.Loans_Date_Start.Name = "Loans_Date_Start";
            this.Loans_Date_Start.Size = new System.Drawing.Size(163, 29);
            this.Loans_Date_Start.TabIndex = 3;
            // 
            // Loans_Comb_Budget
            // 
            this.Loans_Comb_Budget.FormattingEnabled = true;
            this.Loans_Comb_Budget.ItemHeight = 23;
            this.Loans_Comb_Budget.Location = new System.Drawing.Point(127, 279);
            this.Loans_Comb_Budget.Name = "Loans_Comb_Budget";
            this.Loans_Comb_Budget.Size = new System.Drawing.Size(163, 29);
            this.Loans_Comb_Budget.TabIndex = 4;
            this.Loans_Comb_Budget.UseSelectable = true;
            // 
            // Loans_Comb_Department
            // 
            this.Loans_Comb_Department.FormattingEnabled = true;
            this.Loans_Comb_Department.ItemHeight = 23;
            this.Loans_Comb_Department.Location = new System.Drawing.Point(127, 331);
            this.Loans_Comb_Department.Name = "Loans_Comb_Department";
            this.Loans_Comb_Department.Size = new System.Drawing.Size(163, 29);
            this.Loans_Comb_Department.TabIndex = 5;
            this.Loans_Comb_Department.UseSelectable = true;
            this.Loans_Comb_Department.SelectedValueChanged += new System.EventHandler(this.Loans_Comb_Department_SelectedValueChanged);
            // 
            // Loans_Comb_Employ
            // 
            this.Loans_Comb_Employ.FormattingEnabled = true;
            this.Loans_Comb_Employ.ItemHeight = 23;
            this.Loans_Comb_Employ.Location = new System.Drawing.Point(127, 378);
            this.Loans_Comb_Employ.Name = "Loans_Comb_Employ";
            this.Loans_Comb_Employ.Size = new System.Drawing.Size(163, 29);
            this.Loans_Comb_Employ.TabIndex = 6;
            this.Loans_Comb_Employ.UseSelectable = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(654, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 195;
            this.label9.Text = "تاريخ الميزانية";
            // 
            // Loans_Search_Budget
            // 
            this.Loans_Search_Budget.FormattingEnabled = true;
            this.Loans_Search_Budget.ItemHeight = 23;
            this.Loans_Search_Budget.Location = new System.Drawing.Point(742, 48);
            this.Loans_Search_Budget.Name = "Loans_Search_Budget";
            this.Loans_Search_Budget.Size = new System.Drawing.Size(163, 29);
            this.Loans_Search_Budget.TabIndex = 14;
            this.Loans_Search_Budget.UseSelectable = true;
            this.Loans_Search_Budget.SelectedValueChanged += new System.EventHandler(this.Loans_Search_Budget_SelectedValueChanged);
            // 
            // Loans_Print
            // 
            this.Loans_Print.Highlight = true;
            this.Loans_Print.Location = new System.Drawing.Point(710, 478);
            this.Loans_Print.Name = "Loans_Print";
            this.Loans_Print.Size = new System.Drawing.Size(87, 38);
            this.Loans_Print.TabIndex = 11;
            this.Loans_Print.Text = "طباعة";
            this.Loans_Print.UseSelectable = true;
            this.Loans_Print.Click += new System.EventHandler(this.Loans_Print_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 184);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(34, 19);
            this.metroLabel6.TabIndex = 230;
            this.metroLabel6.Text = "تاريخ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(2, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 229;
            this.metroLabel3.Text = "الملاحظات";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(2, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 228;
            this.metroLabel2.Text = "المبلغ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(0, 289);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 19);
            this.metroLabel7.TabIndex = 233;
            this.metroLabel7.Text = "تاريخ الميزانية";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(2, 339);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 232;
            this.metroLabel5.Text = "الاقسام";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(2, 389);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 231;
            this.metroLabel4.Text = "الموظفين";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(2, 240);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 234;
            this.metroLabel1.Text = "تاريخ بداية الحساب";
            // 
            // Loans_Notes
            // 
            // 
            // 
            // 
            this.Loans_Notes.CustomButton.Image = null;
            this.Loans_Notes.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.Loans_Notes.CustomButton.Name = "";
            this.Loans_Notes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Loans_Notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Loans_Notes.CustomButton.TabIndex = 1;
            this.Loans_Notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Loans_Notes.CustomButton.UseSelectable = true;
            this.Loans_Notes.CustomButton.Visible = false;
            this.Loans_Notes.Lines = new string[0];
            this.Loans_Notes.Location = new System.Drawing.Point(127, 135);
            this.Loans_Notes.MaxLength = 32767;
            this.Loans_Notes.Name = "Loans_Notes";
            this.Loans_Notes.PasswordChar = '\0';
            this.Loans_Notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Loans_Notes.SelectedText = "";
            this.Loans_Notes.SelectionLength = 0;
            this.Loans_Notes.SelectionStart = 0;
            this.Loans_Notes.ShortcutsEnabled = true;
            this.Loans_Notes.Size = new System.Drawing.Size(162, 23);
            this.Loans_Notes.TabIndex = 235;
            this.Loans_Notes.UseSelectable = true;
            this.Loans_Notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Loans_Notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Loans_Amont
            // 
            // 
            // 
            // 
            this.Loans_Amont.CustomButton.Image = null;
            this.Loans_Amont.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.Loans_Amont.CustomButton.Name = "";
            this.Loans_Amont.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Loans_Amont.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Loans_Amont.CustomButton.TabIndex = 1;
            this.Loans_Amont.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Loans_Amont.CustomButton.UseSelectable = true;
            this.Loans_Amont.CustomButton.Visible = false;
            this.Loans_Amont.Lines = new string[0];
            this.Loans_Amont.Location = new System.Drawing.Point(127, 86);
            this.Loans_Amont.MaxLength = 32767;
            this.Loans_Amont.Name = "Loans_Amont";
            this.Loans_Amont.PasswordChar = '\0';
            this.Loans_Amont.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Loans_Amont.SelectedText = "";
            this.Loans_Amont.SelectionLength = 0;
            this.Loans_Amont.SelectionStart = 0;
            this.Loans_Amont.ShortcutsEnabled = true;
            this.Loans_Amont.Size = new System.Drawing.Size(162, 23);
            this.Loans_Amont.TabIndex = 236;
            this.Loans_Amont.UseSelectable = true;
            this.Loans_Amont.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Loans_Amont.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Loans_Amont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Loans_Amont_KeyPress);
            // 
            // Loans_Search_All
            // 
            // 
            // 
            // 
            this.Loans_Search_All.CustomButton.Image = null;
            this.Loans_Search_All.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.Loans_Search_All.CustomButton.Name = "";
            this.Loans_Search_All.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Loans_Search_All.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Loans_Search_All.CustomButton.TabIndex = 1;
            this.Loans_Search_All.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Loans_Search_All.CustomButton.UseSelectable = true;
            this.Loans_Search_All.CustomButton.Visible = false;
            this.Loans_Search_All.Lines = new string[0];
            this.Loans_Search_All.Location = new System.Drawing.Point(454, 53);
            this.Loans_Search_All.MaxLength = 32767;
            this.Loans_Search_All.Name = "Loans_Search_All";
            this.Loans_Search_All.PasswordChar = '\0';
            this.Loans_Search_All.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Loans_Search_All.SelectedText = "";
            this.Loans_Search_All.SelectionLength = 0;
            this.Loans_Search_All.SelectionStart = 0;
            this.Loans_Search_All.ShortcutsEnabled = true;
            this.Loans_Search_All.Size = new System.Drawing.Size(162, 23);
            this.Loans_Search_All.TabIndex = 237;
            this.Loans_Search_All.UseSelectable = true;
            this.Loans_Search_All.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Loans_Search_All.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Loans_Search_All.TextChanged += new System.EventHandler(this.Loans_Search_All_TextChanged_1);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(380, 57);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(56, 19);
            this.metroLabel8.TabIndex = 238;
            this.metroLabel8.Text = "بحث عام";
            // 
            // update
            // 
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.update.Location = new System.Drawing.Point(911, 48);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(33, 31);
            this.update.TabIndex = 265;
            this.update.UseSelectable = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Loans_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 539);
            this.Controls.Add(this.update);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.Loans_Search_All);
            this.Controls.Add(this.Loans_Amont);
            this.Controls.Add(this.Loans_Notes);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Loans_Print);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Loans_Search_Budget);
            this.Controls.Add(this.Loans_Comb_Employ);
            this.Controls.Add(this.Loans_Comb_Department);
            this.Controls.Add(this.Loans_Comb_Budget);
            this.Controls.Add(this.Loans_Date_Start);
            this.Controls.Add(this.Loans_Date);
            this.Controls.Add(this.Loans_Fexit);
            this.Controls.Add(this.Loans_delete);
            this.Controls.Add(this.Loans_update);
            this.Controls.Add(this.Loans_add);
            this.Controls.Add(this.Loans_new);
            this.Controls.Add(this.Loans_Gridview);
            this.Name = "Loans_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "القروض";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loans_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton Loans_Fexit;
        private MetroFramework.Controls.MetroButton Loans_delete;
        private MetroFramework.Controls.MetroButton Loans_update;
        private MetroFramework.Controls.MetroButton Loans_add;
        private MetroFramework.Controls.MetroButton Loans_new;
        private MetroFramework.Controls.MetroGrid Loans_Gridview;
        private MetroFramework.Controls.MetroDateTime Loans_Date;
        private MetroFramework.Controls.MetroDateTime Loans_Date_Start;
        private MetroFramework.Controls.MetroComboBox Loans_Comb_Budget;
        private MetroFramework.Controls.MetroComboBox Loans_Comb_Department;
        private MetroFramework.Controls.MetroComboBox Loans_Comb_Employ;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroComboBox Loans_Search_Budget;
        private MetroFramework.Controls.MetroButton Loans_Print;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Loans_Notes;
        private MetroFramework.Controls.MetroTextBox Loans_Amont;
        private MetroFramework.Controls.MetroTextBox Loans_Search_All;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton update;
    }
}