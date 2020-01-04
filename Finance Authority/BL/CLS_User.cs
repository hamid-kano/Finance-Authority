using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Finance_Authority.BL
{
    class CLS_User
    {
        public DataTable User_View()
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("User_View", null);
            DAL.close();
            return Dt;
        }
        public void User_Delete_By_ID(int user_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;
            DAL.excutecommand("User_Delete_By_ID", param);
            DAL.close();
        }
        public DataTable User_View_By_Name(String user_Name)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_Name", SqlDbType.NVarChar);
            param[0].Value = user_Name;
            Dt = DAL.selectdata("User_View_By_Name", param);
            DAL.close();
            return Dt;
        }
        public DataTable User_Check_UserName(String user_Name)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_Name", SqlDbType.NVarChar);
            param[0].Value = user_Name;
            Dt = DAL.selectdata("User_Check_UserName", param);
            DAL.close();
            return Dt;
        }

        public DataTable User_Add(string fullName, string password ,bool Authority_FORM , bool Backup_FORM , bool Backup_Restor_FORM , bool Bills_Details_FORM ,
           bool Bills_FORM , bool Budget_FORM , bool Budget_Now_FORM , bool Coin_Exchange_FORM , bool Contracts_FORM , bool Department_FORM , bool Document_Category_FORM
           , bool Document_FORM , bool Emission_Salaries_FORM , bool Employee_Description_FORM  , bool Employee_FORM , bool Employee_Salaries_FORM 
           , bool EX_Order_FORM , bool EX_Orders_Cat_FORM , bool Leoan_Payments_FORM , bool Loans_FORM , bool Office_FORM
           , bool Payment_Document_FORM , bool Reciver_Document_FORM , bool Role_Functional_FORM , bool Users_FORM , bool Users_LOGS_FORM )
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[28];
            param[0] = new SqlParameter("@fullName", SqlDbType.NVarChar);
            param[0].Value = fullName;
            param[1] = new SqlParameter("@password", SqlDbType.NVarChar);
            param[1].Value = password;
            param[2] = new SqlParameter("@Authority_FORM", SqlDbType.Bit);
            param[2].Value = Authority_FORM;
            param[3] = new SqlParameter("@Backup_FORM", SqlDbType.Bit);
            param[3].Value = Backup_FORM;
            param[4] = new SqlParameter("@Backup_Restor_FORM", SqlDbType.Bit);
            param[4].Value = Backup_Restor_FORM;
            param[5] = new SqlParameter("@Bills_Details_FORM", SqlDbType.Bit);
            param[5].Value = Bills_Details_FORM;
            param[6] = new SqlParameter("@Bills_FORM", SqlDbType.Bit);
            param[6].Value = Bills_FORM;
            param[7] = new SqlParameter("@Budget_FORM", SqlDbType.Bit);
            param[7].Value = Budget_FORM;
            param[8] = new SqlParameter("@Budget_Now_FORM", SqlDbType.Bit);
            param[8].Value = Budget_Now_FORM;
            param[9] = new SqlParameter("@Coin_Exchange_FORM", SqlDbType.Bit);
            param[9].Value = Coin_Exchange_FORM;
            param[10] = new SqlParameter("Contracts_FORM", SqlDbType.Bit);
            param[10].Value = Contracts_FORM;
            param[11] = new SqlParameter("@Department_FORM", SqlDbType.Bit);
            param[11].Value = Department_FORM;
            param[12] = new SqlParameter("@Document_Category_FORM", SqlDbType.Bit);
            param[12].Value = Document_Category_FORM;
            param[13] = new SqlParameter("@Document_FORM", SqlDbType.Bit);
            param[13].Value = Document_FORM;
            param[14] = new SqlParameter("@Emission_Salaries_FORM", SqlDbType.Bit);
            param[14].Value = Emission_Salaries_FORM;
            param[15] = new SqlParameter("@Employee_Description_FORM", SqlDbType.Bit);
            param[15].Value = Employee_Description_FORM;
            param[16] = new SqlParameter("@Employee_FORM", SqlDbType.Bit);
            param[16].Value = Employee_FORM;
            param[17] = new SqlParameter("@Employee_Salaries_FORM", SqlDbType.Bit);
            param[17].Value = Employee_Salaries_FORM;
            param[18] = new SqlParameter("@EX_Order_FORM", SqlDbType.Bit);
            param[18].Value = EX_Order_FORM;
            param[19] = new SqlParameter("@EX_Orders_Cat_FORM", SqlDbType.Bit);
            param[19].Value = EX_Orders_Cat_FORM;
            param[20] = new SqlParameter("@Leoan_Payments_FORM", SqlDbType.Bit);
            param[20].Value = Leoan_Payments_FORM;
            param[21] = new SqlParameter("@Loans_FORM", SqlDbType.Bit);
            param[21].Value = Loans_FORM;
            param[22] = new SqlParameter("@Office_FORM", SqlDbType.Bit);
            param[22].Value = Office_FORM;
            param[23] = new SqlParameter("@Payment_Document_FORM", SqlDbType.Bit);
            param[23].Value = Payment_Document_FORM;
            param[24] = new SqlParameter("@Reciver_Document_FORM", SqlDbType.Bit);
            param[24].Value = Reciver_Document_FORM;
            param[25] = new SqlParameter("@Role_Functional_FORM", SqlDbType.Bit);
            param[25].Value = Role_Functional_FORM;
            param[26] = new SqlParameter("@Users_FORM", SqlDbType.Bit);
            param[26].Value = Users_FORM;
            param[27] = new SqlParameter("@Users_LOGS_FORM", SqlDbType.Bit);
            param[27].Value = Users_LOGS_FORM;
            Dt = DAL.selectdata("User_Add", param);
            DAL.close();
            return Dt;
        }
        public DataTable User_update(string fullName, string password, bool Authority_FORM, bool Backup_FORM, bool Backup_Restor_FORM, bool Bills_Details_FORM,
          bool Bills_FORM, bool Budget_FORM, bool Budget_Now_FORM, bool Coin_Exchange_FORM, bool Contracts_FORM, bool Department_FORM, bool Document_Category_FORM
          , bool Document_FORM, bool Emission_Salaries_FORM, bool Employee_Description_FORM, bool Employee_FORM, bool Employee_Salaries_FORM
          , bool EX_Order_FORM, bool EX_Orders_Cat_FORM, bool Leoan_Payments_FORM, bool Loans_FORM, bool Office_FORM
          , bool Payment_Document_FORM, bool Reciver_Document_FORM, bool Role_Functional_FORM, bool Users_FORM, bool Users_LOGS_FORM, int user_id)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[29];
            param[0] = new SqlParameter("@fullName", SqlDbType.NVarChar);
            param[0].Value = fullName;
            param[1] = new SqlParameter("@password", SqlDbType.NVarChar);
            param[1].Value = password;
            param[2] = new SqlParameter("@Authority_FORM", SqlDbType.Bit);
            param[2].Value = Authority_FORM;
            param[3] = new SqlParameter("@Backup_FORM", SqlDbType.Bit);
            param[3].Value = Backup_FORM;
            param[4] = new SqlParameter("@Backup_Restor_FORM", SqlDbType.Bit);
            param[4].Value = Backup_Restor_FORM;
            param[5] = new SqlParameter("@Bills_Details_FORM", SqlDbType.Bit);
            param[5].Value = Bills_Details_FORM;
            param[6] = new SqlParameter("@Bills_FORM", SqlDbType.Bit);
            param[6].Value = Bills_FORM;
            param[7] = new SqlParameter("@Budget_FORM", SqlDbType.Bit);
            param[7].Value = Budget_FORM;
            param[8] = new SqlParameter("@Budget_Now_FORM", SqlDbType.Bit);
            param[8].Value = Budget_Now_FORM;
            param[9] = new SqlParameter("@Coin_Exchange_FORM", SqlDbType.Bit);
            param[9].Value = Coin_Exchange_FORM;
            param[10] = new SqlParameter("Contracts_FORM", SqlDbType.Bit);
            param[10].Value = Contracts_FORM;
            param[11] = new SqlParameter("@Department_FORM", SqlDbType.Bit);
            param[11].Value = Department_FORM;
            param[12] = new SqlParameter("@Document_Category_FORM", SqlDbType.Bit);
            param[12].Value = Document_Category_FORM;
            param[13] = new SqlParameter("@Document_FORM", SqlDbType.Bit);
            param[13].Value = Document_FORM;
            param[14] = new SqlParameter("@Emission_Salaries_FORM", SqlDbType.Bit);
            param[14].Value = Emission_Salaries_FORM;
            param[15] = new SqlParameter("@Employee_Description_FORM", SqlDbType.Bit);
            param[15].Value = Employee_Description_FORM;
            param[16] = new SqlParameter("@Employee_FORM", SqlDbType.Bit);
            param[16].Value = Employee_FORM;
            param[17] = new SqlParameter("@Employee_Salaries_FORM", SqlDbType.Bit);
            param[17].Value = Employee_Salaries_FORM;
            param[18] = new SqlParameter("@EX_Order_FORM", SqlDbType.Bit);
            param[18].Value = EX_Order_FORM;
            param[19] = new SqlParameter("@EX_Orders_Cat_FORM", SqlDbType.Bit);
            param[19].Value = EX_Orders_Cat_FORM;
            param[20] = new SqlParameter("@Leoan_Payments_FORM", SqlDbType.Bit);
            param[20].Value = Leoan_Payments_FORM;
            param[21] = new SqlParameter("@Loans_FORM", SqlDbType.Bit);
            param[21].Value = Loans_FORM;
            param[22] = new SqlParameter("@Office_FORM", SqlDbType.Bit);
            param[22].Value = Office_FORM;
            param[23] = new SqlParameter("@Payment_Document_FORM", SqlDbType.Bit);
            param[23].Value = Payment_Document_FORM;
            param[24] = new SqlParameter("@Reciver_Document_FORM", SqlDbType.Bit);
            param[24].Value = Reciver_Document_FORM;
            param[25] = new SqlParameter("@Role_Functional_FORM", SqlDbType.Bit);
            param[25].Value = Role_Functional_FORM;
            param[26] = new SqlParameter("@Users_FORM", SqlDbType.Bit);
            param[26].Value = Users_FORM;
            param[27] = new SqlParameter("@Users_LOGS_FORM", SqlDbType.Bit);
            param[27].Value = Users_LOGS_FORM;
            param[28] = new SqlParameter("@user_id", SqlDbType.Int);
            param[28].Value = user_id;
            Dt = DAL.selectdata("User_update", param);
            DAL.close();
            return Dt;
        }
    }
}
