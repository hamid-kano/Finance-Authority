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
    public partial class Role_Functional_FORM : MetroFramework.Forms.MetroForm
    { 
        public Role_Functional_FORM()
        {
            InitializeComponent();
        }

        private void Role_Functional_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Role_Functional_new_Click(object sender, EventArgs e)
        {
            Role_Functional_add.Enabled = true;
            Role_Functional_Name.Text = "";
            Role_Functional_Notes.Text = "";
            Role_Functional_update.Enabled = false;
            Role_Functional_delete.Enabled = false;
        }

        private void Role_Functional_add_Click(object sender, EventArgs e)
        {
            
        }
    }
}
