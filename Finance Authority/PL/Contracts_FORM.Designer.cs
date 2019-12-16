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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contracts_FORM));
            this.Contracts_exit = new MetroFramework.Controls.MetroButton();
            this.Contracts_delete = new MetroFramework.Controls.MetroButton();
            this.Contracts_update = new MetroFramework.Controls.MetroButton();
            this.Contracts_add = new MetroFramework.Controls.MetroButton();
            this.Contracts_new = new MetroFramework.Controls.MetroButton();
            this.Contracts_Gridview = new MetroFramework.Controls.MetroGrid();
            this.Contracts_Date_Start = new MetroFramework.Controls.MetroDateTime();
            this.Contracts_Date_end = new MetroFramework.Controls.MetroDateTime();
            this.Contracts_Comb_Contract_statue = new MetroFramework.Controls.MetroComboBox();
            this.Contracts_Search_All = new MetroFramework.Controls.MetroTextBox();
            this.Contracts_Date_last = new MetroFramework.Controls.MetroDateTime();
            this.Contracts_Date_first = new MetroFramework.Controls.MetroDateTime();
            this.Contracts_Print = new MetroFramework.Controls.MetroButton();
            this.Contracts_Notes = new MetroFramework.Controls.MetroTextBox();
            this.Contracts_Type = new MetroFramework.Controls.MetroTextBox();
            this.Contracts_Comb_Employee = new MetroFramework.Controls.MetroComboBox();
            this.Contracts_Comb_Department = new MetroFramework.Controls.MetroComboBox();
            this.Contracts_Type1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.update = new MetroFramework.Controls.MetroButton();
            this.Contracts_Add_Doc = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Contracts_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Contracts_exit
            // 
            this.Contracts_exit.Highlight = true;
            this.Contracts_exit.Location = new System.Drawing.Point(829, 509);
            this.Contracts_exit.Name = "Contracts_exit";
            this.Contracts_exit.Size = new System.Drawing.Size(87, 37);
            this.Contracts_exit.TabIndex = 12;
            this.Contracts_exit.Text = "خروج";
            this.Contracts_exit.UseSelectable = true;
            this.Contracts_exit.Click += new System.EventHandler(this.Contracts_exit_Click);
            // 
            // Contracts_delete
            // 
            this.Contracts_delete.Enabled = false;
            this.Contracts_delete.Highlight = true;
            this.Contracts_delete.Location = new System.Drawing.Point(613, 509);
            this.Contracts_delete.Name = "Contracts_delete";
            this.Contracts_delete.Size = new System.Drawing.Size(87, 37);
            this.Contracts_delete.TabIndex = 10;
            this.Contracts_delete.Text = "حذف";
            this.Contracts_delete.UseSelectable = true;
            this.Contracts_delete.Click += new System.EventHandler(this.Contracts_delete_Click);
            // 
            // Contracts_update
            // 
            this.Contracts_update.Enabled = false;
            this.Contracts_update.Highlight = true;
            this.Contracts_update.Location = new System.Drawing.Point(505, 509);
            this.Contracts_update.Name = "Contracts_update";
            this.Contracts_update.Size = new System.Drawing.Size(87, 37);
            this.Contracts_update.TabIndex = 9;
            this.Contracts_update.Text = "تعديل";
            this.Contracts_update.UseSelectable = true;
            this.Contracts_update.Click += new System.EventHandler(this.Contracts_update_Click);
            // 
            // Contracts_add
            // 
            this.Contracts_add.Enabled = false;
            this.Contracts_add.Highlight = true;
            this.Contracts_add.Location = new System.Drawing.Point(397, 509);
            this.Contracts_add.Name = "Contracts_add";
            this.Contracts_add.Size = new System.Drawing.Size(87, 37);
            this.Contracts_add.TabIndex = 8;
            this.Contracts_add.Text = "أضافة";
            this.Contracts_add.UseSelectable = true;
            this.Contracts_add.Click += new System.EventHandler(this.Contracts_add_Click);
            // 
            // Contracts_new
            // 
            this.Contracts_new.Highlight = true;
            this.Contracts_new.Location = new System.Drawing.Point(289, 509);
            this.Contracts_new.Name = "Contracts_new";
            this.Contracts_new.Size = new System.Drawing.Size(87, 37);
            this.Contracts_new.TabIndex = 7;
            this.Contracts_new.Text = "جديد";
            this.Contracts_new.UseSelectable = true;
            this.Contracts_new.Click += new System.EventHandler(this.Contracts_new_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Contracts_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Contracts_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Contracts_Gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.Contracts_Gridview.EnableHeadersVisualStyles = false;
            this.Contracts_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Contracts_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Contracts_Gridview.Location = new System.Drawing.Point(268, 107);
            this.Contracts_Gridview.Name = "Contracts_Gridview";
            this.Contracts_Gridview.ReadOnly = true;
            this.Contracts_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Contracts_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Contracts_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Contracts_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Contracts_Gridview.Size = new System.Drawing.Size(669, 383);
            this.Contracts_Gridview.TabIndex = 50;
            this.Contracts_Gridview.Click += new System.EventHandler(this.Contracts_Gridview_Click);
            // 
            // Contracts_Date_Start
            // 
            this.Contracts_Date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Contracts_Date_Start.Location = new System.Drawing.Point(99, 155);
            this.Contracts_Date_Start.MinimumSize = new System.Drawing.Size(0, 29);
            this.Contracts_Date_Start.Name = "Contracts_Date_Start";
            this.Contracts_Date_Start.RightToLeftLayout = true;
            this.Contracts_Date_Start.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Date_Start.TabIndex = 1;
            // 
            // Contracts_Date_end
            // 
            this.Contracts_Date_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Contracts_Date_end.Location = new System.Drawing.Point(99, 209);
            this.Contracts_Date_end.MinimumSize = new System.Drawing.Size(0, 29);
            this.Contracts_Date_end.Name = "Contracts_Date_end";
            this.Contracts_Date_end.RightToLeftLayout = true;
            this.Contracts_Date_end.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Date_end.TabIndex = 2;
            // 
            // Contracts_Comb_Contract_statue
            // 
            this.Contracts_Comb_Contract_statue.FormattingEnabled = true;
            this.Contracts_Comb_Contract_statue.ItemHeight = 23;
            this.Contracts_Comb_Contract_statue.Items.AddRange(new object[] {
            "خبرة",
            "مؤقت",
            "أختصاص"});
            this.Contracts_Comb_Contract_statue.Location = new System.Drawing.Point(99, 263);
            this.Contracts_Comb_Contract_statue.Name = "Contracts_Comb_Contract_statue";
            this.Contracts_Comb_Contract_statue.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Comb_Contract_statue.TabIndex = 3;
            this.Contracts_Comb_Contract_statue.UseSelectable = true;
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
            this.Contracts_Print.Location = new System.Drawing.Point(721, 509);
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
            this.Contracts_Notes.Lines = new string[0];
            this.Contracts_Notes.Location = new System.Drawing.Point(99, 317);
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
            // Contracts_Type
            // 
            // 
            // 
            // 
            this.Contracts_Type.CustomButton.Image = null;
            this.Contracts_Type.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.Contracts_Type.CustomButton.Name = "";
            this.Contracts_Type.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Contracts_Type.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Contracts_Type.CustomButton.TabIndex = 1;
            this.Contracts_Type.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Contracts_Type.CustomButton.UseSelectable = true;
            this.Contracts_Type.CustomButton.Visible = false;
            this.Contracts_Type.Lines = new string[0];
            this.Contracts_Type.Location = new System.Drawing.Point(99, 107);
            this.Contracts_Type.MaxLength = 32767;
            this.Contracts_Type.Name = "Contracts_Type";
            this.Contracts_Type.PasswordChar = '\0';
            this.Contracts_Type.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Contracts_Type.SelectedText = "";
            this.Contracts_Type.SelectionLength = 0;
            this.Contracts_Type.SelectionStart = 0;
            this.Contracts_Type.ShortcutsEnabled = true;
            this.Contracts_Type.Size = new System.Drawing.Size(163, 23);
            this.Contracts_Type.TabIndex = 193;
            this.Contracts_Type.UseSelectable = true;
            this.Contracts_Type.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Contracts_Type.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Contracts_Comb_Employee
            // 
            this.Contracts_Comb_Employee.FormattingEnabled = true;
            this.Contracts_Comb_Employee.ItemHeight = 23;
            this.Contracts_Comb_Employee.Items.AddRange(new object[] {
            "خبرة",
            "مؤقت",
            "أختصاص"});
            this.Contracts_Comb_Employee.Location = new System.Drawing.Point(99, 419);
            this.Contracts_Comb_Employee.Name = "Contracts_Comb_Employee";
            this.Contracts_Comb_Employee.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Comb_Employee.TabIndex = 194;
            this.Contracts_Comb_Employee.UseSelectable = true;
            // 
            // Contracts_Comb_Department
            // 
            this.Contracts_Comb_Department.FormattingEnabled = true;
            this.Contracts_Comb_Department.ItemHeight = 23;
            this.Contracts_Comb_Department.Items.AddRange(new object[] {
            "خبرة",
            "مؤقت",
            "أختصاص"});
            this.Contracts_Comb_Department.Location = new System.Drawing.Point(99, 365);
            this.Contracts_Comb_Department.Name = "Contracts_Comb_Department";
            this.Contracts_Comb_Department.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Comb_Department.TabIndex = 195;
            this.Contracts_Comb_Department.UseSelectable = true;
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
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
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
            this.metroLabel7.Location = new System.Drawing.Point(10, 429);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 19);
            this.metroLabel7.TabIndex = 226;
            this.metroLabel7.Text = "الموظفين";
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
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(10, 375);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(48, 19);
            this.metroLabel9.TabIndex = 228;
            this.metroLabel9.Text = "الأقسام";
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
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Contracts_Add_Doc
            // 
            this.Contracts_Add_Doc.Highlight = true;
            this.Contracts_Add_Doc.Location = new System.Drawing.Point(99, 509);
            this.Contracts_Add_Doc.Name = "Contracts_Add_Doc";
            this.Contracts_Add_Doc.Size = new System.Drawing.Size(87, 37);
            this.Contracts_Add_Doc.TabIndex = 265;
            this.Contracts_Add_Doc.Text = "اضافة وثيقة";
            this.Contracts_Add_Doc.UseSelectable = true;
            this.Contracts_Add_Doc.Click += new System.EventHandler(this.Contracts_Add_Doc_Click);
            // 
            // Contracts_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 556);
            this.Controls.Add(this.Contracts_Add_Doc);
            this.Controls.Add(this.update);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Contracts_Type1);
            this.Controls.Add(this.Contracts_Comb_Department);
            this.Controls.Add(this.Contracts_Comb_Employee);
            this.Controls.Add(this.Contracts_Type);
            this.Controls.Add(this.Contracts_Notes);
            this.Controls.Add(this.Contracts_Print);
            this.Controls.Add(this.Contracts_Date_last);
            this.Controls.Add(this.Contracts_Date_first);
            this.Controls.Add(this.Contracts_Search_All);
            this.Controls.Add(this.Contracts_Comb_Contract_statue);
            this.Controls.Add(this.Contracts_Date_end);
            this.Controls.Add(this.Contracts_Date_Start);
            this.Controls.Add(this.Contracts_exit);
            this.Controls.Add(this.Contracts_delete);
            this.Controls.Add(this.Contracts_update);
            this.Controls.Add(this.Contracts_add);
            this.Controls.Add(this.Contracts_new);
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
        private MetroFramework.Controls.MetroButton Contracts_delete;
        private MetroFramework.Controls.MetroButton Contracts_update;
        private MetroFramework.Controls.MetroButton Contracts_add;
        private MetroFramework.Controls.MetroButton Contracts_new;
        private MetroFramework.Controls.MetroGrid Contracts_Gridview;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_Start;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_end;
        private MetroFramework.Controls.MetroComboBox Contracts_Comb_Contract_statue;
        private MetroFramework.Controls.MetroTextBox Contracts_Search_All;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_last;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_first;
        private MetroFramework.Controls.MetroButton Contracts_Print;
        private MetroFramework.Controls.MetroTextBox Contracts_Notes;
        private MetroFramework.Controls.MetroTextBox Contracts_Type;
        private MetroFramework.Controls.MetroComboBox Contracts_Comb_Employee;
        private MetroFramework.Controls.MetroComboBox Contracts_Comb_Department;
        private MetroFramework.Controls.MetroLabel Contracts_Type1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton update;
        private MetroFramework.Controls.MetroButton Contracts_Add_Doc;
    }
}