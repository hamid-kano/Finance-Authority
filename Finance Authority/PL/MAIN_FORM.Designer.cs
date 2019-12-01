namespace Finance_Authority
{
    partial class MAIN_FORM
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
            this.EX_Orders_Cat_BTN = new MetroFramework.Controls.MetroButton();
            this.EX_Order_BTN = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // EX_Orders_Cat_BTN
            // 
            this.EX_Orders_Cat_BTN.Location = new System.Drawing.Point(85, 149);
            this.EX_Orders_Cat_BTN.Name = "EX_Orders_Cat_BTN";
            this.EX_Orders_Cat_BTN.Size = new System.Drawing.Size(185, 40);
            this.EX_Orders_Cat_BTN.TabIndex = 0;
            this.EX_Orders_Cat_BTN.Text = "ادراة اصناف طلبات صرف المبالغ";
            this.EX_Orders_Cat_BTN.Click += new System.EventHandler(this.EX_Orders_Cat_BTN_Click);
            // 
            // EX_Order_BTN
            // 
            this.EX_Order_BTN.Location = new System.Drawing.Point(85, 206);
            this.EX_Order_BTN.Name = "EX_Order_BTN";
            this.EX_Order_BTN.Size = new System.Drawing.Size(185, 40);
            this.EX_Order_BTN.TabIndex = 1;
            this.EX_Order_BTN.Text = "طلب صرف مبلغ";
            this.EX_Order_BTN.Click += new System.EventHandler(this.EX_Order_BTN_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(85, 252);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(122, 40);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "metroButton3";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(85, 307);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(122, 40);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "metroButton4";
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(85, 366);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(122, 40);
            this.metroButton5.TabIndex = 4;
            this.metroButton5.Text = "metroButton5";
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 599);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.EX_Order_BTN);
            this.Controls.Add(this.EX_Orders_Cat_BTN);
            this.Name = "MAIN_FORM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton EX_Orders_Cat_BTN;
        private MetroFramework.Controls.MetroButton EX_Order_BTN;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}

