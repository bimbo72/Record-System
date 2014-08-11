using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Grade_Record_Keeping.Class;
namespace Grade_Record_Keeping.Forms
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            LEAD ll = new LEAD();
            ll.table_name = "tbl_student";
            for (int x = 0; x < 6; x++) {
                ll.fields.Add(" ");
                ll.values.Add("-");
            }
            MessageBox.Show(ll.Update());
        }
    }
}
