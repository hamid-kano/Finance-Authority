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
    public partial class Employee_Contracts_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        int _Employee_id;
        public Employee_Contracts_FORM(int Employee_id)
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            _Employee_id = Employee_id;
            Contracts_Gridview.DataSource = cont.Contracts_View_Employee_ID(_Employee_id);
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[12].Visible = false;
        }
        private void Contracts_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
