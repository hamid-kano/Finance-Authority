using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Authority.DAL
{
    class DATA_ACCESS_LAYER
    {
        SqlConnection sqlconnection;
        public DATA_ACCESS_LAYER()
        {
            sqlconnection = new SqlConnection(@"Server =192.168.137.1; DataBase=FinanceAuthorityDB; Integrated Security= false; USER ID =qwer;PASSWORD =1234");
        }

        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();

            }
        }

        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        //هذا التابع لإجراء عملية القراءة من قاعدة البيانات
        public DataTable selectdata(string stored_prouceture, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_prouceture;
            cmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //هذا التابع لإجراء عمليات الحذف والإضافة والتعديل
        public void excutecommand(string stored_prouceture, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_prouceture;
            cmd.Connection = sqlconnection;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            cmd.ExecuteNonQuery();
        }

    }
}

