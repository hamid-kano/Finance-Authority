using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Finance_Authority.BL
{
    class CLS_Leoan_Payments
    {
        public DataTable Leoan_Payments_View(int leoan_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@leoan_id ", SqlDbType.Int);
            param[0].Value = leoan_id;
            Dt = DAL.selectdata("Leoan_Payments_View", param);
            DAL.close();
            return Dt;
        }
        public DataTable Leoan_Payments_MAX_id()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            Dt = DAL.selectdata("Leoan_Payments_MAX_id", null);
            DAL.close();
            return Dt;
        }

        public DataTable Leoan_Payments_Comb_Employee_Department(int Department_ID, int Employee_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Department_ID", SqlDbType.Int);
            param[0].Value = Department_ID;
            param[1] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[1].Value = Employee_id;
            Dt = DAL.selectdata("Leoan_Payments_Comb_Employee_Department", param);
            DAL.close();
            return Dt;
        }
        public DataTable Payments_Leoan_by_Departmentid_Employeeid_Loean(int Department_ID, int Employee_id , int idDatelaon)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Department_ID", SqlDbType.Int);
            param[0].Value = Department_ID;
            param[1] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[1].Value = Employee_id;
            param[2] = new SqlParameter("@idDatelaon", SqlDbType.Int);
            param[2].Value = idDatelaon;
            Dt = DAL.selectdata("Payments_Leoan_by_Departmentid_Employeeid_Loean", param);
            DAL.close();
            return Dt;
        }
        public DataTable Leoan_Payments_add(int Loans_ID ,string Amount , string Notes, DateTime Date , int Budget_Id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Loans_ID", SqlDbType.Int);
            param[0].Value = Loans_ID;
            param[1] = new SqlParameter("@Amount", SqlDbType.NVarChar);
            param[1].Value = Amount;
            param[2] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[2].Value = Notes;
            param[3] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[3].Value = Date;
            param[4] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[4].Value = Budget_Id;
            Dt = DAL.selectdata("Leoan_Payments_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Leoan_Payments_update(int Loans_ID, string Amount, string Notes, DateTime Date, int Budget_Id , int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Loans_ID", SqlDbType.Int);
            param[0].Value = Loans_ID;
            param[1] = new SqlParameter("@Amount", SqlDbType.NVarChar);
            param[1].Value = Amount;
            param[2] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[2].Value = Notes;
            param[3] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[3].Value = Date;
            param[4] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[4].Value = Budget_Id;
            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Value = id;
            Dt = DAL.selectdata("Leoan_Payments_update", param);
            DAL.close();
            return Dt;
        }
        public DataTable Leoan_Payments_Delete(int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            Dt = DAL.selectdata("Leoan_Payments_Delete", param);
            DAL.close();
            return Dt;
        }
        public DataTable Leoan_Payments_Search_All(String textchange)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@textchange", SqlDbType.NVarChar);
            param[0].Value = textchange;
            Dt = DAL.selectdata("Leoan_Payments_Search_All", param);
            DAL.close();
            return Dt;
        }
        public DataTable Leoan_Payments_Budget_Date(int Budget_Id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Budget_Id", SqlDbType.Int);
            param[0].Value = Budget_Id; 
            Dt = DAL.selectdata("Leoan_Payments_Budget_Date", param);
            DAL.close();
            return Dt;
        }
    }
}
