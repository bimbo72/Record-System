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
    public partial class frmListSubjects : Grade_Record_Keeping.Forms.frmBaseList
    {
        public frmListSubjects()
        {
            InitializeComponent();
        }

        private void frmListSubjects_Load(object sender, EventArgs e)
        {
            Global_Vars.md.PopulateListView(lsv, Global_Vars.sss.SqlPopulate(this.Name));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddSubject sub = new AddSubject();
            sub.id = 0;
            sub.lstView = this.lsv;
            sub.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(lsv.SelectedItems[0].Text);
                AddSubject a = new AddSubject();
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
                    Subject sub = new Subject();
                    sub.DeleteSubject(Convert.ToInt32(this.lsv.SelectedItems[0].Text));
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
