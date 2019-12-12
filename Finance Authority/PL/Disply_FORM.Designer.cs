﻿namespace Finance_Authority.PL
{
    partial class Disply_FORM
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
            this.logout = new MetroFramework.Controls.MetroButton();
            this.login = new MetroFramework.Controls.MetroButton();
            this.Authority_Name_Auth = new MetroFramework.Controls.MetroLabel();
            this.User_Name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PassWord = new MetroFramework.Controls.MetroTextBox();
            this.Server_Name = new MetroFramework.Controls.MetroTextBox();
            this.PassWord_DB = new MetroFramework.Controls.MetroTextBox();
            this.User_DB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Enabled = false;
            this.logout.Highlight = true;
            this.logout.Location = new System.Drawing.Point(220, 376);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(87, 37);
            this.logout.TabIndex = 6;
            this.logout.Text = "خروج";
            this.logout.UseSelectable = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // login
            // 
            this.login.Highlight = true;
            this.login.Location = new System.Drawing.Point(73, 376);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(87, 37);
            this.login.TabIndex = 5;
            this.login.Text = "تسجيل دخول";
            this.login.UseSelectable = true;
            // 
            // Authority_Name_Auth
            // 
            this.Authority_Name_Auth.AutoSize = true;
            this.Authority_Name_Auth.Location = new System.Drawing.Point(19, 145);
            this.Authority_Name_Auth.Name = "Authority_Name_Auth";
            this.Authority_Name_Auth.Size = new System.Drawing.Size(80, 19);
            this.Authority_Name_Auth.TabIndex = 35;
            this.Authority_Name_Auth.Text = "اسم مستخدم";
            // 
            // User_Name
            // 
            // 
            // 
            // 
            this.User_Name.CustomButton.Image = null;
            this.User_Name.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.User_Name.CustomButton.Name = "";
            this.User_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.User_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.User_Name.CustomButton.TabIndex = 1;
            this.User_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.User_Name.CustomButton.UseSelectable = true;
            this.User_Name.CustomButton.Visible = false;
            this.User_Name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.User_Name.Lines = new string[0];
            this.User_Name.Location = new System.Drawing.Point(108, 145);
            this.User_Name.MaxLength = 32767;
            this.User_Name.Name = "User_Name";
            this.User_Name.PasswordChar = '\0';
            this.User_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.User_Name.SelectedText = "";
            this.User_Name.SelectionLength = 0;
            this.User_Name.SelectionStart = 0;
            this.User_Name.ShortcutsEnabled = true;
            this.User_Name.Size = new System.Drawing.Size(185, 23);
            this.User_Name.TabIndex = 34;
            this.User_Name.UseSelectable = true;
            this.User_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.User_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 191);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "كلمة سر";
            // 
            // PassWord
            // 
            // 
            // 
            // 
            this.PassWord.CustomButton.Image = null;
            this.PassWord.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.PassWord.CustomButton.Name = "";
            this.PassWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassWord.CustomButton.TabIndex = 1;
            this.PassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassWord.CustomButton.UseSelectable = true;
            this.PassWord.CustomButton.Visible = false;
            this.PassWord.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PassWord.Lines = new string[0];
            this.PassWord.Location = new System.Drawing.Point(108, 191);
            this.PassWord.MaxLength = 32767;
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '\0';
            this.PassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassWord.SelectedText = "";
            this.PassWord.SelectionLength = 0;
            this.PassWord.SelectionStart = 0;
            this.PassWord.ShortcutsEnabled = true;
            this.PassWord.Size = new System.Drawing.Size(185, 23);
            this.PassWord.TabIndex = 36;
            this.PassWord.UseSelectable = true;
            this.PassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Server_Name
            // 
            // 
            // 
            // 
            this.Server_Name.CustomButton.Image = null;
            this.Server_Name.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.Server_Name.CustomButton.Name = "";
            this.Server_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Server_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Server_Name.CustomButton.TabIndex = 1;
            this.Server_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Server_Name.CustomButton.UseSelectable = true;
            this.Server_Name.CustomButton.Visible = false;
            this.Server_Name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Server_Name.Lines = new string[0];
            this.Server_Name.Location = new System.Drawing.Point(108, 269);
            this.Server_Name.MaxLength = 32767;
            this.Server_Name.Name = "Server_Name";
            this.Server_Name.PasswordChar = '\0';
            this.Server_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Server_Name.SelectedText = "";
            this.Server_Name.SelectionLength = 0;
            this.Server_Name.SelectionStart = 0;
            this.Server_Name.ShortcutsEnabled = true;
            this.Server_Name.Size = new System.Drawing.Size(185, 23);
            this.Server_Name.TabIndex = 38;
            this.Server_Name.UseSelectable = true;
            this.Server_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Server_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PassWord_DB
            // 
            // 
            // 
            // 
            this.PassWord_DB.CustomButton.Image = null;
            this.PassWord_DB.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.PassWord_DB.CustomButton.Name = "";
            this.PassWord_DB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassWord_DB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassWord_DB.CustomButton.TabIndex = 1;
            this.PassWord_DB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassWord_DB.CustomButton.UseSelectable = true;
            this.PassWord_DB.CustomButton.Visible = false;
            this.PassWord_DB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PassWord_DB.Lines = new string[0];
            this.PassWord_DB.Location = new System.Drawing.Point(205, 308);
            this.PassWord_DB.MaxLength = 32767;
            this.PassWord_DB.Name = "PassWord_DB";
            this.PassWord_DB.PasswordChar = '\0';
            this.PassWord_DB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassWord_DB.SelectedText = "";
            this.PassWord_DB.SelectionLength = 0;
            this.PassWord_DB.SelectionStart = 0;
            this.PassWord_DB.ShortcutsEnabled = true;
            this.PassWord_DB.Size = new System.Drawing.Size(88, 23);
            this.PassWord_DB.TabIndex = 39;
            this.PassWord_DB.UseSelectable = true;
            this.PassWord_DB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassWord_DB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // User_DB
            // 
            // 
            // 
            // 
            this.User_DB.CustomButton.Image = null;
            this.User_DB.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.User_DB.CustomButton.Name = "";
            this.User_DB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.User_DB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.User_DB.CustomButton.TabIndex = 1;
            this.User_DB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.User_DB.CustomButton.UseSelectable = true;
            this.User_DB.CustomButton.Visible = false;
            this.User_DB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.User_DB.Lines = new string[0];
            this.User_DB.Location = new System.Drawing.Point(108, 308);
            this.User_DB.MaxLength = 32767;
            this.User_DB.Name = "User_DB";
            this.User_DB.PasswordChar = '\0';
            this.User_DB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.User_DB.SelectedText = "";
            this.User_DB.SelectionLength = 0;
            this.User_DB.SelectionStart = 0;
            this.User_DB.ShortcutsEnabled = true;
            this.User_DB.Size = new System.Drawing.Size(87, 23);
            this.User_DB.TabIndex = 40;
            this.User_DB.UseSelectable = true;
            this.User_DB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.User_DB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 269);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "اسم السيرفر";
            // 
            // Disply_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 476);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.User_DB);
            this.Controls.Add(this.PassWord_DB);
            this.Controls.Add(this.Server_Name);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.Authority_Name_Auth);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.login);
            this.Name = "Disply_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton logout;
        private MetroFramework.Controls.MetroButton login;
        private MetroFramework.Controls.MetroLabel Authority_Name_Auth;
        private MetroFramework.Controls.MetroTextBox User_Name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PassWord;
        private MetroFramework.Controls.MetroTextBox Server_Name;
        private MetroFramework.Controls.MetroTextBox PassWord_DB;
        private MetroFramework.Controls.MetroTextBox User_DB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}