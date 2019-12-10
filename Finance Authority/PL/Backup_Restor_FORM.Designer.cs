namespace Finance_Authority.PL
{
    partial class Backup_Restor_FORM
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
            this.Close_Button = new MetroFramework.Controls.MetroButton();
            this.Backup_Restor_Path_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Backup_Restor_Button = new MetroFramework.Controls.MetroButton();
            this.Brows_Button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Close_Button
            // 
            this.Close_Button.Highlight = true;
            this.Close_Button.Location = new System.Drawing.Point(351, 180);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(87, 37);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.Text = "خروج";
            this.Close_Button.UseSelectable = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Backup_Restor_Path_TextBox
            // 
            // 
            // 
            // 
            this.Backup_Restor_Path_TextBox.CustomButton.Image = null;
            this.Backup_Restor_Path_TextBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.Backup_Restor_Path_TextBox.CustomButton.Name = "";
            this.Backup_Restor_Path_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Backup_Restor_Path_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Backup_Restor_Path_TextBox.CustomButton.TabIndex = 1;
            this.Backup_Restor_Path_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Backup_Restor_Path_TextBox.CustomButton.UseSelectable = true;
            this.Backup_Restor_Path_TextBox.CustomButton.Visible = false;
            this.Backup_Restor_Path_TextBox.Lines = new string[0];
            this.Backup_Restor_Path_TextBox.Location = new System.Drawing.Point(240, 116);
            this.Backup_Restor_Path_TextBox.MaxLength = 32767;
            this.Backup_Restor_Path_TextBox.Multiline = true;
            this.Backup_Restor_Path_TextBox.Name = "Backup_Restor_Path_TextBox";
            this.Backup_Restor_Path_TextBox.PasswordChar = '\0';
            this.Backup_Restor_Path_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Backup_Restor_Path_TextBox.SelectedText = "";
            this.Backup_Restor_Path_TextBox.SelectionLength = 0;
            this.Backup_Restor_Path_TextBox.SelectionStart = 0;
            this.Backup_Restor_Path_TextBox.ShortcutsEnabled = true;
            this.Backup_Restor_Path_TextBox.Size = new System.Drawing.Size(198, 23);
            this.Backup_Restor_Path_TextBox.TabIndex = 6;
            this.Backup_Restor_Path_TextBox.UseSelectable = true;
            this.Backup_Restor_Path_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Backup_Restor_Path_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Backup_Restor_Button
            // 
            this.Backup_Restor_Button.Highlight = true;
            this.Backup_Restor_Button.Location = new System.Drawing.Point(239, 180);
            this.Backup_Restor_Button.Name = "Backup_Restor_Button";
            this.Backup_Restor_Button.Size = new System.Drawing.Size(87, 37);
            this.Backup_Restor_Button.TabIndex = 1;
            this.Backup_Restor_Button.Text = "استعادة النسخة";
            this.Backup_Restor_Button.UseSelectable = true;
            this.Backup_Restor_Button.Click += new System.EventHandler(this.Backup_Restor_Button_Click);
            // 
            // Brows_Button
            // 
            this.Brows_Button.Highlight = true;
            this.Brows_Button.Location = new System.Drawing.Point(109, 110);
            this.Brows_Button.Name = "Brows_Button";
            this.Brows_Button.Size = new System.Drawing.Size(87, 37);
            this.Brows_Button.TabIndex = 0;
            this.Brows_Button.Text = "مسار النسخة";
            this.Brows_Button.UseSelectable = true;
            this.Brows_Button.Click += new System.EventHandler(this.Brows_Button_Click);
            // 
            // Backup_Restor_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 277);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Backup_Restor_Path_TextBox);
            this.Controls.Add(this.Backup_Restor_Button);
            this.Controls.Add(this.Brows_Button);
            this.Name = "Backup_Restor_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "استعادة النسخ الاحتياطي";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Close_Button;
        private MetroFramework.Controls.MetroTextBox Backup_Restor_Path_TextBox;
        private MetroFramework.Controls.MetroButton Backup_Restor_Button;
        private MetroFramework.Controls.MetroButton Brows_Button;
    }
}