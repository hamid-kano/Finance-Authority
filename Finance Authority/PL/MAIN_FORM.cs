using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Finance_Authority
{
    public partial class MAIN_FORM :MetroForm
    {
        public MAIN_FORM()
        {
            InitializeComponent();
        }

        private void EX_Orders_Cat_BTN_Click(object sender, EventArgs e)
        {
            PL.EX_Orders_Cat_FORM FRM = new PL.EX_Orders_Cat_FORM();
            FRM.ShowDialog();
        }

        private void EX_Order_BTN_Click(object sender, EventArgs e)
        {
            PL.EX_Order_FORM FRM = new PL.EX_Order_FORM();
            FRM.ShowDialog();
        }
    }
}
