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
    public partial class Objects_FORM : MetroFramework.Forms.MetroForm 
    { BL.CLS_Object obj = new BL.CLS_Object();
        public Objects_FORM()
        {
            InitializeComponent();
            this.Objects_dataGrid.DataSource = obj.Object_View();
            this.Objects_dataGrid.Columns[0].Visible = false;
            Object_Comb_Bill.DataSource = obj.Object_Comb_Bill();
            Object_Comb_Bill.DisplayMember = "Bill_id";
            Object_Comb_Bill.ValueMember = "Bill_id";

        }


        private void Objects_new_Click(object sender, EventArgs e)
        {
            Objects_add.Enabled = true;
            Objects_Object.Text = "";
            Object_Amonts.Text = "";
            Object_Price.Text = "";
            Object_Total.Text = "";
            Objects_update.Enabled = false;
            Objects_delete.Enabled = false;
        }

        private void Objects_add_Click(object sender, EventArgs e)
        {
            obj.Object_add(Objects_Object.Text, Object_Amonts.Text, Object_Price.Text, Object_Total.Text, Convert.ToInt32(Object_Comb_Bill.SelectedValue));
            this.Objects_dataGrid.DataSource = obj.Object_View();
            this.Objects_dataGrid.Columns[0].Visible = false;
            Program.Add_Message();
            Objects_Object.Text = "";
            Object_Amonts.Text = "";
            Object_Price.Text = "";
            Object_Total.Text = "";
            Objects_add.Enabled = false;
        }

        private void Objects_dataGrid_Click(object sender, EventArgs e)
        {
            if (Objects_dataGrid.CurrentRow != null)
            {
                Program.object_id = Convert.ToInt32(this.Objects_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Objects_Object.Text = this.Objects_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Object_Amonts.Text = this.Objects_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Object_Price.Text = this.Objects_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Object_Total.Text = this.Objects_dataGrid.CurrentRow.Cells[4].Value.ToString();
                Object_Comb_Bill.Text = this.Objects_dataGrid.CurrentRow.Cells[5].Value.ToString();
                Objects_update.Enabled = true;
                Objects_delete.Enabled = true;
            }
        }

        private void Objects_update_Click(object sender, EventArgs e)
        {
            obj.Object_update(Objects_Object.Text, Object_Amonts.Text, Object_Price.Text, Object_Total.Text, Convert.ToInt32(Object_Comb_Bill.SelectedValue), Program.object_id);
            this.Objects_dataGrid.DataSource = obj.Object_View();
            this.Objects_dataGrid.Columns[0].Visible = false;
            Program.Update_Message();
            Objects_Object.Text = "";
            Object_Amonts.Text = "";
            Object_Price.Text = "";
            Object_Total.Text = "";
            Objects_update.Enabled = false;
            Objects_delete.Enabled = false;
        }

        private void Objects_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                obj.Object_Delete(Program.object_id);
                this.Objects_dataGrid.DataSource = obj.Object_View();
                this.Objects_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Objects_Object.Text = "";
                Object_Amonts.Text = "";
                Object_Price.Text = "";
                Object_Total.Text = "";
                Objects_update.Enabled = false;
                Objects_delete.Enabled = false;
            }
        }

        private void Objects_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
