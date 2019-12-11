namespace Finance_Authority.PL
{
    partial class Coin_Exchange_FORM
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
            this.Coin_Exchange_exit = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_delete = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_update = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_add = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_new = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_Gridview = new MetroFramework.Controls.MetroGrid();
            this.Coin_Exchange_Date = new MetroFramework.Controls.MetroDateTime();
            this.Coin_Exchange_CombBudge = new MetroFramework.Controls.MetroComboBox();
            this.Coin_Exchange_CombSerach = new MetroFramework.Controls.MetroComboBox();
            this.Coin_Exchange_Notes = new MetroFramework.Controls.MetroTextBox();
            this.Coin_Exchange_Sy = new MetroFramework.Controls.MetroTextBox();
            this.Coin_Exchange_Dollar = new MetroFramework.Controls.MetroTextBox();
            this.Coin_Exchange_rate = new MetroFramework.Controls.MetroTextBox();
            this.Coin_Exc_Date = new MetroFramework.Controls.MetroLabel();
            this.Coin_Exc_rate = new MetroFramework.Controls.MetroLabel();
            this.Coin_Exc_CombBudge = new MetroFramework.Controls.MetroLabel();
            this.Coin_Exc_Dollar = new MetroFramework.Controls.MetroLabel();
            this.Coin_Exc_CombSerach = new MetroFramework.Controls.MetroLabel();
            this.Coin_Exc_Sy = new MetroFramework.Controls.MetroLabel();
            this.Coin_Exc_Notes = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Coin_Exchange_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Coin_Exchange_exit
            // 
            this.Coin_Exchange_exit.Highlight = true;
            this.Coin_Exchange_exit.Location = new System.Drawing.Point(700, 390);
            this.Coin_Exchange_exit.Name = "Coin_Exchange_exit";
            this.Coin_Exchange_exit.Size = new System.Drawing.Size(87, 37);
            this.Coin_Exchange_exit.TabIndex = 10;
            this.Coin_Exchange_exit.Text = "خروج";
            this.Coin_Exchange_exit.UseSelectable = true;
            this.Coin_Exchange_exit.Click += new System.EventHandler(this.Coin_Exchange_exit_Click);
            // 
            // Coin_Exchange_delete
            // 
            this.Coin_Exchange_delete.Enabled = false;
            this.Coin_Exchange_delete.Highlight = true;
            this.Coin_Exchange_delete.Location = new System.Drawing.Point(588, 390);
            this.Coin_Exchange_delete.Name = "Coin_Exchange_delete";
            this.Coin_Exchange_delete.Size = new System.Drawing.Size(87, 37);
            this.Coin_Exchange_delete.TabIndex = 9;
            this.Coin_Exchange_delete.Text = "حذف";
            this.Coin_Exchange_delete.UseSelectable = true;
            this.Coin_Exchange_delete.Click += new System.EventHandler(this.Coin_Exchange_delete_Click);
            // 
            // Coin_Exchange_update
            // 
            this.Coin_Exchange_update.Enabled = false;
            this.Coin_Exchange_update.Highlight = true;
            this.Coin_Exchange_update.Location = new System.Drawing.Point(476, 390);
            this.Coin_Exchange_update.Name = "Coin_Exchange_update";
            this.Coin_Exchange_update.Size = new System.Drawing.Size(87, 37);
            this.Coin_Exchange_update.TabIndex = 8;
            this.Coin_Exchange_update.Text = "تعديل";
            this.Coin_Exchange_update.UseSelectable = true;
            this.Coin_Exchange_update.Click += new System.EventHandler(this.Coin_Exchange_update_Click);
            // 
            // Coin_Exchange_add
            // 
            this.Coin_Exchange_add.Enabled = false;
            this.Coin_Exchange_add.Highlight = true;
            this.Coin_Exchange_add.Location = new System.Drawing.Point(364, 390);
            this.Coin_Exchange_add.Name = "Coin_Exchange_add";
            this.Coin_Exchange_add.Size = new System.Drawing.Size(87, 37);
            this.Coin_Exchange_add.TabIndex = 7;
            this.Coin_Exchange_add.Text = "أضافة";
            this.Coin_Exchange_add.UseSelectable = true;
            this.Coin_Exchange_add.Click += new System.EventHandler(this.Coin_Exchange_add_Click);
            // 
            // Coin_Exchange_new
            // 
            this.Coin_Exchange_new.Highlight = true;
            this.Coin_Exchange_new.Location = new System.Drawing.Point(252, 390);
            this.Coin_Exchange_new.Name = "Coin_Exchange_new";
            this.Coin_Exchange_new.Size = new System.Drawing.Size(87, 37);
            this.Coin_Exchange_new.TabIndex = 6;
            this.Coin_Exchange_new.Text = "جديد";
            this.Coin_Exchange_new.UseSelectable = true;
            this.Coin_Exchange_new.Click += new System.EventHandler(this.Coin_Exchange_new_Click);
            // 
            // Coin_Exchange_Gridview
            // 
            this.Coin_Exchange_Gridview.AllowUserToAddRows = false;
            this.Coin_Exchange_Gridview.AllowUserToDeleteRows = false;
            this.Coin_Exchange_Gridview.AllowUserToResizeRows = false;
            this.Coin_Exchange_Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Coin_Exchange_Gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Coin_Exchange_Gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Coin_Exchange_Gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Coin_Exchange_Gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Coin_Exchange_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Coin_Exchange_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Coin_Exchange_Gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.Coin_Exchange_Gridview.EnableHeadersVisualStyles = false;
            this.Coin_Exchange_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Coin_Exchange_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Coin_Exchange_Gridview.Location = new System.Drawing.Point(272, 79);
            this.Coin_Exchange_Gridview.Name = "Coin_Exchange_Gridview";
            this.Coin_Exchange_Gridview.ReadOnly = true;
            this.Coin_Exchange_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Coin_Exchange_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Coin_Exchange_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Coin_Exchange_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Coin_Exchange_Gridview.Size = new System.Drawing.Size(514, 282);
            this.Coin_Exchange_Gridview.TabIndex = 66;
            this.Coin_Exchange_Gridview.Click += new System.EventHandler(this.Coin_Exchange_Gridview_Click);
            // 
            // Coin_Exchange_Date
            // 
            this.Coin_Exchange_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Coin_Exchange_Date.Location = new System.Drawing.Point(103, 229);
            this.Coin_Exchange_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.Coin_Exchange_Date.Name = "Coin_Exchange_Date";
            this.Coin_Exchange_Date.RightToLeftLayout = true;
            this.Coin_Exchange_Date.Size = new System.Drawing.Size(163, 29);
            this.Coin_Exchange_Date.TabIndex = 3;
            // 
            // Coin_Exchange_CombBudge
            // 
            this.Coin_Exchange_CombBudge.FormattingEnabled = true;
            this.Coin_Exchange_CombBudge.ItemHeight = 23;
            this.Coin_Exchange_CombBudge.Location = new System.Drawing.Point(103, 329);
            this.Coin_Exchange_CombBudge.Name = "Coin_Exchange_CombBudge";
            this.Coin_Exchange_CombBudge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Coin_Exchange_CombBudge.Size = new System.Drawing.Size(163, 29);
            this.Coin_Exchange_CombBudge.TabIndex = 5;
            this.Coin_Exchange_CombBudge.UseSelectable = true;
            // 
            // Coin_Exchange_CombSerach
            // 
            this.Coin_Exchange_CombSerach.FormattingEnabled = true;
            this.Coin_Exchange_CombSerach.ItemHeight = 23;
            this.Coin_Exchange_CombSerach.Location = new System.Drawing.Point(445, 32);
            this.Coin_Exchange_CombSerach.Name = "Coin_Exchange_CombSerach";
            this.Coin_Exchange_CombSerach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Coin_Exchange_CombSerach.Size = new System.Drawing.Size(195, 29);
            this.Coin_Exchange_CombSerach.TabIndex = 11;
            this.Coin_Exchange_CombSerach.UseSelectable = true;
            this.Coin_Exchange_CombSerach.SelectedValueChanged += new System.EventHandler(this.Coin_Exchange_CombSerach_SelectedValueChanged);
            // 
            // Coin_Exchange_Notes
            // 
            // 
            // 
            // 
            this.Coin_Exchange_Notes.CustomButton.Image = null;
            this.Coin_Exchange_Notes.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.Coin_Exchange_Notes.CustomButton.Name = "";
            this.Coin_Exchange_Notes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Coin_Exchange_Notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Coin_Exchange_Notes.CustomButton.TabIndex = 1;
            this.Coin_Exchange_Notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Coin_Exchange_Notes.CustomButton.UseSelectable = true;
            this.Coin_Exchange_Notes.CustomButton.Visible = false;
            this.Coin_Exchange_Notes.Lines = new string[0];
            this.Coin_Exchange_Notes.Location = new System.Drawing.Point(103, 282);
            this.Coin_Exchange_Notes.MaxLength = 32767;
            this.Coin_Exchange_Notes.Name = "Coin_Exchange_Notes";
            this.Coin_Exchange_Notes.PasswordChar = '\0';
            this.Coin_Exchange_Notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Coin_Exchange_Notes.SelectedText = "";
            this.Coin_Exchange_Notes.SelectionLength = 0;
            this.Coin_Exchange_Notes.SelectionStart = 0;
            this.Coin_Exchange_Notes.ShortcutsEnabled = true;
            this.Coin_Exchange_Notes.Size = new System.Drawing.Size(163, 23);
            this.Coin_Exchange_Notes.TabIndex = 82;
            this.Coin_Exchange_Notes.UseSelectable = true;
            this.Coin_Exchange_Notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Coin_Exchange_Notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Coin_Exchange_Sy
            // 
            // 
            // 
            // 
            this.Coin_Exchange_Sy.CustomButton.Image = null;
            this.Coin_Exchange_Sy.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.Coin_Exchange_Sy.CustomButton.Name = "";
            this.Coin_Exchange_Sy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Coin_Exchange_Sy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Coin_Exchange_Sy.CustomButton.TabIndex = 1;
            this.Coin_Exchange_Sy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Coin_Exchange_Sy.CustomButton.UseSelectable = true;
            this.Coin_Exchange_Sy.CustomButton.Visible = false;
            this.Coin_Exchange_Sy.Lines = new string[0];
            this.Coin_Exchange_Sy.Location = new System.Drawing.Point(103, 88);
            this.Coin_Exchange_Sy.MaxLength = 32767;
            this.Coin_Exchange_Sy.Name = "Coin_Exchange_Sy";
            this.Coin_Exchange_Sy.PasswordChar = '\0';
            this.Coin_Exchange_Sy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Coin_Exchange_Sy.SelectedText = "";
            this.Coin_Exchange_Sy.SelectionLength = 0;
            this.Coin_Exchange_Sy.SelectionStart = 0;
            this.Coin_Exchange_Sy.ShortcutsEnabled = true;
            this.Coin_Exchange_Sy.Size = new System.Drawing.Size(163, 23);
            this.Coin_Exchange_Sy.TabIndex = 83;
            this.Coin_Exchange_Sy.UseSelectable = true;
            this.Coin_Exchange_Sy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Coin_Exchange_Sy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Coin_Exchange_Dollar
            // 
            // 
            // 
            // 
            this.Coin_Exchange_Dollar.CustomButton.Image = null;
            this.Coin_Exchange_Dollar.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.Coin_Exchange_Dollar.CustomButton.Name = "";
            this.Coin_Exchange_Dollar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Coin_Exchange_Dollar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Coin_Exchange_Dollar.CustomButton.TabIndex = 1;
            this.Coin_Exchange_Dollar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Coin_Exchange_Dollar.CustomButton.UseSelectable = true;
            this.Coin_Exchange_Dollar.CustomButton.Visible = false;
            this.Coin_Exchange_Dollar.Lines = new string[0];
            this.Coin_Exchange_Dollar.Location = new System.Drawing.Point(103, 135);
            this.Coin_Exchange_Dollar.MaxLength = 32767;
            this.Coin_Exchange_Dollar.Name = "Coin_Exchange_Dollar";
            this.Coin_Exchange_Dollar.PasswordChar = '\0';
            this.Coin_Exchange_Dollar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Coin_Exchange_Dollar.SelectedText = "";
            this.Coin_Exchange_Dollar.SelectionLength = 0;
            this.Coin_Exchange_Dollar.SelectionStart = 0;
            this.Coin_Exchange_Dollar.ShortcutsEnabled = true;
            this.Coin_Exchange_Dollar.Size = new System.Drawing.Size(163, 23);
            this.Coin_Exchange_Dollar.TabIndex = 84;
            this.Coin_Exchange_Dollar.UseSelectable = true;
            this.Coin_Exchange_Dollar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Coin_Exchange_Dollar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Coin_Exchange_rate
            // 
            // 
            // 
            // 
            this.Coin_Exchange_rate.CustomButton.Image = null;
            this.Coin_Exchange_rate.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.Coin_Exchange_rate.CustomButton.Name = "";
            this.Coin_Exchange_rate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Coin_Exchange_rate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Coin_Exchange_rate.CustomButton.TabIndex = 1;
            this.Coin_Exchange_rate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Coin_Exchange_rate.CustomButton.UseSelectable = true;
            this.Coin_Exchange_rate.CustomButton.Visible = false;
            this.Coin_Exchange_rate.Lines = new string[0];
            this.Coin_Exchange_rate.Location = new System.Drawing.Point(103, 182);
            this.Coin_Exchange_rate.MaxLength = 32767;
            this.Coin_Exchange_rate.Name = "Coin_Exchange_rate";
            this.Coin_Exchange_rate.PasswordChar = '\0';
            this.Coin_Exchange_rate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Coin_Exchange_rate.SelectedText = "";
            this.Coin_Exchange_rate.SelectionLength = 0;
            this.Coin_Exchange_rate.SelectionStart = 0;
            this.Coin_Exchange_rate.ShortcutsEnabled = true;
            this.Coin_Exchange_rate.Size = new System.Drawing.Size(163, 23);
            this.Coin_Exchange_rate.TabIndex = 85;
            this.Coin_Exchange_rate.UseSelectable = true;
            this.Coin_Exchange_rate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Coin_Exchange_rate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Coin_Exc_Date
            // 
            this.Coin_Exc_Date.AutoSize = true;
            this.Coin_Exc_Date.Location = new System.Drawing.Point(15, 239);
            this.Coin_Exc_Date.Name = "Coin_Exc_Date";
            this.Coin_Exc_Date.Size = new System.Drawing.Size(41, 19);
            this.Coin_Exc_Date.TabIndex = 213;
            this.Coin_Exc_Date.Text = "التاريخ";
            // 
            // Coin_Exc_rate
            // 
            this.Coin_Exc_rate.AutoSize = true;
            this.Coin_Exc_rate.Location = new System.Drawing.Point(7, 186);
            this.Coin_Exc_rate.Name = "Coin_Exc_rate";
            this.Coin_Exc_rate.Size = new System.Drawing.Size(76, 19);
            this.Coin_Exc_rate.TabIndex = 214;
            this.Coin_Exc_rate.Text = "قيمة التحويل";
            // 
            // Coin_Exc_CombBudge
            // 
            this.Coin_Exc_CombBudge.AutoSize = true;
            this.Coin_Exc_CombBudge.Location = new System.Drawing.Point(15, 339);
            this.Coin_Exc_CombBudge.Name = "Coin_Exc_CombBudge";
            this.Coin_Exc_CombBudge.Size = new System.Drawing.Size(49, 19);
            this.Coin_Exc_CombBudge.TabIndex = 215;
            this.Coin_Exc_CombBudge.Text = "الميزانية";
            // 
            // Coin_Exc_Dollar
            // 
            this.Coin_Exc_Dollar.AutoSize = true;
            this.Coin_Exc_Dollar.Location = new System.Drawing.Point(7, 139);
            this.Coin_Exc_Dollar.Name = "Coin_Exc_Dollar";
            this.Coin_Exc_Dollar.Size = new System.Drawing.Size(80, 19);
            this.Coin_Exc_Dollar.TabIndex = 216;
            this.Coin_Exc_Dollar.Text = "المبلغ بالدولار";
            // 
            // Coin_Exc_CombSerach
            // 
            this.Coin_Exc_CombSerach.AutoSize = true;
            this.Coin_Exc_CombSerach.Location = new System.Drawing.Point(303, 42);
            this.Coin_Exc_CombSerach.Name = "Coin_Exc_CombSerach";
            this.Coin_Exc_CombSerach.Size = new System.Drawing.Size(122, 19);
            this.Coin_Exc_CombSerach.TabIndex = 217;
            this.Coin_Exc_CombSerach.Text = "البحث حسب الميزانية";
            // 
            // Coin_Exc_Sy
            // 
            this.Coin_Exc_Sy.AutoSize = true;
            this.Coin_Exc_Sy.Location = new System.Drawing.Point(7, 88);
            this.Coin_Exc_Sy.Name = "Coin_Exc_Sy";
            this.Coin_Exc_Sy.Size = new System.Drawing.Size(86, 19);
            this.Coin_Exc_Sy.TabIndex = 218;
            this.Coin_Exc_Sy.Text = "المبلغ بالسوري";
            // 
            // Coin_Exc_Notes
            // 
            this.Coin_Exc_Notes.AutoSize = true;
            this.Coin_Exc_Notes.Location = new System.Drawing.Point(7, 286);
            this.Coin_Exc_Notes.Name = "Coin_Exc_Notes";
            this.Coin_Exc_Notes.Size = new System.Drawing.Size(66, 19);
            this.Coin_Exc_Notes.TabIndex = 219;
            this.Coin_Exc_Notes.Text = "الملاحظات";
            // 
            // Coin_Exchange_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Coin_Exc_Notes);
            this.Controls.Add(this.Coin_Exc_Sy);
            this.Controls.Add(this.Coin_Exc_CombSerach);
            this.Controls.Add(this.Coin_Exc_Dollar);
            this.Controls.Add(this.Coin_Exc_CombBudge);
            this.Controls.Add(this.Coin_Exc_rate);
            this.Controls.Add(this.Coin_Exc_Date);
            this.Controls.Add(this.Coin_Exchange_rate);
            this.Controls.Add(this.Coin_Exchange_Dollar);
            this.Controls.Add(this.Coin_Exchange_Sy);
            this.Controls.Add(this.Coin_Exchange_Notes);
            this.Controls.Add(this.Coin_Exchange_CombSerach);
            this.Controls.Add(this.Coin_Exchange_CombBudge);
            this.Controls.Add(this.Coin_Exchange_Date);
            this.Controls.Add(this.Coin_Exchange_exit);
            this.Controls.Add(this.Coin_Exchange_delete);
            this.Controls.Add(this.Coin_Exchange_update);
            this.Controls.Add(this.Coin_Exchange_add);
            this.Controls.Add(this.Coin_Exchange_new);
            this.Controls.Add(this.Coin_Exchange_Gridview);
            this.Name = "Coin_Exchange_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "التحويل المالي";
            ((System.ComponentModel.ISupportInitialize)(this.Coin_Exchange_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton Coin_Exchange_exit;
        private MetroFramework.Controls.MetroButton Coin_Exchange_delete;
        private MetroFramework.Controls.MetroButton Coin_Exchange_update;
        private MetroFramework.Controls.MetroButton Coin_Exchange_add;
        private MetroFramework.Controls.MetroButton Coin_Exchange_new;
        private MetroFramework.Controls.MetroGrid Coin_Exchange_Gridview;
        private MetroFramework.Controls.MetroDateTime Coin_Exchange_Date;
        private MetroFramework.Controls.MetroComboBox Coin_Exchange_CombBudge;
        private MetroFramework.Controls.MetroComboBox Coin_Exchange_CombSerach;
        private MetroFramework.Controls.MetroTextBox Coin_Exchange_Notes;
        private MetroFramework.Controls.MetroTextBox Coin_Exchange_Sy;
        private MetroFramework.Controls.MetroTextBox Coin_Exchange_Dollar;
        private MetroFramework.Controls.MetroTextBox Coin_Exchange_rate;
        private MetroFramework.Controls.MetroLabel Coin_Exc_Date;
        private MetroFramework.Controls.MetroLabel Coin_Exc_rate;
        private MetroFramework.Controls.MetroLabel Coin_Exc_CombBudge;
        private MetroFramework.Controls.MetroLabel Coin_Exc_Dollar;
        private MetroFramework.Controls.MetroLabel Coin_Exc_CombSerach;
        private MetroFramework.Controls.MetroLabel Coin_Exc_Sy;
        private MetroFramework.Controls.MetroLabel Coin_Exc_Notes;
    }
}