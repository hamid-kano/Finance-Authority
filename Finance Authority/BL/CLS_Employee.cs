using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Employee
    {
        public DataTable Employee_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("Employee_View", null);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_add(string First_Name, string Father_Name, string Last_Name, string Mother_Name, string Mobail, string Scie_Level, string Scie_Specialization, DateTime Brith_Date, string No_Financial , string No_Affairs , string No_File , string No_Card , string Gender , string Marital_status , string Pr_Service_Years)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[15];
            param[0] = new SqlParameter("@First_Name", SqlDbType.NVarChar);
            param[0].Value = First_Name;
            param[1] = new SqlParameter("@Father_Name", SqlDbType.NVarChar);
            param[1].Value = Father_Name;
            param[2] = new SqlParameter("@Last_Name", SqlDbType.NVarChar);
            param[2].Value = Last_Name;
            param[3] = new SqlParameter("@Mother_Name", SqlDbType.NVarChar);
            param[3].Value = Mother_Name;
            param[4] = new SqlParameter("@Mobail", SqlDbType.NVarChar);
            param[4].Value = Mobail;
            param[5] = new SqlParameter("@Scie_Level", SqlDbType.NVarChar);
            param[5].Value = Scie_Level;
            param[6] = new SqlParameter("@Brith_Date", SqlDbType.DateTime);
            param[6].Value = Brith_Date;
            param[7] = new SqlParameter("@Scie_Specialization", SqlDbType.NVarChar);
            param[7].Value = Scie_Specialization;
            param[8] = new SqlParameter("@No_Financial", SqlDbType.NVarChar);
            param[8].Value = No_Financial;
            param[9] = new SqlParameter("@No_Affairs", SqlDbType.NVarChar);
            param[9].Value = No_Affairs;
            param[10] = new SqlParameter("@No_File", SqlDbType.NVarChar);
            param[10].Value = No_File;
            param[11] = new SqlParameter("@No_Card", SqlDbType.NVarChar);
            param[11].Value = No_Card;
            param[12] = new SqlParameter("@Gender", SqlDbType.NVarChar);
            param[12].Value = Gender;
            param[13] = new SqlParameter("@Marital_status", SqlDbType.NVarChar);
            param[13].Value = Marital_status;
            param[14] = new SqlParameter("@Pr_Service_Years", SqlDbType.NVarChar);
            param[14].Value = Pr_Service_Years;
            Dt = DAL.selectdata("Employee_add", param);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_update(string First_Name, string Father_Name, string Last_Name, string Mother_Name, string Mobail, string Scie_Level, string Scie_Specialization, DateTime Brith_Date, string No_Financial, string No_Affairs, string No_File, string No_Card, string Gender, string Marital_status, string Pr_Service_Years , int Employee_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@First_Name", SqlDbType.NVarChar);
            param[0].Value = First_Name;
            param[1] = new SqlParameter("@Father_Name", SqlDbType.NVarChar);
            param[1].Value = Father_Name;
            param[2] = new SqlParameter("@Last_Name", SqlDbType.NVarChar);
            param[2].Value = Last_Name;
            param[3] = new SqlParameter("@Mother_Name", SqlDbType.NVarChar);
            param[3].Value = Mother_Name;
            param[4] = new SqlParameter("@Mobail", SqlDbType.NVarChar);
            param[4].Value = Mobail;
            param[5] = new SqlParameter("@Scie_Level", SqlDbType.NVarChar);
            param[5].Value = Scie_Level;
            param[6] = new SqlParameter("@Brith_Date", SqlDbType.DateTime);
            param[6].Value = Brith_Date;
            param[7] = new SqlParameter("@Scie_Specialization", SqlDbType.NVarChar);
            param[7].Value = Scie_Specialization;
            param[8] = new SqlParameter("@No_Financial", SqlDbType.NVarChar);
            param[8].Value = No_Financial;
            param[9] = new SqlParameter("@No_Affairs", SqlDbType.NVarChar);
            param[9].Value = No_Affairs;
            param[10] = new SqlParameter("@No_File", SqlDbType.NVarChar);
            param[10].Value = No_File;
            param[11] = new SqlParameter("@No_Card", SqlDbType.NVarChar);
            param[11].Value = No_Card;
            param[12] = new SqlParameter("@Gender", SqlDbType.NVarChar);
            param[12].Value = Gender;
            param[13] = new SqlParameter("@Marital_status", SqlDbType.NVarChar);
            param[13].Value = Marital_status;
            param[14] = new SqlParameter("@Pr_Service_Years", SqlDbType.NVarChar);
            param[14].Value = Pr_Service_Years;
            param[15] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[15].Value = Employee_id;
            Dt = DAL.selectdata("Employee_update", param);
            DAL.close();
            return Dt;
        }
        public void Employee_Delete(int Employee_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Employee_id", SqlDbType.Int);
            param[0].Value = Employee_id;
            DAL.excutecommand("Employee_Delete", param);
            DAL.close();

        }
        public DataTable Employee_Search_Name(String text_Change)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text_Change", SqlDbType.NVarChar);
            param[0].Value = text_Change;
            Dt = DAL.selectdata("Employee_Search_Name", param);
            DAL.close();
            return Dt;
        }
        public DataTable Employee_Search_Mony(String text_Change)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text_Change", SqlDbType.NVarChar);
            param[0].Value = text_Change;
            Dt = DAL.selectdata("Employee_Search_Mony", param);
            DAL.close();
            return Dt;
        }
    }
}
