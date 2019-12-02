using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Role_Functional
    {
        public DataTable Role_Functional_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Role_Functional_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Role_Functional_add(string Role_Name, string Notes)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Role_Name", SqlDbType.NVarChar);
            param[0].Value = Role_Name;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            Dt = DAL.selectdata("Role_Functional_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Role_Functional_update(int Role_Functional_id, string Role_Name, string Notes)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Role_Name", SqlDbType.NVarChar);
            param[0].Value = Role_Name;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            param[2] = new SqlParameter("@Role_Functional_id", SqlDbType.NVarChar);
            param[2].Value = Role_Functional_id;
            Dt = DAL.selectdata("Role_Functional_update", param);
            DAL.close();
            return Dt;
        }
        public void Role_Functional_Delete(int Role_Functional_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Role_Functional_id", SqlDbType.Int);
            param[0].Value = Role_Functional_id;
            DAL.excutecommand("Role_Functional_Delete", param);
            DAL.close();

        }
        public DataTable Role_Functional_Search(String Role_Name)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Role_Name", SqlDbType.NVarChar);
            param[0].Value = Role_Name;
            Dt = DAL.selectdata("Role_Functional_Search", param);
            DAL.close();
            return Dt;
        }
        public DataTable Role_Functional_Cheack(string Role_Name)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Role_Name", SqlDbType.NVarChar);
            param[0].Value = Role_Name;
            Dt = DAL.selectdata("Role_Functional_Cheack", param);
            DAL.close();
            return Dt;
        }
    }
}
