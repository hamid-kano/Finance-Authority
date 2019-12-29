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
    public partial class Employee_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee Emp = new BL.CLS_Employee();
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        DataTable Dt = new DataTable();
        DataTable Dt_emp = new DataTable();
        DataTable Dt_cons = new DataTable();
        DataTable Dt_Descrip = new DataTable();
        BL.Authority Auth = new BL.Authority();
        BL.Department Dep = new BL.Department();
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        int _Empolyee_Description_ID;
        int contract_id;
        int Employee_id;
        bool StatusContractNewOrOld = false;
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        public Employee_FORM(int Empolyee_Description_ID)
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            //this.Employee_dataGrid.DataSource = Emp.Employee_View();
            //Employee_dataGrid.Columns[0].Visible = false;
            Employee_Gender.SelectedIndex = 0;
            Employee_Marital_status.SelectedIndex = 0;
            Employee_Description_Comb_Role.DataSource = Empl_Des.Employee_Description_Comb_Role();
            Employee_Description_Comb_Role.DisplayMember = "Role_Name";
            Employee_Description_Comb_Role.ValueMember = "Role_Functional_id";
            //Employee_Description_Comb_Department.DataSource = Empl_Des.Employee_Description_Comb_Department();
            //Employee_Description_Comb_Department.DisplayMember = "Department_Name";
            //Employee_Description_Comb_Department.ValueMember = "Department_ID";
            Contracts_Comb_Contract_statue.SelectedIndex = 0;
            Employee_Description_Comb_Satutes.SelectedIndex = 0;
            Employee_Description_Comb_out_work_Statues.SelectedIndex = 0;
            Contracts_Comb_Contract_statue.SelectedIndex = 0;
            Contracts_Type.SelectedIndex = 0;
            Employee_CombAthuontic.DataSource = Auth.Authority_view();
            Employee_CombAthuontic.DisplayMember = "اسم الهيئة";
            Employee_CombAthuontic.ValueMember = "Authority_ID";
            _Empolyee_Description_ID = Empolyee_Description_ID;
            if (_Empolyee_Description_ID != -1)
            {
                Statues_Change.Enabled = true;
                Employee_add.Text = "تعديل";
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
                // معلومات الوصف الوظيفي
                Employee_CombAthuontic.Text = Dt.Rows[0][10].ToString();
                Employee_CombOffice.Text = Dt.Rows[0][9].ToString();
                Employee_Description_N0_Book.Text = Dt.Rows[0][4].ToString();
                Employee_Description_Salery.Text = Dt.Rows[0][5].ToString(); ;
                Employee_Description_Comb_Department.Text = Dt.Rows[0][6].ToString();
                Employee_Description_Comb_Role.Text = Dt.Rows[0][7].ToString();
                Employee_Description_Comb_Satutes.Text = Dt.Rows[0][1].ToString();
                Employee_Description_Now.Checked = Convert.ToBoolean(Dt.Rows[0][2].ToString()) ? true : false;
                Employee_Description_lift.Checked = Employee_Description_Now.Checked ? false : true;
                Contracts_Brows_Docs.Enabled = true;
                Employees_Brows_Docs.Enabled = true;
                Employee_delete.Enabled = true;

                if (Employee_Description_Comb_Satutes.Text == "عقد")
                {
                    StatusContractNewOrOld = true;
                    Dt_cons = Emp.Contracts_View_id((int)Dt.Rows[0][0]);
                    contract_id = (int)Dt_cons.Rows[0][0];
                    Contracts_Type.Text = Dt_cons.Rows[0][1].ToString();
                    Contracts_Date_Start.Text = Dt_cons.Rows[0][2].ToString();
                    Contracts_Date_end.Text = Dt_cons.Rows[0][3].ToString();
                    Contracts_Notes.Text = Dt_cons.Rows[0][5].ToString();
                    Contracts_Comb_Contract_statue.Text = Dt_cons.Rows[0][4].ToString();
                    groupBox_Contract.Enabled = true;

                }
                else
                {
                    groupBox_Contract.Enabled = false;
                }
            }
            else
            {
                Employee_Description_Comb_out_work_Statues.Enabled = false;
                CB_out_work.Enabled = false;
                CB_in_work.Checked = true;
                CB_in_work.Enabled = false;
                Statues_Change.Enabled = false;
                Contracts_Brows_Docs.Enabled = false;
                Employees_Brows_Docs.Enabled = false;
            }

        }

        private void Employee_new_Click(object sender, EventArgs e)
        {
            Employee_add.Enabled = true;
            Employee_First_Name.Text = "";
            Employee_Father_Name.Text = "";
            Employee_Last_Name.Text = "";
            Employee_Mother_Name.Text = "";
            Employee_Mobail.Text = "";
            Employee_Scie_Level.Text = "";
            Employee_Scie_Specialization.Text = "";
            Employee_No_Financial.Text = "";
            Employee_No_Affairs.Text = "";
            Employee_No_File.Text = "";
            Employee_No_Card.Text = "";
            Employee_Gender.Text = "";
            Employee_Marital_status.Text = "";
            Employee_Pr_Service_Years.Text = "";
            Employee_delete.Enabled = false;
            Employee_Description_N0_Book.Text = "";
            Employee_Description_Salery.Text = "";
            Contracts_Type.Text = "";
            Contracts_Notes.Text = "";
            Contracts_Brows_Docs.Enabled = false;
            Employees_Brows_Docs.Enabled = false;
            Employee_add.Text = "اضافة";
            Statues_Change.Enabled = false;



        }

        private void Employee_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_add_Click(object sender, EventArgs e)
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
            if (Employee_Pr_Service_Years.Text == String.Empty)
            {

                MessageBox.Show("أضف عدد سنوات الخدمة السابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //// التحقق من معلومات الوصف الوظيفي
            if (Employee_Description_N0_Book.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم الكتاب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Description_Salery.Text == String.Empty)
            {

                MessageBox.Show("أضف راتب الموظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (groupBox_Contract.Enabled)
            {
                if (Contracts_Type.Text == String.Empty)
                {

                    MessageBox.Show("ادخل نوع العقد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Contracts_Date_Start.Value > Contracts_Date_end.Value)
                {

                    MessageBox.Show("يجب ان يكون تاريخ نهاية العقد اكبر من تاريخ بدايته", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            //bool Functunal_status = Employee_Description_Allowes.Checked ? true : false;
            /// 
            if (Employee_add.Text != "تعديل")
            {
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
                            if (MessageBox.Show("يوجد موظف بنفس الاسم هل تريد الاضافة؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                return;
                        }
                    }
                }
                Dt_Descrip = Empl_Des.Employee_Description_View();
                for (int i = 0; i < Dt_Descrip.Rows.Count; i++)
                {
                    if ((int)Empl_Des.Employee_Description_View().Rows[i][0] != _Empolyee_Description_ID)
                    {
                        if (Employee_Description_N0_Book.Text == Dt_Descrip.Rows[i][4].ToString())
                        {
                            MessageBox.Show("رقم الكتاب موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
                Emp.Employee_add(Employee_First_Name.Text, Employee_Father_Name.Text, Employee_Last_Name.Text, Employee_Mother_Name.Text
            , Employee_Mobail.Text, Employee_Scie_Level.Text, Employee_Scie_Specialization.Text, Employee_Brith_Date.Value
            , Employee_No_Financial.Text, Employee_No_Affairs.Text, Employee_No_File.Text, Employee_No_Card.Text, Employee_Gender.Text
            , Employee_Marital_status.Text, Employee_Pr_Service_Years.Text);
                // اضافة الوصف الوظيفي
                Program.Employee_id = (int)Emp.Employee_last_id().Rows[0][0];
                bool Role_status = true;
                Empl_Des.Employee_Description_add(Employee_Description_Comb_Satutes.Text, Role_status, Employee_Description_DateTime.Value, Employee_Description_N0_Book.Text, Employee_Description_Salery.Text,
                    Convert.ToInt32(Employee_Description_Comb_Department.SelectedValue), Convert.ToInt32(Employee_Description_Comb_Role.SelectedValue), Program.Employee_id);

                int Description_last_id = (int)Emp.Employee_Description_last_id().Rows[0][0];
                /// اضافة ملحقات لهذا المووظف
                if (MessageBox.Show("هل تريد اضافة ملحقات لهذا الموظف؟", "ملحقات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Document_FORM FRM = new Document_FORM(Description_last_id, "موظف");
                    FRM.ShowDialog();
                }
                ////

                if (groupBox_Contract.Enabled == true)
                {
                    cont.Contracts_add(Contracts_Type.Text, Contracts_Date_Start.Value, Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
                         , Contracts_Notes.Text, Description_last_id);
                    Contracts_Type.Text = "";
                    Contracts_Notes.Text = "";
                    ///
                    /// اضافة ملحقات للعقد
                    if (MessageBox.Show("هل تريد اضافة ملحقات لهذا العقد؟", "ملحقات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Document_FORM FRM = new Document_FORM(Description_last_id, "عقد");
                        FRM.ShowDialog();
                    }
                    ////
                    ///
                }
                Program.Add_Message();
                LOG.LOGS_add(Program.USER_ID, "اضافة", "اضافة موظف جديد", DateTime.Now);

            }
            else
            {

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
                }
                Dt_Descrip = Empl_Des.Employee_Description_View();
                for (int i = 0; i < Dt_Descrip.Rows.Count; i++)
                {
                    if ((int)Empl_Des.Employee_Description_View().Rows[i][0] != _Empolyee_Description_ID)
                    {
                        if (Employee_Description_N0_Book.Text == Dt_Descrip.Rows[i][4].ToString())
                        {
                            MessageBox.Show("رقم الكتاب موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
                Emp.Employee_update(Employee_First_Name.Text, Employee_Father_Name.Text, Employee_Last_Name.Text, Employee_Mother_Name.Text
                   , Employee_Mobail.Text, Employee_Scie_Level.Text, Employee_Scie_Specialization.Text, Employee_Brith_Date.Value
                    , Employee_No_Financial.Text, Employee_No_Affairs.Text, Employee_No_File.Text, Employee_No_Card.Text, Employee_Gender.Text
                    , Employee_Marital_status.Text, Employee_Pr_Service_Years.Text, Employee_id);
                //
                if (Employee_Description_Update.Checked)
                {
                    Empl_Des.Employee_Description_update(Employee_Description_Comb_Satutes.Text, Employee_Description_Now.Checked, Employee_Description_DateTime.Value, Employee_Description_N0_Book.Text, Employee_Description_Salery.Text, Convert.ToInt32(Employee_Description_Comb_Department.SelectedValue),
                        Convert.ToInt32(Employee_Description_Comb_Role.SelectedValue),
                          Employee_id, _Empolyee_Description_ID);
                }
                else
                {

                    Empl_Des.Employee_Description_update_Role_status_Empl_ID(Employee_id);// جعل الحالات الوظيفية السابقة سابقة
                    Empl_Des.Employee_Description_add(Employee_Description_Comb_Satutes.Text, true, Employee_Description_DateTime.Value, Employee_Description_N0_Book.Text, Employee_Description_Salery.Text,
                        Convert.ToInt32(Employee_Description_Comb_Department.SelectedValue), Convert.ToInt32(Employee_Description_Comb_Role.SelectedValue), Employee_id);
                }
                //
                if (StatusContractNewOrOld && Employee_Description_Comb_Satutes.Text == "عقد")
                {
                    cont.Contracts_update(Contracts_Type.Text, Contracts_Date_Start.Value, Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
                    , Contracts_Notes.Text, _Empolyee_Description_ID, contract_id);
                }
                else if (!StatusContractNewOrOld && Employee_Description_Comb_Satutes.Text == "عقد")
                {
                    cont.Contracts_add(Contracts_Type.Text, Contracts_Date_Start.Value, Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
                         , Contracts_Notes.Text, _Empolyee_Description_ID);
                    Contracts_Type.Text = "";
                    Contracts_Notes.Text = "";

                }
                // كان عقد واصبح غير ملتحق بعقد
                else if (StatusContractNewOrOld && Employee_Description_Comb_Satutes.Text != "عقد")
                {
                    /// حالة التعديل يتم الحذف
                    if (Employee_Description_Update.Checked)
                    {
                        cont.Contracts_Delete(contract_id);
                    }
                    /// حالة التغيير يتم وضع العقد منتهي
                    else if (Employee_Description_Change.Checked)
                    {
                        contract_id = (int)Dt_cons.Rows[0][0];
                        Contracts_Type.Text = Dt_cons.Rows[0][1].ToString();
                        Contracts_Date_Start.Text = Dt_cons.Rows[0][2].ToString();
                        Contracts_Date_end.Text = DateTime.Now.ToString();
                        Contracts_Notes.Text = Dt_cons.Rows[0][5].ToString();
                        Contracts_Comb_Contract_statue.Text = "منتهي";
                        cont.Contracts_update(Contracts_Type.Text, Contracts_Date_Start.Value, Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
                      , Contracts_Notes.Text, _Empolyee_Description_ID, contract_id);

                    }

                }

                Program.Update_Message();
                LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل معلومات موظف", DateTime.Now);
                Employee_Description_N0_Book.Text = "";
                Employee_Description_Salery.Text = "";
                Employee_First_Name.Text = "";
                Employee_Father_Name.Text = "";
                Employee_Last_Name.Text = "";
                Employee_Mother_Name.Text = "";
                Employee_Mobail.Text = "";
                Employee_Scie_Level.Text = "";
                Employee_Scie_Specialization.Text = "";
                Employee_No_Financial.Text = "";
                Employee_No_Affairs.Text = "";
                Employee_No_File.Text = "";
                Employee_No_Card.Text = "";
                Employee_Gender.Text = "";
                Employee_Marital_status.Text = "";
                Employee_Pr_Service_Years.Text = "";
                Employee_add.Enabled = false;

            }
        }
        private void Employee_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الموظف .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Empl_Des.Employee_Description_Delete(_Empolyee_Description_ID);
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف موظف", DateTime.Now);
                Employee_First_Name.Text = "";
                Employee_Father_Name.Text = "";
                Employee_Last_Name.Text = "";
                Employee_Mother_Name.Text = "";
                Employee_Mobail.Text = "";
                Employee_Scie_Level.Text = "";
                Employee_Scie_Specialization.Text = "";
                Employee_No_Financial.Text = "";
                Employee_No_Affairs.Text = "";
                Employee_No_File.Text = "";
                Employee_No_Card.Text = "";
                Employee_Gender.Text = "";
                Employee_Marital_status.Text = "";
                Employee_Pr_Service_Years.Text = "";
                Employee_delete.Enabled = false;
                Employees_Brows_Docs.Enabled = false;

            }
        }
        private void Employee_Mobail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_No_Financial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_No_Affairs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_No_File_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }
        private void Employee_No_Card_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }
        private void Employee_Pr_Service_Years_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_Description_N0_Book_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_Description_Salery_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_CombAthuontic_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idAthuontic = Convert.ToInt32(Employee_CombAthuontic.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Employee_CombOffice.DataSource = Dep.Department_CombAuthority_Office(idAthuontic);
                Employee_CombOffice.DisplayMember = "Office_Name";
                Employee_CombOffice.ValueMember = "Office_ID";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Employee_CombOffice_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idOffice = Convert.ToInt32(Employee_CombOffice.SelectedValue);
                Employee_Description_Comb_Department.DataSource = Dep.Loans_Comb_Department(idOffice);
                Employee_Description_Comb_Department.DisplayMember = "Department_Name";
                Employee_Description_Comb_Department.ValueMember = "Department_ID";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Employee_Description_Comb_Satutes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Employee_Description_Comb_Satutes.Text == "عقد")
            {
                groupBox_Contract.Enabled = true;
            }
            else groupBox_Contract.Enabled = false;

        }

        private void Contracts_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(_Empolyee_Description_ID, "عقد");
            FRM.ShowDialog();
        }

        private void Employees_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(_Empolyee_Description_ID, "موظف");
            FRM.ShowDialog();
        }

        private void CB_in_work_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_in_work.Checked)
            {
                CB_out_work.Checked = false;
                Employee_Description_Comb_Satutes.Enabled = true;
                Employee_Description_Comb_out_work_Statues.Enabled = false;
            }
            else
            {
                CB_out_work.Checked = true;
                Employee_Description_Comb_out_work_Statues.Enabled = true;
                Employee_Description_Comb_Satutes.Enabled = false;
            }
        }

        private void CB_out_work_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_out_work.Checked)
            {
                CB_in_work.Checked = false;
                Employee_Description_Comb_Satutes.Enabled = false;
                Employee_Description_Comb_out_work_Statues.Enabled = true;
            }
            else
            {
                CB_in_work.Checked = true;
                Employee_Description_Comb_out_work_Statues.Enabled = false;
                Employee_Description_Comb_Satutes.Enabled = true;

            }
        }
    }
} 


