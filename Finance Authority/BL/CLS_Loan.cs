using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Loan
    {
        public DataTable Loans_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Loans_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Leoan_Max_ID()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Leoan_Max_ID", null);
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
        public DataTable Loans_add(string Amount, string Notes, DateTime Date, DateTime Date_Start_Compute, int Budget_Id , int Employee_Des_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Amount", SqlDbType.NVarChar);
            param[0].Value = Amount;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = Date;
            param[3] = new SqlParameter("@Date_Start_Compute", SqlDbType.DateTime);
            param[3].Value = Date_Start_Compute;
            param[4] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[4].Value = Budget_Id;
            param[5] = new SqlParameter("@Employee_Des_ID", SqlDbType.Int);
            param[5].Value = Employee_Des_ID;
            Dt = DAL.selectdata("Loans_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Loans_update(string Amount, string Notes, DateTime Date, DateTime Date_Start_Compute, int Budget_Id, int Employee_Des_ID , int Loans_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Amount", SqlDbType.NVarChar);
            param[0].Value = Amount;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = Date;
            param[3] = new SqlParameter("@Date_Start_Compute", SqlDbType.DateTime);
            param[3].Value = Date_Start_Compute;
            param[4] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[4].Value = Budget_Id;
            param[5] = new SqlParameter("@Employee_Des_ID", SqlDbType.Int);
            param[5].Value = Employee_Des_ID;
            param[6] = new SqlParameter("@Loans_ID", SqlDbType.Int);
            param[6].Value = Loans_ID;
            Dt = DAL.selectdata("Loans_update", param);
            DAL.close();
            return Dt;
        }
        public void Loans_Delete(int Loans_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Loans_ID", SqlDbType.Int);
            param[0].Value = Loans_ID;
            DAL.excutecommand("Loans_Delete", param);
            DAL.close();

        }
        public DataTable Loans_Search_All(String textchange)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@textchange", SqlDbType.NVarChar);
            param[0].Value = textchange;
            Dt = DAL.selectdata("Loans_Search_All", param);
            DAL.close();
            return Dt;
        }
        public DataTable Loans_Search_Budget_Date(int Budget_Id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[0].Value = Budget_Id;
            Dt = DAL.selectdata("Loans_Search_Budget_Date", param);
            DAL.close();
            return Dt;
        }
        public DataTable Loans_Search_By_desc_ID(int Employee_Des_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Employee_Des_ID", SqlDbType.Int);
            param[0].Value = Employee_Des_ID;
            Dt = DAL.selectdata("Loans_Search_By_desc_ID", param);
            DAL.close();
            return Dt;
        }
        public DataTable Loans_By_Employee_id(int Employee_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[0].Value = Employee_id;
            Dt = DAL.selectdata("Loans_By_Employee_id", param);
            DAL.close();
            return Dt;
        }
        public DataTable Loans_By_Employee_id_Between_Date(int Employee_id, DateTime Date_first, DateTime Date_last)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[0].Value = Employee_id;
            param[1] = new SqlParameter("@Date_first", SqlDbType.DateTime);
            param[1].Value = Date_first;
            param[2] = new SqlParameter("@Date_last", SqlDbType.DateTime);
            param[2].Value = Date_last;
            Dt = DAL.selectdata("Loans_By_Employee_id_Between_Date", param);
            DAL.close();
            return Dt;
        }

    }
}
