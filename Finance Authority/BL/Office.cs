using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class Office
    {
        public DataTable Office_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Office_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Office_add(string Office_Name, string Notes,int Authority_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Office_Name", SqlDbType.NVarChar);
            param[0].Value = Office_Name;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            param[2] = new SqlParameter("@Authority_ID", SqlDbType.Int);
            param[2].Value = Authority_ID;
            Dt = DAL.selectdata("Office_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Office_update(int Office_ID ,string Office_Name, string Notes, int Authority_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Office_Name", SqlDbType.NVarChar);
            param[0].Value = Office_Name;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            param[2] = new SqlParameter("@Authority_ID", SqlDbType.Int);
            param[2].Value = Authority_ID;
            param[3] = new SqlParameter("@Office_ID", SqlDbType.Int);
            param[3].Value = Office_ID;
            Dt = DAL.selectdata("Office_update", param);
            DAL.close();
            return Dt;
        }
        public void Office_Delete(int Office_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Office_ID", SqlDbType.Int);
            param[0].Value = Office_ID;
            DAL.excutecommand("Office_Delete", param);
            DAL.close();

        }
        public DataTable Office_Cheack(string Office_Name , int Authontic_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Office_Name", SqlDbType.NVarChar);
            param[0].Value = Office_Name;
            param[1] = new SqlParameter("@Authontic_id", SqlDbType.Int);
            param[1].Value = Authontic_id;
            Dt = DAL.selectdata("Office_Cheack", param);
            DAL.close();
            return Dt;
        }
        public DataTable Office_Search(String Office_Name)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Office_Name", SqlDbType.NVarChar);
            param[0].Value = Office_Name;
            Dt = DAL.selectdata("Office_Search", param);
            DAL.close();
            return Dt;
        }
        public DataTable Office_Comb_Authontic()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Office_Comb_Authontic", null);
            DAL.close();
            return Dt;
        }
    }
}
