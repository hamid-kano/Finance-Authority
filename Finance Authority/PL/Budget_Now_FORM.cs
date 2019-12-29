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
    public partial class Budget_Now_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Budget Bud = new BL.CLS_Budget();
        DataTable dt = new DataTable();
        public Budget_Now_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            dt = Bud.Budget_Last_Budget();
            if (dt.Rows.Count!=0)
            {
                Budget_Now_amount_sy.Text = dt.Rows[0][1].ToString();
                Budget_Now_amount_Dollar.Text = dt.Rows[0][2].ToString();
                Budget_Now_import_sy.Text = dt.Rows[0][3].ToString();
                Budget_Now_import_Dollar.Text = dt.Rows[0][4].ToString();
                Budget_Now_Recycle_Sy.Text = dt.Rows[0][5].ToString();
                Budget_Now_Recycle_Dollar.Text = dt.Rows[0][6].ToString();
                Budget_Now_spicified_Sy.Text = dt.Rows[0][7].ToString();
                Budget_Now_spicified_Dollar.Text = dt.Rows[0][8].ToString();
                Budget_Now_DateTime.Text = dt.Rows[0][9].ToString();
                Budget_Now_Notes.Text = dt.Rows[0][10].ToString();
            }  
        }
    }
}
