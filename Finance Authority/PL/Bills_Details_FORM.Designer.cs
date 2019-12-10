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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bill_Objects_dataGrid = new MetroFramework.Controls.MetroGrid();
            this.Bills_exit = new MetroFramework.Controls.MetroButton();
            this.Bills_delete = new MetroFramework.Controls.MetroButton();
            this.Bills_update = new MetroFramework.Controls.MetroButton();
            this.Bills_add = new MetroFramework.Controls.MetroButton();
            this.Bills_new = new MetroFramework.Controls.MetroButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Bill_Total = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Bills_Notes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Bills_NO_Bill = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Bills_Buyer_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Bill_Type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bills_Coin_Type = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Bills_Exchange_rate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bills_Date = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bills_Paid = new System.Windows.Forms.RadioButton();
            this.Bills_Not = new System.Windows.Forms.RadioButton();
            this.Bills_Comb_Budget = new MetroFramework.Controls.MetroComboBox();
            this.Bills_Comb_Department = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bills_Details_Print = new MetroFramework.Controls.MetroButton();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill_Objects_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Bill_Objects_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bill_Objects_dataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Bill_Objects_dataGrid.EnableHeadersVisualStyles = false;
            this.Bill_Objects_dataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Bill_Objects_dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bill_Objects_dataGrid.Location = new System.Drawing.Point(315, 77);
            this.Bill_Objects_dataGrid.Name = "Bill_Objects_dataGrid";
            this.Bill_Objects_dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill_Objects_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Bill_Objects_dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Bill_Objects_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Bill_Objects_dataGrid.Size = new System.Drawing.Size(679, 415);
            this.Bill_Objects_dataGrid.TabIndex = 47;
            this.Bill_Objects_dataGrid.Click += new System.EventHandler(this.Bills_dataGrid_Click);
            // 
            // Bills_exit
            // 
            this.Bills_exit.Highlight = true;
            this.Bills_exit.Location = new System.Drawing.Point(881, 508);
            this.Bills_exit.Name = "Bills_exit";
            this.Bills_exit.Size = new System.Drawing.Size(87, 37);
            this.Bills_exit.TabIndex = 46;
            this.Bills_exit.Text = "خروج";
            this.Bills_exit.UseSelectable = true;
            this.Bills_exit.Click += new System.EventHandler(this.Bills_exit_Click);
            // 
            // Bills_delete
            // 
            this.Bills_delete.Highlight = true;
            this.Bills_delete.Location = new System.Drawing.Point(661, 508);
            this.Bills_delete.Name = "Bills_delete";
            this.Bills_delete.Size = new System.Drawing.Size(87, 37);
            this.Bills_delete.TabIndex = 45;
            this.Bills_delete.Text = "حذف";
            this.Bills_delete.UseSelectable = true;
            this.Bills_delete.Click += new System.EventHandler(this.Bills_delete_Click);
            // 
            // Bills_update
            // 
            this.Bills_update.Highlight = true;
            this.Bills_update.Location = new System.Drawing.Point(551, 508);
            this.Bills_update.Name = "Bills_update";
            this.Bills_update.Size = new System.Drawing.Size(87, 37);
            this.Bills_update.TabIndex = 44;
            this.Bills_update.Text = "تعديل";
            this.Bills_update.UseSelectable = true;
            this.Bills_update.Click += new System.EventHandler(this.Bills_update_Click);
            // 
            // Bills_add
            // 
            this.Bills_add.Enabled = false;
            this.Bills_add.Highlight = true;
            this.Bills_add.Location = new System.Drawing.Point(441, 508);
            this.Bills_add.Name = "Bills_add";
            this.Bills_add.Size = new System.Drawing.Size(87, 37);
            this.Bills_add.TabIndex = 43;
            this.Bills_add.Text = "أضافة";
            this.Bills_add.UseSelectable = true;
            this.Bills_add.Click += new System.EventHandler(this.Bills_add_Click);
            // 
            // Bills_new
            // 
            this.Bills_new.Highlight = true;
            this.Bills_new.Location = new System.Drawing.Point(331, 508);
            this.Bills_new.Name = "Bills_new";
            this.Bills_new.Size = new System.Drawing.Size(87, 37);
            this.Bills_new.TabIndex = 42;
            this.Bills_new.Text = "جديد";
            this.Bills_new.UseSelectable = true;
            this.Bills_new.Click += new System.EventHandler(this.Bills_new_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 196;
            this.label8.Text = "القيمة الكلية للفاتورة";
            // 
            // Bill_Total
            // 
            this.Bill_Total.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Total.Location = new System.Drawing.Point(148, 247);
            this.Bill_Total.Name = "Bill_Total";
            this.Bill_Total.Size = new System.Drawing.Size(140, 23);
            this.Bill_Total.TabIndex = 195;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 393);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 194;
            this.label14.Text = "الملاحظات";
            // 
            // Bills_Notes
            // 
            this.Bills_Notes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills_Notes.Location = new System.Drawing.Point(148, 389);
            this.Bills_Notes.Name = "Bills_Notes";
            this.Bills_Notes.Size = new System.Drawing.Size(140, 23);
            this.Bills_Notes.TabIndex = 193;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 192;
            this.label15.Text = "التاريخ";
            // 
            // Bills_NO_Bill
            // 
            this.Bills_NO_Bill.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills_NO_Bill.Location = new System.Drawing.Point(148, 74);
            this.Bills_NO_Bill.Name = "Bills_NO_Bill";
            this.Bills_NO_Bill.Size = new System.Drawing.Size(140, 23);
            this.Bills_NO_Bill.TabIndex = 191;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 190;
            this.label13.Text = "نوع العملة";
            // 
            // Bills_Buyer_Name
            // 
            this.Bills_Buyer_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills_Buyer_Name.Location = new System.Drawing.Point(148, 111);
            this.Bills_Buyer_Name.Name = "Bills_Buyer_Name";
            this.Bills_Buyer_Name.Size = new System.Drawing.Size(140, 23);
            this.Bills_Buyer_Name.TabIndex = 189;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 188;
            this.label10.Text = "نوع الفاتورة";
            // 
            // Bill_Type
            // 
            this.Bill_Type.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Type.Location = new System.Drawing.Point(148, 213);
            this.Bill_Type.Name = "Bill_Type";
            this.Bill_Type.Size = new System.Drawing.Size(140, 23);
            this.Bill_Type.TabIndex = 187;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 186;
            this.label2.Text = "أسم البائع";
            // 
            // Bills_Coin_Type
            // 
            this.Bills_Coin_Type.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills_Coin_Type.Location = new System.Drawing.Point(148, 145);
            this.Bills_Coin_Type.Name = "Bills_Coin_Type";
            this.Bills_Coin_Type.Size = new System.Drawing.Size(140, 23);
            this.Bills_Coin_Type.TabIndex = 185;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 184;
            this.label9.Text = "قيمة التحويل";
            // 
            // Bills_Exchange_rate
            // 
            this.Bills_Exchange_rate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills_Exchange_rate.Location = new System.Drawing.Point(148, 179);
            this.Bills_Exchange_rate.Name = "Bills_Exchange_rate";
            this.Bills_Exchange_rate.Size = new System.Drawing.Size(140, 23);
            this.Bills_Exchange_rate.TabIndex = 183;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 197;
            this.label1.Text = "رقم الفاتورة";
            // 
            // Bills_Date
            // 
            this.Bills_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Bills_Date.Location = new System.Drawing.Point(148, 283);
            this.Bills_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.Bills_Date.Name = "Bills_Date";
            this.Bills_Date.Size = new System.Drawing.Size(140, 29);
            this.Bills_Date.TabIndex = 198;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bills_Paid);
            this.groupBox1.Controls.Add(this.Bills_Not);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 55);
            this.groupBox1.TabIndex = 199;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حالة الفاتورة:";
            // 
            // Bills_Paid
            // 
            this.Bills_Paid.AutoSize = true;
            this.Bills_Paid.Checked = true;
            this.Bills_Paid.Location = new System.Drawing.Point(135, 22);
            this.Bills_Paid.Name = "Bills_Paid";
            this.Bills_Paid.Size = new System.Drawing.Size(66, 20);
            this.Bills_Paid.TabIndex = 174;
            this.Bills_Paid.TabStop = true;
            this.Bills_Paid.Text = "مدفوعة";
            this.Bills_Paid.UseVisualStyleBackColor = true;
            // 
            // Bills_Not
            // 
            this.Bills_Not.AutoSize = true;
            this.Bills_Not.Location = new System.Drawing.Point(24, 22);
            this.Bills_Not.Name = "Bills_Not";
            this.Bills_Not.Size = new System.Drawing.Size(88, 20);
            this.Bills_Not.TabIndex = 175;
            this.Bills_Not.Text = "غير مدفوعة";
            this.Bills_Not.UseVisualStyleBackColor = true;
            // 
            // Bills_Comb_Budget
            // 
            this.Bills_Comb_Budget.FormattingEnabled = true;
            this.Bills_Comb_Budget.ItemHeight = 23;
            this.Bills_Comb_Budget.Location = new System.Drawing.Point(148, 423);
            this.Bills_Comb_Budget.Name = "Bills_Comb_Budget";
            this.Bills_Comb_Budget.Size = new System.Drawing.Size(140, 29);
            this.Bills_Comb_Budget.TabIndex = 200;
            this.Bills_Comb_Budget.UseSelectable = true;
            // 
            // Bills_Comb_Department
            // 
            this.Bills_Comb_Department.FormattingEnabled = true;
            this.Bills_Comb_Department.ItemHeight = 23;
            this.Bills_Comb_Department.Location = new System.Drawing.Point(148, 463);
            this.Bills_Comb_Department.Name = "Bills_Comb_Department";
            this.Bills_Comb_Department.Size = new System.Drawing.Size(140, 29);
            this.Bills_Comb_Department.TabIndex = 201;
            this.Bills_Comb_Department.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 202;
            this.label3.Text = "تاريخ الميزانية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 203;
            this.label4.Text = "أسم القسم";
            // 
            // Bills_Details_Print
            // 
            this.Bills_Details_Print.Highlight = true;
            this.Bills_Details_Print.Location = new System.Drawing.Point(771, 508);
            this.Bills_Details_Print.Name = "Bills_Details_Print";
            this.Bills_Details_Print.Size = new System.Drawing.Size(87, 37);
            this.Bills_Details_Print.TabIndex = 247;
            this.Bills_Details_Print.Text = "طباعة";
            this.Bills_Details_Print.UseSelectable = true;
            this.Bills_Details_Print.Click += new System.EventHandler(this.Bills_Details_Print_Click);
            // 
            // Bills_Details_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 568);
            this.Controls.Add(this.Bills_Details_Print);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bills_Comb_Department);
            this.Controls.Add(this.Bills_Comb_Budget);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bills_Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Bill_Total);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Bills_Notes);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Bills_NO_Bill);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Bills_Buyer_Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Bill_Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bills_Coin_Type);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Bills_Exchange_rate);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Bill_Total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Bills_Notes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Bills_NO_Bill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Bills_Buyer_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Bill_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Bills_Coin_Type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Bills_Exchange_rate;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime Bills_Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Bills_Paid;
        private System.Windows.Forms.RadioButton Bills_Not;
        private MetroFramework.Controls.MetroComboBox Bills_Comb_Budget;
        private MetroFramework.Controls.MetroComboBox Bills_Comb_Department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton Bills_Details_Print;
    }
}