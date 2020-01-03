using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Authority.PL
{
    public partial class Users_Logs_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_LOGS logs = new BL.CLS_LOGS();
        public Users_Logs_FORM()
        {
            InitializeComponent();
            Users_Logs_DataGrid.DataSource = logs.LOGS_View();
            Users_Logs_DataGrid.Columns[0].Visible = false;
        }

        private void Users_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
