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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Loans_Fexit = new MetroFramework.Controls.MetroButton();
            this.Loans_delete = new MetroFramework.Controls.MetroButton();
            this.Loans_update = new MetroFramework.Controls.MetroButton();
            this.Loans_add = new MetroFramework.Controls.MetroButton();
            this.Loans_new = new MetroFramework.Controls.MetroButton();
            this.Loans_Gridview = new MetroFramework.Controls.MetroGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.Loans_Notes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Loans_Amont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Loans_Date = new MetroFramework.Controls.MetroDateTime();
            this.Loans_Date_Start = new MetroFramework.Controls.MetroDateTime();
            this.Loans_Comb_Budget = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Loans_Comb_Department = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Loans_Comb_Employ = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Loans_Search_All = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Loans_Search_Budget = new MetroFramework.Controls.MetroComboBox();
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
            this.Loans_Fexit.Location = new System.Drawing.Point(818, 479);
            this.Loans_Fexit.Name = "Loans_Fexit";
            this.Loans_Fexit.Size = new System.Drawing.Size(87, 37);
            this.Loans_Fexit.TabIndex = 55;
            this.Loans_Fexit.Text = "خروج";
            this.Loans_Fexit.UseSelectable = true;
            this.Loans_Fexit.Click += new System.EventHandler(this.Loans_Fexit_Click);
            // 
            // Loans_delete
            // 
            this.Loans_delete.Enabled = false;
            this.Loans_delete.Highlight = true;
            this.Loans_delete.Location = new System.Drawing.Point(706, 479);
            this.Loans_delete.Name = "Loans_delete";
            this.Loans_delete.Size = new System.Drawing.Size(87, 37);
            this.Loans_delete.TabIndex = 54;
            this.Loans_delete.Text = "حذف";
            this.Loans_delete.UseSelectable = true;
            this.Loans_delete.Click += new System.EventHandler(this.Loans_delete_Click);
            // 
            // Loans_update
            // 
            this.Loans_update.Enabled = false;
            this.Loans_update.Highlight = true;
            this.Loans_update.Location = new System.Drawing.Point(594, 479);
            this.Loans_update.Name = "Loans_update";
            this.Loans_update.Size = new System.Drawing.Size(87, 37);
            this.Loans_update.TabIndex = 53;
            this.Loans_update.Text = "تعديل";
            this.Loans_update.UseSelectable = true;
            this.Loans_update.Click += new System.EventHandler(this.Loans_update_Click);
            // 
            // Loans_add
            // 
            this.Loans_add.Enabled = false;
            this.Loans_add.Highlight = true;
            this.Loans_add.Location = new System.Drawing.Point(482, 479);
            this.Loans_add.Name = "Loans_add";
            this.Loans_add.Size = new System.Drawing.Size(87, 37);
            this.Loans_add.TabIndex = 52;
            this.Loans_add.Text = "أضافة";
            this.Loans_add.UseSelectable = true;
            this.Loans_add.Click += new System.EventHandler(this.Loans_add_Click);
            // 
            // Loans_new
            // 
            this.Loans_new.Highlight = true;
            this.Loans_new.Location = new System.Drawing.Point(370, 479);
            this.Loans_new.Name = "Loans_new";
            this.Loans_new.Size = new System.Drawing.Size(87, 37);
            this.Loans_new.TabIndex = 51;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Loans_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Loans_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Loans_Gridview.DefaultCellStyle = dataGridViewCellStyle5;
            this.Loans_Gridview.EnableHeadersVisualStyles = false;
            this.Loans_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Loans_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Loans_Gridview.Location = new System.Drawing.Point(324, 90);
            this.Loans_Gridview.Name = "Loans_Gridview";
            this.Loans_Gridview.ReadOnly = true;
            this.Loans_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Loans_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Loans_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Loans_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Loans_Gridview.Size = new System.Drawing.Size(624, 377);
            this.Loans_Gridview.TabIndex = 50;
            this.Loans_Gridview.Click += new System.EventHandler(this.Loans_Gridview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "الملاحظات";
            // 
            // Loans_Notes
            // 
            this.Loans_Notes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loans_Notes.Location = new System.Drawing.Point(127, 135);
            this.Loans_Notes.Name = "Loans_Notes";
            this.Loans_Notes.Size = new System.Drawing.Size(163, 23);
            this.Loans_Notes.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "المبلغ";
            // 
            // Loans_Amont
            // 
            this.Loans_Amont.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loans_Amont.Location = new System.Drawing.Point(127, 90);
            this.Loans_Amont.Name = "Loans_Amont";
            this.Loans_Amont.Size = new System.Drawing.Size(163, 23);
            this.Loans_Amont.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "تاريخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "تاريخ بداية الحساب";
            // 
            // Loans_Date
            // 
            this.Loans_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Loans_Date.Location = new System.Drawing.Point(127, 184);
            this.Loans_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.Loans_Date.Name = "Loans_Date";
            this.Loans_Date.Size = new System.Drawing.Size(163, 29);
            this.Loans_Date.TabIndex = 58;
            // 
            // Loans_Date_Start
            // 
            this.Loans_Date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Loans_Date_Start.Location = new System.Drawing.Point(127, 230);
            this.Loans_Date_Start.MinimumSize = new System.Drawing.Size(0, 29);
            this.Loans_Date_Start.Name = "Loans_Date_Start";
            this.Loans_Date_Start.Size = new System.Drawing.Size(163, 29);
            this.Loans_Date_Start.TabIndex = 59;
            // 
            // Loans_Comb_Budget
            // 
            this.Loans_Comb_Budget.FormattingEnabled = true;
            this.Loans_Comb_Budget.ItemHeight = 23;
            this.Loans_Comb_Budget.Location = new System.Drawing.Point(127, 279);
            this.Loans_Comb_Budget.Name = "Loans_Comb_Budget";
            this.Loans_Comb_Budget.Size = new System.Drawing.Size(163, 29);
            this.Loans_Comb_Budget.TabIndex = 60;
            this.Loans_Comb_Budget.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "تاريخ الميزانية";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "الأقسام";
            // 
            // Loans_Comb_Department
            // 
            this.Loans_Comb_Department.FormattingEnabled = true;
            this.Loans_Comb_Department.ItemHeight = 23;
            this.Loans_Comb_Department.Location = new System.Drawing.Point(127, 331);
            this.Loans_Comb_Department.Name = "Loans_Comb_Department";
            this.Loans_Comb_Department.Size = new System.Drawing.Size(163, 29);
            this.Loans_Comb_Department.TabIndex = 62;
            this.Loans_Comb_Department.UseSelectable = true;
            this.Loans_Comb_Department.SelectedValueChanged += new System.EventHandler(this.Loans_Comb_Department_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "الموظفين";
            // 
            // Loans_Comb_Employ
            // 
            this.Loans_Comb_Employ.FormattingEnabled = true;
            this.Loans_Comb_Employ.ItemHeight = 23;
            this.Loans_Comb_Employ.Location = new System.Drawing.Point(127, 378);
            this.Loans_Comb_Employ.Name = "Loans_Comb_Employ";
            this.Loans_Comb_Employ.Size = new System.Drawing.Size(163, 29);
            this.Loans_Comb_Employ.TabIndex = 64;
            this.Loans_Comb_Employ.UseSelectable = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(374, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 193;
            this.label8.Text = "بحث عام";
            // 
            // Loans_Search_All
            // 
            // 
            // 
            // 
            this.Loans_Search_All.CustomButton.Image = null;
            this.Loans_Search_All.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.Loans_Search_All.CustomButton.Name = "";
            this.Loans_Search_All.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Loans_Search_All.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Loans_Search_All.CustomButton.TabIndex = 1;
            this.Loans_Search_All.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Loans_Search_All.CustomButton.UseSelectable = true;
            this.Loans_Search_All.CustomButton.Visible = false;
            this.Loans_Search_All.Lines = new string[0];
            this.Loans_Search_All.Location = new System.Drawing.Point(437, 54);
            this.Loans_Search_All.MaxLength = 32767;
            this.Loans_Search_All.Name = "Loans_Search_All";
            this.Loans_Search_All.PasswordChar = '\0';
            this.Loans_Search_All.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Loans_Search_All.SelectedText = "";
            this.Loans_Search_All.SelectionLength = 0;
            this.Loans_Search_All.SelectionStart = 0;
            this.Loans_Search_All.ShortcutsEnabled = true;
            this.Loans_Search_All.Size = new System.Drawing.Size(158, 23);
            this.Loans_Search_All.TabIndex = 192;
            this.Loans_Search_All.UseSelectable = true;
            this.Loans_Search_All.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Loans_Search_All.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Loans_Search_All.TextChanged += new System.EventHandler(this.Loans_Search_All_TextChanged);
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
            this.Loans_Search_Budget.TabIndex = 194;
            this.Loans_Search_Budget.UseSelectable = true;
            this.Loans_Search_Budget.SelectedValueChanged += new System.EventHandler(this.Loans_Search_Budget_SelectedValueChanged);
            // 
            // Loans_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 539);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Loans_Search_Budget);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Loans_Search_All);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Loans_Comb_Employ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Loans_Comb_Department);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Loans_Comb_Budget);
            this.Controls.Add(this.Loans_Date_Start);
            this.Controls.Add(this.Loans_Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loans_Fexit);
            this.Controls.Add(this.Loans_delete);
            this.Controls.Add(this.Loans_update);
            this.Controls.Add(this.Loans_add);
            this.Controls.Add(this.Loans_new);
            this.Controls.Add(this.Loans_Gridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Loans_Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Loans_Amont);
            this.Name = "Loans_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "القروض";
            this.Load += new System.EventHandler(this.Loans_FORM_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Loans_Notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Loans_Amont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroDateTime Loans_Date;
        private MetroFramework.Controls.MetroDateTime Loans_Date_Start;
        private MetroFramework.Controls.MetroComboBox Loans_Comb_Budget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox Loans_Comb_Department;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox Loans_Comb_Employ;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox Loans_Search_All;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroComboBox Loans_Search_Budget;
    }
}