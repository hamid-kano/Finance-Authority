using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Finance_Authority.BL
{
    class CLS_Contracts
    {
        public DataTable Contracts_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Contracts_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Contracts_Comb_Employee(int idDepartment)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idDepartment", SqlDbType.Int);
            param[0].Value = idDepartment;
            Dt = DAL.selectdata("Contracts_Comb_Employee", param);
            DAL.close();
            return Dt;
        }
        public DataTable Contracts_by_Departmentid_Employeeid(int Department_ID, int Employee_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Department_ID", SqlDbType.Int);
            param[0].Value = Department_ID;
            param[1] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[1].Value = Employee_id;
            Dt = DAL.selectdata("Contracts_by_Departmentid_Employeeid", param);
            DAL.close();
            return Dt;
        }
        public DataTable Contracts_add(string Contract_Type, DateTime Contract_Start , DateTime Contract_End , string Contract_Status , string Notes , int Employee_Des_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Contract_Type", SqlDbType.NVarChar);
            param[0].Value = Contract_Type;
            param[1] = new SqlParameter("@Contract_Start", SqlDbType.DateTime);
            param[1].Value = Contract_Start;
            param[2] = new SqlParameter("@Contract_End", SqlDbType.DateTime);
            param[2].Value = Contract_End;
            param[3] = new SqlParameter("@Contract_Status", SqlDbType.NVarChar);
            param[3].Value = Contract_Status;
            param[4] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[4].Value = Notes;
            param[5] = new SqlParameter("@Employee_Des_ID", SqlDbType.Int);
            param[5].Value = Employee_Des_ID;
            Dt = DAL.selectdata("Contracts_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Contracts_update(string Contract_Type, DateTime Contract_Start, DateTime Contract_End, string Contract_Status, string Notes, int Employee_Des_ID, int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Contract_Type", SqlDbType.NVarChar);
            param[0].Value = Contract_Type;
            param[1] = new SqlParameter("@Contract_Start", SqlDbType.DateTime);
            param[1].Value = Contract_Start;
            param[2] = new SqlParameter("@Contract_End", SqlDbType.DateTime);
            param[2].Value = Contract_End;
            param[3] = new SqlParameter("@Contract_Status", SqlDbType.NVarChar);
            param[3].Value = Contract_Status;
            param[4] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[4].Value = Notes;
            param[5] = new SqlParameter("@Employee_Des_ID", SqlDbType.Int);
            param[5].Value = Employee_Des_ID;
            param[6] = new SqlParameter("@id", SqlDbType.Int);
            param[6].Value = id;
            Dt = DAL.selectdata("Contracts_update", param);
            DAL.close();
            return Dt;
        }
        public void Contracts_Delete(int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.excutecommand("Contracts_Delete", param);
            DAL.close();

        }
        public DataTable Contracts_Search_All(String textchang)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@textchang", SqlDbType.NVarChar);
            param[0].Value = textchang;
            Dt = DAL.selectdata("Contracts_Search_All", param);
            DAL.close();
            return Dt;
        }
        public DataTable Contracts_Cheack(String No_Book)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@No_Book", SqlDbType.NVarChar);
            param[0].Value = No_Book;
            Dt = DAL.selectdata("Contracts_Cheack", param);
            DAL.close();
            return Dt;
        }
        public DataTable Contracts_Search_Between_Date(DateTime Contracts_Date_first, DateTime Contracts_Date_last)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Contracts_Date_first", SqlDbType.DateTime);
            param[0].Value = Contracts_Date_first;
            param[1] = new SqlParameter("@Contracts_Date_last", SqlDbType.DateTime);
            param[1].Value = Contracts_Date_last;
            Dt = DAL.selectdata("Contracts_Search_Between_Date", param);
            DAL.close();
            return Dt;
        }
    }
}
