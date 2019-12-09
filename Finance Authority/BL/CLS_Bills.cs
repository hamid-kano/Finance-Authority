using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Bills
    {
        public DataTable Bills_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Bill_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Bill_Max_ID()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Bill_Max_ID", null);
            DAL.close();
            return Dt;
        }
        public DataTable Bills_Comb_Bill()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Object_Comb_Bill", null);
            DAL.close();
            return Dt;
        }
        public DataTable Bills_Object_add(string object_Name, string object_Quantity ,string object_Unit_Price ,string object_Total_price ,int Bill_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@object_Name", SqlDbType.NVarChar);
            param[0].Value = object_Name;
            param[1] = new SqlParameter("@object_Quantity", SqlDbType.NVarChar);
            param[1].Value = object_Quantity;
            param[2] = new SqlParameter("@object_Unit_Price", SqlDbType.NVarChar);
            param[2].Value = object_Unit_Price;
            param[3] = new SqlParameter("@object_Total_price", SqlDbType.NVarChar);
            param[3].Value = object_Total_price;
            param[4] = new SqlParameter("@Bill_id", SqlDbType.Int);
            param[4].Value = Bill_id;
            Dt = DAL.selectdata("Object_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Bills_Object_update(string object_Name, string object_Quantity, string object_Unit_Price, string object_Total_price, int Bill_id ,int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@object_Name", SqlDbType.NVarChar);
            param[0].Value = object_Name;
            param[1] = new SqlParameter("@object_Quantity", SqlDbType.NVarChar);
            param[1].Value = object_Quantity;
            param[2] = new SqlParameter("@object_Unit_Price", SqlDbType.NVarChar);
            param[2].Value = object_Unit_Price;
            param[3] = new SqlParameter("@object_Total_price", SqlDbType.NVarChar);
            param[3].Value = object_Total_price;
            param[4] = new SqlParameter("@Bill_id", SqlDbType.Int);
            param[4].Value = Bill_id;
            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Value = id;
            Dt = DAL.selectdata("Object_update", param);
            DAL.close();
            return Dt;
        }
        public void Bills_Object_Delete(int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.excutecommand("Object_Delete", param);
            DAL.close();

        }

        public void Bills_Object_Delete_ByBill_Id(int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = id;
            DAL.excutecommand("Object_Delete_By_Bill_ID", param);
            DAL.close();
        }
        public DataTable Bills_Search_All(String textchange)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@textchange", SqlDbType.NVarChar);
            param[0].Value = textchange;
            Dt = DAL.selectdata("Bills_Search_All", param);
            DAL.close();
            return Dt;
        }
        public DataTable Bills_Search_Between_Date(DateTime Bills_Date_first, DateTime Bills_Date_last)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Bills_Date_first", SqlDbType.DateTime);
            param[0].Value = Bills_Date_first;
            param[1] = new SqlParameter("@Bills_Date_last", SqlDbType.DateTime);
            param[1].Value = Bills_Date_last;
            Dt = DAL.selectdata("Bills_Search_Between_Date", param);
            DAL.close();
            return Dt;
        }
    }
}
