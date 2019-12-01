using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Exchange_Order
    {  
        public DataTable Exchange_Order_view()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Exchange_Order_view", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_Orders_CombCategorise()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_Orders_CombCategorise", null);
            DAL.close();
            return Dt;
        }
        public DataTable Exchange_Order_add(string NO_Order,DateTime Date , string To_Source , string Body_Order , string Notes, int Category_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@NO_Order", SqlDbType.NVarChar);
            param[0].Value = NO_Order;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;
            param[2] = new SqlParameter("@To_Source", SqlDbType.NVarChar);
            param[2].Value = To_Source;
            param[3] = new SqlParameter("@Body_Order", SqlDbType.NVarChar);
            param[3].Value = Body_Order;
            param[4] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[4].Value = Notes;
            param[5] = new SqlParameter("@Category_id", SqlDbType.Int);
            param[5].Value = Category_id;
            Dt = DAL.selectdata("Exchange_Order_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Exchange_Order_update(int id ,string NO_Order, DateTime Date, string To_Source, string Body_Order, string Notes, int Category_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@NO_Order", SqlDbType.NVarChar);
            param[0].Value = NO_Order;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;
            param[2] = new SqlParameter("@To_Source", SqlDbType.NVarChar);
            param[2].Value = To_Source;
            param[3] = new SqlParameter("@Body_Order", SqlDbType.NVarChar);
            param[3].Value = Body_Order;
            param[4] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[4].Value = Notes;
            param[5] = new SqlParameter("@Category_id", SqlDbType.Int);
            param[5].Value = Category_id;
            param[6] = new SqlParameter("@id", SqlDbType.Int);
            param[6].Value = id;
            Dt = DAL.selectdata("Exchange_Order_update", param);
            DAL.close();
            return Dt;
        }
        public void Exchange_Order_Delete(int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.excutecommand("Exchange_Order_Delete", param);
            DAL.close();

        }
        public DataTable Exchange_Order_Cheack(string NO_Order)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NO_Order", SqlDbType.NVarChar);
            param[0].Value = NO_Order;
            Dt = DAL.selectdata("Exchange_Order_Cheack", param);
            DAL.close();
            return Dt;
        }
        public DataTable Exchange_Order_Search_All(String text_Query)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text_Query", SqlDbType.NVarChar);
            param[0].Value = text_Query;
            Dt = DAL.selectdata("Exchange_Order_Search_All", param);
            DAL.close();
            return Dt;
        }
        public DataTable Exchange_Order_Search_NO_Order(String NO_Order)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NO_Order", SqlDbType.NVarChar);
            param[0].Value = NO_Order;
            Dt = DAL.selectdata("Exchange_Order_Search_NO_Order", param);
            DAL.close();
            return Dt;
        }
        public DataTable Exchange_Order_Search_Between_Date(DateTime f_date, DateTime l_date)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@f_date", SqlDbType.DateTime);
            param[0].Value = f_date;
            param[1] = new SqlParameter("@l_date", SqlDbType.DateTime);
            param[1].Value = l_date;
            Dt = DAL.selectdata("Exchange_Order_Search_Between_Date", param);
            DAL.close();
            return Dt;
        }
    }
}
