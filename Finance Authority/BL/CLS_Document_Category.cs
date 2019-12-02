using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Document_Category
    {
        public DataTable Document_Category_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Document_Category_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Document_Category_add(string Document_Type)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Document_Type", SqlDbType.NVarChar);
            param[0].Value = Document_Type;
            Dt = DAL.selectdata("Document_Category_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Document_Category_update(int Category_id, string Document_Type)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Document_Type", SqlDbType.NVarChar);
            param[0].Value = Document_Type;
            param[1] = new SqlParameter("@Category_id", SqlDbType.Int);
            param[1].Value = Category_id;
            Dt = DAL.selectdata("Document_Category_update", param);
            DAL.close();
            return Dt;
        }
        public void Document_Category_Delete(int Category_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Category_id", SqlDbType.Int);
            param[0].Value = Category_id;
            DAL.excutecommand("Document_Category_Delete", param);
            DAL.close();
        }
        public DataTable Document_Category_Cheack(string Document_Type)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Document_Type", SqlDbType.NVarChar);
            param[0].Value = Document_Type;
            Dt = DAL.selectdata("Document_Category_Cheack", param);
            DAL.close();
            return Dt;
        }
        public DataTable Document_Category_Search(string Document_Type)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Document_Type", SqlDbType.NVarChar);
            param[0].Value = Document_Type;
            Dt = DAL.selectdata("Document_Category_Search", param);
            DAL.close();
            return Dt;
        }
    }
}
