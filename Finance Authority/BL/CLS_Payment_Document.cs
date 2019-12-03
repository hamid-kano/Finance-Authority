using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Payment_Document
    {
        
        public DataTable Payment_Document_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Payment_Document_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Payment_Document_add(string Amount_SY, string Amount_Dollar, string Exchange_rate, string No_Pay_Document ,string No_Order, string Reason, string To_Receiver, DateTime Date, string Notes, int Budget_Id, int Category_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@Amount_SY", SqlDbType.NVarChar);
            param[0].Value = Amount_SY;
            param[1] = new SqlParameter("@Amount_Dollar", SqlDbType.NVarChar);
            param[1].Value = Amount_Dollar;
            param[2] = new SqlParameter("@Exchange_rate", SqlDbType.NVarChar);
            param[2].Value = Exchange_rate;
            param[3] = new SqlParameter("@No_Pay_Document", SqlDbType.NVarChar);
            param[3].Value = No_Pay_Document;
            param[4] = new SqlParameter("@Reason", SqlDbType.NVarChar);
            param[4].Value = Reason;
            param[5] = new SqlParameter("@To_Receiver", SqlDbType.NVarChar);
            param[5].Value = To_Receiver;
            param[6] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[6].Value = Date;
            param[7] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[7].Value = Notes;
            param[8] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[8].Value = Budget_Id;
            param[9] = new SqlParameter("@Category_id", SqlDbType.Int);
            param[9].Value = Category_id;
            param[10] = new SqlParameter("@No_Order", SqlDbType.NVarChar);
            param[10].Value = No_Order;
            Dt = DAL.selectdata("Payment_Document_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Payment_Document_update(string Amount_SY, string Amount_Dollar, string Exchange_rate, string No_Pay_Document, string No_Order, string Reason, string To_Receiver, DateTime Date, string Notes, int Budget_Id, int Category_id, int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@Amount_SY", SqlDbType.NVarChar);
            param[0].Value = Amount_SY;
            param[1] = new SqlParameter("@Amount_Dollar", SqlDbType.NVarChar);
            param[1].Value = Amount_Dollar;
            param[2] = new SqlParameter("@Exchange_rate", SqlDbType.NVarChar);
            param[2].Value = Exchange_rate;
            param[3] = new SqlParameter("@No_Pay_Document", SqlDbType.NVarChar);
            param[3].Value = No_Pay_Document;
            param[4] = new SqlParameter("@Reason", SqlDbType.NVarChar);
            param[4].Value = Reason;
            param[5] = new SqlParameter("@To_Receiver", SqlDbType.NVarChar);
            param[5].Value = To_Receiver;
            param[6] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[6].Value = Date;
            param[7] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[7].Value = Notes;
            param[8] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[8].Value = Budget_Id;
            param[9] = new SqlParameter("@Category_id", SqlDbType.Int);
            param[9].Value = Category_id;
            param[10] = new SqlParameter("@id", SqlDbType.Int);
            param[10].Value = id;
            param[11] = new SqlParameter("@No_Order", SqlDbType.NVarChar);
            param[11].Value = No_Order;
            Dt = DAL.selectdata("Payment_Document_update", param);
            DAL.close();
            return Dt;
        }
        public void Payment_Document_Delete(int Payment_Document_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Payment_Document_id", SqlDbType.Int);
            param[0].Value = Payment_Document_id;
            DAL.excutecommand("Payment_Document_Delete", param);
            DAL.close();

        }
        public DataTable Payment_Document_Search(String No_Order)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@No_Order", SqlDbType.NVarChar);
            param[0].Value = No_Order;
            Dt = DAL.selectdata("Payment_Document_Search", param);
            DAL.close();
            return Dt;
        }
        public DataTable Payment_Document_Date_between(DateTime Payment_Document_Date_first, DateTime Payment_Document_Date_last)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Payment_Document_Date_first", SqlDbType.DateTime);
            param[0].Value = Payment_Document_Date_first;
            param[1] = new SqlParameter("@Payment_Document_Date_last", SqlDbType.DateTime);
            param[1].Value = Payment_Document_Date_last;
            Dt = DAL.selectdata("Payment_Document_Date_between", param);
            DAL.close();
            return Dt;
        }
    }
}
