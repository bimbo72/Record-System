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
    public partial class frmListSemester : Grade_Record_Keeping.Forms.frmBaseList
    {
        public frmListSemester()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddSemester a = new AddSemester();
            a.id = 0;
            a.lstView = this.lsv;
            a.ShowDialog();
        }

        private void frmListSemester_Load(object sender, EventArgs e)
        {
            Global_Vars.md.PopulateListView(lsv, Global_Vars.sss.SqlPopulate(this.Name));
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(lsv.SelectedItems[0].Text);
                AddSemester a = new AddSemester();
                a.id = _id;
                a.lstView = this.lsv;
                a.ShowDialog();
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
                    Semester sem = new Semester();
                    sem.DeleteSemester(Convert.ToInt32(this.lsv.SelectedItems[0].Text));
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
