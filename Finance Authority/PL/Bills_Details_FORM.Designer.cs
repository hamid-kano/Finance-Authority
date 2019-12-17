namespace Finance_Authority.PL
{
    partial class Bills_Details_FORM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bill_Objects_dataGrid = new MetroFramework.Controls.MetroGrid();
            this.Bills_exit = new MetroFramework.Controls.MetroButton();
            this.Bills_delete = new MetroFramework.Controls.MetroButton();
            this.Bills_update = new MetroFramework.Controls.MetroButton();
            this.Bills_add = new MetroFramework.Controls.MetroButton();
            this.Bills_new = new MetroFramework.Controls.MetroButton();
            this.Bills_Date = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bills_Not = new MetroFramework.Controls.MetroRadioButton();
            this.Bills_Paid = new MetroFramework.Controls.MetroRadioButton();
            this.Bills_Comb_Budget = new MetroFramework.Controls.MetroComboBox();
            this.Bills_Comb_Department = new MetroFramework.Controls.MetroComboBox();
            this.Bills_Details_Print = new MetroFramework.Controls.MetroButton();
            this.Bills_NO_Bill = new MetroFramework.Controls.MetroTextBox();
            this.Bills_Buyer_Name = new MetroFramework.Controls.MetroTextBox();
            this.Bills_Exchange_rate = new MetroFramework.Controls.MetroTextBox();
            this.Bill_Type = new MetroFramework.Controls.MetroTextBox();
            this.Bill_Total = new MetroFramework.Controls.MetroTextBox();
            this.Bills_Notes = new MetroFramework.Controls.MetroTextBox();
            this.Bills_Details_Namber = new MetroFramework.Controls.MetroLabel();
            this.Bills_Details_Name = new MetroFramework.Controls.MetroLabel();
            this.Bills_Details_Type_coin = new MetroFramework.Controls.MetroLabel();
            this.Bills_Details_Rate = new MetroFramework.Controls.MetroLabel();
            this.Bills_Details_Type_Bill = new MetroFramework.Controls.MetroLabel();
            this.Bills_Details_Total = new MetroFramework.Controls.MetroLabel();
            this.Bills_Details_Date = new MetroFramework.Controls.MetroLabel();
            this.Bills_Details_Name_Department = new MetroFramework.Controls.MetroLabel();
            this.Bills_Details_Note = new MetroFramework.Controls.MetroLabel();
            this.Bills_Details_Date_Budget = new MetroFramework.Controls.MetroLabel();
            this.Bills_Coin_Type = new MetroFramework.Controls.MetroComboBox();
            this.Bills_Brows_Docs = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_Objects_dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bill_Objects_dataGrid
            // 
            this.Bill_Objects_dataGrid.AllowUserToOrderColumns = true;
            this.Bill_Objects_dataGrid.AllowUserToResizeRows = false;
            this.Bill_Objects_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bill_Objects_dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bill_Objects_dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bill_Objects_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Bill_Objects_dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill_Objects_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.Bill_Objects_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bill_Objects_dataGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.Bill_Objects_dataGrid.EnableHeadersVisualStyles = false;
            this.Bill_Objects_dataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Bill_Objects_dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bill_Objects_dataGrid.Location = new System.Drawing.Point(294, 77);
            this.Bill_Objects_dataGrid.Name = "Bill_Objects_dataGrid";
            this.Bill_Objects_dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill_Objects_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.Bill_Objects_dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Bill_Objects_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Bill_Objects_dataGrid.Size = new System.Drawing.Size(700, 434);
            this.Bill_Objects_dataGrid.TabIndex = 47;
            this.Bill_Objects_dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_Objects_dataGrid_CellValueChanged);
            this.Bill_Objects_dataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.Bill_Objects_dataGrid_CurrentCellDirtyStateChanged);
            this.Bill_Objects_dataGrid.Click += new System.EventHandler(this.Bills_dataGrid_Click);
            // 
            // Bills_exit
            // 
            this.Bills_exit.Highlight = true;
            this.Bills_exit.Location = new System.Drawing.Point(882, 540);
            this.Bills_exit.Name = "Bills_exit";
            this.Bills_exit.Size = new System.Drawing.Size(87, 37);
            this.Bills_exit.TabIndex = 17;
            this.Bills_exit.Text = "خروج";
            this.Bills_exit.UseSelectable = true;
            this.Bills_exit.Click += new System.EventHandler(this.Bills_exit_Click);
            // 
            // Bills_delete
            // 
            this.Bills_delete.Highlight = true;
            this.Bills_delete.Location = new System.Drawing.Point(662, 540);
            this.Bills_delete.Name = "Bills_delete";
            this.Bills_delete.Size = new System.Drawing.Size(87, 37);
            this.Bills_delete.TabIndex = 15;
            this.Bills_delete.Text = "حذف";
            this.Bills_delete.UseSelectable = true;
            this.Bills_delete.Click += new System.EventHandler(this.Bills_delete_Click);
            // 
            // Bills_update
            // 
            this.Bills_update.Highlight = true;
            this.Bills_update.Location = new System.Drawing.Point(552, 540);
            this.Bills_update.Name = "Bills_update";
            this.Bills_update.Size = new System.Drawing.Size(87, 37);
            this.Bills_update.TabIndex = 14;
            this.Bills_update.Text = "تعديل";
            this.Bills_update.UseSelectable = true;
            this.Bills_update.Click += new System.EventHandler(this.Bills_update_Click);
            // 
            // Bills_add
            // 
            this.Bills_add.Highlight = true;
            this.Bills_add.Location = new System.Drawing.Point(442, 540);
            this.Bills_add.Name = "Bills_add";
            this.Bills_add.Size = new System.Drawing.Size(87, 37);
            this.Bills_add.TabIndex = 13;
            this.Bills_add.Text = "أضافة";
            this.Bills_add.UseSelectable = true;
            this.Bills_add.Click += new System.EventHandler(this.Bills_add_Click);
            // 
            // Bills_new
            // 
            this.Bills_new.Highlight = true;
            this.Bills_new.Location = new System.Drawing.Point(332, 540);
            this.Bills_new.Name = "Bills_new";
            this.Bills_new.Size = new System.Drawing.Size(87, 37);
            this.Bills_new.TabIndex = 12;
            this.Bills_new.Text = "جديد";
            this.Bills_new.UseSelectable = true;
            this.Bills_new.Click += new System.EventHandler(this.Bills_new_Click);
            // 
            // Bills_Date
            // 
            this.Bills_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Bills_Date.Location = new System.Drawing.Point(148, 281);
            this.Bills_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.Bills_Date.Name = "Bills_Date";
            this.Bills_Date.Size = new System.Drawing.Size(140, 29);
            this.Bills_Date.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bills_Not);
            this.groupBox1.Controls.Add(this.Bills_Paid);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 55);
            this.groupBox1.TabIndex = 199;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حالة الفاتورة:";
            // 
            // Bills_Not
            // 
            this.Bills_Not.AutoSize = true;
            this.Bills_Not.Location = new System.Drawing.Point(31, 27);
            this.Bills_Not.Name = "Bills_Not";
            this.Bills_Not.Size = new System.Drawing.Size(83, 15);
            this.Bills_Not.TabIndex = 222;
            this.Bills_Not.Text = " غير مدفوعة";
            this.Bills_Not.UseSelectable = true;
            // 
            // Bills_Paid
            // 
            this.Bills_Paid.AutoSize = true;
            this.Bills_Paid.Checked = true;
            this.Bills_Paid.Location = new System.Drawing.Point(157, 27);
            this.Bills_Paid.Name = "Bills_Paid";
            this.Bills_Paid.Size = new System.Drawing.Size(61, 15);
            this.Bills_Paid.TabIndex = 221;
            this.Bills_Paid.TabStop = true;
            this.Bills_Paid.Text = "مدفوعة";
            this.Bills_Paid.UseSelectable = true;
            // 
            // Bills_Comb_Budget
            // 
            this.Bills_Comb_Budget.FormattingEnabled = true;
            this.Bills_Comb_Budget.ItemHeight = 23;
            this.Bills_Comb_Budget.Location = new System.Drawing.Point(148, 421);
            this.Bills_Comb_Budget.Name = "Bills_Comb_Budget";
            this.Bills_Comb_Budget.Size = new System.Drawing.Size(140, 29);
            this.Bills_Comb_Budget.TabIndex = 10;
            this.Bills_Comb_Budget.UseSelectable = true;
            // 
            // Bills_Comb_Department
            // 
            this.Bills_Comb_Department.FormattingEnabled = true;
            this.Bills_Comb_Department.ItemHeight = 23;
            this.Bills_Comb_Department.Location = new System.Drawing.Point(148, 461);
            this.Bills_Comb_Department.Name = "Bills_Comb_Department";
            this.Bills_Comb_Department.Size = new System.Drawing.Size(140, 29);
            this.Bills_Comb_Department.TabIndex = 11;
            this.Bills_Comb_Department.UseSelectable = true;
            // 
            // Bills_Details_Print
            // 
            this.Bills_Details_Print.Highlight = true;
            this.Bills_Details_Print.Location = new System.Drawing.Point(772, 540);
            this.Bills_Details_Print.Name = "Bills_Details_Print";
            this.Bills_Details_Print.Size = new System.Drawing.Size(87, 37);
            this.Bills_Details_Print.TabIndex = 16;
            this.Bills_Details_Print.Text = "طباعة";
            this.Bills_Details_Print.UseSelectable = true;
            this.Bills_Details_Print.Click += new System.EventHandler(this.Bills_Details_Print_Click);
            // 
            // Bills_NO_Bill
            // 
            // 
            // 
            // 
            this.Bills_NO_Bill.CustomButton.Image = null;
            this.Bills_NO_Bill.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.Bills_NO_Bill.CustomButton.Name = "";
            this.Bills_NO_Bill.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Bills_NO_Bill.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Bills_NO_Bill.CustomButton.TabIndex = 1;
            this.Bills_NO_Bill.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Bills_NO_Bill.CustomButton.UseSelectable = true;
            this.Bills_NO_Bill.CustomButton.Visible = false;
            this.Bills_NO_Bill.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Bills_NO_Bill.Lines = new string[0];
            this.Bills_NO_Bill.Location = new System.Drawing.Point(145, 77);
            this.Bills_NO_Bill.MaxLength = 32767;
            this.Bills_NO_Bill.Name = "Bills_NO_Bill";
            this.Bills_NO_Bill.PasswordChar = '\0';
            this.Bills_NO_Bill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Bills_NO_Bill.SelectedText = "";
            this.Bills_NO_Bill.SelectionLength = 0;
            this.Bills_NO_Bill.SelectionStart = 0;
            this.Bills_NO_Bill.ShortcutsEnabled = true;
            this.Bills_NO_Bill.Size = new System.Drawing.Size(143, 23);
            this.Bills_NO_Bill.TabIndex = 0;
            this.Bills_NO_Bill.UseSelectable = true;
            this.Bills_NO_Bill.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Bills_NO_Bill.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Bills_NO_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bills_NO_Bill_KeyPress);
            // 
            // Bills_Buyer_Name
            // 
            // 
            // 
            // 
            this.Bills_Buyer_Name.CustomButton.Image = null;
            this.Bills_Buyer_Name.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.Bills_Buyer_Name.CustomButton.Name = "";
            this.Bills_Buyer_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Bills_Buyer_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Bills_Buyer_Name.CustomButton.TabIndex = 1;
            this.Bills_Buyer_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Bills_Buyer_Name.CustomButton.UseSelectable = true;
            this.Bills_Buyer_Name.CustomButton.Visible = false;
            this.Bills_Buyer_Name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Bills_Buyer_Name.Lines = new string[0];
            this.Bills_Buyer_Name.Location = new System.Drawing.Point(145, 111);
            this.Bills_Buyer_Name.MaxLength = 32767;
            this.Bills_Buyer_Name.Name = "Bills_Buyer_Name";
            this.Bills_Buyer_Name.PasswordChar = '\0';
            this.Bills_Buyer_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Bills_Buyer_Name.SelectedText = "";
            this.Bills_Buyer_Name.SelectionLength = 0;
            this.Bills_Buyer_Name.SelectionStart = 0;
            this.Bills_Buyer_Name.ShortcutsEnabled = true;
            this.Bills_Buyer_Name.Size = new System.Drawing.Size(143, 23);
            this.Bills_Buyer_Name.TabIndex = 1;
            this.Bills_Buyer_Name.UseSelectable = true;
            this.Bills_Buyer_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Bills_Buyer_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Bills_Exchange_rate
            // 
            // 
            // 
            // 
            this.Bills_Exchange_rate.CustomButton.Image = null;
            this.Bills_Exchange_rate.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.Bills_Exchange_rate.CustomButton.Name = "";
            this.Bills_Exchange_rate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Bills_Exchange_rate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Bills_Exchange_rate.CustomButton.TabIndex = 1;
            this.Bills_Exchange_rate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Bills_Exchange_rate.CustomButton.UseSelectable = true;
            this.Bills_Exchange_rate.CustomButton.Visible = false;
            this.Bills_Exchange_rate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Bills_Exchange_rate.Lines = new string[0];
            this.Bills_Exchange_rate.Location = new System.Drawing.Point(145, 179);
            this.Bills_Exchange_rate.MaxLength = 32767;
            this.Bills_Exchange_rate.Name = "Bills_Exchange_rate";
            this.Bills_Exchange_rate.PasswordChar = '\0';
            this.Bills_Exchange_rate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Bills_Exchange_rate.SelectedText = "";
            this.Bills_Exchange_rate.SelectionLength = 0;
            this.Bills_Exchange_rate.SelectionStart = 0;
            this.Bills_Exchange_rate.ShortcutsEnabled = true;
            this.Bills_Exchange_rate.Size = new System.Drawing.Size(143, 23);
            this.Bills_Exchange_rate.TabIndex = 3;
            this.Bills_Exchange_rate.UseSelectable = true;
            this.Bills_Exchange_rate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Bills_Exchange_rate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Bills_Exchange_rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bills_Exchange_rate_KeyPress);
            // 
            // Bill_Type
            // 
            // 
            // 
            // 
            this.Bill_Type.CustomButton.Image = null;
            this.Bill_Type.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.Bill_Type.CustomButton.Name = "";
            this.Bill_Type.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Bill_Type.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Bill_Type.CustomButton.TabIndex = 1;
            this.Bill_Type.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Bill_Type.CustomButton.UseSelectable = true;
            this.Bill_Type.CustomButton.Visible = false;
            this.Bill_Type.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Bill_Type.Lines = new string[0];
            this.Bill_Type.Location = new System.Drawing.Point(145, 213);
            this.Bill_Type.MaxLength = 32767;
            this.Bill_Type.Name = "Bill_Type";
            this.Bill_Type.PasswordChar = '\0';
            this.Bill_Type.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Bill_Type.SelectedText = "";
            this.Bill_Type.SelectionLength = 0;
            this.Bill_Type.SelectionStart = 0;
            this.Bill_Type.ShortcutsEnabled = true;
            this.Bill_Type.Size = new System.Drawing.Size(143, 23);
            this.Bill_Type.TabIndex = 4;
            this.Bill_Type.UseSelectable = true;
            this.Bill_Type.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Bill_Type.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Bill_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bill_Type_KeyPress);
            // 
            // Bill_Total
            // 
            // 
            // 
            // 
            this.Bill_Total.CustomButton.Image = null;
            this.Bill_Total.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.Bill_Total.CustomButton.Name = "";
            this.Bill_Total.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Bill_Total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Bill_Total.CustomButton.TabIndex = 1;
            this.Bill_Total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Bill_Total.CustomButton.UseSelectable = true;
            this.Bill_Total.CustomButton.Visible = false;
            this.Bill_Total.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Bill_Total.Lines = new string[0];
            this.Bill_Total.Location = new System.Drawing.Point(145, 247);
            this.Bill_Total.MaxLength = 32767;
            this.Bill_Total.Name = "Bill_Total";
            this.Bill_Total.PasswordChar = '\0';
            this.Bill_Total.ReadOnly = true;
            this.Bill_Total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Bill_Total.SelectedText = "";
            this.Bill_Total.SelectionLength = 0;
            this.Bill_Total.SelectionStart = 0;
            this.Bill_Total.ShortcutsEnabled = true;
            this.Bill_Total.Size = new System.Drawing.Size(143, 23);
            this.Bill_Total.TabIndex = 5;
            this.Bill_Total.UseSelectable = true;
            this.Bill_Total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Bill_Total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Bill_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bill_Total_KeyPress);
            // 
            // Bills_Notes
            // 
            // 
            // 
            // 
            this.Bills_Notes.CustomButton.Image = null;
            this.Bills_Notes.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.Bills_Notes.CustomButton.Name = "";
            this.Bills_Notes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Bills_Notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Bills_Notes.CustomButton.TabIndex = 1;
            this.Bills_Notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Bills_Notes.CustomButton.UseSelectable = true;
            this.Bills_Notes.CustomButton.Visible = false;
            this.Bills_Notes.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Bills_Notes.Lines = new string[0];
            this.Bills_Notes.Location = new System.Drawing.Point(145, 387);
            this.Bills_Notes.MaxLength = 32767;
            this.Bills_Notes.Name = "Bills_Notes";
            this.Bills_Notes.PasswordChar = '\0';
            this.Bills_Notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Bills_Notes.SelectedText = "";
            this.Bills_Notes.SelectionLength = 0;
            this.Bills_Notes.SelectionStart = 0;
            this.Bills_Notes.ShortcutsEnabled = true;
            this.Bills_Notes.Size = new System.Drawing.Size(143, 23);
            this.Bills_Notes.TabIndex = 6;
            this.Bills_Notes.UseSelectable = true;
            this.Bills_Notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Bills_Notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Bills_Details_Namber
            // 
            this.Bills_Details_Namber.AutoSize = true;
            this.Bills_Details_Namber.Location = new System.Drawing.Point(32, 75);
            this.Bills_Details_Namber.Name = "Bills_Details_Namber";
            this.Bills_Details_Namber.Size = new System.Drawing.Size(67, 19);
            this.Bills_Details_Namber.TabIndex = 211;
            this.Bills_Details_Namber.Text = "رقم الفاتورة";
            // 
            // Bills_Details_Name
            // 
            this.Bills_Details_Name.AutoSize = true;
            this.Bills_Details_Name.Location = new System.Drawing.Point(32, 109);
            this.Bills_Details_Name.Name = "Bills_Details_Name";
            this.Bills_Details_Name.Size = new System.Drawing.Size(60, 19);
            this.Bills_Details_Name.TabIndex = 212;
            this.Bills_Details_Name.Text = "أسم البائع";
            // 
            // Bills_Details_Type_coin
            // 
            this.Bills_Details_Type_coin.AutoSize = true;
            this.Bills_Details_Type_coin.Location = new System.Drawing.Point(32, 147);
            this.Bills_Details_Type_coin.Name = "Bills_Details_Type_coin";
            this.Bills_Details_Type_coin.Size = new System.Drawing.Size(63, 19);
            this.Bills_Details_Type_coin.TabIndex = 213;
            this.Bills_Details_Type_coin.Text = "نوع العملة";
            // 
            // Bills_Details_Rate
            // 
            this.Bills_Details_Rate.AutoSize = true;
            this.Bills_Details_Rate.Location = new System.Drawing.Point(32, 184);
            this.Bills_Details_Rate.Name = "Bills_Details_Rate";
            this.Bills_Details_Rate.Size = new System.Drawing.Size(76, 19);
            this.Bills_Details_Rate.TabIndex = 214;
            this.Bills_Details_Rate.Text = "قيمة التحويل";
            // 
            // Bills_Details_Type_Bill
            // 
            this.Bills_Details_Type_Bill.AutoSize = true;
            this.Bills_Details_Type_Bill.Location = new System.Drawing.Point(32, 218);
            this.Bills_Details_Type_Bill.Name = "Bills_Details_Type_Bill";
            this.Bills_Details_Type_Bill.Size = new System.Drawing.Size(67, 19);
            this.Bills_Details_Type_Bill.TabIndex = 215;
            this.Bills_Details_Type_Bill.Text = "نوع الفاتورة";
            // 
            // Bills_Details_Total
            // 
            this.Bills_Details_Total.AutoSize = true;
            this.Bills_Details_Total.Location = new System.Drawing.Point(32, 249);
            this.Bills_Details_Total.Name = "Bills_Details_Total";
            this.Bills_Details_Total.Size = new System.Drawing.Size(113, 19);
            this.Bills_Details_Total.TabIndex = 216;
            this.Bills_Details_Total.Text = "القيمة الكلية للفاتورة";
            // 
            // Bills_Details_Date
            // 
            this.Bills_Details_Date.AutoSize = true;
            this.Bills_Details_Date.Location = new System.Drawing.Point(32, 289);
            this.Bills_Details_Date.Name = "Bills_Details_Date";
            this.Bills_Details_Date.Size = new System.Drawing.Size(41, 19);
            this.Bills_Details_Date.TabIndex = 217;
            this.Bills_Details_Date.Text = "التاريخ";
            // 
            // Bills_Details_Name_Department
            // 
            this.Bills_Details_Name_Department.AutoSize = true;
            this.Bills_Details_Name_Department.Location = new System.Drawing.Point(32, 465);
            this.Bills_Details_Name_Department.Name = "Bills_Details_Name_Department";
            this.Bills_Details_Name_Department.Size = new System.Drawing.Size(68, 19);
            this.Bills_Details_Name_Department.TabIndex = 218;
            this.Bills_Details_Name_Department.Text = "أسم القسم";
            // 
            // Bills_Details_Note
            // 
            this.Bills_Details_Note.AutoSize = true;
            this.Bills_Details_Note.Location = new System.Drawing.Point(32, 389);
            this.Bills_Details_Note.Name = "Bills_Details_Note";
            this.Bills_Details_Note.Size = new System.Drawing.Size(66, 19);
            this.Bills_Details_Note.TabIndex = 219;
            this.Bills_Details_Note.Text = "الملاحظات";
            // 
            // Bills_Details_Date_Budget
            // 
            this.Bills_Details_Date_Budget.AutoSize = true;
            this.Bills_Details_Date_Budget.Location = new System.Drawing.Point(32, 431);
            this.Bills_Details_Date_Budget.Name = "Bills_Details_Date_Budget";
            this.Bills_Details_Date_Budget.Size = new System.Drawing.Size(78, 19);
            this.Bills_Details_Date_Budget.TabIndex = 220;
            this.Bills_Details_Date_Budget.Text = "تاريخ الميزانية";
            // 
            // Bills_Coin_Type
            // 
            this.Bills_Coin_Type.FormattingEnabled = true;
            this.Bills_Coin_Type.ItemHeight = 23;
            this.Bills_Coin_Type.Items.AddRange(new object[] {
            "سوري",
            "دولار"});
            this.Bills_Coin_Type.Location = new System.Drawing.Point(145, 143);
            this.Bills_Coin_Type.Name = "Bills_Coin_Type";
            this.Bills_Coin_Type.Size = new System.Drawing.Size(143, 29);
            this.Bills_Coin_Type.TabIndex = 222;
            this.Bills_Coin_Type.UseSelectable = true;
            // 
            // Bills_Brows_Docs
            // 
            this.Bills_Brows_Docs.Enabled = false;
            this.Bills_Brows_Docs.Highlight = true;
            this.Bills_Brows_Docs.Location = new System.Drawing.Point(114, 516);
            this.Bills_Brows_Docs.Name = "Bills_Brows_Docs";
            this.Bills_Brows_Docs.Size = new System.Drawing.Size(118, 37);
            this.Bills_Brows_Docs.TabIndex = 223;
            this.Bills_Brows_Docs.Text = "استعراض الملحقات";
            this.Bills_Brows_Docs.UseSelectable = true;
            this.Bills_Brows_Docs.Click += new System.EventHandler(this.Bills_Brows_Docs_Click);
            // 
            // Bills_Details_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 610);
            this.Controls.Add(this.Bills_Brows_Docs);
            this.Controls.Add(this.Bills_Coin_Type);
            this.Controls.Add(this.Bills_Details_Date_Budget);
            this.Controls.Add(this.Bills_Details_Note);
            this.Controls.Add(this.Bills_Details_Name_Department);
            this.Controls.Add(this.Bills_Details_Date);
            this.Controls.Add(this.Bills_Details_Total);
            this.Controls.Add(this.Bills_Details_Type_Bill);
            this.Controls.Add(this.Bills_Details_Rate);
            this.Controls.Add(this.Bills_Details_Type_coin);
            this.Controls.Add(this.Bills_Details_Name);
            this.Controls.Add(this.Bills_Details_Namber);
            this.Controls.Add(this.Bills_Notes);
            this.Controls.Add(this.Bill_Total);
            this.Controls.Add(this.Bill_Type);
            this.Controls.Add(this.Bills_Exchange_rate);
            this.Controls.Add(this.Bills_Buyer_Name);
            this.Controls.Add(this.Bills_NO_Bill);
            this.Controls.Add(this.Bills_Details_Print);
            this.Controls.Add(this.Bills_Comb_Department);
            this.Controls.Add(this.Bills_Comb_Budget);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bills_Date);
            this.Controls.Add(this.Bill_Objects_dataGrid);
            this.Controls.Add(this.Bills_exit);
            this.Controls.Add(this.Bills_delete);
            this.Controls.Add(this.Bills_update);
            this.Controls.Add(this.Bills_add);
            this.Controls.Add(this.Bills_new);
            this.Name = "Bills_Details_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تفاصيل الفاتورة";
            ((System.ComponentModel.ISupportInitialize)(this.Bill_Objects_dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid Bill_Objects_dataGrid;
        private MetroFramework.Controls.MetroButton Bills_exit;
        private MetroFramework.Controls.MetroButton Bills_delete;
        private MetroFramework.Controls.MetroButton Bills_update;
        private MetroFramework.Controls.MetroButton Bills_add;
        private MetroFramework.Controls.MetroButton Bills_new;
        private MetroFramework.Controls.MetroDateTime Bills_Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox Bills_Comb_Budget;
        private MetroFramework.Controls.MetroComboBox Bills_Comb_Department;
        private MetroFramework.Controls.MetroButton Bills_Details_Print;
        private MetroFramework.Controls.MetroTextBox Bills_NO_Bill;
        private MetroFramework.Controls.MetroTextBox Bills_Buyer_Name;
        private MetroFramework.Controls.MetroTextBox Bills_Exchange_rate;
        private MetroFramework.Controls.MetroTextBox Bill_Type;
        private MetroFramework.Controls.MetroTextBox Bill_Total;
        private MetroFramework.Controls.MetroTextBox Bills_Notes;
        private MetroFramework.Controls.MetroLabel Bills_Details_Namber;
        private MetroFramework.Controls.MetroLabel Bills_Details_Name;
        private MetroFramework.Controls.MetroLabel Bills_Details_Type_coin;
        private MetroFramework.Controls.MetroLabel Bills_Details_Rate;
        private MetroFramework.Controls.MetroLabel Bills_Details_Type_Bill;
        private MetroFramework.Controls.MetroLabel Bills_Details_Total;
        private MetroFramework.Controls.MetroLabel Bills_Details_Date;
        private MetroFramework.Controls.MetroLabel Bills_Details_Name_Department;
        private MetroFramework.Controls.MetroLabel Bills_Details_Note;
        private MetroFramework.Controls.MetroLabel Bills_Details_Date_Budget;
        private MetroFramework.Controls.MetroRadioButton Bills_Not;
        private MetroFramework.Controls.MetroRadioButton Bills_Paid;
        private MetroFramework.Controls.MetroComboBox Bills_Coin_Type;
        private MetroFramework.Controls.MetroButton Bills_Brows_Docs;
    }
}