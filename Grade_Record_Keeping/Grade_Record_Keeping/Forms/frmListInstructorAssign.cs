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
    public partial class frmListInstructorAssign : Grade_Record_Keeping.Forms.frmBaseList
    {
        public frmListInstructorAssign()
        {
            InitializeComponent();
        }
        private void frmListInstructorAssign_Load(object sender, EventArgs e)
        {
            btn_edit.Visible = false;
            btn_delete.Visible = false;
            Global_Vars.md.PopulateListView(lsv, Global_Vars.sss.SqlPopulate(this.Name));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                frmAssignSubject fas = new frmAssignSubject();
                fas.id = Convert.ToInt32(lsv.SelectedItems[0].Text);
                fas.ShowDialog();
            }
            catch (Exception) {
                MessageBox.Show("Please select record first");
            }
        }
    }
}
