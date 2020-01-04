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
    public partial class User_Account_FORM  : MetroFramework.Forms.MetroForm
    {
        BL.CLS_User user = new BL.CLS_User();
        public User_Account_FORM()
        {
            InitializeComponent();
            User_Account_userName.Text = Program.USER_NAME;
        }

        private void User_Account_Fexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_Account_update_Click(object sender, EventArgs e)
        {
            if (User_Account_userName.Text == "")
            {
                MessageBox.Show("يجب ادخال اسم المستخدم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (User_Account_old_password.Text == "")
            {
                MessageBox.Show("يجب ادخال كلمة المرور القديمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (User_Account_new_password.Text == "")
            {
                MessageBox.Show("يجب ادخال كلمة المرور الجديدة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (User_Account_Confirm_new_password.Text == "")
            {
                MessageBox.Show("يجب ادخال تأكيد كلمة المرور الجديدة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (User_Account_new_password.Text != User_Account_Confirm_new_password.Text)
            {
                MessageBox.Show("كلمة المرور الجديدة وتأكيدها غير متطابقتين", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Program.USER_NAME != User_Account_userName.Text)
            {
                if (user.User_Check_UserName(User_Account_userName.Text).Rows.Count > 0)
                {
                    MessageBox.Show("هناك مستخدم آخر بنفس الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (User_Account_old_password.Text !=Program.USER_PASSWORD)
            {
                MessageBox.Show("كلمة المرور القديمة غير صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            user.User_update_Username_Password(User_Account_userName.Text, User_Account_new_password.Text,Program.USER_ID);
            Program.USER_NAME = User_Account_userName.Text;
            Program.USER_PASSWORD = User_Account_new_password.Text;
            Program.Special_Message("تمت عملية التعديل بنجاح");
            User_Account_old_password.Text = "";
            User_Account_new_password.Text = "";
            User_Account_Confirm_new_password.Text = "";
        }
    }
}
