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
    public partial class frmListGradeStatus : Grade_Record_Keeping.Forms.frmBaseList
    {
        public frmListGradeStatus()
        {
            InitializeComponent();
        }

        private void frmListGradeStatus_Load(object sender, EventArgs e)
        {
            Global_Vars.md.PopulateListView(lsv, Global_Vars.sss.SqlPopulate(this.Name));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frmGradeStatus fgs = new frmGradeStatus();
            fgs.id = 0;
            fgs.lstView = this.lsv;
            fgs.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(lsv.SelectedItems[0].Text);
                frmGradeStatus fgs = new frmGradeStatus();
                fgs.id = _id;
                fgs.lstView = this.lsv;
                fgs.ShowDialog();
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
                    GradeStatus gs = new GradeStatus();
                    gs.DeleteGradeStatus(Convert.ToInt32(this.lsv.SelectedItems[0].Text));
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
