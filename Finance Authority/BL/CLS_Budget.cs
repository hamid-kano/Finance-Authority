using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Budget
    {
        public DataTable Budget_view()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Budget_view", null);
            DAL.close();
            return Dt;
        }
        // الصندوق الحالي
        public DataTable Budget_Last_Budget()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Budget_Last_Budget", null);
            DAL.close();
            return Dt;
        }

        // مجموع الواردات
        public DataTable Budget_Last_Sum_Reciver()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Budget_Last_Sum_Reciver", null);
            DAL.close();
            return Dt;
        }
        // مجموع الصادرات
        public DataTable Budget_Last_Sum_Payment()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Budget_Last_Sum_Payment", null);
            DAL.close();
            return Dt;
        }
        // تحديث الميزانية بعد عملية الدفع
        public DataTable Budget_update_after_Payment(string Amount_Now_SY, string Amount_Now_Dollar)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Amount_Now_SY", SqlDbType.NVarChar);
            param[0].Value = Amount_Now_SY;
            param[1] = new SqlParameter("@Amount_Now_Dollar", SqlDbType.NVarChar);
            param[1].Value = Amount_Now_Dollar;
            Dt = DAL.selectdata("Budget_update_after_Payment", param);
            DAL.close();
            return Dt;
        }
        public DataTable Reciver_Sum_import()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Reciver_Sum_import", null);
            DAL.close();
            return Dt;
        }

        public DataTable Budget_add(string Amount_Now_SY,string Amount_Now_Dollar,string Imports_Amount_SY,string Imports_Amount_Dollar , string Recycle_Amount_SY , string Recycle_Amount_Dollar,string Specified_Amount_SY , string Specified_Amount_Dollar, string Notes, DateTime Date)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Amount_Now_SY", SqlDbType.NVarChar);
            param[0].Value = Amount_Now_SY;
            param[1] = new SqlParameter("@Amount_Now_Dollar", SqlDbType.NVarChar);
            param[1].Value = Amount_Now_Dollar;
            param[2] = new SqlParameter("@Imports_Amount_SY", SqlDbType.NVarChar);
            param[2].Value = Imports_Amount_SY;
            param[3] = new SqlParameter("@Imports_Amount_Dollar", SqlDbType.NVarChar);
            param[3].Value = Imports_Amount_Dollar;
            param[4] = new SqlParameter("@Recycle_Amount_SY", SqlDbType.NVarChar);
            param[4].Value = Recycle_Amount_SY;
            param[5] = new SqlParameter("@Recycle_Amount_Dollar", SqlDbType.NVarChar);
            param[5].Value = Recycle_Amount_Dollar;
            param[6] = new SqlParameter("@Specified_Amount_SY", SqlDbType.NVarChar);
            param[6].Value = Specified_Amount_SY;
            param[7] = new SqlParameter("@Specified_Amount_Dollar", SqlDbType.NVarChar);
            param[7].Value = Specified_Amount_Dollar;
            param[8] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[8].Value = Notes;
            param[9] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[9].Value = Date;
            Dt = DAL.selectdata("Budget_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Budget_update(string Amount_Now_SY, string Amount_Now_Dollar, string Imports_Amount_SY, string Imports_Amount_Dollar, string Recycle_Amount_SY, string Recycle_Amount_Dollar, string Specified_Amount_SY, string Specified_Amount_Dollar, string Notes, DateTime Date , int Budget_Id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@Amount_Now_SY", SqlDbType.NVarChar);
            param[0].Value = Amount_Now_SY;
            param[1] = new SqlParameter("@Amount_Now_Dollar", SqlDbType.NVarChar);
            param[1].Value = Amount_Now_Dollar;
            param[2] = new SqlParameter("@Imports_Amount_SY", SqlDbType.NVarChar);
            param[2].Value = Imports_Amount_SY;
            param[3] = new SqlParameter("@Imports_Amount_Dollar", SqlDbType.NVarChar);
            param[3].Value = Imports_Amount_Dollar;
            param[4] = new SqlParameter("@Recycle_Amount_SY", SqlDbType.NVarChar);
            param[4].Value = Recycle_Amount_SY;
            param[5] = new SqlParameter("@Recycle_Amount_Dollar", SqlDbType.NVarChar);
            param[5].Value = Recycle_Amount_Dollar;
            param[6] = new SqlParameter("@Specified_Amount_SY", SqlDbType.NVarChar);
            param[6].Value = Specified_Amount_SY;
            param[7] = new SqlParameter("@Specified_Amount_Dollar", SqlDbType.NVarChar);
            param[7].Value = Specified_Amount_Dollar;
            param[8] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[8].Value = Notes;
            param[9] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[9].Value = Date;
            param[10] = new SqlParameter("@Budget_Id", SqlDbType.NVarChar);
            param[10].Value = Budget_Id;
            Dt = DAL.selectdata("Budget_update", param);
            DAL.close();
            return Dt;
        }
        public void Budget_Delete(int Budget_Id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[0].Value = Budget_Id;
            DAL.excutecommand("Budget_Delete", param);
            DAL.close();

        }
        public DataTable Budget_Date_Between(DateTime Date_first, DateTime Date_last)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Date_first", SqlDbType.DateTime);
            param[0].Value = Date_first;
            param[1] = new SqlParameter("@Date_last", SqlDbType.DateTime);
            param[1].Value = Date_last;
            Dt = DAL.selectdata("Budget_Date_Between", param);
            DAL.close();
            return Dt;

        }
    }
}
