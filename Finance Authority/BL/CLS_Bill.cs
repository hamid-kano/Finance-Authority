using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Bill
    {
        public DataTable Bill_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Bill_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Bill_add(int NO_Bill, string Buyer_Name, string Coin_Type, string Exchange_rate ,string Bill_Type , string Bill_Total_Amount, 
            DateTime Date ,bool Paid_or_Not , string Notes, int Budget_Id,int Department_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@NO_Bill", SqlDbType.Int);
            param[0].Value = NO_Bill;
            param[1] = new SqlParameter("@Buyer_Name", SqlDbType.NVarChar);
            param[1].Value = Buyer_Name;
            param[2] = new SqlParameter("@Coin_Type", SqlDbType.NVarChar);
            param[2].Value = Coin_Type;
            param[3] = new SqlParameter("@Exchange_rate", SqlDbType.NVarChar);
            param[3].Value = Exchange_rate;
            param[4] = new SqlParameter("@Bill_Type", SqlDbType.NVarChar);
            param[4].Value = Bill_Type;
            param[5] = new SqlParameter("@Bill_Total_Amount", SqlDbType.NVarChar);
            param[5].Value = Bill_Total_Amount;
            param[6] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[6].Value = Date;
            param[7] = new SqlParameter("@Paid_or_Not", SqlDbType.Bit);
            param[7].Value = Paid_or_Not;
            param[8] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[8].Value = Notes;
            param[9] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[9].Value = Budget_Id;
            param[10] = new SqlParameter("@Department_id", SqlDbType.Int);
            param[10].Value = Department_id;
            Dt = DAL.selectdata("Bill_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Bill_update(int NO_Bill, string Buyer_Name, string Coin_Type, string Exchange_rate, string Bill_Type, string Bill_Total_Amount,
           DateTime Date, bool Paid_or_Not, string Notes, int Budget_Id, int Department_id , int Bill_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@NO_Bill", SqlDbType.Int);
            param[0].Value = NO_Bill;
            param[1] = new SqlParameter("@Buyer_Name", SqlDbType.NVarChar);
            param[1].Value = Buyer_Name;
            param[2] = new SqlParameter("@Coin_Type", SqlDbType.NVarChar);
            param[2].Value = Coin_Type;
            param[3] = new SqlParameter("@Exchange_rate", SqlDbType.NVarChar);
            param[3].Value = Exchange_rate;
            param[4] = new SqlParameter("@Bill_Type", SqlDbType.NVarChar);
            param[4].Value = Bill_Type;
            param[5] = new SqlParameter("@Bill_Total_Amount", SqlDbType.NVarChar);
            param[5].Value = Bill_Total_Amount;
            param[6] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[6].Value = Date;
            param[7] = new SqlParameter("@Paid_or_Not", SqlDbType.Bit);
            param[7].Value = Paid_or_Not;
            param[8] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[8].Value = Notes;
            param[9] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[9].Value = Budget_Id;
            param[10] = new SqlParameter("@Department_id", SqlDbType.Int);
            param[10].Value = Department_id;
            param[11] = new SqlParameter("@Bill_id", SqlDbType.Int);
            param[11].Value = Bill_id;
            Dt = DAL.selectdata("Bill_update", param);
            DAL.close();
            return Dt;
        }
        public void Bill_Delete(int Bill_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Bill_id", SqlDbType.Int);
            param[0].Value = Bill_id;
            DAL.excutecommand("Bill_Delete", param);
            DAL.close();

        }
    }
}
