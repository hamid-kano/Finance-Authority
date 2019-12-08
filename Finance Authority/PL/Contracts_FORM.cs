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
        public Contracts_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Contracts_Gridview.DataSource = cont.Contracts_View();
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Comb_Department.DataSource = Empl_Des.Employee_Description_Comb_Department();
            Contracts_Comb_Department.DisplayMember = "Department_Name";
            Contracts_Comb_Department.ValueMember = "Department_ID";
           


        }

        private void Contracts_new_Click(object sender, EventArgs e)
        {
            Contracts_add.Enabled = true;
            Contracts_Type.Text = "";
            Contracts_Notes.Text = "";
            Contracts_Comb_Department.DataSource = Empl_Des.Employee_Description_Comb_Department();
            Contracts_Comb_Department.DisplayMember = "Department_Name";
            Contracts_Comb_Department.ValueMember = "Department_ID";

        }

        private void Contracts_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contracts_Comb_Department_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idDepartment = Convert.ToInt32(Contracts_Comb_Department.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Contracts_Comb_Employee.DataSource = cont.Contracts_Comb_Employee(idDepartment);
                Contracts_Comb_Employee.DisplayMember = "fullName";
                Contracts_Comb_Employee.ValueMember = "Emp_id";

            }
            catch (Exception)
            {

                //throw;
            }       
        }

        private void Contracts_add_Click(object sender, EventArgs e)
        {
            int idDepartment = Convert.ToInt32(Contracts_Comb_Department.SelectedValue);
            int idemployee = Convert.ToInt32(Contracts_Comb_Employee.SelectedValue);
            DataTable DT = cont.Contracts_by_Departmentid_Employeeid(idDepartment, idemployee);
            if (DT.Rows.Count > 0)
            {
                DataRow row = DT.Rows[0];
                int id_EmployeeDES = Convert.ToInt32(row["Employee_Des_ID"]);
                //MessageBox.Show(id_EmployeeDES.ToString());
             //   bool Functunal_status = Contracts_end.Checked ? true : false;
                cont.Contracts_add(Contracts_Type.Text , Contracts_Date_Start.Value , Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
                     , Contracts_Notes.Text, id_EmployeeDES );
                this.Contracts_Gridview.DataSource = cont.Contracts_View();
                Contracts_Gridview.Columns[0].Visible = false;
                Program.Add_Message();
                Contracts_Type.Text = "";
                Contracts_Notes.Text = "";
                Contracts_add.Enabled = false;
            }


        }

        private void Contracts_Gridview_Click(object sender, EventArgs e)
        {
            if (Contracts_Gridview.CurrentRow != null)
            {
                Program.Contracts_id = Convert.ToInt32(this.Contracts_Gridview.CurrentRow.Cells[0].Value.ToString());
                Contracts_Type.Text = this.Contracts_Gridview.CurrentRow.Cells[1].Value.ToString();
                Contracts_Date_Start.Text = this.Contracts_Gridview.CurrentRow.Cells[2].Value.ToString();
                Contracts_Date_end.Text = this.Contracts_Gridview.CurrentRow.Cells[3].Value.ToString();
                Contracts_Comb_Employee.Text = this.Contracts_Gridview.CurrentRow.Cells[6].Value.ToString();
                Contracts_Comb_Department.Text = this.Contracts_Gridview.CurrentRow.Cells[7].Value.ToString();
                Contracts_Notes.Text = this.Contracts_Gridview.CurrentRow.Cells[5].Value.ToString();
                Contracts_Comb_Contract_statue.Text= this.Contracts_Gridview.CurrentRow.Cells[4].Value.ToString();
                //Contracts_end.Checked = Convert.ToBoolean(this.Contracts_Gridview.CurrentRow.Cells[4].Value) ? true : false;
                //Contracts_Not_end.Checked = Contracts_end.Checked ? false : true;
                Contracts_update.Enabled = true;
                Contracts_delete.Enabled = true;
            }
        }

        private void Contracts_update_Click(object sender, EventArgs e)
        {
            int idDepartment = Convert.ToInt32(Contracts_Comb_Department.SelectedValue);
            int idemployee = Convert.ToInt32(Contracts_Comb_Employee.SelectedValue);
            DataTable DT = cont.Contracts_by_Departmentid_Employeeid(idDepartment, idemployee);
            if (DT.Rows.Count > 0)
            {
                DataRow row = DT.Rows[0];
                int id_EmployeeDES = Convert.ToInt32(row["Employee_Des_ID"]);
                //MessageBox.Show(id_EmployeeDES.ToString());
               // bool Functunal_status = Contracts_end.Checked ? true : false;
                cont.Contracts_update(Contracts_Type.Text, Contracts_Date_Start.Value, Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
                     , Contracts_Notes.Text, id_EmployeeDES, Program.Contracts_id);
                this.Contracts_Gridview.DataSource = cont.Contracts_View();
                Contracts_Gridview.Columns[0].Visible = false;
                Program.Update_Message();
                Contracts_Type.Text = "";
                Contracts_Notes.Text = "";
                Contracts_add.Enabled = false;
            }
            
        }

        private void Contracts_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cont.Contracts_Delete(Program.Contracts_id);
                this.Contracts_Gridview.DataSource = cont.Contracts_View();
                Contracts_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Contracts_Type.Text = "";
                Contracts_Notes.Text = "";
                Contracts_update.Enabled = false;
                Contracts_delete.Enabled = false;
            }
        }
    }
}
