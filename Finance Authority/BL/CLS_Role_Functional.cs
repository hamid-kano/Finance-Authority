using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Finance_Authority.BL
{
    class CLS_Role_Functional
    {
        public DataTable Role_Functional_add(string Role_Functional_Name, string Notes)
        {
            DAL.DATA_ACCESS_LAYER DAL = new DAL.DATA_ACCESS_LAYER();
            DAL.open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Role_Functional_Name", SqlDbType.NVarChar);
            param[0].Value = Role_Functional_Name;
            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[1].Value = Notes;
            Dt = DAL.selectdata("Role_Functional_add", param);
            DAL.close();
            return Dt;
        }
    }
}
