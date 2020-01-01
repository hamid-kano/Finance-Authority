using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_LOGS
    {
        public DataTable LOGS_add(int ID_USER, string TYPE_LOGS , string DESCRIPTION_LOGS ,DateTime DATE_LOGS)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID_USER", SqlDbType.Int);
            param[0].Value = ID_USER;
            param[1] = new SqlParameter("@TYPE_LOGS", SqlDbType.NVarChar);
            param[1].Value = TYPE_LOGS;
            param[2] = new SqlParameter("@DESCRIPTION_LOGS", SqlDbType.NVarChar);
            param[2].Value = DESCRIPTION_LOGS;
            param[3] = new SqlParameter("@DATE_LOGS", SqlDbType.DateTime);
            param[3].Value = DATE_LOGS;
            Dt = DAL.selectdata("LOGS_add", param);
            DAL.close();
            return Dt;
        }
        public void LOGS_Delete_By_ID(int ID_LOGS)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_LOGS", SqlDbType.Int);
            param[0].Value = ID_LOGS;
            DAL.excutecommand("LOGS_Delete_By_ID", param);
            DAL.close();
        }
        public DataTable LOGS_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("LOGS_View", null);
            DAL.close();
            return Dt;
        }
    }
}
