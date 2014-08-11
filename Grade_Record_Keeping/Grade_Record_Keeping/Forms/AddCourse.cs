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
    public partial class AddCourse : Form
    {
        public int id=0;
        public ListView lstView;
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            if(id!=0){
                lbltitle.Text = "Update Course";
                Course c = new Course();
                c.LoadCourse(id);
                tb_course_Initial.Text = c.course_initial;
                tb_course_Name.Text = c.course_name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.course_initial = tb_course_Initial.Text;
            c.course_name = tb_course_Name.Text;
            if (id == 0)
            {
                c.course_id = Convert.ToInt32(null);
                c.InsertCourse();
                MessageBox.Show("Course Inserted");
            }
            else {
                c.course_id = id;
                c.UpdateCourse();
                MessageBox.Show("Course Updated");
            }
            this.Close();
            Global_Vars.md.PopulateListView(lstView, Global_Vars.sss.SqlPopulate("frmListCourse"));
        }
    }
}
