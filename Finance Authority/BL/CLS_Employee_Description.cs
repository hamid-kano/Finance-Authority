using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Employee_Description
    {
        public DataTable Employee_Description_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Employee_Description_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Description_Comb_employ()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Employee_Description_Comb_employ", null);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Description_Comb_Role()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Employee_Description_Comb_Role", null);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Description_Comb_Department()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Employee_Description_Comb_Department", null);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Description_add(string Func_Status, bool Role_Status, DateTime Date , string Book_Number, string Salary, int Department_ID, int Role_Functional_id, int Employee_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Func_Status", SqlDbType.NVarChar);
            param[0].Value = Func_Status;
            param[1] = new SqlParameter("@Role_Status", SqlDbType.Bit);
            param[1].Value = Role_Status;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = Date;
            param[3] = new SqlParameter("@Book_Number", SqlDbType.NVarChar);
            param[3].Value = Book_Number;
            param[4] = new SqlParameter("@Salary", SqlDbType.NVarChar);
            param[4].Value = Salary;
            param[5] = new SqlParameter("@Department_ID", SqlDbType.Int);
            param[5].Value = Department_ID;
            param[6] = new SqlParameter("@Role_Functional_id", SqlDbType.Int);
            param[6].Value = Role_Functional_id;
            param[7] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[7].Value = Employee_id;
            Dt = DAL.selectdata("Employee_Description_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Description_update(string Func_Status, bool Role_Status, DateTime Date, string Book_Number, string Salary, int Department_ID, int Role_Functional_id, int Employee_id , int Employee_Des_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@Func_Status", SqlDbType.NVarChar);
            param[0].Value = Func_Status;
            param[1] = new SqlParameter("@Role_Status", SqlDbType.Bit);
            param[1].Value = Role_Status;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = Date;
            param[3] = new SqlParameter("@Book_Number", SqlDbType.NVarChar);
            param[3].Value = Book_Number;
            param[4] = new SqlParameter("@Salary", SqlDbType.NVarChar);
            param[4].Value = Salary;
            param[5] = new SqlParameter("@Department_ID", SqlDbType.Int);
            param[5].Value = Department_ID;
            param[6] = new SqlParameter("@Role_Functional_id", SqlDbType.Int);
            param[6].Value = Role_Functional_id;
            param[7] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[7].Value = Employee_id;
            param[8] = new SqlParameter("@Employee_Des_ID", SqlDbType.Int);
            param[8].Value = Employee_Des_ID;
            Dt = DAL.selectdata("Employee_Description_update", param);
            DAL.close();
            return Dt;
        }
        public void Employee_Description_Delete(int Employee_Des_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Employee_Des_ID ", SqlDbType.Int);
            param[0].Value = Employee_Des_ID;
            DAL.excutecommand("Employee_Description_Delete", param);
            DAL.close();

        }
        public DataTable Employee_Description_Search_Department(String Department_Name)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Department_Name", SqlDbType.NVarChar);
            param[0].Value = Department_Name;
            Dt = DAL.selectdata("Employee_Description_Search_Department", param);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Description_Search_All(String text_change)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text_change", SqlDbType.NVarChar);
            param[0].Value = text_change;
            Dt = DAL.selectdata("Employee_Description_Search_All", param);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Description_update_Role_status_Empl_ID  (int Employee_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Employee_id", SqlDbType.NVarChar);
            param[0].Value = Employee_id;
            Dt = DAL.selectdata("Employee_Description_update_Role_status_Empl_ID", param);
            DAL.close();
            return Dt;
        }

    }
}
