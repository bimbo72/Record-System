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
    public partial class AddInstructor : Form
    {
        public int id=0;
        public ListView lstview;
        public AddInstructor()
        {
            InitializeComponent();
        }

        private void AddInstructor_Load(object sender, EventArgs e)
        {
            if (id != 0) {
                Instructor i = new Instructor();
                i.LoadInstructor(id);
                tb_uid.Text = i.instructor_id;
                tb_fname.Text = i.fname;
                tb_mname.Text = i.mname;
                tb_lname.Text = i.lname;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Instructor i = new Instructor();
            i.instructor_id = tb_uid.Text;
            i.fname = tb_fname.Text;
            i.mname = tb_mname.Text;
            i.lname = tb_lname.Text;
            if (id == 0)
            {
                i.i_id = Convert.ToInt32(null);
                i.InsertInstructor();
                MessageBox.Show("Instructor Inserted");
            }
            else {
                i.i_id = id;
                i.UpdateInstructor();
                MessageBox.Show("Instructor Updated");
            }
            this.Close();
            Global_Vars.md.PopulateListView(lstview,Global_Vars.sss.SqlPopulate("frmListInstructor"));
        }
    }
}
