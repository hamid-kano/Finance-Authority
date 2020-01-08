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
    public partial class Employee_Finance_History_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee_Salaries emp_Sal = new BL.CLS_Employee_Salaries();
        BL.CLS_Loan loan = new BL.CLS_Loan();
        int _Employee_id;
        public Employee_Finance_History_FORM(int Employee_id)
        {
            InitializeComponent();
            _Employee_id = Employee_id;
            this.StyleManager = Program.theme_style(this);
            this.Salaries_DGV.DataSource = emp_Sal.Employee_Salaries_By_id(_Employee_id);
            Salaries_DGV.Columns[0].Visible = false;
            Salaries_DGV.Columns[17].Visible = false;
            Salaries_DGV.Columns[18].Visible = false;
            Salaries_DGV.Columns[20].Visible = false;
            Loans_DGV.DataSource = loan.Loans_By_Employee_id(_Employee_id);
            Loans_DGV.Columns[0].Visible = false;
            Loans_DGV.Columns[10].Visible = false;
        }
        private void Employee_Description_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Salaries_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Date_first_Salary_ValueChanged(object sender, EventArgs e)
        {
            this.Salaries_DGV.DataSource = emp_Sal.Employee_Salaries_By_id_Between_Date(_Employee_id, Date_first_Salary.Value, Date_last__Salary.Value);
            Salaries_DGV.Columns[0].Visible = false;
            Salaries_DGV.Columns[17].Visible = false;
            Salaries_DGV.Columns[18].Visible = false;
            Salaries_DGV.Columns[20].Visible = false;
        }

        private void Date_last__Salary_ValueChanged(object sender, EventArgs e)
        {
            this.Salaries_DGV.DataSource = emp_Sal.Employee_Salaries_By_id_Between_Date(_Employee_id,Date_first_Salary.Value, Date_last__Salary.Value);
            Salaries_DGV.Columns[0].Visible = false;
            Salaries_DGV.Columns[17].Visible = false;
            Salaries_DGV.Columns[18].Visible = false;
            Salaries_DGV.Columns[20].Visible = false;
        }

        private void Date_first_Loans_ValueChanged(object sender, EventArgs e)
        {
            this.Loans_DGV.DataSource = loan.Loans_By_Employee_id_Between_Date(_Employee_id, Date_first_Loans.Value, Date_Last_Loans.Value);
            Loans_DGV.Columns[0].Visible = false;
            Loans_DGV.Columns[10].Visible = false;
        }

        private void Date_Last_Loans_ValueChanged(object sender, EventArgs e)
        {
            this.Loans_DGV.DataSource = loan.Loans_By_Employee_id_Between_Date(_Employee_id, Date_first_Loans.Value, Date_Last_Loans.Value);
            Loans_DGV.Columns[0].Visible = false;
            Loans_DGV.Columns[10].Visible = false;
        }

        private void Refrech_Salary_Click(object sender, EventArgs e)
        {
            this.Salaries_DGV.DataSource = emp_Sal.Employee_Salaries_By_id(_Employee_id);
            Salaries_DGV.Columns[0].Visible = false;
            Salaries_DGV.Columns[17].Visible = false;
            Salaries_DGV.Columns[18].Visible = false;
            Salaries_DGV.Columns[20].Visible = false;
        }

        private void Refrech_Loan_Click(object sender, EventArgs e)
        {
            Loans_DGV.DataSource = loan.Loans_By_Employee_id(_Employee_id);
            Loans_DGV.Columns[0].Visible = false;
            Loans_DGV.Columns[10].Visible = false;
        }
    }
}
