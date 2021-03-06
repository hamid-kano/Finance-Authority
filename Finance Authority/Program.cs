﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        public static int Category_id;
        public static int Exchange_Order_id;
        public static int Authority_ID;
        public static int Office_ID;
        public static int Department_ID;
        public static int Role_Functional_id;
        public static int  Budget_Id;
        public static int Coin_Exchange_id;
        public static int Category_id_id;
        public static int Reciver_Document_id;
        public static int Payment_Document_id;
        public static int Employee_id;
        public static int Employee_Description_id;
        public static int Contracts_id;
        public static int Emission_Salaries_id;
        public static int Loan_id;
        public static int Leoan_Payments_id;
        public static int Employee_Salaries_id;
        public static int Document_id;
        public static int Bill_Id;
        public static String RPT_SERVER_NAME;
        public static int USER_ID=-1;
        public static string USER_NAME;
        public static string USER_PASSWORD;
        public static string Server_UserName;
        public static string Server_Password;
        public static string Server_Name;

        /// </summary>
        /// 
        public static int theme=1;
        public static int style=14;

        // حساب الصندوق الحالي و نسبة الواردات والصادرات
        public static BL.CLS_Budget budget = new BL.CLS_Budget();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.Finance_Authority());
        }


        public static MetroFramework.Components.MetroStyleManager theme_style(MetroFramework.Forms.MetroForm frm)
        {
            MetroFramework.Components.MetroStyleManager metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            metroStyleManager.Owner = frm;
            if (theme==0)
                metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
           
            //// style

            switch (style)
            {
                case 0:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Red;
                    Program.style = 0;
                    break;
                case 1:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
                    Program.style = 1;
                    break;
                case 2:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Pink;
                    Program.style = 2;
                    break;
                case 3:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Magenta;
                    Program.style = 3;
                    break;
                case 4:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Purple;
                    Program.style = 4;
                    break;
                case 5:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Yellow;
                    Program.style = 5;
                    break;
                case 6:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.White;
                    Program.style = 6;
                    break;
                case 7:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
                    Program.style = 7;
                    break;
                case 8:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Teal;
                    Program.style = 8;
                    break;
                case 9:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Green;
                    Program.style = 9;
                    break;
                case 10:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Black;
                    Program.style = 10;
                    break;
                case 11:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Brown;
                    Program.style = 11;
                    break;
                case 12:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Lime;
                    Program.style = 12;
                    break;
                case 13:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Silver;
                    Program.style = 13;
                    break;
                case 14:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
                    Program.style = 14;
                    break;

            }

            return metroStyleManager;

        }

        public static void Add_Message()
        {
            MessageBox.Show("تمت عملية الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Special_Message(string contentMessage)
        {
            MessageBox.Show(contentMessage, "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Update_Message()
        {
            MessageBox.Show("تمت عملية التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Delete_Message() 
        {
            MessageBox.Show("تمت عملية الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult Delete_Confirm_Message()
        {
            return MessageBox.Show("هل تريد الحذف بالتاكيد ؟", "تنبيه", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
        }
         public static bool DenyChar(KeyPressEventArgs e) 
         {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                return true;
            }
            else
            {
                return false;
            }
         }
        public static DataRow Budget_NOW()
        {
            if (budget.Budget_Last_Budget().Rows.Count!=0)
            {
                DataRow dt = budget.Budget_Last_Budget().Rows[0];
                return dt;
            }
            else
            {
                return null;
            }
        }

        //الميزانية الفعلية = المبلغ الحالي -الوارد +الصادر
        //نسبة الواردات = مجموع الواردات / الميزانية الفعلية
        public static double Month_Imports_rate()
        {
            try
            {
                DataRow dt_Sum_import = budget.Budget_Last_Sum_Reciver().Rows[0];
                DataRow dt_Sum_export = budget.Budget_Last_Sum_Payment().Rows[0]; 
                 DataRow dt_Budget_NOW = Budget_NOW();
                double sumimport = Convert.ToDouble(dt_Sum_import[0]);
                double sumexport = Convert.ToDouble(dt_Sum_export[0]);
                double budgetNow = Convert.ToDouble(dt_Budget_NOW[0]);
                double actual_Budget = Convert.ToDouble(dt_Budget_NOW[0]) + Convert.ToDouble(dt_Sum_export[0]) - Convert.ToDouble(dt_Sum_import[0]);
                return Convert.ToDouble(Math.Round((Convert.ToDouble(dt_Sum_import[0]) / actual_Budget) * 100)) <0? 0: Convert.ToDouble(Math.Round((Convert.ToDouble(dt_Sum_import[0]) / actual_Budget) * 100));
            }
            catch
            {
                return 0;
            }
        }
        public static double Month_Exmports_rate()
        {
            try
            {
                DataRow dt_Sum_import = budget.Budget_Last_Sum_Reciver().Rows[0];
                DataRow dt_Sum_export = budget.Budget_Last_Sum_Payment().Rows[0];
                DataRow dt_Budget_NOW = Budget_NOW();
                double sumimport = Convert.ToDouble(dt_Sum_import[0]);
                double sumexport = Convert.ToDouble(dt_Sum_export[0]);
                double budgetNow = Convert.ToDouble(dt_Budget_NOW[0]);
                double actual_Budget = Convert.ToDouble(dt_Budget_NOW[0]) + Convert.ToDouble(dt_Sum_export[0]) - Convert.ToDouble(dt_Sum_import[0]);
                return Convert.ToDouble(Math.Round((Convert.ToDouble(dt_Sum_export[0]) / actual_Budget) * 100))<0 ? 0: Convert.ToDouble(Math.Round((Convert.ToDouble(dt_Sum_export[0]) / actual_Budget) * 100));
            }
            catch
            {
                return 0;
            }
        }

        //  تحديث الميزانية بعد عمليات الدفع و الاستلام
        public static void Budget_update_after_Payment_Reciver(string TypeDoc,string SY ,string Dollar)
        {
           
            DataRow dt_Budget_NOW = Budget_NOW();
            DataRow dt_Sum_import = budget.Budget_Last_Sum_Reciver().Rows[0]; // جلب الواردات الشهرية سوري ودولار
            if (dt_Budget_NOW!=null)
            {
                double sy_now = Convert.ToDouble(dt_Budget_NOW[1]);
                double dollar_now = Convert.ToDouble(dt_Budget_NOW[2]);
                double sy = SY != string.Empty ? Convert.ToDouble(SY) : 0;
                double dollar = Dollar != string.Empty ? Convert.ToDouble(Dollar) : 0;

                if (TypeDoc == "R")
                {
                    budget.Budget_update_after_Payment_Reciver((sy_now + sy).ToString(), (dollar_now + dollar).ToString()
                        ,dt_Sum_import[0].ToString(),dt_Sum_import[1].ToString());
                }
                else
                {
                    budget.Budget_update_after_Payment_Reciver((sy_now - sy).ToString(), (dollar_now - dollar).ToString()
                        , dt_Sum_import[0].ToString(),dt_Sum_import[1].ToString());
                }
            }     
        }
        public static int IsServerConnected()
        {
            string connectionString1= @"Server = " + Program.Server_Name + "; DataBase=FinanceAuthorityDB; Integrated Security= false; USER ID =" + Program.Server_UserName + ";PASSWORD =" + Program.Server_Password + "";
            string connectionString2 = @"Server = " + Program.Server_Name + "; DataBase=FinanceAuthorityDB; Integrated Security= true;";
            string connectionString3 = @"Server = .; DataBase=FinanceAuthorityDB; Integrated Security= true;";
            using (SqlConnection connection = new SqlConnection(connectionString1))
            {
                try
                {
                    connection.Open();
                    return 1;
                }
                catch (SqlException)
                {
                    //return 0;
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                try
                {
                    connection.Open();
                    return 2;
                }
                catch (SqlException)
                {
                    //return 0;
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString3))
            {
                try
                {
                    connection.Open();
                    return 3;
                }
                catch (SqlException)
                {
                    return 0;
                }
            }
        }
    }
}
