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
    public partial class Emission_Salaries_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Emission_Salaries Emiss = new BL.CLS_Emission_Salaries();
        BL.Department Dep = new BL.Department();
        public Emission_Salaries_FORM()
        {
            InitializeComponent();
            this.Emission_Salaries_dataGrid.DataSource = Emiss.Emission_Salaries_View();
            Emission_Salaries_dataGrid.Columns[0].Visible = false;
            Emission_Salaries_Comb_Budget.DataSource = Emiss.Emission_Salaries_Comb_Budget();
            Emission_Salaries_Comb_Budget.DisplayMember = "Date";
            Emission_Salaries_Comb_Budget.ValueMember = "Budget_Id";
            Emission_Salaries_Name_office.DataSource = Dep.Department_CombOffice();
            Emission_Salaries_Name_office.DisplayMember = "Office_Name";
            Emission_Salaries_Name_office.ValueMember = "Office_ID";
        }

        private void Emission_Salaries_new_Click(object sender, EventArgs e)
        {
            Emission_Salaries_add.Enabled = true;
            Emission_Salaries_update.Enabled = false;
            Emission_Salaries_delete.Enabled = false;
        }

        private void Emission_Salaries_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Emission_Salaries_add_Click(object sender, EventArgs e)
        {
            Emiss.Emission_Salaries_add(Convert.ToInt32(Emission_Salaries_Name_office.SelectedValue) , Emission_Salaries_Date.Value , Convert.ToInt32(Emission_Salaries_Comb_Budget.SelectedValue));
            this.Emission_Salaries_dataGrid.DataSource = Emiss.Emission_Salaries_View();
            Emission_Salaries_dataGrid.Columns[0].Visible = false;
            Emission_Salaries_add.Enabled = false;
        }

        private void Emission_Salaries_update_Click(object sender, EventArgs e)
        {
            Emiss.Emission_Salaries_update(Convert.ToInt32(Emission_Salaries_Name_office.SelectedValue), Emission_Salaries_Date.Value, Convert.ToInt32(Emission_Salaries_Comb_Budget.SelectedValue), Program.Emission_Salaries_id);
            this.Emission_Salaries_dataGrid.DataSource = Emiss.Emission_Salaries_View();
            Emission_Salaries_dataGrid.Columns[0].Visible = false;
            Emission_Salaries_update.Enabled = false;
            Emission_Salaries_delete.Enabled = false;
        }

        private void Emission_Salaries_dataGrid_Click(object sender, EventArgs e)
        {
            if (Emission_Salaries_dataGrid.CurrentRow != null)
            {
                Program.Emission_Salaries_id = Convert.ToInt32(this.Emission_Salaries_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Emission_Salaries_Name_office.Text = this.Emission_Salaries_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Emission_Salaries_Date.Text = this.Emission_Salaries_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Emission_Salaries_Comb_Budget.Text = this.Emission_Salaries_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Emission_Salaries_update.Enabled = true;
                Emission_Salaries_delete.Enabled = true;
            }
        }

        private void Emission_Salaries_delete_Click(object sender, EventArgs e)
        {
            Emiss.Emission_Salaries_Delete(Program.Emission_Salaries_id);
            this.Emission_Salaries_dataGrid.DataSource = Emiss.Emission_Salaries_View();
            Emission_Salaries_dataGrid.Columns[0].Visible = false;
            Emission_Salaries_update.Enabled = false;
            Emission_Salaries_delete.Enabled = false;
        }
    }
}
