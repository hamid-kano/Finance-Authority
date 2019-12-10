namespace Finance_Authority.PL
{
    partial class Department_FORM
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
            this.Department_CombOffice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Department_exit = new MetroFramework.Controls.MetroButton();
            this.Department_delete = new MetroFramework.Controls.MetroButton();
            this.Department_update = new MetroFramework.Controls.MetroButton();
            this.Department_add = new MetroFramework.Controls.MetroButton();
            this.Department_new = new MetroFramework.Controls.MetroButton();
            this.Department_Gridview = new MetroFramework.Controls.MetroGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.Department_Notes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Department_textsearch = new System.Windows.Forms.TextBox();
            this.Department_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Department_CombOffice
            // 
            this.Department_CombOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Department_CombOffice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_CombOffice.FormattingEnabled = true;
            this.Department_CombOffice.Location = new System.Drawing.Point(93, 225);
            this.Department_CombOffice.Name = "Department_CombOffice";
            this.Department_CombOffice.Size = new System.Drawing.Size(163, 24);
            this.Department_CombOffice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "المكتب";
            // 
            // Department_exit
            // 
            this.Department_exit.Highlight = true;
            this.Department_exit.Location = new System.Drawing.Point(703, 370);
            this.Department_exit.Name = "Department_exit";
            this.Department_exit.Size = new System.Drawing.Size(87, 37);
            this.Department_exit.TabIndex = 7;
            this.Department_exit.Text = "خروج";
            this.Department_exit.UseSelectable = true;
            this.Department_exit.Click += new System.EventHandler(this.Department_exit_Click);
            // 
            // Department_delete
            // 
            this.Department_delete.Enabled = false;
            this.Department_delete.Highlight = true;
            this.Department_delete.Location = new System.Drawing.Point(591, 370);
            this.Department_delete.Name = "Department_delete";
            this.Department_delete.Size = new System.Drawing.Size(87, 37);
            this.Department_delete.TabIndex = 6;
            this.Department_delete.Text = "حذف";
            this.Department_delete.UseSelectable = true;
            this.Department_delete.Click += new System.EventHandler(this.Department_delete_Click);
            // 
            // Department_update
            // 
            this.Department_update.Enabled = false;
            this.Department_update.Highlight = true;
            this.Department_update.Location = new System.Drawing.Point(479, 370);
            this.Department_update.Name = "Department_update";
            this.Department_update.Size = new System.Drawing.Size(87, 37);
            this.Department_update.TabIndex = 5;
            this.Department_update.Text = "تعديل";
            this.Department_update.UseSelectable = true;
            this.Department_update.Click += new System.EventHandler(this.Department_update_Click);
            // 
            // Department_add
            // 
            this.Department_add.Enabled = false;
            this.Department_add.Highlight = true;
            this.Department_add.Location = new System.Drawing.Point(367, 370);
            this.Department_add.Name = "Department_add";
            this.Department_add.Size = new System.Drawing.Size(87, 37);
            this.Department_add.TabIndex = 4;
            this.Department_add.Text = "أضافة";
            this.Department_add.UseSelectable = true;
            this.Department_add.Click += new System.EventHandler(this.Department_add_Click);
            // 
            // Department_new
            // 
            this.Department_new.Highlight = true;
            this.Department_new.Location = new System.Drawing.Point(255, 370);
            this.Department_new.Name = "Department_new";
            this.Department_new.Size = new System.Drawing.Size(87, 37);
            this.Department_new.TabIndex = 3;
            this.Department_new.Text = "جديد";
            this.Department_new.UseSelectable = true;
            this.Department_new.Click += new System.EventHandler(this.Department_new_Click);
            // 
            // Department_Gridview
            // 
            this.Department_Gridview.AllowUserToAddRows = false;
            this.Department_Gridview.AllowUserToDeleteRows = false;
            this.Department_Gridview.AllowUserToResizeRows = false;
            this.Department_Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Department_Gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Department_Gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Department_Gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Department_Gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Department_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Department_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Department_Gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.Department_Gridview.EnableHeadersVisualStyles = false;
            this.Department_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Department_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Department_Gridview.Location = new System.Drawing.Point(291, 80);
            this.Department_Gridview.Name = "Department_Gridview";
            this.Department_Gridview.ReadOnly = true;
            this.Department_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Department_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Department_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Department_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Department_Gridview.Size = new System.Drawing.Size(472, 253);
            this.Department_Gridview.TabIndex = 66;
            this.Department_Gridview.Click += new System.EventHandler(this.Department_Gridview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "الملاحظات";
            // 
            // Department_Notes
            // 
            this.Department_Notes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_Notes.Location = new System.Drawing.Point(93, 171);
            this.Department_Notes.Name = "Department_Notes";
            this.Department_Notes.Size = new System.Drawing.Size(163, 23);
            this.Department_Notes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "أسم القسم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "البحث";
            // 
            // Department_textsearch
            // 
            this.Department_textsearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_textsearch.Location = new System.Drawing.Point(368, 44);
            this.Department_textsearch.Name = "Department_textsearch";
            this.Department_textsearch.Size = new System.Drawing.Size(350, 23);
            this.Department_textsearch.TabIndex = 8;
            this.Department_textsearch.TextChanged += new System.EventHandler(this.Department_textsearch_TextChanged);
            // 
            // Department_Name
            // 
            this.Department_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_Name.Location = new System.Drawing.Point(93, 104);
            this.Department_Name.Name = "Department_Name";
            this.Department_Name.Size = new System.Drawing.Size(163, 23);
            this.Department_Name.TabIndex = 0;
            // 
            // Department_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Department_CombOffice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Department_exit);
            this.Controls.Add(this.Department_delete);
            this.Controls.Add(this.Department_update);
            this.Controls.Add(this.Department_add);
            this.Controls.Add(this.Department_new);
            this.Controls.Add(this.Department_Gridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Department_Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Department_textsearch);
            this.Controls.Add(this.Department_Name);
            this.Name = "Department_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الاقسام";
            ((System.ComponentModel.ISupportInitialize)(this.Department_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Department_CombOffice;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton Department_exit;
        private MetroFramework.Controls.MetroButton Department_delete;
        private MetroFramework.Controls.MetroButton Department_update;
        private MetroFramework.Controls.MetroButton Department_add;
        private MetroFramework.Controls.MetroButton Department_new;
        private MetroFramework.Controls.MetroGrid Department_Gridview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Department_Notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Department_textsearch;
        private System.Windows.Forms.TextBox Department_Name;
    }
}