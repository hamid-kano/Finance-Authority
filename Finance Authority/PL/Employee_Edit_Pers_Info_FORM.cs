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
    public partial class Employee_Edit_Pers_Info_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee Emp = new BL.CLS_Employee();
        DataTable Dt_emp = new DataTable();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        int _Empolyee_Description_ID;
        int Employee_id;
        DataTable Dt = new DataTable();
        public Employee_Edit_Pers_Info_FORM(int Empolyee_Description_ID)
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            _Empolyee_Description_ID = Empolyee_Description_ID;
            Dt = Emp.Employee_Description_View_id(_Empolyee_Description_ID);
            Dt_emp = Emp.Employee_View_id((int)Dt.Rows[0][8]);
            Employee_id = (int)Dt_emp.Rows[0][0];
            Employee_First_Name.Text = Dt_emp.Rows[0][1].ToString();
            Employee_Father_Name.Text = Dt_emp.Rows[0][2].ToString();
            Employee_Last_Name.Text = Dt_emp.Rows[0][3].ToString();
            Employee_Mother_Name.Text = Dt_emp.Rows[0][4].ToString();
            Employee_Brith_Date.Text = Dt_emp.Rows[0][5].ToString();
            Employee_Mobail.Text = Dt_emp.Rows[0][6].ToString();
            Employee_Scie_Level.Text = Dt_emp.Rows[0][7].ToString();
            Employee_Scie_Specialization.Text = Dt_emp.Rows[0][8].ToString();
            Employee_No_Financial.Text = Dt_emp.Rows[0][9].ToString();
            Employee_No_Affairs.Text = Dt_emp.Rows[0][10].ToString();
            Employee_No_File.Text = Dt_emp.Rows[0][11].ToString();
            Employee_No_Card.Text = Dt_emp.Rows[0][12].ToString();
            Employee_Gender.Text = Dt_emp.Rows[0][13].ToString(); ;
            Employee_Marital_status.Text = Dt_emp.Rows[0][14].ToString();
            Employee_Pr_Service_Years.Text = Dt_emp.Rows[0][15].ToString();
        }

        private void Employee_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Edit_Click(object sender, EventArgs e)
        {
            if (Employee_First_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف اسم الاول للموظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Father_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف اسم الاب للموظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Last_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف الكنية للموظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Mother_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف اسم الام للموظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Scie_Level.Text == String.Empty)
            {

                MessageBox.Show("أضف التحصيل العلمي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Scie_Specialization.Text == String.Empty)
            {

                MessageBox.Show("أضف المؤهل العلمي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_No_Financial.Text == String.Empty)
            {

                MessageBox.Show("أضف الرقم المالي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_No_Affairs.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم الشؤون", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_No_File.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم الاضبارة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_No_Card.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم البطاقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Gender.Text == String.Empty)
            {

                MessageBox.Show("أضف الجنس", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Marital_status.Text == String.Empty)
            {

                MessageBox.Show("أضف الوضع العائلي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Dt = Emp.Employee_View();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                if ((int)Emp.Employee_View().Rows[i][0] != Employee_id)
                {
                    if (Employee_No_Financial.Text == Dt.Rows[i][9].ToString())
                    {
                        MessageBox.Show("الرقم المالي موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (Employee_No_Affairs.Text == Dt.Rows[i][10].ToString())
                    {
                        MessageBox.Show("الرقم شؤون موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (Employee_No_File.Text == Dt.Rows[i][11].ToString())
                    {
                        MessageBox.Show("الرقم الاضبارة موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (Employee_No_Card.Text == Dt.Rows[i][12].ToString())
                    {
                        MessageBox.Show("الرقم البطاقة موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (Employee_First_Name.Text == Dt.Rows[i][1].ToString() && Employee_Father_Name.Text == Dt.Rows[i][2].ToString()
                        && Employee_Last_Name.Text == Dt.Rows[i][3].ToString())
                    {
                        if (MessageBox.Show("يوجد موظف بنفس الاسم هل تريد التعديل على أيتِ حال؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            return;
                    }
                }
                Emp.Employee_update(Employee_First_Name.Text, Employee_Father_Name.Text, Employee_Last_Name.Text, Employee_Mother_Name.Text
              , Employee_Mobail.Text, Employee_Scie_Level.Text, Employee_Scie_Specialization.Text, Employee_Brith_Date.Value
               , Employee_No_Financial.Text, Employee_No_Affairs.Text, Employee_No_File.Text, Employee_No_Card.Text, Employee_Gender.Text
               , Employee_Marital_status.Text, Employee_Pr_Service_Years.Text, Employee_id);
                //
            }
            Program.Update_Message();
            LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل معلومات موظف", DateTime.Now);
        }
    }
}
