namespace Finance_Authority.PL
{
    partial class Office_FORM
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
            this.Office_exit = new MetroFramework.Controls.MetroButton();
            this.Office_delete = new MetroFramework.Controls.MetroButton();
            this.Office_update = new MetroFramework.Controls.MetroButton();
            this.Office_add = new MetroFramework.Controls.MetroButton();
            this.Office_new = new MetroFramework.Controls.MetroButton();
            this.Office_Gridview = new MetroFramework.Controls.MetroGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.Office_Notes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Office_textsearch = new System.Windows.Forms.TextBox();
            this.Office_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Office_CombAuthontic = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Office_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Office_exit
            // 
            this.Office_exit.Highlight = true;
            this.Office_exit.Location = new System.Drawing.Point(698, 377);
            this.Office_exit.Name = "Office_exit";
            this.Office_exit.Size = new System.Drawing.Size(87, 37);
            this.Office_exit.TabIndex = 57;
            this.Office_exit.Text = "خروج";
            this.Office_exit.UseSelectable = true;
            this.Office_exit.Click += new System.EventHandler(this.Office_exit_Click);
            // 
            // Office_delete
            // 
            this.Office_delete.Enabled = false;
            this.Office_delete.Highlight = true;
            this.Office_delete.Location = new System.Drawing.Point(586, 377);
            this.Office_delete.Name = "Office_delete";
            this.Office_delete.Size = new System.Drawing.Size(87, 37);
            this.Office_delete.TabIndex = 56;
            this.Office_delete.Text = "حذف";
            this.Office_delete.UseSelectable = true;
            this.Office_delete.Click += new System.EventHandler(this.Office_delete_Click);
            // 
            // Office_update
            // 
            this.Office_update.Enabled = false;
            this.Office_update.Highlight = true;
            this.Office_update.Location = new System.Drawing.Point(474, 377);
            this.Office_update.Name = "Office_update";
            this.Office_update.Size = new System.Drawing.Size(87, 37);
            this.Office_update.TabIndex = 55;
            this.Office_update.Text = "تعديل";
            this.Office_update.UseSelectable = true;
            this.Office_update.Click += new System.EventHandler(this.Office_update_Click);
            // 
            // Office_add
            // 
            this.Office_add.Enabled = false;
            this.Office_add.Highlight = true;
            this.Office_add.Location = new System.Drawing.Point(362, 377);
            this.Office_add.Name = "Office_add";
            this.Office_add.Size = new System.Drawing.Size(87, 37);
            this.Office_add.TabIndex = 54;
            this.Office_add.Text = "أضافة";
            this.Office_add.UseSelectable = true;
            this.Office_add.Click += new System.EventHandler(this.Office_add_Click_1);
            // 
            // Office_new
            // 
            this.Office_new.Highlight = true;
            this.Office_new.Location = new System.Drawing.Point(250, 377);
            this.Office_new.Name = "Office_new";
            this.Office_new.Size = new System.Drawing.Size(87, 37);
            this.Office_new.TabIndex = 53;
            this.Office_new.Text = "جديد";
            this.Office_new.UseSelectable = true;
            this.Office_new.Click += new System.EventHandler(this.Office_new_Click);
            // 
            // Office_Gridview
            // 
            this.Office_Gridview.AllowUserToAddRows = false;
            this.Office_Gridview.AllowUserToDeleteRows = false;
            this.Office_Gridview.AllowUserToResizeRows = false;
            this.Office_Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Office_Gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Office_Gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Office_Gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Office_Gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Office_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Office_Gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.Office_Gridview.EnableHeadersVisualStyles = false;
            this.Office_Gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Office_Gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Office_Gridview.Location = new System.Drawing.Point(286, 87);
            this.Office_Gridview.Name = "Office_Gridview";
            this.Office_Gridview.ReadOnly = true;
            this.Office_Gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Office_Gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Office_Gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Office_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Office_Gridview.Size = new System.Drawing.Size(472, 253);
            this.Office_Gridview.TabIndex = 52;
            this.Office_Gridview.Click += new System.EventHandler(this.Office_Gridview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "الملاحظات";
            // 
            // Office_Notes
            // 
            this.Office_Notes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office_Notes.Location = new System.Drawing.Point(88, 178);
            this.Office_Notes.Name = "Office_Notes";
            this.Office_Notes.Size = new System.Drawing.Size(163, 23);
            this.Office_Notes.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "أسم المكتب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "البحث";
            // 
            // Office_textsearch
            // 
            this.Office_textsearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office_textsearch.Location = new System.Drawing.Point(363, 51);
            this.Office_textsearch.Name = "Office_textsearch";
            this.Office_textsearch.Size = new System.Drawing.Size(350, 23);
            this.Office_textsearch.TabIndex = 47;
            this.Office_textsearch.TextChanged += new System.EventHandler(this.Office_textsearch_TextChanged);
            // 
            // Office_Name
            // 
            this.Office_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office_Name.Location = new System.Drawing.Point(88, 111);
            this.Office_Name.Name = "Office_Name";
            this.Office_Name.Size = new System.Drawing.Size(163, 23);
            this.Office_Name.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "الهيئة";
            // 
            // Office_CombAuthontic
            // 
            this.Office_CombAuthontic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Office_CombAuthontic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office_CombAuthontic.FormattingEnabled = true;
            this.Office_CombAuthontic.Location = new System.Drawing.Point(88, 232);
            this.Office_CombAuthontic.Name = "Office_CombAuthontic";
            this.Office_CombAuthontic.Size = new System.Drawing.Size(163, 24);
            this.Office_CombAuthontic.TabIndex = 59;
            // 
            // Office_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 438);
            this.Controls.Add(this.Office_CombAuthontic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Office_exit);
            this.Controls.Add(this.Office_delete);
            this.Controls.Add(this.Office_update);
            this.Controls.Add(this.Office_add);
            this.Controls.Add(this.Office_new);
            this.Controls.Add(this.Office_Gridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Office_Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Office_textsearch);
            this.Controls.Add(this.Office_Name);
            this.Name = "Office_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "المكاتب";
            ((System.ComponentModel.ISupportInitialize)(this.Office_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Office_exit;
        private MetroFramework.Controls.MetroButton Office_delete;
        private MetroFramework.Controls.MetroButton Office_update;
        private MetroFramework.Controls.MetroButton Office_add;
        private MetroFramework.Controls.MetroButton Office_new;
        private MetroFramework.Controls.MetroGrid Office_Gridview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Office_Notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Office_textsearch;
        private System.Windows.Forms.TextBox Office_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Office_CombAuthontic;
    }
}