using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Document
    {
        public DataTable Document_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Document_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Document_add(string Type_Doc, string Doc_Name, string Doc_URL , string Location, string Extends, string Notes)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Type_Doc", SqlDbType.NVarChar);
            param[0].Value = Type_Doc;
            param[1] = new SqlParameter("@Doc_Name", SqlDbType.NVarChar);
            param[1].Value = Doc_Name;
            param[2] = new SqlParameter("@Doc_URL", SqlDbType.NVarChar);
            param[2].Value = Doc_URL;
            param[3] = new SqlParameter("@Location", SqlDbType.NVarChar);
            param[3].Value = Location;
            param[4] = new SqlParameter("@Extends", SqlDbType.NVarChar);
            param[4].Value = Extends;
            param[5] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[5].Value = Notes;
            Dt = DAL.selectdata("Document_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Document_update(string Type_Doc, string Doc_Name, string Doc_URL, string Location, string Extends, string Notes ,int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Type_Doc", SqlDbType.NVarChar);
            param[0].Value = Type_Doc;
            param[1] = new SqlParameter("@Doc_Name", SqlDbType.NVarChar);
            param[1].Value = Doc_Name;
            param[2] = new SqlParameter("@Doc_URL", SqlDbType.NVarChar);
            param[2].Value = Doc_URL;
            param[3] = new SqlParameter("@Location", SqlDbType.NVarChar);
            param[3].Value = Location;
            param[4] = new SqlParameter("@Extends", SqlDbType.NVarChar);
            param[4].Value = Extends;
            param[5] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[5].Value = Notes;
            param[6] = new SqlParameter("@id", SqlDbType.Int);
            param[6].Value = id;
            Dt = DAL.selectdata("Document_update", param);
            DAL.close();
            return Dt;
        }
        public void Document_Delete(int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.excutecommand("Document_Delete", param);
            DAL.close();

        }
    }
}
