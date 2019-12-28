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
        public DataTable Document_View_By_Type_Id_Doc(string Document_Type,int Doc_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Document_Type", SqlDbType.NVarChar);
            param[0].Value = Document_Type;
            param[1] = new SqlParameter("@Doc_id", SqlDbType.NVarChar);
            param[1].Value = Doc_id;
            Dt = DAL.selectdata("Document_View_By_Type_Id_Doc", param);
            DAL.close();
            return Dt;
        }
        public DataTable Document_View_By_Type_Id_Doc_SearchAll(string Document_Type, int Doc_id, string query)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Document_Type", SqlDbType.NVarChar);
            param[0].Value = Document_Type;
            param[1] = new SqlParameter("@Doc_id", SqlDbType.NVarChar);
            param[1].Value = Doc_id;
            param[2] = new SqlParameter("@query", SqlDbType.NVarChar);
            param[2].Value = query;
            Dt = DAL.selectdata("Document_View_By_Type_Id_Doc_SearchAll", param);
            DAL.close();
            return Dt;
        }
        public DataTable Document_add(string Type_Doc, string Doc_Name, string Doc_URL , string Location, string Extends, string Notes, int Doc_id)
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
            param[6] = new SqlParameter("@Doc_id", SqlDbType.NVarChar);
            param[6].Value = Doc_id;

            Dt = DAL.selectdata("Document_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Document_update(string Type_Doc, string Doc_Name, string Doc_URL, string Location, string Extends, string Notes, int Doc_id, int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[8];
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
            param[6] = new SqlParameter("@Doc_id", SqlDbType.NVarChar);
            param[6].Value = Doc_id;
            param[7] = new SqlParameter("@id", SqlDbType.Int);
            param[7].Value = id;
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
        public DataTable Document_Search_All(string textchange)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@textchange", SqlDbType.NVarChar);
            param[0].Value = textchange;
            Dt = DAL.selectdata("Document_Search_All", param);
            DAL.close();
            return Dt;
        }
    }
}
