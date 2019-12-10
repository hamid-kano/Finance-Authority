using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Authority.PL
{
    public partial class Reciver_Document_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Coin_Exchange Coin = new BL.CLS_Coin_Exchange();
        BL.CLS_Reciver_Document Reciv = new BL.CLS_Reciver_Document();


        public Reciver_Document_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Reciver_Document_dataGrid.DataSource= Reciv.Reciver_Document_View();
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
            Reciver_Document_Comb_Date.DataSource = Coin.Coin_Exchange_CombBudg();
            Reciver_Document_Comb_Date.DisplayMember = "Date";
            Reciver_Document_Comb_Date.ValueMember = "Budget_Id";
            Reciver_Document_Comb_Cate.DataSource = Reciv.Reciver_Document_Comb_Cate();
            Reciver_Document_Comb_Cate.DisplayMember = "Document_Type";
            Reciver_Document_Comb_Cate.ValueMember = "Category_id";
        }

        private void Reciver_Document_new_Click(object sender, EventArgs e)
        {
            Reciver_Document_add.Enabled = true;
            Reciver_Document_sy.Text = "";
            Reciver_Document_Dollar.Text = "";
            Reciver_Document_rate.Text = "";
            Reciver_Document_no.Text = "";
            Reciver_Document_Reason.Text = "";
            Reciver_Document_Receve.Text = "";
            Reciver_Document_Notes.Text = "";
            Reciver_Document_update.Enabled = false;
            Reciver_Document_delete.Enabled = false;
        }

        private void Reciver_Document_xit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reciver_Document_add_Click(object sender, EventArgs e)
        {
            Reciv.Reciver_Document_add(Reciver_Document_sy.Text , Reciver_Document_Dollar.Text , Reciver_Document_rate.Text , Reciver_Document_no.Text , Reciver_Document_Reason.Text, Reciver_Document_Receve.Text , Reciver_Document_DateTime.Value, Reciver_Document_Notes.Text , Convert.ToInt32(Reciver_Document_Comb_Date.SelectedValue), Convert.ToInt32(Reciver_Document_Comb_Cate.SelectedValue));
            this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_View();
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
            Program.Add_Message();
            Reciver_Document_sy.Text = "";
            Reciver_Document_Dollar.Text = "";
            Reciver_Document_rate.Text = "";
            Reciver_Document_no.Text = "";
            Reciver_Document_Reason.Text = "";
            Reciver_Document_Receve.Text = "";
            Reciver_Document_Notes.Text = "";
            Reciver_Document_add.Enabled = false;

        }

        private void Reciver_Document_update_Click(object sender, EventArgs e)
        {
            Reciv.Reciver_Document_update(Reciver_Document_sy.Text, Reciver_Document_Dollar.Text, Reciver_Document_rate.Text, Reciver_Document_no.Text, Reciver_Document_Reason.Text, Reciver_Document_Receve.Text, Reciver_Document_DateTime.Value, Reciver_Document_Notes.Text, Convert.ToInt32(Reciver_Document_Comb_Date.SelectedValue), Convert.ToInt32(Reciver_Document_Comb_Cate.SelectedValue) , Program.Reciver_Document_id);
            this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_View();
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
            Program.Update_Message();
            Reciver_Document_sy.Text = "";
            Reciver_Document_Dollar.Text = "";
            Reciver_Document_rate.Text = "";
            Reciver_Document_no.Text = "";
            Reciver_Document_Reason.Text = "";
            Reciver_Document_Receve.Text = "";
            Reciver_Document_Notes.Text = "";
            Reciver_Document_update.Enabled = false;
            Reciver_Document_delete.Enabled = false;
        }

        private void Reciver_Document_dataGrid_Click(object sender, EventArgs e)
        {
            if (Reciver_Document_dataGrid.CurrentRow != null)
            {
                Program.Reciver_Document_id= Convert.ToInt32(this.Reciver_Document_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Reciver_Document_sy.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Reciver_Document_Dollar.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Reciver_Document_rate.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Reciver_Document_no.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[4].Value.ToString();
                Reciver_Document_Reason.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[5].Value.ToString();
                Reciver_Document_Receve.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[6].Value.ToString();
                Reciver_Document_DateTime.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[7].Value.ToString();
                Reciver_Document_Notes.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[8].Value.ToString();
                Reciver_Document_Comb_Date.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[9].Value.ToString();
                Reciver_Document_Comb_Cate.Text= this.Reciver_Document_dataGrid.CurrentRow.Cells[10].Value.ToString();
                Reciver_Document_update.Enabled = true;
                Reciver_Document_delete.Enabled = true;
            }
        }

        private void Reciver_Document_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Reciv.Reciver_Document_Delete(Program.Reciver_Document_id);
                this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_View();
                this.Reciver_Document_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reciver_Document_sy.Text = "";
                Reciver_Document_Dollar.Text = "";
                Reciver_Document_rate.Text = "";
                Reciver_Document_no.Text = "";
                Reciver_Document_Reason.Text = "";
                Reciver_Document_Receve.Text = "";
                Reciver_Document_Notes.Text = "";
                Reciver_Document_update.Enabled = false;
                Reciver_Document_delete.Enabled = false;
            }
        }

        private void Reciver_Document_Search_TextChanged(object sender, EventArgs e)
        {
            this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_Search(Reciver_Document_Search.Text);
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Reciver_Document_Date_first_ValueChanged(object sender, EventArgs e)
        {
            this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_Date_Butween(Reciver_Document_Date_first.Value, Reciver_Document_Date_last.Value);
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Reciver_Document_Date_last_ValueChanged(object sender, EventArgs e)
        {
            this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_Date_Butween(Reciver_Document_Date_first.Value, Reciver_Document_Date_last.Value);
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Reciver_Document_Print_Click(object sender, EventArgs e)
        {
            REPT.Crystal_Reciver_Document Art = new REPT.Crystal_Reciver_Document();

            REPT.FRM_Report FRPT = new REPT.FRM_Report();

            if (Reciver_Document_dataGrid.Rows.Count != 0)
            {
                // DataTable dt = dataGrid_Ringall.DataSource;
                Art.SetDataSource(Reciver_Document_dataGrid.DataSource);

                FRPT.crystalReportViewer1.ReportSource = Art;
                FRPT.ShowDialog();
            }
        }
    }
}
