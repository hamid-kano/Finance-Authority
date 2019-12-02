using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class Department
    {
        public DataTable Department_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Department_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Department_add(string Department_Name, string Notes, int Office_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Department_Name", SqlDbType.NVarChar);
            param[0].Value = Department_Name;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            param[2] = new SqlParameter("@Office_ID", SqlDbType.Int);
            param[2].Value = Office_ID;
            Dt = DAL.selectdata("Department_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Department_update(int Office_ID, string Department_Name, string Notes, int Department_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Department_Name", SqlDbType.NVarChar);
            param[0].Value = Department_Name;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            param[2] = new SqlParameter("@Department_ID", SqlDbType.Int);
            param[2].Value = Department_ID;
            param[3] = new SqlParameter("@Office_ID", SqlDbType.Int);
            param[3].Value = Office_ID;
            Dt = DAL.selectdata("Department_update", param);
            DAL.close();
            return Dt;
        }
        public void Department_Delete(int Department_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Department_ID", SqlDbType.Int);
            param[0].Value = Department_ID;
            DAL.excutecommand("Department_Delete", param);
            DAL.close();

        }
        public DataTable Department_Cheack(string Department_Name)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Department_Name", SqlDbType.NVarChar);
            param[0].Value = Department_Name;
            Dt = DAL.selectdata("Department_Cheack", param);
            DAL.close();
            return Dt;
        }
        public DataTable Department_CombOffice()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Department_CombOffice", null);
            DAL.close();
            return Dt;
        }
        public DataTable Department_Search(String textchang)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@textchang", SqlDbType.NVarChar);
            param[0].Value = textchang;
            Dt = DAL.selectdata("Department_Search", param);
            DAL.close();
            return Dt;
        }
    }
}
