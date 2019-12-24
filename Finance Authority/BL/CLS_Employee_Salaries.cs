using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Employee_Salaries
    {
        public DataTable Employee_Salaries_Comb_Date_Emiss()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Employee_Salaries_Comb_Date_Emiss", null);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Salaries_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Employee_Salaries_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Salaries_add(string Working_Days, string Rem_Day_contracts, string Absences, string Vac_out_Salary, string Exam_Vacations, string Punishments, string Loans, 
            string Tasks, string Reparations, string Years_Seniority, string Total, string Salary_after_Rebates, 
            string Notes, string Insurances, string Field_1, string Field_2,int Emission_Salaries_id, int Employee_Des_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[18];
            param[0] = new SqlParameter("@Working_Days", SqlDbType.NVarChar);
            param[0].Value = Working_Days;
            param[1] = new SqlParameter("@Rem_Day_contracts", SqlDbType.NVarChar);
            param[1].Value = Rem_Day_contracts;
            param[2] = new SqlParameter("@Absences", SqlDbType.NVarChar);
            param[2].Value = Absences;
            param[3] = new SqlParameter("@Vac_out_Salary", SqlDbType.NVarChar);
            param[3].Value = Vac_out_Salary;
            param[4] = new SqlParameter("@Exam_Vacations", SqlDbType.NVarChar);
            param[4].Value = Exam_Vacations;
            param[5] = new SqlParameter("@Punishments", SqlDbType.NVarChar);
            param[5].Value = Punishments;
            param[6] = new SqlParameter("@Loans", SqlDbType.NVarChar);
            param[6].Value = Loans;
            param[7] = new SqlParameter("@Tasks", SqlDbType.NVarChar);
            param[7].Value = Tasks;
            param[8] = new SqlParameter("@Reparations", SqlDbType.NVarChar);
            param[8].Value = Reparations;
            param[9] = new SqlParameter("@Years_Seniority", SqlDbType.NVarChar);
            param[9].Value = Years_Seniority;
            param[10] = new SqlParameter("@Total", SqlDbType.NVarChar);
            param[10].Value = Total;
            param[11] = new SqlParameter("@Salary_after_Rebates", SqlDbType.NVarChar);
            param[11].Value = Salary_after_Rebates;
            param[12] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[12].Value = Notes;
            param[13] = new SqlParameter("@Insurances", SqlDbType.NVarChar);
            param[13].Value = Insurances;
            param[14] = new SqlParameter("@Field_1", SqlDbType.NVarChar);
            param[14].Value = Field_1;
            param[15] = new SqlParameter("@Field_2", SqlDbType.NVarChar);
            param[15].Value = Field_2;
            param[16] = new SqlParameter("@Emission_Salaries_id", SqlDbType.Int);
            param[16].Value = Emission_Salaries_id;
            param[17] = new SqlParameter("@Employee_Des_ID", SqlDbType.Int);
            param[17].Value = Employee_Des_ID;
            Dt = DAL.selectdata("Employee_Salaries_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Salaries_update(string Working_Days, string Rem_Day_contracts, string Absences, string Vac_out_Salary, string Exam_Vacations, string Punishments, string Loans,
            string Tasks, string Reparations, string Years_Seniority, string Total, string Salary_after_Rebates,
            string Notes, string Insurances, string Field_1, string Field_2, int Emission_Salaries_id, int Employee_Des_ID , int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[19];
            param[0] = new SqlParameter("@Working_Days", SqlDbType.NVarChar);
            param[0].Value = Working_Days;
            param[1] = new SqlParameter("@Rem_Day_contracts", SqlDbType.NVarChar);
            param[1].Value = Rem_Day_contracts;
            param[2] = new SqlParameter("@Absences", SqlDbType.NVarChar);
            param[2].Value = Absences;
            param[3] = new SqlParameter("@Vac_out_Salary", SqlDbType.NVarChar);
            param[3].Value = Vac_out_Salary;
            param[4] = new SqlParameter("@Exam_Vacations", SqlDbType.NVarChar);
            param[4].Value = Exam_Vacations;
            param[5] = new SqlParameter("@Punishments", SqlDbType.NVarChar);
            param[5].Value = Punishments;
            param[6] = new SqlParameter("@Loans", SqlDbType.NVarChar);
            param[6].Value = Loans;
            param[7] = new SqlParameter("@Tasks", SqlDbType.NVarChar);
            param[7].Value = Tasks;
            param[8] = new SqlParameter("@Reparations", SqlDbType.NVarChar);
            param[8].Value = Reparations;
            param[9] = new SqlParameter("@Years_Seniority", SqlDbType.NVarChar);
            param[9].Value = Years_Seniority;
            param[10] = new SqlParameter("@Total", SqlDbType.NVarChar);
            param[10].Value = Total;
            param[11] = new SqlParameter("@Salary_after_Rebates", SqlDbType.NVarChar);
            param[11].Value = Salary_after_Rebates;
            param[12] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[12].Value = Notes;
            param[13] = new SqlParameter("@Insurances", SqlDbType.NVarChar);
            param[13].Value = Insurances;
            param[14] = new SqlParameter("@Field_1", SqlDbType.NVarChar);
            param[14].Value = Field_1;
            param[15] = new SqlParameter("@Field_2", SqlDbType.NVarChar);
            param[15].Value = Field_2;
            param[16] = new SqlParameter("@Emission_Salaries_id", SqlDbType.Int);
            param[16].Value = Emission_Salaries_id;
            param[17] = new SqlParameter("@Employee_Des_ID", SqlDbType.Int);
            param[17].Value = Employee_Des_ID;
            param[18] = new SqlParameter("@id", SqlDbType.Int);
            param[18].Value = id;
            Dt = DAL.selectdata("Employee_Salaries_update", param);
            DAL.close();
            return Dt;
        }
        public void Employee_Salaries_Delete(int id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.excutecommand("Employee_Salaries_Delete", param);
            DAL.close();
        }
        public void Employee_Salaries_Delete_by_Emission_ID(int Emission_ID)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Emission_ID", SqlDbType.Int);
            param[0].Value = Emission_ID;
            DAL.excutecommand("Employee_Salaries_Delete_by_Emission_ID", param);
            DAL.close();

        }

        public DataTable Employee_Salaries_Search_Office(int office_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@office_id", SqlDbType.Int);
            param[0].Value = office_id;
            Dt = DAL.selectdata("Employee_Salaries_Search_Office", param);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Salaries_Search_Emission_Salaries(int Emission_Salaries)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Emission_Salaries", SqlDbType.Int);
            param[0].Value = Emission_Salaries;
            Dt = DAL.selectdata("Employee_Salaries_Search_Emission_Salaries", param);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Salaries_Search_Employee_Offiice(int Employee_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[0].Value = Employee_id;
            Dt = DAL.selectdata("Employee_Salaries_Search_Employee_Offiice", param);
            DAL.close();
            return Dt;
        }
    }
}
