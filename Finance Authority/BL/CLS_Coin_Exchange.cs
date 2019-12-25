using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Coin_Exchange
    {
        public DataTable Coin_Exchange_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Coin_Exchange_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Coin_Exchange_add(string Amount_SY ,string Amount_Dollar ,string Exchange_rate ,DateTime Date, string Notes , int Budget_Id,bool StatusCoin_EX)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Amount_SY", SqlDbType.NVarChar);
            param[0].Value = Amount_SY;
            param[1] = new SqlParameter("@Amount_Dollar", SqlDbType.NVarChar);
            param[1].Value = Amount_Dollar;
            param[2] = new SqlParameter("@Exchange_rate", SqlDbType.NVarChar);
            param[2].Value = Exchange_rate;
            param[3] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[3].Value = Date;
            param[4] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[4].Value = Notes;
            param[5] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[5].Value = Budget_Id;
            param[6] = new SqlParameter("@StatusCoin_EX", SqlDbType.Bit);
            param[6].Value = StatusCoin_EX;
            Dt = DAL.selectdata("Coin_Exchange_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Coin_Exchange_update(string Amount_SY, string Amount_Dollar, string Exchange_rate, DateTime Date, string Notes, int Budget_Id,bool StatusCoin_EX , int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Amount_SY", SqlDbType.NVarChar);
            param[0].Value = Amount_SY;
            param[1] = new SqlParameter("@Amount_Dollar", SqlDbType.NVarChar);
            param[1].Value = Amount_Dollar;
            param[2] = new SqlParameter("@Exchange_rate", SqlDbType.NVarChar);
            param[2].Value = Exchange_rate;
            param[3] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[3].Value = Date;
            param[4] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[4].Value = Notes;
            param[5] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[5].Value = Budget_Id;
            param[6] = new SqlParameter("@StatusCoin_EX", SqlDbType.Bit);
            param[6].Value = StatusCoin_EX;
            param[7] = new SqlParameter("@id", SqlDbType.Int);
            param[7].Value = id;
            Dt = DAL.selectdata("Coin_Exchange_update", param);
            DAL.close();
            return Dt;
        }
        public DataTable Coin_Exchange_CombBudg()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Coin_Exchange_CombBudg", null);
            DAL.close();
            return Dt;
        }
        public void Coin_Exchange_Delete(int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.excutecommand("Coin_Exchange_Delete", param);
            DAL.close();

        }
        public DataTable Coin_Exchange_Search_Date_Budget(int Date_Budget)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Date_Budget ", SqlDbType.Int);
            param[0].Value = Date_Budget;
            Dt = DAL.selectdata("Coin_Exchange_Search_Date_Budget", param);
            DAL.close();
            return Dt;
        }
    }
}
