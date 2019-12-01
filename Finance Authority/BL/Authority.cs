using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class Authority
    {
        public DataTable Authority_view()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Authority_view", null);
            DAL.close();
            return Dt;
        }
        public DataTable Authority_add(string Authority_Name, string Notes)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Authority_Name", SqlDbType.NVarChar);
            param[0].Value = Authority_Name;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            Dt = DAL.selectdata("Authority_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Authority_update(int Authority_ID ,string Authority_Name, string Notes)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Authority_Name", SqlDbType.NVarChar);
            param[0].Value = Authority_Name;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            param[2] = new SqlParameter("@Authority_ID", SqlDbType.NVarChar);
            param[2].Value = Authority_ID;
            Dt = DAL.selectdata("Authority_update", param);
            DAL.close();
            return Dt;
        }
        public void Authority_Delete(int Authority_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Authority_ID", SqlDbType.Int);
            param[0].Value = Authority_ID;
            DAL.excutecommand("Authority_Delete", param);
            DAL.close();

        }
        public DataTable Authority_Search_Name(String Authority_Name)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Authority_Name", SqlDbType.NVarChar);
            param[0].Value = Authority_Name;
            Dt = DAL.selectdata("Authority_Search_Name", param);
            DAL.close();
            return Dt;
        }
        public DataTable Authority_Cheack(string Authority_Name)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Authority_Name", SqlDbType.NVarChar);
            param[0].Value = Authority_Name;
            Dt = DAL.selectdata("Authority_Cheack", param);
            DAL.close();
            return Dt;
        }
    }
}
