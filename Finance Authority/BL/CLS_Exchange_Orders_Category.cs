using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority
{
    class CLS_Exchange_Orders_Category
    {
        public DataTable EX_Orders_Cat_view()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("EX_Orders_Cat_view", null);
            DAL.close();
            return Dt;
        }
        public DataTable EX_Orders_Cat_add(string Exchange_Order_Type)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Exchange_Order_Type", SqlDbType.NVarChar);
            param[0].Value = Exchange_Order_Type;
            Dt = DAL.selectdata("EX_Orders_Cat_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable EX_Orders_Cat_update(int Category_id, string Exchange_Order_Type)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Category_id ", SqlDbType.Int);
            param[0].Value = Category_id;
            param[1] = new SqlParameter("@Exchange_Order_Type", SqlDbType.NVarChar);
            param[1].Value = Exchange_Order_Type;
            Dt = DAL.selectdata("EX_Orders_Cat_update", param);
            DAL.close();
            return Dt;
        }
        public void EX_Orders_Cat_Delete(int Category_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Category_id", SqlDbType.Int);
            param[0].Value = Category_id;
            DAL.excutecommand("EX_Orders_Cat_Delete", param);
            DAL.close();

        }
        public DataTable EX_Orders_Cat_Cheack(string Exchange_Order_Type)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Exchange_Order_Type", SqlDbType.NVarChar);
            param[0].Value = Exchange_Order_Type;
            Dt = DAL.selectdata("EX_Orders_Cat_Cheack", param);
            DAL.close();
            return Dt;
        }
        public DataTable EX_Orders_Cat_Search(String Exchange_Order_Type)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Exchange_Order_Type", SqlDbType.NVarChar);
            param[0].Value = Exchange_Order_Type;
            Dt = DAL.selectdata("EX_Orders_Cat_Search", param);
            DAL.close();
            return Dt;
        }
    }
}
