using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Grade_Record_Keeping.Class;
namespace Grade_Record_Keeping.Forms
{
    public partial class frmListInstructor : Grade_Record_Keeping.Forms.frmBaseList
    {
        public frmListInstructor()
        {
            InitializeComponent();
        }

        private void frmListInstructor_Load(object sender, EventArgs e)
        {
            Global_Vars.md.PopulateListView(lsv, Global_Vars.sss.SqlPopulate(this.Name));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddInstructor ai = new AddInstructor();
            ai.id = 0;
            ai.lstview = this.lsv;
            ai.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int _id;
            try
            {
                _id = Convert.ToInt32(lsv.SelectedItems[0].Text);
                AddInstructor ai = new AddInstructor();
                ai.id = _id;
                ai.lstview = lsv;
                ai.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select record first");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete record?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Instructor i = new Instructor();
                    i.DeleteInstructor(Convert.ToInt32(this.lsv.SelectedItems[0].Text));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select record first");
            }
            Global_Vars.md.PopulateListView(lsv, Global_Vars.sss.SqlPopulate(this.Name));
        }
    }
}
