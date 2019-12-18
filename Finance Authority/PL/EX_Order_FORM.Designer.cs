namespace Finance_Authority.PL
{
    partial class EX_Order_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EX_Order_FORM));
            this.EX_Orders_DateTime = new MetroFramework.Controls.MetroDateTime();
            this.EX_Orders_new = new MetroFramework.Controls.MetroButton();
            this.EX_Orders_add = new MetroFramework.Controls.MetroButton();
            this.EX_Orders_update = new MetroFramework.Controls.MetroButton();
            this.EX_Orders_delete = new MetroFramework.Controls.MetroButton();
            this.EX_Orders_exit = new MetroFramework.Controls.MetroButton();
            this.EX_Orders_dataGrid = new MetroFramework.Controls.MetroGrid();
            this.EX_Orders_last = new MetroFramework.Controls.MetroDateTime();
            this.EX_Orders_first = new MetroFramework.Controls.MetroDateTime();
            this.EX_Order_Print = new MetroFramework.Controls.MetroButton();
            this.EX_Orders_order = new MetroFramework.Controls.MetroTextBox();
            this.Coin_Exc_Sy = new MetroFramework.Controls.MetroLabel();
            this.EX_Orders_Body_order = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.EX_Orders_tosorce = new MetroFramework.Controls.MetroTextBox();
            this.EX_Orders_Notes = new MetroFramework.Controls.MetroTextBox();
            this.EX_Orders_search = new MetroFramework.Controls.MetroTextBox();
            this.EX_Orders_search_All = new MetroFramework.Controls.MetroTextBox();
            this.EX_Orders_CombCategorise = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.update = new MetroFramework.Controls.MetroButton();
            this.EX_Orders_Brows_Docs = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.EX_Orders_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EX_Orders_DateTime
            // 
            this.EX_Orders_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EX_Orders_DateTime.Location = new System.Drawing.Point(113, 157);
            this.EX_Orders_DateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.EX_Orders_DateTime.Name = "EX_Orders_DateTime";
            this.EX_Orders_DateTime.RightToLeftLayout = true;
            this.EX_Orders_DateTime.Size = new System.Drawing.Size(166, 29);
            this.EX_Orders_DateTime.TabIndex = 1;
            // 
            // EX_Orders_new
            // 
            this.EX_Orders_new.Highlight = true;
            this.EX_Orders_new.Location = new System.Drawing.Point(265, 413);
            this.EX_Orders_new.Name = "EX_Orders_new";
            this.EX_Orders_new.Size = new System.Drawing.Size(87, 37);
            this.EX_Orders_new.TabIndex = 6;
            this.EX_Orders_new.Text = "جديد";
            this.EX_Orders_new.UseSelectable = true;
            this.EX_Orders_new.Click += new System.EventHandler(this.EX_Orders_new_Click);
            // 
            // EX_Orders_add
            // 
            this.EX_Orders_add.Enabled = false;
            this.EX_Orders_add.Highlight = true;
            this.EX_Orders_add.Location = new System.Drawing.Point(377, 413);
            this.EX_Orders_add.Name = "EX_Orders_add";
            this.EX_Orders_add.Size = new System.Drawing.Size(87, 37);
            this.EX_Orders_add.TabIndex = 7;
            this.EX_Orders_add.Text = "أضافة";
            this.EX_Orders_add.UseSelectable = true;
            this.EX_Orders_add.Click += new System.EventHandler(this.EX_Orders_add_Click);
            // 
            // EX_Orders_update
            // 
            this.EX_Orders_update.Enabled = false;
            this.EX_Orders_update.Highlight = true;
            this.EX_Orders_update.Location = new System.Drawing.Point(489, 413);
            this.EX_Orders_update.Name = "EX_Orders_update";
            this.EX_Orders_update.Size = new System.Drawing.Size(87, 37);
            this.EX_Orders_update.TabIndex = 8;
            this.EX_Orders_update.Text = "تعديل";
            this.EX_Orders_update.UseSelectable = true;
            this.EX_Orders_update.Click += new System.EventHandler(this.EX_Orders_update_Click);
            // 
            // EX_Orders_delete
            // 
            this.EX_Orders_delete.Enabled = false;
            this.EX_Orders_delete.Highlight = true;
            this.EX_Orders_delete.Location = new System.Drawing.Point(601, 413);
            this.EX_Orders_delete.Name = "EX_Orders_delete";
            this.EX_Orders_delete.Size = new System.Drawing.Size(87, 37);
            this.EX_Orders_delete.TabIndex = 9;
            this.EX_Orders_delete.Text = "حذف";
            this.EX_Orders_delete.UseSelectable = true;
            this.EX_Orders_delete.Click += new System.EventHandler(this.EX_Orders_delete_Click);
            // 
            // EX_Orders_exit
            // 
            this.EX_Orders_exit.Highlight = true;
            this.EX_Orders_exit.Location = new System.Drawing.Point(825, 413);
            this.EX_Orders_exit.Name = "EX_Orders_exit";
            this.EX_Orders_exit.Size = new System.Drawing.Size(87, 37);
            this.EX_Orders_exit.TabIndex = 11;
            this.EX_Orders_exit.Text = "خروج";
            this.EX_Orders_exit.UseSelectable = true;
            this.EX_Orders_exit.Click += new System.EventHandler(this.EX_Orders_exit_Click);
            // 
            // EX_Orders_dataGrid
            // 
            this.EX_Orders_dataGrid.AllowUserToAddRows = false;
            this.EX_Orders_dataGrid.AllowUserToDeleteRows = false;
            this.EX_Orders_dataGrid.AllowUserToResizeRows = false;
            this.EX_Orders_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EX_Orders_dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EX_Orders_dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EX_Orders_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EX_Orders_dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EX_Orders_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EX_Orders_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EX_Orders_dataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.EX_Orders_dataGrid.EnableHeadersVisualStyles = false;
            this.EX_Orders_dataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EX_Orders_dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EX_Orders_dataGrid.Location = new System.Drawing.Point(285, 92);
            this.EX_Orders_dataGrid.Name = "EX_Orders_dataGrid";
            this.EX_Orders_dataGrid.ReadOnly = true;
            this.EX_Orders_dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EX_Orders_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.EX_Orders_dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EX_Orders_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EX_Orders_dataGrid.Size = new System.Drawing.Size(636, 315);
            this.EX_Orders_dataGrid.TabIndex = 41;
            this.EX_Orders_dataGrid.Click += new System.EventHandler(this.EX_Orders_dataGrid_Click);
            // 
            // EX_Orders_last
            // 
            this.EX_Orders_last.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EX_Orders_last.Location = new System.Drawing.Point(685, 16);
            this.EX_Orders_last.MinimumSize = new System.Drawing.Size(0, 29);
            this.EX_Orders_last.Name = "EX_Orders_last";
            this.EX_Orders_last.RightToLeftLayout = true;
            this.EX_Orders_last.Size = new System.Drawing.Size(128, 29);
            this.EX_Orders_last.TabIndex = 15;
            this.EX_Orders_last.ValueChanged += new System.EventHandler(this.EX_Orders_last_ValueChanged);
            // 
            // EX_Orders_first
            // 
            this.EX_Orders_first.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EX_Orders_first.Location = new System.Drawing.Point(477, 16);
            this.EX_Orders_first.MinimumSize = new System.Drawing.Size(0, 29);
            this.EX_Orders_first.Name = "EX_Orders_first";
            this.EX_Orders_first.RightToLeftLayout = true;
            this.EX_Orders_first.Size = new System.Drawing.Size(128, 29);
            this.EX_Orders_first.TabIndex = 14;
            this.EX_Orders_first.ValueChanged += new System.EventHandler(this.EX_Orders_first_ValueChanged);
            // 
            // EX_Order_Print
            // 
            this.EX_Order_Print.Highlight = true;
            this.EX_Order_Print.Location = new System.Drawing.Point(713, 413);
            this.EX_Order_Print.Name = "EX_Order_Print";
            this.EX_Order_Print.Size = new System.Drawing.Size(87, 37);
            this.EX_Order_Print.TabIndex = 10;
            this.EX_Order_Print.Text = "طباعة";
            this.EX_Order_Print.UseSelectable = true;
            this.EX_Order_Print.Click += new System.EventHandler(this.EX_Order_Print_Click);
            // 
            // EX_Orders_order
            // 
            // 
            // 
            // 
            this.EX_Orders_order.CustomButton.Image = null;
            this.EX_Orders_order.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.EX_Orders_order.CustomButton.Name = "";
            this.EX_Orders_order.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EX_Orders_order.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EX_Orders_order.CustomButton.TabIndex = 1;
            this.EX_Orders_order.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EX_Orders_order.CustomButton.UseSelectable = true;
            this.EX_Orders_order.CustomButton.Visible = false;
            this.EX_Orders_order.Lines = new string[0];
            this.EX_Orders_order.Location = new System.Drawing.Point(113, 107);
            this.EX_Orders_order.MaxLength = 32767;
            this.EX_Orders_order.Name = "EX_Orders_order";
            this.EX_Orders_order.PasswordChar = '\0';
            this.EX_Orders_order.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EX_Orders_order.SelectedText = "";
            this.EX_Orders_order.SelectionLength = 0;
            this.EX_Orders_order.SelectionStart = 0;
            this.EX_Orders_order.ShortcutsEnabled = true;
            this.EX_Orders_order.Size = new System.Drawing.Size(166, 23);
            this.EX_Orders_order.TabIndex = 223;
            this.EX_Orders_order.UseSelectable = true;
            this.EX_Orders_order.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EX_Orders_order.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EX_Orders_order.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EX_Orders_order_KeyPress);
            // 
            // Coin_Exc_Sy
            // 
            this.Coin_Exc_Sy.AutoSize = true;
            this.Coin_Exc_Sy.Location = new System.Drawing.Point(10, 111);
            this.Coin_Exc_Sy.Name = "Coin_Exc_Sy";
            this.Coin_Exc_Sy.Size = new System.Drawing.Size(66, 19);
            this.Coin_Exc_Sy.TabIndex = 222;
            this.Coin_Exc_Sy.Text = "رقم الطلب";
            // 
            // EX_Orders_Body_order
            // 
            // 
            // 
            // 
            this.EX_Orders_Body_order.CustomButton.Image = null;
            this.EX_Orders_Body_order.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.EX_Orders_Body_order.CustomButton.Name = "";
            this.EX_Orders_Body_order.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EX_Orders_Body_order.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EX_Orders_Body_order.CustomButton.TabIndex = 1;
            this.EX_Orders_Body_order.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EX_Orders_Body_order.CustomButton.UseSelectable = true;
            this.EX_Orders_Body_order.CustomButton.Visible = false;
            this.EX_Orders_Body_order.Lines = new string[0];
            this.EX_Orders_Body_order.Location = new System.Drawing.Point(113, 248);
            this.EX_Orders_Body_order.MaxLength = 32767;
            this.EX_Orders_Body_order.Name = "EX_Orders_Body_order";
            this.EX_Orders_Body_order.PasswordChar = '\0';
            this.EX_Orders_Body_order.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EX_Orders_Body_order.SelectedText = "";
            this.EX_Orders_Body_order.SelectionLength = 0;
            this.EX_Orders_Body_order.SelectionStart = 0;
            this.EX_Orders_Body_order.ShortcutsEnabled = true;
            this.EX_Orders_Body_order.Size = new System.Drawing.Size(166, 23);
            this.EX_Orders_Body_order.TabIndex = 225;
            this.EX_Orders_Body_order.UseSelectable = true;
            this.EX_Orders_Body_order.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EX_Orders_Body_order.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 212);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 224;
            this.metroLabel1.Text = "الجهة المستلمة";
            // 
            // EX_Orders_tosorce
            // 
            // 
            // 
            // 
            this.EX_Orders_tosorce.CustomButton.Image = null;
            this.EX_Orders_tosorce.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.EX_Orders_tosorce.CustomButton.Name = "";
            this.EX_Orders_tosorce.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EX_Orders_tosorce.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EX_Orders_tosorce.CustomButton.TabIndex = 1;
            this.EX_Orders_tosorce.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EX_Orders_tosorce.CustomButton.UseSelectable = true;
            this.EX_Orders_tosorce.CustomButton.Visible = false;
            this.EX_Orders_tosorce.Lines = new string[0];
            this.EX_Orders_tosorce.Location = new System.Drawing.Point(113, 208);
            this.EX_Orders_tosorce.MaxLength = 32767;
            this.EX_Orders_tosorce.Name = "EX_Orders_tosorce";
            this.EX_Orders_tosorce.PasswordChar = '\0';
            this.EX_Orders_tosorce.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EX_Orders_tosorce.SelectedText = "";
            this.EX_Orders_tosorce.SelectionLength = 0;
            this.EX_Orders_tosorce.SelectionStart = 0;
            this.EX_Orders_tosorce.ShortcutsEnabled = true;
            this.EX_Orders_tosorce.Size = new System.Drawing.Size(166, 23);
            this.EX_Orders_tosorce.TabIndex = 226;
            this.EX_Orders_tosorce.UseSelectable = true;
            this.EX_Orders_tosorce.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EX_Orders_tosorce.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EX_Orders_Notes
            // 
            // 
            // 
            // 
            this.EX_Orders_Notes.CustomButton.Image = null;
            this.EX_Orders_Notes.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.EX_Orders_Notes.CustomButton.Name = "";
            this.EX_Orders_Notes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EX_Orders_Notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EX_Orders_Notes.CustomButton.TabIndex = 1;
            this.EX_Orders_Notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EX_Orders_Notes.CustomButton.UseSelectable = true;
            this.EX_Orders_Notes.CustomButton.Visible = false;
            this.EX_Orders_Notes.Lines = new string[0];
            this.EX_Orders_Notes.Location = new System.Drawing.Point(113, 295);
            this.EX_Orders_Notes.MaxLength = 32767;
            this.EX_Orders_Notes.Name = "EX_Orders_Notes";
            this.EX_Orders_Notes.PasswordChar = '\0';
            this.EX_Orders_Notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EX_Orders_Notes.SelectedText = "";
            this.EX_Orders_Notes.SelectionLength = 0;
            this.EX_Orders_Notes.SelectionStart = 0;
            this.EX_Orders_Notes.ShortcutsEnabled = true;
            this.EX_Orders_Notes.Size = new System.Drawing.Size(166, 23);
            this.EX_Orders_Notes.TabIndex = 227;
            this.EX_Orders_Notes.UseSelectable = true;
            this.EX_Orders_Notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EX_Orders_Notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EX_Orders_search
            // 
            // 
            // 
            // 
            this.EX_Orders_search.CustomButton.Image = null;
            this.EX_Orders_search.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.EX_Orders_search.CustomButton.Name = "";
            this.EX_Orders_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EX_Orders_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EX_Orders_search.CustomButton.TabIndex = 1;
            this.EX_Orders_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EX_Orders_search.CustomButton.UseSelectable = true;
            this.EX_Orders_search.CustomButton.Visible = false;
            this.EX_Orders_search.Lines = new string[0];
            this.EX_Orders_search.Location = new System.Drawing.Point(487, 63);
            this.EX_Orders_search.MaxLength = 32767;
            this.EX_Orders_search.Name = "EX_Orders_search";
            this.EX_Orders_search.PasswordChar = '\0';
            this.EX_Orders_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EX_Orders_search.SelectedText = "";
            this.EX_Orders_search.SelectionLength = 0;
            this.EX_Orders_search.SelectionStart = 0;
            this.EX_Orders_search.ShortcutsEnabled = true;
            this.EX_Orders_search.Size = new System.Drawing.Size(125, 23);
            this.EX_Orders_search.TabIndex = 228;
            this.EX_Orders_search.UseSelectable = true;
            this.EX_Orders_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EX_Orders_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EX_Orders_search.TextChanged += new System.EventHandler(this.EX_Orders_search_TextChanged_1);
            // 
            // EX_Orders_search_All
            // 
            // 
            // 
            // 
            this.EX_Orders_search_All.CustomButton.Image = null;
            this.EX_Orders_search_All.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.EX_Orders_search_All.CustomButton.Name = "";
            this.EX_Orders_search_All.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EX_Orders_search_All.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EX_Orders_search_All.CustomButton.TabIndex = 1;
            this.EX_Orders_search_All.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EX_Orders_search_All.CustomButton.UseSelectable = true;
            this.EX_Orders_search_All.CustomButton.Visible = false;
            this.EX_Orders_search_All.Lines = new string[0];
            this.EX_Orders_search_All.Location = new System.Drawing.Point(708, 59);
            this.EX_Orders_search_All.MaxLength = 32767;
            this.EX_Orders_search_All.Name = "EX_Orders_search_All";
            this.EX_Orders_search_All.PasswordChar = '\0';
            this.EX_Orders_search_All.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EX_Orders_search_All.SelectedText = "";
            this.EX_Orders_search_All.SelectionLength = 0;
            this.EX_Orders_search_All.SelectionStart = 0;
            this.EX_Orders_search_All.ShortcutsEnabled = true;
            this.EX_Orders_search_All.Size = new System.Drawing.Size(125, 23);
            this.EX_Orders_search_All.TabIndex = 229;
            this.EX_Orders_search_All.UseSelectable = true;
            this.EX_Orders_search_All.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EX_Orders_search_All.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EX_Orders_search_All.TextChanged += new System.EventHandler(this.EX_Orders_search_All_TextChanged_1);
            // 
            // EX_Orders_CombCategorise
            // 
            this.EX_Orders_CombCategorise.FormattingEnabled = true;
            this.EX_Orders_CombCategorise.ItemHeight = 23;
            this.EX_Orders_CombCategorise.Location = new System.Drawing.Point(113, 336);
            this.EX_Orders_CombCategorise.Name = "EX_Orders_CombCategorise";
            this.EX_Orders_CombCategorise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EX_Orders_CombCategorise.Size = new System.Drawing.Size(166, 29);
            this.EX_Orders_CombCategorise.TabIndex = 230;
            this.EX_Orders_CombCategorise.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 167);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 231;
            this.metroLabel2.Text = "التاريخ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 252);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 232;
            this.metroLabel3.Text = "نص الطلب";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 346);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 233;
            this.metroLabel4.Text = "صنف الطلب";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 299);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 234;
            this.metroLabel5.Text = "الملاحظات";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(402, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 235;
            this.metroLabel6.Text = "تاريخ البداية";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(611, 26);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 19);
            this.metroLabel7.TabIndex = 236;
            this.metroLabel7.Text = "تاريخ النهاية";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(342, 67);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(139, 19);
            this.metroLabel8.TabIndex = 237;
            this.metroLabel8.Text = "البحث حسب رقم الطلب";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(639, 63);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(63, 19);
            this.metroLabel9.TabIndex = 238;
            this.metroLabel9.Text = "البحث عام";
            // 
            // update
            // 
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.update.Location = new System.Drawing.Point(855, 55);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(33, 31);
            this.update.TabIndex = 267;
            this.update.UseSelectable = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // EX_Orders_Brows_Docs
            // 
            this.EX_Orders_Brows_Docs.Enabled = false;
            this.EX_Orders_Brows_Docs.Highlight = true;
            this.EX_Orders_Brows_Docs.Location = new System.Drawing.Point(90, 413);
            this.EX_Orders_Brows_Docs.Name = "EX_Orders_Brows_Docs";
            this.EX_Orders_Brows_Docs.Size = new System.Drawing.Size(118, 37);
            this.EX_Orders_Brows_Docs.TabIndex = 287;
            this.EX_Orders_Brows_Docs.Text = "استعراض الملحقات";
            this.EX_Orders_Brows_Docs.UseSelectable = true;
            this.EX_Orders_Brows_Docs.Click += new System.EventHandler(this.EX_Orders_Brows_Docs_Click);
            // 
            // EX_Order_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 463);
            this.Controls.Add(this.EX_Orders_Brows_Docs);
            this.Controls.Add(this.update);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.EX_Orders_CombCategorise);
            this.Controls.Add(this.EX_Orders_search_All);
            this.Controls.Add(this.EX_Orders_search);
            this.Controls.Add(this.EX_Orders_Notes);
            this.Controls.Add(this.EX_Orders_tosorce);
            this.Controls.Add(this.EX_Orders_Body_order);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.EX_Orders_order);
            this.Controls.Add(this.Coin_Exc_Sy);
            this.Controls.Add(this.EX_Order_Print);
            this.Controls.Add(this.EX_Orders_first);
            this.Controls.Add(this.EX_Orders_last);
            this.Controls.Add(this.EX_Orders_dataGrid);
            this.Controls.Add(this.EX_Orders_exit);
            this.Controls.Add(this.EX_Orders_delete);
            this.Controls.Add(this.EX_Orders_update);
            this.Controls.Add(this.EX_Orders_add);
            this.Controls.Add(this.EX_Orders_new);
            this.Controls.Add(this.EX_Orders_DateTime);
            this.Name = "EX_Order_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "طلبات صرف مبلغ";
            ((System.ComponentModel.ISupportInitialize)(this.EX_Orders_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime EX_Orders_DateTime;
        private MetroFramework.Controls.MetroButton EX_Orders_new;
        private MetroFramework.Controls.MetroButton EX_Orders_add;
        private MetroFramework.Controls.MetroButton EX_Orders_update;
        private MetroFramework.Controls.MetroButton EX_Orders_delete;
        private MetroFramework.Controls.MetroButton EX_Orders_exit;
        private MetroFramework.Controls.MetroGrid EX_Orders_dataGrid;
        private MetroFramework.Controls.MetroDateTime EX_Orders_last;
        private MetroFramework.Controls.MetroDateTime EX_Orders_first;
        private MetroFramework.Controls.MetroButton EX_Order_Print;
        private MetroFramework.Controls.MetroTextBox EX_Orders_order;
        private MetroFramework.Controls.MetroLabel Coin_Exc_Sy;
        private MetroFramework.Controls.MetroTextBox EX_Orders_Body_order;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox EX_Orders_tosorce;
        private MetroFramework.Controls.MetroTextBox EX_Orders_Notes;
        private MetroFramework.Controls.MetroTextBox EX_Orders_search;
        private MetroFramework.Controls.MetroTextBox EX_Orders_search_All;
        private MetroFramework.Controls.MetroComboBox EX_Orders_CombCategorise;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton update;
        private MetroFramework.Controls.MetroButton EX_Orders_Brows_Docs;
    }
}