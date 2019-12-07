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
    public partial class Employee_Salaries_FORM :MetroFramework.Forms.MetroForm
    {
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        public Employee_Salaries_FORM()
        {
            InitializeComponent();
           
            Empl_Sala_Comb_Department.DataSource = Empl_Des.Employee_Description_Comb_Department();
            Empl_Sala_Comb_Department.DisplayMember = "Department_Name";
            Empl_Sala_Comb_Department.ValueMember = "Department_ID";
        }

        private void Empl_Sala_Comb_Department_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idDepartment = Convert.ToInt32(Empl_Sala_Comb_Department.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Empl_Sala_Comb_Emplyment.DataSource = cont.Contracts_Comb_Employee(idDepartment);
                Empl_Sala_Comb_Emplyment.DisplayMember = "fullName";
                Empl_Sala_Comb_Emplyment.ValueMember = "Emp_id";

            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
