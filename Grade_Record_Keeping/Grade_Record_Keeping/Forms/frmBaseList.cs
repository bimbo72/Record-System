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
    public partial class frmBaseList : Form
    {
        public frmBaseList()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception) {
                MessageBox.Show("Select Record First");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* string sql = "";
            //sql = Global_Vars.sss.SqlPopulate() + " where (";
            int count = 1;
            foreach (string f in Global_Vars.sss._Fields()) {

                if (count == Global_Vars.sss._Fields().Count)
                {
                    sql = sql +"("+ f + " LIKE '%" + textBox1.Text + "%'))";
                }
                else { sql = sql +"("+ f + " LIKE '%" + textBox1.Text + "%')||"; 
                }
                count++;
            }
            Global_Vars.md.PopulateListView(lsv, sql);*/
        }

      
    }
}
