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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.Coin_Exchange_exit = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_delete = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_update = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_add = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_new = new MetroFramework.Controls.MetroButton();
            this.Coin_Exchange_Gridview = new MetroFramework.Controls.MetroGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.Coin_Exchange_Dollar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Coin_Exchange_Sy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Coin_Exchange_rate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Coin_Exchange_Notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Coin_Exchange_Date = new MetroFramework.Controls.MetroDateTime();
            this.Coin_Exchange_CombBudge = new MetroFramework.Controls.MetroComboBox();
            this.Coin_Exchange_CombSerach = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Coin_Exchange_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "الميزانية";
            // 
            // Coin_Exchange_exit
            // 
            this.Coin_Exchange_exit.Highlight = true;
            this.Coin_Exchange_exit.Location = new System.Drawing.Point(700, 390);
            this.Coin_Exchange_exit.Name = "Coin_Exchange_exit";
            this.Coin_Exchange_exit.Size = new System.Drawing.Size(87, 37);
            this.Coin_Exchange_exit.TabIndex = 71;
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
            this.Coin_Exchange_delete.TabIndex = 70;
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
            this.Coin_Exchange_update.TabIndex = 69;
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
            this.Coin_Exchange_add.TabIndex = 68;
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
            this.Coin_Exchange_new.TabIndex = 67;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Coin_Exchange_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Coin_Exchange_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Coin_Exchange_Gridview.DefaultCellStyle = dataGridViewCellStyle11;
            this.Coin_Exchange_Gridview.EnableHeadersVisualStyles = false;
            this.Coin_Exchange_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Coin_Exchange_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Coin_Exchange_Gridview.Location = new System.Drawing.Point(272, 79);
            this.Coin_Exchange_Gridview.Name = "Coin_Exchange_Gridview";
            this.Coin_Exchange_Gridview.ReadOnly = true;
            this.Coin_Exchange_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Coin_Exchange_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Coin_Exchange_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Coin_Exchange_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Coin_Exchange_Gridview.Size = new System.Drawing.Size(514, 282);
            this.Coin_Exchange_Gridview.TabIndex = 66;
            this.Coin_Exchange_Gridview.Click += new System.EventHandler(this.Coin_Exchange_Gridview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "المبلغ بالدولار";
            // 
            // Coin_Exchange_Dollar
            // 
            this.Coin_Exchange_Dollar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coin_Exchange_Dollar.Location = new System.Drawing.Point(103, 133);
            this.Coin_Exchange_Dollar.Name = "Coin_Exchange_Dollar";
            this.Coin_Exchange_Dollar.Size = new System.Drawing.Size(163, 23);
            this.Coin_Exchange_Dollar.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "المبلغ بالسوري";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "البحث حسب الميزانية";
            // 
            // Coin_Exchange_Sy
            // 
            this.Coin_Exchange_Sy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coin_Exchange_Sy.Location = new System.Drawing.Point(103, 85);
            this.Coin_Exchange_Sy.Name = "Coin_Exchange_Sy";
            this.Coin_Exchange_Sy.Size = new System.Drawing.Size(163, 23);
            this.Coin_Exchange_Sy.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "قيمة التحويل";
            // 
            // Coin_Exchange_rate
            // 
            this.Coin_Exchange_rate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coin_Exchange_rate.Location = new System.Drawing.Point(103, 181);
            this.Coin_Exchange_rate.Name = "Coin_Exchange_rate";
            this.Coin_Exchange_rate.Size = new System.Drawing.Size(163, 23);
            this.Coin_Exchange_rate.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "الملاحظات";
            // 
            // Coin_Exchange_Notes
            // 
            this.Coin_Exchange_Notes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coin_Exchange_Notes.Location = new System.Drawing.Point(103, 283);
            this.Coin_Exchange_Notes.Name = "Coin_Exchange_Notes";
            this.Coin_Exchange_Notes.Size = new System.Drawing.Size(163, 23);
            this.Coin_Exchange_Notes.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 79;
            this.label8.Text = "التاريخ";
            // 
            // Coin_Exchange_Date
            // 
            this.Coin_Exchange_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Coin_Exchange_Date.Location = new System.Drawing.Point(103, 229);
            this.Coin_Exchange_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.Coin_Exchange_Date.Name = "Coin_Exchange_Date";
            this.Coin_Exchange_Date.RightToLeftLayout = true;
            this.Coin_Exchange_Date.Size = new System.Drawing.Size(163, 29);
            this.Coin_Exchange_Date.TabIndex = 82;
            // 
            // Coin_Exchange_CombBudge
            // 
            this.Coin_Exchange_CombBudge.FormattingEnabled = true;
            this.Coin_Exchange_CombBudge.ItemHeight = 23;
            this.Coin_Exchange_CombBudge.Location = new System.Drawing.Point(103, 332);
            this.Coin_Exchange_CombBudge.Name = "Coin_Exchange_CombBudge";
            this.Coin_Exchange_CombBudge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Coin_Exchange_CombBudge.Size = new System.Drawing.Size(163, 29);
            this.Coin_Exchange_CombBudge.TabIndex = 83;
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
            this.Coin_Exchange_CombSerach.TabIndex = 84;
            this.Coin_Exchange_CombSerach.UseSelectable = true;
           
            this.Coin_Exchange_CombSerach.SelectedValueChanged += new System.EventHandler(this.Coin_Exchange_CombSerach_SelectedValueChanged);
            // 
            // Coin_Exchange_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Coin_Exchange_CombSerach);
            this.Controls.Add(this.Coin_Exchange_CombBudge);
            this.Controls.Add(this.Coin_Exchange_Date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Coin_Exchange_Notes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Coin_Exchange_rate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Coin_Exchange_exit);
            this.Controls.Add(this.Coin_Exchange_delete);
            this.Controls.Add(this.Coin_Exchange_update);
            this.Controls.Add(this.Coin_Exchange_add);
            this.Controls.Add(this.Coin_Exchange_new);
            this.Controls.Add(this.Coin_Exchange_Gridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Coin_Exchange_Dollar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Coin_Exchange_Sy);
            this.Name = "Coin_Exchange_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "التحويل المالي";
            ((System.ComponentModel.ISupportInitialize)(this.Coin_Exchange_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton Coin_Exchange_exit;
        private MetroFramework.Controls.MetroButton Coin_Exchange_delete;
        private MetroFramework.Controls.MetroButton Coin_Exchange_update;
        private MetroFramework.Controls.MetroButton Coin_Exchange_add;
        private MetroFramework.Controls.MetroButton Coin_Exchange_new;
        private MetroFramework.Controls.MetroGrid Coin_Exchange_Gridview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Coin_Exchange_Dollar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Coin_Exchange_Sy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Coin_Exchange_rate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Coin_Exchange_Notes;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroDateTime Coin_Exchange_Date;
        private MetroFramework.Controls.MetroComboBox Coin_Exchange_CombBudge;
        private MetroFramework.Controls.MetroComboBox Coin_Exchange_CombSerach;
    }
}