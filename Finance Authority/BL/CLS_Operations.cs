﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Operations
    {
        public DataTable Operations_Bill_Salary_LoanPay_Viewby_towID( int id_Bill_Salary_LoanPay, bool statue_TPay_FRec)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Bill_Salary_LoanPay", SqlDbType.Int);
            param[0].Value = id_Bill_Salary_LoanPay;
            param[1] = new SqlParameter("@statue_TPay_FRec", SqlDbType.Bit);
            param[1].Value = statue_TPay_FRec;
            Dt = DAL.selectdata("Operations_Bill_Salary_LoanPay_Viewby_towID", param);
            DAL.close();
            return Dt;
        }
        public DataTable Operations_Bill_Salary_LoanPay_add(int id_Doc_Pay_Rec, int id_Bill_Salary_LoanPay, bool statue_TPay_FRec)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_Doc_Pay_Rec", SqlDbType.Int);
            param[0].Value = id_Doc_Pay_Rec;
            param[1] = new SqlParameter("@id_Bill_Salary_LoanPay", SqlDbType.Int);
            param[1].Value = id_Bill_Salary_LoanPay;
            param[2] = new SqlParameter("@statue_TPay_FRec", SqlDbType.Bit);
            param[2].Value = statue_TPay_FRec;
            Dt = DAL.selectdata("Operations_Bill_Salary_LoanPay_add", param);
            DAL.close();
            return Dt;
        }
        public void Operations_Bill_Salary_LoanPay_Delete(int id_Doc_Pay_Rec, int id_Bill_Salary_LoanPay)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DataTable Dt = new DataTable();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_Doc_Pay_Rec", SqlDbType.Int);
            param[0].Value = id_Doc_Pay_Rec;
            param[1] = new SqlParameter("@id_Bill_Salary_LoanPay", SqlDbType.Int);
            param[1].Value = id_Bill_Salary_LoanPay;
            DAL.excutecommand("Operations_Bill_Salary_LoanPay_Delete", param);
            DAL.close();

        }
    }
}
