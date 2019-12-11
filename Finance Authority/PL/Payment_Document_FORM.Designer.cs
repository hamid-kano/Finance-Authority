namespace Finance_Authority.PL
{
    partial class Payment_Document_FORM
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
            this.Payment_Document_Date_last = new MetroFramework.Controls.MetroDateTime();
            this.Payment_Document_Date_first = new MetroFramework.Controls.MetroDateTime();
            this.Payment_Document_Comb_Cate = new MetroFramework.Controls.MetroComboBox();
            this.Payment_Document_Comb_Date = new MetroFramework.Controls.MetroComboBox();
            this.Payment_Document_dataGrid = new MetroFramework.Controls.MetroGrid();
            this.Payment_Document_exit = new MetroFramework.Controls.MetroButton();
            this.Payment_Document_delete = new MetroFramework.Controls.MetroButton();
            this.Payment_Document_update = new MetroFramework.Controls.MetroButton();
            this.Payment_Document_add = new MetroFramework.Controls.MetroButton();
            this.Payment_Document_new = new MetroFramework.Controls.MetroButton();
            this.Payment_Document_DateTime = new MetroFramework.Controls.MetroDateTime();
            this.Payment_Document_Print = new MetroFramework.Controls.MetroButton();
            this.Coin_Exc_Sy = new MetroFramework.Controls.MetroLabel();
            this.Payment_Document_Search = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Payment_Document_sy = new MetroFramework.Controls.MetroTextBox();
            this.Payment_Document_no = new MetroFramework.Controls.MetroTextBox();
            this.Payment_Document_rate = new MetroFramework.Controls.MetroTextBox();
            this.Payment_Document_Dollar = new MetroFramework.Controls.MetroTextBox();
            this.Payment_Document_Reason = new MetroFramework.Controls.MetroTextBox();
            this.Payment_Document_No_Order = new MetroFramework.Controls.MetroTextBox();
            this.Payment_Document_Receve = new MetroFramework.Controls.MetroTextBox();
            this.Payment_Document_Notes = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_Document_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Payment_Document_Date_last
            // 
            this.Payment_Document_Date_last.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Payment_Document_Date_last.Location = new System.Drawing.Point(790, 72);
            this.Payment_Document_Date_last.MinimumSize = new System.Drawing.Size(0, 29);
            this.Payment_Document_Date_last.Name = "Payment_Document_Date_last";
            this.Payment_Document_Date_last.RightToLeftLayout = true;
            this.Payment_Document_Date_last.Size = new System.Drawing.Size(188, 29);
            this.Payment_Document_Date_last.TabIndex = 19;
            this.Payment_Document_Date_last.ValueChanged += new System.EventHandler(this.Payment_Document_Date_last_ValueChanged);
            // 
            // Payment_Document_Date_first
            // 
            this.Payment_Document_Date_first.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Payment_Document_Date_first.Location = new System.Drawing.Point(790, 29);
            this.Payment_Document_Date_first.MinimumSize = new System.Drawing.Size(0, 29);
            this.Payment_Document_Date_first.Name = "Payment_Document_Date_first";
            this.Payment_Document_Date_first.RightToLeftLayout = true;
            this.Payment_Document_Date_first.Size = new System.Drawing.Size(188, 29);
            this.Payment_Document_Date_first.TabIndex = 18;
            this.Payment_Document_Date_first.ValueChanged += new System.EventHandler(this.Payment_Document_Date_first_ValueChanged);
            // 
            // Payment_Document_Comb_Cate
            // 
            this.Payment_Document_Comb_Cate.FormattingEnabled = true;
            this.Payment_Document_Comb_Cate.ItemHeight = 23;
            this.Payment_Document_Comb_Cate.Location = new System.Drawing.Point(125, 493);
            this.Payment_Document_Comb_Cate.Name = "Payment_Document_Comb_Cate";
            this.Payment_Document_Comb_Cate.Size = new System.Drawing.Size(188, 29);
            this.Payment_Document_Comb_Cate.TabIndex = 10;
            this.Payment_Document_Comb_Cate.UseSelectable = true;
            // 
            // Payment_Document_Comb_Date
            // 
            this.Payment_Document_Comb_Date.FormattingEnabled = true;
            this.Payment_Document_Comb_Date.ItemHeight = 23;
            this.Payment_Document_Comb_Date.Location = new System.Drawing.Point(125, 450);
            this.Payment_Document_Comb_Date.Name = "Payment_Document_Comb_Date";
            this.Payment_Document_Comb_Date.Size = new System.Drawing.Size(188, 29);
            this.Payment_Document_Comb_Date.TabIndex = 9;
            this.Payment_Document_Comb_Date.UseSelectable = true;
            // 
            // Payment_Document_dataGrid
            // 
            this.Payment_Document_dataGrid.AllowUserToAddRows = false;
            this.Payment_Document_dataGrid.AllowUserToDeleteRows = false;
            this.Payment_Document_dataGrid.AllowUserToResizeRows = false;
            this.Payment_Document_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Payment_Document_dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Payment_Document_dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Payment_Document_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Payment_Document_dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Payment_Document_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Payment_Document_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Payment_Document_dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Payment_Document_dataGrid.EnableHeadersVisualStyles = false;
            this.Payment_Document_dataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Payment_Document_dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Payment_Document_dataGrid.Location = new System.Drawing.Point(319, 106);
            this.Payment_Document_dataGrid.Name = "Payment_Document_dataGrid";
            this.Payment_Document_dataGrid.ReadOnly = true;
            this.Payment_Document_dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Payment_Document_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Payment_Document_dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Payment_Document_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Payment_Document_dataGrid.Size = new System.Drawing.Size(697, 399);
            this.Payment_Document_dataGrid.TabIndex = 147;
            this.Payment_Document_dataGrid.Click += new System.EventHandler(this.Payment_Document_dataGrid_Click);
            // 
            // Payment_Document_exit
            // 
            this.Payment_Document_exit.Highlight = true;
            this.Payment_Document_exit.Location = new System.Drawing.Point(909, 518);
            this.Payment_Document_exit.Name = "Payment_Document_exit";
            this.Payment_Document_exit.Size = new System.Drawing.Size(87, 37);
            this.Payment_Document_exit.TabIndex = 16;
            this.Payment_Document_exit.Text = "خروج";
            this.Payment_Document_exit.UseSelectable = true;
            this.Payment_Document_exit.Click += new System.EventHandler(this.Payment_Document_exit_Click);
            // 
            // Payment_Document_delete
            // 
            this.Payment_Document_delete.Enabled = false;
            this.Payment_Document_delete.Highlight = true;
            this.Payment_Document_delete.Location = new System.Drawing.Point(689, 518);
            this.Payment_Document_delete.Name = "Payment_Document_delete";
            this.Payment_Document_delete.Size = new System.Drawing.Size(87, 37);
            this.Payment_Document_delete.TabIndex = 14;
            this.Payment_Document_delete.Text = "حذف";
            this.Payment_Document_delete.UseSelectable = true;
            this.Payment_Document_delete.Click += new System.EventHandler(this.Payment_Document_delete_Click);
            // 
            // Payment_Document_update
            // 
            this.Payment_Document_update.Enabled = false;
            this.Payment_Document_update.Highlight = true;
            this.Payment_Document_update.Location = new System.Drawing.Point(582, 518);
            this.Payment_Document_update.Name = "Payment_Document_update";
            this.Payment_Document_update.Size = new System.Drawing.Size(87, 37);
            this.Payment_Document_update.TabIndex = 13;
            this.Payment_Document_update.Text = "تعديل";
            this.Payment_Document_update.UseSelectable = true;
            this.Payment_Document_update.Click += new System.EventHandler(this.Payment_Document_update_Click);
            // 
            // Payment_Document_add
            // 
            this.Payment_Document_add.Enabled = false;
            this.Payment_Document_add.Highlight = true;
            this.Payment_Document_add.Location = new System.Drawing.Point(463, 518);
            this.Payment_Document_add.Name = "Payment_Document_add";
            this.Payment_Document_add.Size = new System.Drawing.Size(87, 37);
            this.Payment_Document_add.TabIndex = 12;
            this.Payment_Document_add.Text = "أضافة";
            this.Payment_Document_add.UseSelectable = true;
            this.Payment_Document_add.Click += new System.EventHandler(this.Payment_Document_add_Click);
            // 
            // Payment_Document_new
            // 
            this.Payment_Document_new.Highlight = true;
            this.Payment_Document_new.Location = new System.Drawing.Point(351, 518);
            this.Payment_Document_new.Name = "Payment_Document_new";
            this.Payment_Document_new.Size = new System.Drawing.Size(87, 37);
            this.Payment_Document_new.TabIndex = 11;
            this.Payment_Document_new.Text = "جديد";
            this.Payment_Document_new.UseSelectable = true;
            this.Payment_Document_new.Click += new System.EventHandler(this.Payment_Document_new_Click);
            // 
            // Payment_Document_DateTime
            // 
            this.Payment_Document_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Payment_Document_DateTime.Location = new System.Drawing.Point(125, 370);
            this.Payment_Document_DateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.Payment_Document_DateTime.Name = "Payment_Document_DateTime";
            this.Payment_Document_DateTime.RightToLeftLayout = true;
            this.Payment_Document_DateTime.Size = new System.Drawing.Size(188, 29);
            this.Payment_Document_DateTime.TabIndex = 7;
            // 
            // Payment_Document_Print
            // 
            this.Payment_Document_Print.Highlight = true;
            this.Payment_Document_Print.Location = new System.Drawing.Point(799, 518);
            this.Payment_Document_Print.Name = "Payment_Document_Print";
            this.Payment_Document_Print.Size = new System.Drawing.Size(87, 37);
            this.Payment_Document_Print.TabIndex = 15;
            this.Payment_Document_Print.Text = "طباعة";
            this.Payment_Document_Print.UseSelectable = true;
            this.Payment_Document_Print.Click += new System.EventHandler(this.Payment_Document_Print_Click);
            // 
            // Coin_Exc_Sy
            // 
            this.Coin_Exc_Sy.AutoSize = true;
            this.Coin_Exc_Sy.Location = new System.Drawing.Point(364, 60);
            this.Coin_Exc_Sy.Name = "Coin_Exc_Sy";
            this.Coin_Exc_Sy.Size = new System.Drawing.Size(152, 19);
            this.Coin_Exc_Sy.TabIndex = 223;
            this.Coin_Exc_Sy.Text = "بحث حسب رقم أمر الصرف";
            // 
            // Payment_Document_Search
            // 
            // 
            // 
            // 
            this.Payment_Document_Search.CustomButton.Image = null;
            this.Payment_Document_Search.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Payment_Document_Search.CustomButton.Name = "";
            this.Payment_Document_Search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payment_Document_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_Document_Search.CustomButton.TabIndex = 1;
            this.Payment_Document_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_Document_Search.CustomButton.UseSelectable = true;
            this.Payment_Document_Search.CustomButton.Visible = false;
            this.Payment_Document_Search.Lines = new string[0];
            this.Payment_Document_Search.Location = new System.Drawing.Point(522, 60);
            this.Payment_Document_Search.MaxLength = 32767;
            this.Payment_Document_Search.Name = "Payment_Document_Search";
            this.Payment_Document_Search.PasswordChar = '\0';
            this.Payment_Document_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_Document_Search.SelectedText = "";
            this.Payment_Document_Search.SelectionLength = 0;
            this.Payment_Document_Search.SelectionStart = 0;
            this.Payment_Document_Search.ShortcutsEnabled = true;
            this.Payment_Document_Search.Size = new System.Drawing.Size(188, 23);
            this.Payment_Document_Search.TabIndex = 222;
            this.Payment_Document_Search.UseSelectable = true;
            this.Payment_Document_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_Document_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Payment_Document_Search.TextChanged += new System.EventHandler(this.Payment_Document_Search_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 225;
            this.metroLabel1.Text = "المبلغ بالسوري";
            // 
            // Payment_Document_sy
            // 
            // 
            // 
            // 
            this.Payment_Document_sy.CustomButton.Image = null;
            this.Payment_Document_sy.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Payment_Document_sy.CustomButton.Name = "";
            this.Payment_Document_sy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payment_Document_sy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_Document_sy.CustomButton.TabIndex = 1;
            this.Payment_Document_sy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_Document_sy.CustomButton.UseSelectable = true;
            this.Payment_Document_sy.CustomButton.Visible = false;
            this.Payment_Document_sy.Lines = new string[0];
            this.Payment_Document_sy.Location = new System.Drawing.Point(125, 110);
            this.Payment_Document_sy.MaxLength = 32767;
            this.Payment_Document_sy.Name = "Payment_Document_sy";
            this.Payment_Document_sy.PasswordChar = '\0';
            this.Payment_Document_sy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_Document_sy.SelectedText = "";
            this.Payment_Document_sy.SelectionLength = 0;
            this.Payment_Document_sy.SelectionStart = 0;
            this.Payment_Document_sy.ShortcutsEnabled = true;
            this.Payment_Document_sy.Size = new System.Drawing.Size(188, 23);
            this.Payment_Document_sy.TabIndex = 224;
            this.Payment_Document_sy.UseSelectable = true;
            this.Payment_Document_sy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_Document_sy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Payment_Document_no
            // 
            // 
            // 
            // 
            this.Payment_Document_no.CustomButton.Image = null;
            this.Payment_Document_no.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Payment_Document_no.CustomButton.Name = "";
            this.Payment_Document_no.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payment_Document_no.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_Document_no.CustomButton.TabIndex = 1;
            this.Payment_Document_no.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_Document_no.CustomButton.UseSelectable = true;
            this.Payment_Document_no.CustomButton.Visible = false;
            this.Payment_Document_no.Lines = new string[0];
            this.Payment_Document_no.Location = new System.Drawing.Point(125, 227);
            this.Payment_Document_no.MaxLength = 32767;
            this.Payment_Document_no.Name = "Payment_Document_no";
            this.Payment_Document_no.PasswordChar = '\0';
            this.Payment_Document_no.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_Document_no.SelectedText = "";
            this.Payment_Document_no.SelectionLength = 0;
            this.Payment_Document_no.SelectionStart = 0;
            this.Payment_Document_no.ShortcutsEnabled = true;
            this.Payment_Document_no.Size = new System.Drawing.Size(188, 23);
            this.Payment_Document_no.TabIndex = 226;
            this.Payment_Document_no.UseSelectable = true;
            this.Payment_Document_no.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_Document_no.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Payment_Document_rate
            // 
            // 
            // 
            // 
            this.Payment_Document_rate.CustomButton.Image = null;
            this.Payment_Document_rate.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Payment_Document_rate.CustomButton.Name = "";
            this.Payment_Document_rate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payment_Document_rate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_Document_rate.CustomButton.TabIndex = 1;
            this.Payment_Document_rate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_Document_rate.CustomButton.UseSelectable = true;
            this.Payment_Document_rate.CustomButton.Visible = false;
            this.Payment_Document_rate.Lines = new string[0];
            this.Payment_Document_rate.Location = new System.Drawing.Point(125, 188);
            this.Payment_Document_rate.MaxLength = 32767;
            this.Payment_Document_rate.Name = "Payment_Document_rate";
            this.Payment_Document_rate.PasswordChar = '\0';
            this.Payment_Document_rate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_Document_rate.SelectedText = "";
            this.Payment_Document_rate.SelectionLength = 0;
            this.Payment_Document_rate.SelectionStart = 0;
            this.Payment_Document_rate.ShortcutsEnabled = true;
            this.Payment_Document_rate.Size = new System.Drawing.Size(188, 23);
            this.Payment_Document_rate.TabIndex = 227;
            this.Payment_Document_rate.UseSelectable = true;
            this.Payment_Document_rate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_Document_rate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Payment_Document_Dollar
            // 
            // 
            // 
            // 
            this.Payment_Document_Dollar.CustomButton.Image = null;
            this.Payment_Document_Dollar.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Payment_Document_Dollar.CustomButton.Name = "";
            this.Payment_Document_Dollar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payment_Document_Dollar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_Document_Dollar.CustomButton.TabIndex = 1;
            this.Payment_Document_Dollar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_Document_Dollar.CustomButton.UseSelectable = true;
            this.Payment_Document_Dollar.CustomButton.Visible = false;
            this.Payment_Document_Dollar.Lines = new string[0];
            this.Payment_Document_Dollar.Location = new System.Drawing.Point(125, 149);
            this.Payment_Document_Dollar.MaxLength = 32767;
            this.Payment_Document_Dollar.Name = "Payment_Document_Dollar";
            this.Payment_Document_Dollar.PasswordChar = '\0';
            this.Payment_Document_Dollar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_Document_Dollar.SelectedText = "";
            this.Payment_Document_Dollar.SelectionLength = 0;
            this.Payment_Document_Dollar.SelectionStart = 0;
            this.Payment_Document_Dollar.ShortcutsEnabled = true;
            this.Payment_Document_Dollar.Size = new System.Drawing.Size(188, 23);
            this.Payment_Document_Dollar.TabIndex = 228;
            this.Payment_Document_Dollar.UseSelectable = true;
            this.Payment_Document_Dollar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_Document_Dollar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Payment_Document_Reason
            // 
            // 
            // 
            // 
            this.Payment_Document_Reason.CustomButton.Image = null;
            this.Payment_Document_Reason.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Payment_Document_Reason.CustomButton.Name = "";
            this.Payment_Document_Reason.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payment_Document_Reason.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_Document_Reason.CustomButton.TabIndex = 1;
            this.Payment_Document_Reason.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_Document_Reason.CustomButton.UseSelectable = true;
            this.Payment_Document_Reason.CustomButton.Visible = false;
            this.Payment_Document_Reason.Lines = new string[0];
            this.Payment_Document_Reason.Location = new System.Drawing.Point(125, 298);
            this.Payment_Document_Reason.MaxLength = 32767;
            this.Payment_Document_Reason.Name = "Payment_Document_Reason";
            this.Payment_Document_Reason.PasswordChar = '\0';
            this.Payment_Document_Reason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_Document_Reason.SelectedText = "";
            this.Payment_Document_Reason.SelectionLength = 0;
            this.Payment_Document_Reason.SelectionStart = 0;
            this.Payment_Document_Reason.ShortcutsEnabled = true;
            this.Payment_Document_Reason.Size = new System.Drawing.Size(188, 23);
            this.Payment_Document_Reason.TabIndex = 229;
            this.Payment_Document_Reason.UseSelectable = true;
            this.Payment_Document_Reason.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_Document_Reason.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Payment_Document_No_Order
            // 
            // 
            // 
            // 
            this.Payment_Document_No_Order.CustomButton.Image = null;
            this.Payment_Document_No_Order.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Payment_Document_No_Order.CustomButton.Name = "";
            this.Payment_Document_No_Order.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payment_Document_No_Order.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_Document_No_Order.CustomButton.TabIndex = 1;
            this.Payment_Document_No_Order.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_Document_No_Order.CustomButton.UseSelectable = true;
            this.Payment_Document_No_Order.CustomButton.Visible = false;
            this.Payment_Document_No_Order.Lines = new string[0];
            this.Payment_Document_No_Order.Location = new System.Drawing.Point(125, 259);
            this.Payment_Document_No_Order.MaxLength = 32767;
            this.Payment_Document_No_Order.Name = "Payment_Document_No_Order";
            this.Payment_Document_No_Order.PasswordChar = '\0';
            this.Payment_Document_No_Order.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_Document_No_Order.SelectedText = "";
            this.Payment_Document_No_Order.SelectionLength = 0;
            this.Payment_Document_No_Order.SelectionStart = 0;
            this.Payment_Document_No_Order.ShortcutsEnabled = true;
            this.Payment_Document_No_Order.Size = new System.Drawing.Size(188, 23);
            this.Payment_Document_No_Order.TabIndex = 230;
            this.Payment_Document_No_Order.UseSelectable = true;
            this.Payment_Document_No_Order.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_Document_No_Order.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Payment_Document_Receve
            // 
            // 
            // 
            // 
            this.Payment_Document_Receve.CustomButton.Image = null;
            this.Payment_Document_Receve.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Payment_Document_Receve.CustomButton.Name = "";
            this.Payment_Document_Receve.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payment_Document_Receve.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_Document_Receve.CustomButton.TabIndex = 1;
            this.Payment_Document_Receve.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_Document_Receve.CustomButton.UseSelectable = true;
            this.Payment_Document_Receve.CustomButton.Visible = false;
            this.Payment_Document_Receve.Lines = new string[0];
            this.Payment_Document_Receve.Location = new System.Drawing.Point(125, 337);
            this.Payment_Document_Receve.MaxLength = 32767;
            this.Payment_Document_Receve.Name = "Payment_Document_Receve";
            this.Payment_Document_Receve.PasswordChar = '\0';
            this.Payment_Document_Receve.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_Document_Receve.SelectedText = "";
            this.Payment_Document_Receve.SelectionLength = 0;
            this.Payment_Document_Receve.SelectionStart = 0;
            this.Payment_Document_Receve.ShortcutsEnabled = true;
            this.Payment_Document_Receve.Size = new System.Drawing.Size(188, 23);
            this.Payment_Document_Receve.TabIndex = 231;
            this.Payment_Document_Receve.UseSelectable = true;
            this.Payment_Document_Receve.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_Document_Receve.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Payment_Document_Notes
            // 
            // 
            // 
            // 
            this.Payment_Document_Notes.CustomButton.Image = null;
            this.Payment_Document_Notes.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Payment_Document_Notes.CustomButton.Name = "";
            this.Payment_Document_Notes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Payment_Document_Notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Payment_Document_Notes.CustomButton.TabIndex = 1;
            this.Payment_Document_Notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Payment_Document_Notes.CustomButton.UseSelectable = true;
            this.Payment_Document_Notes.CustomButton.Visible = false;
            this.Payment_Document_Notes.Lines = new string[0];
            this.Payment_Document_Notes.Location = new System.Drawing.Point(125, 415);
            this.Payment_Document_Notes.MaxLength = 32767;
            this.Payment_Document_Notes.Name = "Payment_Document_Notes";
            this.Payment_Document_Notes.PasswordChar = '\0';
            this.Payment_Document_Notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Payment_Document_Notes.SelectedText = "";
            this.Payment_Document_Notes.SelectionLength = 0;
            this.Payment_Document_Notes.SelectionStart = 0;
            this.Payment_Document_Notes.ShortcutsEnabled = true;
            this.Payment_Document_Notes.Size = new System.Drawing.Size(188, 23);
            this.Payment_Document_Notes.TabIndex = 232;
            this.Payment_Document_Notes.UseSelectable = true;
            this.Payment_Document_Notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Payment_Document_Notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(720, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 233;
            this.metroLabel2.Text = "تاريخ البداية";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(721, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 234;
            this.metroLabel3.Text = "تاريخ النهاية";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 188);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 19);
            this.metroLabel4.TabIndex = 235;
            this.metroLabel4.Text = "سعر الصرف";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 263);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 236;
            this.metroLabel5.Text = "رقم امر الصرف";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 302);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 237;
            this.metroLabel6.Text = "السبب";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 337);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 19);
            this.metroLabel7.TabIndex = 238;
            this.metroLabel7.Text = "المستلم";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 370);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 239;
            this.metroLabel8.Text = "التاريخ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 227);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(61, 19);
            this.metroLabel9.TabIndex = 240;
            this.metroLabel9.Text = "رقم السند";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 149);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(80, 19);
            this.metroLabel10.TabIndex = 241;
            this.metroLabel10.Text = "المبلغ بالدولار";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(23, 503);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(69, 19);
            this.metroLabel11.TabIndex = 242;
            this.metroLabel11.Text = "نوع الصنف";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(23, 460);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(78, 19);
            this.metroLabel12.TabIndex = 243;
            this.metroLabel12.Text = "تاريخ الميزانية";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(23, 419);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(66, 19);
            this.metroLabel13.TabIndex = 244;
            this.metroLabel13.Text = "الملاحظات";
            // 
            // Payment_Document_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 578);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Payment_Document_Notes);
            this.Controls.Add(this.Payment_Document_Receve);
            this.Controls.Add(this.Payment_Document_No_Order);
            this.Controls.Add(this.Payment_Document_Reason);
            this.Controls.Add(this.Payment_Document_Dollar);
            this.Controls.Add(this.Payment_Document_rate);
            this.Controls.Add(this.Payment_Document_no);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Payment_Document_sy);
            this.Controls.Add(this.Coin_Exc_Sy);
            this.Controls.Add(this.Payment_Document_Search);
            this.Controls.Add(this.Payment_Document_Print);
            this.Controls.Add(this.Payment_Document_Date_last);
            this.Controls.Add(this.Payment_Document_Date_first);
            this.Controls.Add(this.Payment_Document_Comb_Cate);
            this.Controls.Add(this.Payment_Document_Comb_Date);
            this.Controls.Add(this.Payment_Document_dataGrid);
            this.Controls.Add(this.Payment_Document_exit);
            this.Controls.Add(this.Payment_Document_delete);
            this.Controls.Add(this.Payment_Document_update);
            this.Controls.Add(this.Payment_Document_add);
            this.Controls.Add(this.Payment_Document_new);
            this.Controls.Add(this.Payment_Document_DateTime);
            this.Name = "Payment_Document_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سندات الدفع";
            ((System.ComponentModel.ISupportInitialize)(this.Payment_Document_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime Payment_Document_Date_last;
        private MetroFramework.Controls.MetroDateTime Payment_Document_Date_first;
        private MetroFramework.Controls.MetroComboBox Payment_Document_Comb_Cate;
        private MetroFramework.Controls.MetroComboBox Payment_Document_Comb_Date;
        private MetroFramework.Controls.MetroGrid Payment_Document_dataGrid;
        private MetroFramework.Controls.MetroButton Payment_Document_exit;
        private MetroFramework.Controls.MetroButton Payment_Document_delete;
        private MetroFramework.Controls.MetroButton Payment_Document_update;
        private MetroFramework.Controls.MetroButton Payment_Document_add;
        private MetroFramework.Controls.MetroButton Payment_Document_new;
        private MetroFramework.Controls.MetroDateTime Payment_Document_DateTime;
        private MetroFramework.Controls.MetroButton Payment_Document_Print;
        private MetroFramework.Controls.MetroLabel Coin_Exc_Sy;
        private MetroFramework.Controls.MetroTextBox Payment_Document_Search;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Payment_Document_sy;
        private MetroFramework.Controls.MetroTextBox Payment_Document_no;
        private MetroFramework.Controls.MetroTextBox Payment_Document_rate;
        private MetroFramework.Controls.MetroTextBox Payment_Document_Dollar;
        private MetroFramework.Controls.MetroTextBox Payment_Document_Reason;
        private MetroFramework.Controls.MetroTextBox Payment_Document_No_Order;
        private MetroFramework.Controls.MetroTextBox Payment_Document_Receve;
        private MetroFramework.Controls.MetroTextBox Payment_Document_Notes;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
    }
}