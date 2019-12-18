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
    public partial class Contracts_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        int _Contract_id;
        public Contracts_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Contracts_Gridview.DataSource = cont.Contracts_View();
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[7].Visible = false;
        }

        private void Contracts_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Contracts_Gridview_Click(object sender, EventArgs e)
        {
            if (Contracts_Gridview.CurrentRow != null)
            {
                Program.Employee_Description_id= Convert.ToInt32(this.Contracts_Gridview.CurrentRow.Cells[7].Value.ToString());
                _Contract_id= Convert.ToInt32(this.Contracts_Gridview.CurrentRow.Cells[0].Value.ToString());
                Contracts_Type.Text = this.Contracts_Gridview.CurrentRow.Cells[1].Value.ToString();
                Contracts_Date_Start.Text = this.Contracts_Gridview.CurrentRow.Cells[2].Value.ToString();
                Contracts_Date_end.Text = this.Contracts_Gridview.CurrentRow.Cells[3].Value.ToString();
                Contracts_Employee.Text = this.Contracts_Gridview.CurrentRow.Cells[6].Value.ToString();
                Contracts_Notes.Text = this.Contracts_Gridview.CurrentRow.Cells[5].Value.ToString();
                Contracts_Comb_Contract_statue.Text= this.Contracts_Gridview.CurrentRow.Cells[4].Value.ToString();
                //Contracts_end.Checked = Convert.ToBoolean(this.Contracts_Gridview.CurrentRow.Cells[4].Value) ? true : false;
                //Contracts_Not_end.Checked = Contracts_end.Checked ? false : true;
                Contracts_Details.Enabled = true;
                Contracts_Brows_Docs.Enabled = true;
            }
        }

        private void Contracts_Search_All_TextChanged(object sender, EventArgs e)
        {
            this.Contracts_Gridview.DataSource = cont.Contracts_Search_All(Contracts_Search_All.Text);
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[7].Visible = false;
        }

        private void Contracts_Date_first_ValueChanged(object sender, EventArgs e)
        {
            this.Contracts_Gridview.DataSource = cont.Contracts_Search_Between_Date(Contracts_Date_first.Value , Contracts_Date_last.Value);
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[7].Visible = false;
        }

        private void Contracts_Date_last_ValueChanged(object sender, EventArgs e)
        {
            this.Contracts_Gridview.DataSource = cont.Contracts_Search_Between_Date(Contracts_Date_first.Value, Contracts_Date_last.Value);
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[7].Visible = false;
        }

        private void Contracts_Print_Click(object sender, EventArgs e)
        {
            REPT.Crystal_Contracts Art = new REPT.Crystal_Contracts();

            REPT.FRM_Report FRPT = new REPT.FRM_Report();

            if (Contracts_Gridview.Rows.Count != 0)
            {
                // DataTable dt = dataGrid_Ringall.DataSource;
                Art.SetDataSource(Contracts_Gridview.DataSource);

                FRPT.crystalReportViewer1.ReportSource = Art;
                FRPT.ShowDialog();
            }
        }

        private void Contracts_Details_Click(object sender, EventArgs e)
        {
            Employee_FORM FRM = new Employee_FORM(Program.Employee_Description_id);
            FRM.ShowDialog();
        }

        private void Contracts_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(Program.Employee_Description_id, "عقد");
            FRM.ShowDialog();

        }
    }
}
