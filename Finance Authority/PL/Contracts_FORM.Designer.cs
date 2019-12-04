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
            this.Contracts_exit = new MetroFramework.Controls.MetroButton();
            this.Contracts_delete = new MetroFramework.Controls.MetroButton();
            this.Contracts_update = new MetroFramework.Controls.MetroButton();
            this.Contracts_add = new MetroFramework.Controls.MetroButton();
            this.Contracts_new = new MetroFramework.Controls.MetroButton();
            this.Contracts_Gridview = new MetroFramework.Controls.MetroGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.Contracts_Notes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contracts_Type = new System.Windows.Forms.TextBox();
            this.Contracts_Date_Start = new MetroFramework.Controls.MetroDateTime();
            this.Contracts_Date_end = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Contracts_end = new System.Windows.Forms.RadioButton();
            this.Contracts_Not_end = new System.Windows.Forms.RadioButton();
            this.Contracts_Comb_Department = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Contracts_Comb_Employee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Contracts_Gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contracts_exit
            // 
            this.Contracts_exit.Highlight = true;
            this.Contracts_exit.Location = new System.Drawing.Point(794, 509);
            this.Contracts_exit.Name = "Contracts_exit";
            this.Contracts_exit.Size = new System.Drawing.Size(87, 37);
            this.Contracts_exit.TabIndex = 55;
            this.Contracts_exit.Text = "خروج";
            this.Contracts_exit.UseSelectable = true;
            this.Contracts_exit.Click += new System.EventHandler(this.Contracts_exit_Click);
            // 
            // Contracts_delete
            // 
            this.Contracts_delete.Enabled = false;
            this.Contracts_delete.Highlight = true;
            this.Contracts_delete.Location = new System.Drawing.Point(682, 509);
            this.Contracts_delete.Name = "Contracts_delete";
            this.Contracts_delete.Size = new System.Drawing.Size(87, 37);
            this.Contracts_delete.TabIndex = 54;
            this.Contracts_delete.Text = "حذف";
            this.Contracts_delete.UseSelectable = true;
            // 
            // Contracts_update
            // 
            this.Contracts_update.Enabled = false;
            this.Contracts_update.Highlight = true;
            this.Contracts_update.Location = new System.Drawing.Point(570, 509);
            this.Contracts_update.Name = "Contracts_update";
            this.Contracts_update.Size = new System.Drawing.Size(87, 37);
            this.Contracts_update.TabIndex = 53;
            this.Contracts_update.Text = "تعديل";
            this.Contracts_update.UseSelectable = true;
            // 
            // Contracts_add
            // 
            this.Contracts_add.Enabled = false;
            this.Contracts_add.Highlight = true;
            this.Contracts_add.Location = new System.Drawing.Point(458, 509);
            this.Contracts_add.Name = "Contracts_add";
            this.Contracts_add.Size = new System.Drawing.Size(87, 37);
            this.Contracts_add.TabIndex = 52;
            this.Contracts_add.Text = "أضافة";
            this.Contracts_add.UseSelectable = true;
            this.Contracts_add.Click += new System.EventHandler(this.Contracts_add_Click);
            // 
            // Contracts_new
            // 
            this.Contracts_new.Highlight = true;
            this.Contracts_new.Location = new System.Drawing.Point(346, 509);
            this.Contracts_new.Name = "Contracts_new";
            this.Contracts_new.Size = new System.Drawing.Size(87, 37);
            this.Contracts_new.TabIndex = 51;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "الملاحظات";
            // 
            // Contracts_Notes
            // 
            this.Contracts_Notes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contracts_Notes.Location = new System.Drawing.Point(99, 359);
            this.Contracts_Notes.Name = "Contracts_Notes";
            this.Contracts_Notes.Size = new System.Drawing.Size(163, 23);
            this.Contracts_Notes.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "نوع العقد";
            // 
            // Contracts_Type
            // 
            this.Contracts_Type.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contracts_Type.Location = new System.Drawing.Point(99, 139);
            this.Contracts_Type.Name = "Contracts_Type";
            this.Contracts_Type.Size = new System.Drawing.Size(163, 23);
            this.Contracts_Type.TabIndex = 46;
            // 
            // Contracts_Date_Start
            // 
            this.Contracts_Date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Contracts_Date_Start.Location = new System.Drawing.Point(99, 183);
            this.Contracts_Date_Start.MinimumSize = new System.Drawing.Size(0, 29);
            this.Contracts_Date_Start.Name = "Contracts_Date_Start";
            this.Contracts_Date_Start.RightToLeftLayout = true;
            this.Contracts_Date_Start.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Date_Start.TabIndex = 56;
            // 
            // Contracts_Date_end
            // 
            this.Contracts_Date_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Contracts_Date_end.Location = new System.Drawing.Point(99, 233);
            this.Contracts_Date_end.MinimumSize = new System.Drawing.Size(0, 29);
            this.Contracts_Date_end.Name = "Contracts_Date_end";
            this.Contracts_Date_end.RightToLeftLayout = true;
            this.Contracts_Date_end.Size = new System.Drawing.Size(163, 29);
            this.Contracts_Date_end.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "تاريخ البداية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "تاريخ النهاية";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Contracts_end);
            this.groupBox1.Controls.Add(this.Contracts_Not_end);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 55);
            this.groupBox1.TabIndex = 179;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الحالة العقد:";
            // 
            // Contracts_end
            // 
            this.Contracts_end.AutoSize = true;
            this.Contracts_end.Checked = true;
            this.Contracts_end.Location = new System.Drawing.Point(157, 22);
            this.Contracts_end.Name = "Contracts_end";
            this.Contracts_end.Size = new System.Drawing.Size(63, 20);
            this.Contracts_end.TabIndex = 174;
            this.Contracts_end.TabStop = true;
            this.Contracts_end.Text = "منتهي";
            this.Contracts_end.UseVisualStyleBackColor = true;
            // 
            // Contracts_Not_end
            // 
            this.Contracts_Not_end.AutoSize = true;
            this.Contracts_Not_end.Location = new System.Drawing.Point(24, 22);
            this.Contracts_Not_end.Name = "Contracts_Not_end";
            this.Contracts_Not_end.Size = new System.Drawing.Size(85, 20);
            this.Contracts_Not_end.TabIndex = 175;
            this.Contracts_Not_end.Text = "غير منتهي";
            this.Contracts_Not_end.UseVisualStyleBackColor = true;
            // 
            // Contracts_Comb_Department
            // 
            this.Contracts_Comb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Contracts_Comb_Department.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contracts_Comb_Department.FormattingEnabled = true;
            this.Contracts_Comb_Department.Location = new System.Drawing.Point(99, 405);
            this.Contracts_Comb_Department.Name = "Contracts_Comb_Department";
            this.Contracts_Comb_Department.Size = new System.Drawing.Size(163, 24);
            this.Contracts_Comb_Department.TabIndex = 181;
            this.Contracts_Comb_Department.SelectedValueChanged += new System.EventHandler(this.Contracts_Comb_Department_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 180;
            this.label7.Text = "الأقسام";
            // 
            // Contracts_Comb_Employee
            // 
            this.Contracts_Comb_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Contracts_Comb_Employee.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contracts_Comb_Employee.FormattingEnabled = true;
            this.Contracts_Comb_Employee.Location = new System.Drawing.Point(99, 452);
            this.Contracts_Comb_Employee.Name = "Contracts_Comb_Employee";
            this.Contracts_Comb_Employee.Size = new System.Drawing.Size(163, 24);
            this.Contracts_Comb_Employee.TabIndex = 183;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 182;
            this.label5.Text = "الموظفين";
            // 
            // Contracts_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 556);
            this.Controls.Add(this.Contracts_Comb_Employee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Contracts_Comb_Department);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contracts_Date_end);
            this.Controls.Add(this.Contracts_Date_Start);
            this.Controls.Add(this.Contracts_exit);
            this.Controls.Add(this.Contracts_delete);
            this.Controls.Add(this.Contracts_update);
            this.Controls.Add(this.Contracts_add);
            this.Controls.Add(this.Contracts_new);
            this.Controls.Add(this.Contracts_Gridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Contracts_Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Contracts_Type);
            this.Name = "Contracts_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العقود";
            ((System.ComponentModel.ISupportInitialize)(this.Contracts_Gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contracts_Notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contracts_Type;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_Start;
        private MetroFramework.Controls.MetroDateTime Contracts_Date_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Contracts_end;
        private System.Windows.Forms.RadioButton Contracts_Not_end;
        private System.Windows.Forms.ComboBox Contracts_Comb_Department;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Contracts_Comb_Employee;
        private System.Windows.Forms.Label label5;
    }
}