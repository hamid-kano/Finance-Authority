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
    public partial class Employee_Description_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.Office Offic = new BL.Office();
        public Employee_Description_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            Employee_Description_Comb_Search.DataSource = Offic.Office_View();
            Employee_Description_Comb_Search.DisplayMember = "اسم المكتب";
            Employee_Description_Comb_Search.ValueMember = "Office_ID";
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View_Spical_three();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[10].Visible = false;
           
        }

        private void Employee_Description_new_Click(object sender, EventArgs e)
        { 
            Employee_Description_delete.Enabled = false;
        }

        private void Employee_Description_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void Employee_Description_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف صفة الموظف .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Empl_Des.Employee_Description_Delete(Program.Employee_Description_id);
                this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View_Spical_three();
                Employee_Description_dataGrid.Columns[0].Visible = false;
                Employee_Description_dataGrid.Columns[10].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Employee_Description_delete.Enabled = false;
            }
        }

        private void Employee_Description_dataGrid_Click(object sender, EventArgs e)
        {
            if (Employee_Description_dataGrid.CurrentRow != null)
            {
                Program.Employee_Description_id = Convert.ToInt32(this.Employee_Description_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Employee_Description_delete.Enabled = true;
                Employee_Description_Details.Enabled = true;
            }
        }

        private void Employee_Description_Comb_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_Search_Office(Employee_Description_Comb_Search.Text);
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[10].Visible = false;
        }

        private void Employee_Description_Search_all_TextChanged(object sender, EventArgs e)
        {
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_Search_All(Employee_Description_Search_all.Text);
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[10].Visible = false;
        }

        private void Employee_Description_Print_Click(object sender, EventArgs e)
        {
            REPT.Crystal_Employee_Description Art = new REPT.Crystal_Employee_Description();

            REPT.FRM_Report FRPT = new REPT.FRM_Report();

            if (Employee_Description_dataGrid.Rows.Count != 0)
            {
                // DataTable dt = dataGrid_Ringall.DataSource;
                Art.SetDataSource(Employee_Description_dataGrid.DataSource);

                FRPT.crystalReportViewer1.ReportSource = Art;
                FRPT.ShowDialog();
            }
        }

        private void Employee_Description_N0_Book_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_Description_Salery_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_Description_Details_Click(object sender, EventArgs e)
        {
            Employee_FORM FRM = new Employee_FORM(Program.Employee_Description_id);
            FRM.ShowDialog();
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View_Spical_three();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[10].Visible = false;
        }

        private void Employee_Description_view_all_Click(object sender, EventArgs e)
        {
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[10].Visible = false;
        }
    }
}
