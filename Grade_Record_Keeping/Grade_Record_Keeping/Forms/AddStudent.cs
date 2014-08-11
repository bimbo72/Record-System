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
    public partial class AddStudent : Form
    {
        public ListView lstView;
        public int id=0;
        public AddStudent()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.s_id = Convert.ToInt32(null);
            s.stud_id = tb_sid.Text;
            s.fname = tb_fname.Text;
            s.mname = tb_mname.Text;
            s.lname = tb_lname.Text;
                if (id == 0)
                {
                    s.s_id = Convert.ToInt32(null);
                    if (s.CheckIfExist(tb_sid.Text) == false)
                    {
                    s.InsertStudent();
                    MessageBox.Show("Student Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Student Id already exist");
                    }
                }
                else
                {
                    s.s_id = id;
                    s.UpdateStudent();
                    MessageBox.Show("Student Updated");
                }
                Global_Vars.md.PopulateListView(lstView,Global_Vars.sss.SqlPopulate("frmListStudents"));
                this.Close();         
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            if (id != 0) {
                Student s = new Student();
                s.LoadStudent(id);
                tb_fname.Text = s.fname;
                tb_sid.Text = s.stud_id;
                tb_mname.Text = s.mname;
                tb_lname.Text = s.lname;
            }
        }
    }
}
