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
    public partial class Users_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_User user = new BL.CLS_User();
        int _user_id;
        public Users_FORM()
        {
            InitializeComponent();
            Users_DataGrid.DataSource = user.User_View();
            Users_DataGrid.Columns[0].Visible = false;
        }

        private void Users_new_Click(object sender, EventArgs e)
        {
            Users_update.Enabled = false;
            Users_delete.Enabled = false;
            Users_add.Enabled = true;
            Users_userName.Text = "";
            Users_password.Text = "";
            Users_Confirm_password.Text = "";
            foreach (var item in groupBox1.Controls)
            {
                CheckBox checkBox=(CheckBox)item;
                checkBox.Checked = false;
            }
        }

        private void Users_add_Click(object sender, EventArgs e)
        {
            if (Users_userName.Text=="")
            {
                MessageBox.Show("يجب ادخال اسم المستخدم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Users_password.Text == "")
            {
                MessageBox.Show("يجب ادخال كلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Users_Confirm_password.Text == "")
            {
                MessageBox.Show("يجب ادخال تأكيد كلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Users_password.Text !=Users_Confirm_password.Text)
            {
                MessageBox.Show("كلمة المرور وتأكيدها غير متطابقتين", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (user.User_Check_UserName(Users_userName.Text).Rows.Count>0)
            {
                MessageBox.Show("هناك مستخدم آخر بنفس الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            user.User_Add(Users_userName.Text, Users_password.Text, Authority_FORM.Checked, Backup_FORM.Checked, Backup_Restor_FORM.Checked, Bills_Details_FORM.Checked, Bills_FORM.Checked,
                Budget_FORM.Checked, Budget_Now_FORM.Checked, Coin_Exchange_FORM.Checked, Contracts_FORM.Checked, Department_FORM.Checked, Document_Category_FORM.Checked,
                Document_FORM.Checked, Emission_Salaries_FORM.Checked, Employee_Description_FORM.Checked, Employee_FORM.Checked, Employee_Salaries_FORM.Checked,
                EX_Order_FORM.Checked, EX_Orders_Cat_FORM.Checked, Leoan_Payments_FORM.Checked, Loans_FORM.Checked, Office_FORM.Checked, Payment_Document_FORM.Checked,
                Reciver_Document_FORM.Checked, Role_Functional_FORM.Checked, Users_CB_FORM.Checked, Users_LOGS_FORM.Checked);

            Program.Special_Message("تمت الاضافة بنجاح");
            Users_DataGrid.DataSource = user.User_View();
            Users_DataGrid.Columns[0].Visible = false;
            Users_userName.Text = "";
            Users_password.Text = "";
            Users_Confirm_password.Text = "";
            foreach (var item in groupBox1.Controls)
            {
                CheckBox checkBox = (CheckBox)item;
                checkBox.Checked = false;
            }
            Users_update.Enabled = false;
            Users_delete.Enabled = false;
            Users_add.Enabled = false;
        }

        private void Users_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_DataGrid_Click(object sender, EventArgs e)
        {
            if (this.Users_DataGrid.CurrentRow!=null)
            {
                Users_update.Enabled = true;
                Users_delete.Enabled = true;
                Users_add.Enabled = false;
                _user_id=Convert.ToInt32(Users_DataGrid.CurrentRow.Cells[0].Value.ToString());
                DataGridViewRow dr = this.Users_DataGrid.CurrentRow;
                Users_userName.Text = dr.Cells[1].Value.ToString();
                Users_password.Text = dr.Cells[2].Value.ToString();
                Users_Confirm_password.Text = Users_password.Text;
                Authority_FORM.Checked = Convert.ToBoolean(dr.Cells[3].Value);
                Backup_FORM.Checked = Convert.ToBoolean(dr.Cells[4].Value);
                Backup_Restor_FORM.Checked = Convert.ToBoolean(dr.Cells[5].Value);
                Bills_Details_FORM.Checked = Convert.ToBoolean(dr.Cells[6].Value);
                Bills_FORM.Checked = Convert.ToBoolean(dr.Cells[7].Value);
                Budget_FORM.Checked = Convert.ToBoolean(dr.Cells[8].Value);
                Budget_Now_FORM.Checked = Convert.ToBoolean(dr.Cells[9].Value);
                Coin_Exchange_FORM.Checked = Convert.ToBoolean(dr.Cells[10].Value);
                Contracts_FORM.Checked = Convert.ToBoolean(dr.Cells[11].Value);
                Department_FORM.Checked = Convert.ToBoolean(dr.Cells[12].Value);
                Document_Category_FORM.Checked = Convert.ToBoolean(dr.Cells[13].Value);
                Document_FORM.Checked = Convert.ToBoolean(dr.Cells[14].Value);
                Emission_Salaries_FORM.Checked = Convert.ToBoolean(dr.Cells[15].Value);
                Employee_Description_FORM.Checked = Convert.ToBoolean(dr.Cells[16].Value);
                Employee_FORM.Checked = Convert.ToBoolean(dr.Cells[17].Value);
                Employee_Salaries_FORM.Checked = Convert.ToBoolean(dr.Cells[18].Value);
                EX_Order_FORM.Checked = Convert.ToBoolean(dr.Cells[19].Value);
                EX_Orders_Cat_FORM.Checked = Convert.ToBoolean(dr.Cells[20].Value);
                Leoan_Payments_FORM.Checked = Convert.ToBoolean(dr.Cells[21].Value);
                Loans_FORM.Checked = Convert.ToBoolean(dr.Cells[22].Value);
                Office_FORM.Checked = Convert.ToBoolean(dr.Cells[23].Value);
                Payment_Document_FORM.Checked = Convert.ToBoolean(dr.Cells[24].Value);
                Reciver_Document_FORM.Checked = Convert.ToBoolean(dr.Cells[25].Value);
                Role_Functional_FORM.Checked = Convert.ToBoolean(dr.Cells[26].Value);
                Users_CB_FORM.Checked = Convert.ToBoolean(dr.Cells[27].Value);
                Users_LOGS_FORM.Checked = Convert.ToBoolean(dr.Cells[28].Value);
            }
        }

        private void Users_delete_Click(object sender, EventArgs e)
        {
            Users_update.Enabled = false;
            Users_delete.Enabled = false;
            Users_add.Enabled = false;
            Users_userName.Text = "";
            Users_password.Text = "";
            Users_Confirm_password.Text = "";
            foreach (var item in groupBox1.Controls)
            {
                CheckBox checkBox = (CheckBox)item;
                checkBox.Checked = false;
            }
            user.User_Delete_By_ID(_user_id);
            Program.Special_Message("تم الحذف  بنجاح");
            Users_DataGrid.DataSource = user.User_View();
            Users_DataGrid.Columns[0].Visible = false;
        }

        private void Users_update_Click(object sender, EventArgs e)
        {
            if (Users_userName.Text == "")
            {
                MessageBox.Show("يجب ادخال اسم المستخدم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Users_password.Text == "")
            {
                MessageBox.Show("يجب ادخال كلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Users_Confirm_password.Text == "")
            {
                MessageBox.Show("يجب ادخال تأكيد كلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Users_password.Text != Users_Confirm_password.Text)
            {
                MessageBox.Show("كلمة المرور وتأكيدها غير متطابقتين", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Users_userName.Text.Length>50 || Users_password.Text.Length>50)
            {
                MessageBox.Show("يجب ألا يتجاوز اسم المستخدم وكلمة المرور اكثر من 50 محرف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Users_DataGrid.CurrentRow.Cells[1].Value.ToString()!=Users_userName.Text)
            {
                if (user.User_Check_UserName(Users_userName.Text).Rows.Count>0)
                {
                    MessageBox.Show("هناك مستخدم آخر بنفس الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            user.User_update(Users_userName.Text, Users_password.Text, Authority_FORM.Checked, Backup_FORM.Checked, Backup_Restor_FORM.Checked, Bills_Details_FORM.Checked, Bills_FORM.Checked,
    Budget_FORM.Checked, Budget_Now_FORM.Checked, Coin_Exchange_FORM.Checked, Contracts_FORM.Checked, Department_FORM.Checked, Document_Category_FORM.Checked,
    Document_FORM.Checked, Emission_Salaries_FORM.Checked, Employee_Description_FORM.Checked, Employee_FORM.Checked, Employee_Salaries_FORM.Checked,
    EX_Order_FORM.Checked, EX_Orders_Cat_FORM.Checked, Leoan_Payments_FORM.Checked, Loans_FORM.Checked, Office_FORM.Checked, Payment_Document_FORM.Checked,
    Reciver_Document_FORM.Checked, Role_Functional_FORM.Checked, Users_CB_FORM.Checked, Users_LOGS_FORM.Checked,_user_id);

            Program.Special_Message("تمت التعديل بنجاح");
            Users_DataGrid.DataSource = user.User_View();
            Users_DataGrid.Columns[0].Visible = false;
            Users_userName.Text = "";
            Users_password.Text = "";
            Users_Confirm_password.Text = "";
            foreach (var item in groupBox1.Controls)
            {
                CheckBox checkBox = (CheckBox)item;
                checkBox.Checked = false;
            }
            Users_update.Enabled = false;
            Users_delete.Enabled = false;
            Users_add.Enabled = false;
        }

        private void Users_Search_ByName_TextChanged(object sender, EventArgs e)
        {
            Users_DataGrid.DataSource = user.User_View_By_Name(Users_Search_ByName.Text);
            Users_DataGrid.Columns[0].Visible = false;
        }
    }
}
