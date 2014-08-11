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
    public partial class frmListSchoolYear : Grade_Record_Keeping.Forms.frmBaseList
    {
        public frmListSchoolYear()
        {
            InitializeComponent();
        }

        private void frmListSchoolYear_Load(object sender, EventArgs e)
        {
            Global_Vars.md.PopulateListView(lsv, Global_Vars.sss.SqlPopulate(this.Name));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddSchoolYear asy = new AddSchoolYear();
            asy.id = 0;
            asy.lstView = this.lsv;
            asy.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(lsv.SelectedItems[0].Text);
                AddSchoolYear asy = new AddSchoolYear();
                asy.id = _id;
                asy.lstView = this.lsv;
                asy.ShowDialog();
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
                    School_Year sy = new School_Year();
                    sy.DeleteSchoolYear(Convert.ToInt32(this.lsv.SelectedItems[0].Text));
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
