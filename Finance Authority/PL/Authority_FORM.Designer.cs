namespace Finance_Authority.PL
{
    partial class Authority_FORM
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Authority_textsearch = new System.Windows.Forms.TextBox();
            this.Authority_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Authority_Notes = new System.Windows.Forms.TextBox();
            this.Authority_Gridview = new MetroFramework.Controls.MetroGrid();
            this.Authority_exit = new MetroFramework.Controls.MetroButton();
            this.Authority_delete = new MetroFramework.Controls.MetroButton();
            this.Authority_update = new MetroFramework.Controls.MetroButton();
            this.Authority_add = new MetroFramework.Controls.MetroButton();
            this.Authority_new = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Authority_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "أسم الهيئة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "البحث";
            // 
            // Authority_textsearch
            // 
            this.Authority_textsearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authority_textsearch.Location = new System.Drawing.Point(197, 47);
            this.Authority_textsearch.Name = "Authority_textsearch";
            this.Authority_textsearch.Size = new System.Drawing.Size(350, 23);
            this.Authority_textsearch.TabIndex = 8;
            this.Authority_textsearch.TextChanged += new System.EventHandler(this.Authority_textsearch_TextChanged);
            // 
            // Authority_Name
            // 
            this.Authority_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authority_Name.Location = new System.Drawing.Point(175, 345);
            this.Authority_Name.Name = "Authority_Name";
            this.Authority_Name.Size = new System.Drawing.Size(163, 23);
            this.Authority_Name.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "الملاحظات";
            // 
            // Authority_Notes
            // 
            this.Authority_Notes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authority_Notes.Location = new System.Drawing.Point(426, 345);
            this.Authority_Notes.Name = "Authority_Notes";
            this.Authority_Notes.Size = new System.Drawing.Size(163, 23);
            this.Authority_Notes.TabIndex = 1;
            // 
            // Authority_Gridview
            // 
            this.Authority_Gridview.AllowUserToAddRows = false;
            this.Authority_Gridview.AllowUserToDeleteRows = false;
            this.Authority_Gridview.AllowUserToResizeRows = false;
            this.Authority_Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Authority_Gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Authority_Gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Authority_Gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Authority_Gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Authority_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Authority_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Authority_Gridview.DefaultCellStyle = dataGridViewCellStyle5;
            this.Authority_Gridview.EnableHeadersVisualStyles = false;
            this.Authority_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Authority_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Authority_Gridview.Location = new System.Drawing.Point(23, 76);
            this.Authority_Gridview.Name = "Authority_Gridview";
            this.Authority_Gridview.ReadOnly = true;
            this.Authority_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Authority_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Authority_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Authority_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Authority_Gridview.Size = new System.Drawing.Size(624, 253);
            this.Authority_Gridview.TabIndex = 27;
            this.Authority_Gridview.Click += new System.EventHandler(this.Authority_Gridview_Click);
            // 
            // Authority_exit
            // 
            this.Authority_exit.Highlight = true;
            this.Authority_exit.Location = new System.Drawing.Point(524, 390);
            this.Authority_exit.Name = "Authority_exit";
            this.Authority_exit.Size = new System.Drawing.Size(87, 37);
            this.Authority_exit.TabIndex = 7;
            this.Authority_exit.Text = "خروج";
            this.Authority_exit.UseSelectable = true;
            this.Authority_exit.Click += new System.EventHandler(this.Authority_exit_Click);
            // 
            // Authority_delete
            // 
            this.Authority_delete.Enabled = false;
            this.Authority_delete.Highlight = true;
            this.Authority_delete.Location = new System.Drawing.Point(412, 390);
            this.Authority_delete.Name = "Authority_delete";
            this.Authority_delete.Size = new System.Drawing.Size(87, 37);
            this.Authority_delete.TabIndex = 6;
            this.Authority_delete.Text = "حذف";
            this.Authority_delete.UseSelectable = true;
            this.Authority_delete.Click += new System.EventHandler(this.Authority_delete_Click);
            // 
            // Authority_update
            // 
            this.Authority_update.Enabled = false;
            this.Authority_update.Highlight = true;
            this.Authority_update.Location = new System.Drawing.Point(300, 390);
            this.Authority_update.Name = "Authority_update";
            this.Authority_update.Size = new System.Drawing.Size(87, 37);
            this.Authority_update.TabIndex = 5;
            this.Authority_update.Text = "تعديل";
            this.Authority_update.UseSelectable = true;
            this.Authority_update.Click += new System.EventHandler(this.Authority_update_Click);
            // 
            // Authority_add
            // 
            this.Authority_add.Enabled = false;
            this.Authority_add.Highlight = true;
            this.Authority_add.Location = new System.Drawing.Point(188, 390);
            this.Authority_add.Name = "Authority_add";
            this.Authority_add.Size = new System.Drawing.Size(87, 37);
            this.Authority_add.TabIndex = 4;
            this.Authority_add.Text = "أضافة";
            this.Authority_add.UseSelectable = true;
            this.Authority_add.Click += new System.EventHandler(this.Authority_add_Click);
            // 
            // Authority_new
            // 
            this.Authority_new.Highlight = true;
            this.Authority_new.Location = new System.Drawing.Point(76, 390);
            this.Authority_new.Name = "Authority_new";
            this.Authority_new.Size = new System.Drawing.Size(87, 37);
            this.Authority_new.TabIndex = 3;
            this.Authority_new.Text = "جديد";
            this.Authority_new.UseSelectable = true;
            this.Authority_new.Click += new System.EventHandler(this.Authority_new_Click);
            // 
            // Authority_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.Authority_exit);
            this.Controls.Add(this.Authority_delete);
            this.Controls.Add(this.Authority_update);
            this.Controls.Add(this.Authority_add);
            this.Controls.Add(this.Authority_new);
            this.Controls.Add(this.Authority_Gridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Authority_Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Authority_textsearch);
            this.Controls.Add(this.Authority_Name);
            this.Name = "Authority_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الهيئات";
            this.Load += new System.EventHandler(this.Authority_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Authority_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Authority_textsearch;
        private System.Windows.Forms.TextBox Authority_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Authority_Notes;
        private MetroFramework.Controls.MetroGrid Authority_Gridview;
        private MetroFramework.Controls.MetroButton Authority_exit;
        private MetroFramework.Controls.MetroButton Authority_delete;
        private MetroFramework.Controls.MetroButton Authority_update;
        private MetroFramework.Controls.MetroButton Authority_add;
        private MetroFramework.Controls.MetroButton Authority_new;
    }
}