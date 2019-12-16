﻿using System;
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
        BL.Authority Auth = new BL.Authority();
        BL.Department Dep = new BL.Department();
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        int _Empolyee_Description_ID;
        int contract_id;
        int Employee_id;
        bool StatusContractNewOrOld = false;
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
            Employee_Description_Comb_Satutes.SelectedIndex = 0;
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

                Employee_Description_N0_Book.Text = Dt.Rows[0][4].ToString();
                Employee_Description_Salery.Text = Dt.Rows[0][5].ToString(); ;
                Employee_Description_Comb_Department.Text = Dt.Rows[0][6].ToString();
                Employee_Description_Comb_Role.Text = Dt.Rows[0][7].ToString();
                Employee_Description_Comb_Satutes.Text = Dt.Rows[0][1].ToString();
                Employee_Description_Now.Checked = Convert.ToBoolean(Dt.Rows[0][2].ToString()) ? true : false;
                Employee_Description_lift.Checked = Employee_Description_Now.Checked ? false : true;

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
                Statues_Change.Enabled = false;
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
            Employee_update.Enabled = false;
            Employee_delete.Enabled = false;
            Employee_Description_N0_Book.Text = "";
            Employee_Description_Salery.Text = "";
            Contracts_Type.Text = "";
            Contracts_Notes.Text = "";


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

                MessageBox.Show("أضف عدد السنوات السابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            }
            //bool Functunal_status = Employee_Description_Allowes.Checked ? true : false;
            /// 
            if (Employee_add.Text != "تعديل")
            {
                Emp.Employee_add(Employee_First_Name.Text, Employee_Father_Name.Text, Employee_Last_Name.Text, Employee_Mother_Name.Text
                    , Employee_Mobail.Text, Employee_Scie_Level.Text, Employee_Scie_Specialization.Text, Employee_Brith_Date.Value
                    , Employee_No_Financial.Text, Employee_No_Affairs.Text, Employee_No_File.Text, Employee_No_Card.Text, Employee_Gender.Text
                    , Employee_Marital_status.Text, Employee_Pr_Service_Years.Text);

                // اضافة الوصف الوظيفي
                int last_id_Emp = (int)Emp.Employee_last_id().Rows[0][0];
                bool Role_status = true;
                Empl_Des.Employee_Description_add(Employee_Description_Comb_Satutes.Text, Role_status, Employee_Description_DateTime.Value, Employee_Description_N0_Book.Text, Employee_Description_Salery.Text,
                    Convert.ToInt32(Employee_Description_Comb_Department.SelectedValue), Convert.ToInt32(Employee_Description_Comb_Role.SelectedValue), last_id_Emp);
                if (groupBox_Contract.Enabled == true)
                {
                    int Description_last_id = (int)Emp.Employee_Description_last_id().Rows[0][0];
                    cont.Contracts_add(Contracts_Type.Text, Contracts_Date_Start.Value, Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
                         , Contracts_Notes.Text, Description_last_id);
                    Contracts_Type.Text = "";
                    Contracts_Notes.Text = "";
                }
                ///
                Program.Add_Message();

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
                            if (MessageBox.Show("يوجد موظف بنفس الاسم هل تريد الاضافة؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                return;
                        }
                    }

                    Emp.Employee_update(Employee_First_Name.Text, Employee_Father_Name.Text, Employee_Last_Name.Text, Employee_Mother_Name.Text
                  , Employee_Mobail.Text, Employee_Scie_Level.Text, Employee_Scie_Specialization.Text, Employee_Brith_Date.Value
                  , Employee_No_Financial.Text, Employee_No_Affairs.Text, Employee_No_File.Text, Employee_No_Card.Text, Employee_Gender.Text
                  , Employee_Marital_status.Text, Employee_Pr_Service_Years.Text, Employee_id);
                    //
                    if (Employee_Description_Update.Checked)
                    {
                        Empl_Des.Employee_Description_update(Employee_Description_Comb_Satutes.Text, Employee_Description_Now.Checked, Employee_Description_DateTime.Value, Employee_Description_N0_Book.Text, Employee_Description_Salery.Text, Convert.ToInt32(Employee_Description_Comb_Department.SelectedValue), Convert.ToInt32(Employee_Description_Comb_Role.SelectedValue),
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
                    else if (!StatusContractNewOrOld &&  Employee_Description_Comb_Satutes.Text == "عقد")
                    {
                        cont.Contracts_add(Contracts_Type.Text, Contracts_Date_Start.Value, Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
                             , Contracts_Notes.Text, _Empolyee_Description_ID);
                        Contracts_Type.Text = "";
                        Contracts_Notes.Text = "";

                    }
                    // كان عقد واصبح غير ملتحق بعقد
                    else if (StatusContractNewOrOld && Employee_Description_Comb_Satutes.Text != "عقد" )
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
                }
                Program.Update_Message();
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

            private void Employee_update_Click(object sender, EventArgs e)
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

                    MessageBox.Show("أضف عدد السنوات السابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Dt = Emp.Employee_View();
                for (int i = 0; i < Dt.Rows.Count; i++)
                {


                    if ((int)Dt.Rows[i][0] != Program.Employee_id)
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
                            if (MessageBox.Show("يوجد موظف بنفس الاسم هل تريد الاضافة؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                            }
                            else
                            {
                                return;
                            }

                        }

                    }
                }
                Emp.Employee_update(Employee_First_Name.Text, Employee_Father_Name.Text, Employee_Last_Name.Text, Employee_Mother_Name.Text
               , Employee_Mobail.Text, Employee_Scie_Level.Text, Employee_Scie_Specialization.Text, Employee_Brith_Date.Value
               , Employee_No_Financial.Text, Employee_No_Affairs.Text, Employee_No_File.Text, Employee_No_Card.Text, Employee_Gender.Text
               , Employee_Marital_status.Text, Employee_Pr_Service_Years.Text, Program.Employee_id);
                Program.Update_Message();
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
                Employee_update.Enabled = false;
                Employee_delete.Enabled = false;
            }

            //private void Employee_dataGrid_Click(object sender, EventArgs e)
            //{
            //    if (Employee_dataGrid.CurrentRow != null)
            //    {
            //        Program.Employee_id= Convert.ToInt32(this.Employee_dataGrid.CurrentRow.Cells[0].Value.ToString());
            //        Employee_First_Name.Text = this.Employee_dataGrid.CurrentRow.Cells[1].Value.ToString();
            //        Employee_Father_Name.Text = this.Employee_dataGrid.CurrentRow.Cells[2].Value.ToString();
            //        Employee_Last_Name.Text = this.Employee_dataGrid.CurrentRow.Cells[3].Value.ToString();
            //        Employee_Mother_Name.Text = this.Employee_dataGrid.CurrentRow.Cells[4].Value.ToString();
            //        Employee_Brith_Date.Text = this.Employee_dataGrid.CurrentRow.Cells[5].Value.ToString();
            //        Employee_Mobail.Text = this.Employee_dataGrid.CurrentRow.Cells[6].Value.ToString();
            //        Employee_Scie_Level.Text = this.Employee_dataGrid.CurrentRow.Cells[7].Value.ToString();
            //        Employee_Scie_Specialization.Text = this.Employee_dataGrid.CurrentRow.Cells[8].Value.ToString();
            //        Employee_No_Financial.Text = this.Employee_dataGrid.CurrentRow.Cells[9].Value.ToString();
            //        Employee_No_Affairs.Text = this.Employee_dataGrid.CurrentRow.Cells[10].Value.ToString();
            //        Employee_No_File.Text = this.Employee_dataGrid.CurrentRow.Cells[11].Value.ToString();
            //        Employee_No_Card.Text = this.Employee_dataGrid.CurrentRow.Cells[12].Value.ToString();
            //        Employee_Gender.Text = this.Employee_dataGrid.CurrentRow.Cells[13].Value.ToString();
            //        Employee_Marital_status.Text = this.Employee_dataGrid.CurrentRow.Cells[14].Value.ToString();
            //        Employee_Pr_Service_Years.Text = this.Employee_dataGrid.CurrentRow.Cells[15].Value.ToString();
            //        Employee_update.Enabled = true;
            //        Employee_delete.Enabled = true;
            //        Employee_add.Enabled = false;
            //    }
            //}

            private void Employee_delete_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("هل تريد حذف الموظف .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Emp.Employee_Delete(Program.Employee_id);
                    //this.Employee_dataGrid.DataSource = Emp.Employee_View();
                    //Employee_dataGrid.Columns[0].Visible = false;
                    MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Employee_update.Enabled = false;
                    Employee_delete.Enabled = false;
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


            //private void Employee_Print_Click(object sender, EventArgs e)
            //{
            //    REPT.Crystal_Employee Art = new REPT.Crystal_Employee();

            //    REPT.FRM_Report FRPT = new REPT.FRM_Report();

            //    if (Employee_dataGrid.Rows.Count != 0)
            //    {
            //        // DataTable dt = dataGrid_Ringall.DataSource;
            //        Art.SetDataSource(Employee_dataGrid.DataSource);

            //        FRPT.crystalReportViewer1.ReportSource = Art;
            //        FRPT.ShowDialog();
            //    }
            //}     
            //private void Employee_Search_Name_TextChanged_1(object sender, EventArgs e)
            //{
            //    this.Employee_dataGrid.DataSource = Emp.Employee_Search_Name(Employee_Search_Name.Text);
            //    Employee_dataGrid.Columns[0].Visible = false;
            //}

            //private void Employee_Search_Mony_TextChanged(object sender, EventArgs e)
            //{
            //    this.Employee_dataGrid.DataSource = Emp.Employee_Search_Mony(Employee_Search_Mony.Text);
            //    Employee_dataGrid.Columns[0].Visible = false;
            //}


        }
    } 


