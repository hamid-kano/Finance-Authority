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
        int _Contract_id;
        int _Employee_id;
        DataTable DT;
        public Employee_Contracts_FORM(int Employee_id)
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            _Employee_id = Employee_id;
            Contracts_Gridview.DataSource = DT = cont.Contracts_View_Employee_ID(_Employee_id);
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[12].Visible = false;
        }
        private void Contracts_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Contracts_FORM_Load(object sender, EventArgs e)
        {

        }

        private void Contracts_Gridview_Click(object sender, EventArgs e)
        {
            if (Contracts_Gridview.CurrentRow != null)
            {
                _Contract_id = Convert.ToInt32(this.Contracts_Gridview.CurrentRow.Cells[0].Value.ToString());
                Contracts_Type.Text = this.Contracts_Gridview.CurrentRow.Cells[7].Value.ToString();
                Contracts_Date_Start.Text = this.Contracts_Gridview.CurrentRow.Cells[8].Value.ToString();
                Contracts_Date_end.Text = this.Contracts_Gridview.CurrentRow.Cells[9].Value.ToString();
                Contracts_Comb_Contract_statue.Text = this.Contracts_Gridview.CurrentRow.Cells[10].Value.ToString();
                Contracts_Notes.Text = this.Contracts_Gridview.CurrentRow.Cells[11].Value.ToString();
                Program.Employee_Description_id = Convert.ToInt32(this.Contracts_Gridview.CurrentRow.Cells[12].Value.ToString());
                Contracts_Brows_Docs.Enabled = true;
                if (DT.Rows.Count>0)
                {
                    Contracts_Update_Last_Cont.Enabled = Convert.ToInt32(DT.Rows[0][12]) == Program.Employee_Description_id ? true : false;
                }
            }
        }

        private void Contracts_Update_Last_Cont_Click(object sender, EventArgs e)
        {
           if (Contracts_Type.SelectedIndex == -1)
           {

              MessageBox.Show("ادخل نوع العقد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;           
           }
            if (Contracts_Comb_Contract_statue.SelectedIndex == -1)
            {

                MessageBox.Show("ادخل حالة العقد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Contracts_Date_Start.Value > Contracts_Date_end.Value)
           {

              MessageBox.Show("يجب ان يكون تاريخ نهاية العقد اكبر من تاريخ بدايته", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;            
           }
            cont.Contracts_update(Contracts_Type.Text, Contracts_Date_Start.Value, Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
             , Contracts_Notes.Text, Program.Employee_Description_id, _Contract_id);
            Program.Update_Message();
            LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل معلومات عقد", DateTime.Now);
            Contracts_Gridview.DataSource = DT = cont.Contracts_View_Employee_ID(_Employee_id);
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[12].Visible = false;
        }
    }
}
