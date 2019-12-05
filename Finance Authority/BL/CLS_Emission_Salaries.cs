using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Emission_Salaries
    {
        public DataTable Emission_Salaries_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Emission_Salaries_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Emission_Salaries_add(int Office_ID, DateTime Date , int Budget_Id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Office_ID", SqlDbType.Int);
            param[0].Value = Office_ID;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;
            param[2] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[2].Value = Budget_Id;
            Dt = DAL.selectdata("Emission_Salaries_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Emission_Salaries_update(int Office_ID, DateTime Date, int Budget_Id , int Emission_Salaries_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Office_ID", SqlDbType.Int);
            param[0].Value = Office_ID;
            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;
            param[2] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[2].Value = Budget_Id;
            param[3] = new SqlParameter("@Emission_Salaries_id", SqlDbType.Int);
            param[3].Value = Emission_Salaries_id;
            Dt = DAL.selectdata("Emission_Salaries_update", param);
            DAL.close();
            return Dt;
        }
        public void Emission_Salaries_Delete(int Emission_Salaries_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Emission_Salaries_id", SqlDbType.Int);
            param[0].Value = Emission_Salaries_id;
            DAL.excutecommand("Emission_Salaries_Delete", param);
            DAL.close();

        }
        public DataTable Emission_Salaries_Comb_Budget()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Emission_Salaries_Comb_Budget", null);
            DAL.close();
            return Dt;
        }
    }
}
