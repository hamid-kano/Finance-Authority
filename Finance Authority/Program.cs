using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


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
        /// </summary>
        /// 
        public static int theme=1;
        public static int style=-1;

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
                case -1:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
                case 0:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Red;
                    break;
                case 1:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
                    break;
                case 2:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Pink;
                    break;
                case 3:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Magenta;
                    break;
                case 4:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Purple;
                    break;
                case 5:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Yellow;
                    break;
                default:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
            }

            return metroStyleManager;

        }

        public static void Add_Message()
        {
            MessageBox.Show("تمت عملية الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DataRow dt = budget.Budget_Last_Budget().Rows[0];
            return dt;
        }

        //الميزانية الفعلية = المبلغ الحالي -الوارد +الصادر
        //نسبة الواردات = مجموع الواردات / الميزانية الفعلية
        public static int Month_Imports_rate()
        {
            try
            {
                DataRow dt_Sum_import = budget.Budget_Last_Sum_Reciver().Rows[0];
                DataRow dt_Sum_export = budget.Budget_Last_Sum_Payment().Rows[0]; 
                 DataRow dt_Budget_NOW = Budget_NOW();
                int sumimport = Convert.ToInt32(dt_Sum_import[0]);
                int sumexport = Convert.ToInt32(dt_Sum_export[0]);
                int budgetNow = Convert.ToInt32(dt_Budget_NOW[0]);
                int actual_Budget = Convert.ToInt32(dt_Budget_NOW[0]) + Convert.ToInt32(dt_Sum_export[0]) - Convert.ToInt32(dt_Sum_import[0]);
                return Convert.ToInt32(Math.Round((Convert.ToDouble(dt_Sum_import[0]) / actual_Budget) * 100)) <0? 0: Convert.ToInt32(Math.Round((Convert.ToDouble(dt_Sum_import[0]) / actual_Budget) * 100));
            }
            catch
            {
                return 0;
            }
        }
        public static int Month_Exmports_rate()
        {
            try
            {
                DataRow dt_Sum_import = budget.Budget_Last_Sum_Reciver().Rows[0];
                DataRow dt_Sum_export = budget.Budget_Last_Sum_Payment().Rows[0];
                DataRow dt_Budget_NOW = Budget_NOW();
                int sumimport = Convert.ToInt32(dt_Sum_import[0]);
                int sumexport = Convert.ToInt32(dt_Sum_export[0]);
                int budgetNow = Convert.ToInt32(dt_Budget_NOW[0]);
                int actual_Budget = Convert.ToInt32(dt_Budget_NOW[0]) + Convert.ToInt32(dt_Sum_export[0]) - Convert.ToInt32(dt_Sum_import[0]);
                return Convert.ToInt32(Math.Round((Convert.ToDouble(dt_Sum_export[0]) / actual_Budget) * 100))<0 ? 0: Convert.ToInt32(Math.Round((Convert.ToDouble(dt_Sum_export[0]) / actual_Budget) * 100));
            }
            catch
            {
                return 0;
            }
        }

        // تحديث الميزانية بعد عمليات الدفع
        // statue add ;update ;delete
        public static void Budget_update_after_Payment_Reciver(string statue,string statusPR,string SY ,string Dollar)
        {
            DataRow dt_Budget_NOW = Budget_NOW();
            int sy_now =Convert.ToInt32(dt_Budget_NOW[1]);
            int dollar_now = Convert.ToInt32(dt_Budget_NOW[2]);
            int sy = SY != string.Empty? Convert.ToInt32(SY) : 0;
            int dollar = Dollar != string.Empty ? Convert.ToInt32(Dollar) : 0; 
            if (statue == "add")
            {
                if (statusPR=="p")
                {
                    budget.Budget_update_after_Payment_Reciver((sy_now - sy).ToString(), (dollar_now - dollar).ToString());
                }
                else
                {
                    budget.Budget_update_after_Payment_Reciver((sy_now + sy).ToString(), (dollar_now + dollar).ToString());
                }
            }
            else if (statue == "update")
            {
                    budget.Budget_update_after_Payment_Reciver((sy_now + sy).ToString(), (dollar_now + dollar).ToString());
            }
            else if (statue == "delete")
            {
                if (statusPR == "p")
                {
                    budget.Budget_update_after_Payment_Reciver((sy_now + sy).ToString(), (dollar_now + dollar).ToString());
                }
                else 
                {
                    budget.Budget_update_after_Payment_Reciver((sy_now - sy).ToString(), (dollar_now - dollar).ToString());
                }
            }

        }
    }
}
