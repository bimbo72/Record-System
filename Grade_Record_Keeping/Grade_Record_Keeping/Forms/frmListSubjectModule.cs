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
    public partial class frmListSubjectModule : Grade_Record_Keeping.Forms.frmBaseList
    {
        public frmListSubjectModule()
        {
            InitializeComponent();
        }

        private void frmListSubjectModule_Load(object sender, EventArgs e)
        {
            Global_Vars.md.PopulateListView(lsv, Global_Vars.sss.SqlPopulate(this.Name));
        }
    }
}
