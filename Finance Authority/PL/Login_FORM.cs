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
    public partial class Login_FORM : MetroFramework.Forms.MetroForm
    {
        public Login_FORM()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
