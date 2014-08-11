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
    public partial class frmAssignSubject : Form
    {
        public int id;
        public string ins_id;
        List<int> lst_ids;
        public frmAssignSubject()
        {
            InitializeComponent();
            lst_ids = new List<int>();
            ins_id = "";
        }

        private void frmAssignSubject_Load(object sender, EventArgs e)
        {
            string sql = "Select * from tbl_school_year";
            Global_Vars.md.PopulateCombobox(cbosy, sql);
            Global_Vars.md.PopulateCombobox(cbosy1, sql);
            sql = "Select * from tbl_semester";
            Global_Vars.md.PopulateCombobox(cbosemester, sql);
            Global_Vars.md.PopulateCombobox(cbosem, sql);
            Instructor i = new Instructor();
            i.LoadInstructor(id);
            ins_id = i.instructor_id;
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            if ((cbosem.Text != "") && (cbosy1.Text != ""))
            {
                try
                {
                    int _sy_id, _semester_id;   
                    School_Year sy = new School_Year();
                    _sy_id = sy.getSyID(cbosy1.Text);
                    Semester sem = new Semester();
                    _semester_id = sem.getSemesterID(cbosem.Text);
                    InstructorSubject InsSub = new InstructorSubject();
                    InsSub.i_s_id = Convert.ToInt32(null);
                    InsSub.instructor_id = ins_id;
                    InsSub.semester_id = _semester_id;
                    InsSub.sy_id = _sy_id;
                    InsSub.subject_id = Convert.ToInt32(lsv1.SelectedItems[0].Text);
                    InsSub.InsertInstructorSubj();
                    /*
                    string sql = "Select s.sub_id,s.code,s.subject_name,s.description,s.unit,m.module,i_s.id from tbl_subject s" +
                           " inner join tbl_module m on m.m_id=s.module_id inner join tbl_instructor_subject i_s on i_s.subject_id" +
                           "=s.sub_id inner join tbl_instructor i on i.instructor_id= i_s.instructor_id where i.id='" + id + "'";
                    Global_Vars.md.PopulateListView(lsv2, sql);*/
                    _search(tb_search2.Text, lsv2);
                }
                catch (Exception)
                {
                    MessageBox.Show("Select Subject First");
                }
            }
            else {
                MessageBox.Show("Plese Select School Year or Semester First");
            }

       }

        private void btn_transfr2_Click(object sender, EventArgs e)
        {
            try
            {
                lst_ids.Remove(Convert.ToInt32(lsv2.SelectedItems[0].Text));
                //string sql = "Select s.sub_id,s.code,s.subject_name,s.description,s.unit,m.module from tbl_subject s" +
                 //  " inner join tbl_module m on m.m_id=s.module_id;";              
                //Global_Vars.md.PopulateListView(lsv2, sql, lst_ids);
            }
            catch (Exception) {
                MessageBox.Show("Select Record First");
            }
        }

        private void tb_search1_TextChanged(object sender, EventArgs e)
        {
            _search(tb_search1.Text,lsv1);
        }
        private void _search(string val,ListView lsv) {
            string sql = "";
            if (lsv == lsv1)
            {
                    sql = "Select s.sub_id,s.code,s.subject_name,s.description,s.unit,m.module from tbl_subject s" +
                           " inner join tbl_module m on m.m_id=s.module_id where ((s.sub_id like '%" + val +
                   "%')||(s.code like '%" + val + "%')||(s.subject_name like '%" + val + "%')||(s.description like '%" +
                    val + "%')||(s.unit like '%" + val + "%')||(m.module like '%" + val + "%'))";
                Global_Vars.md.PopulateListView(lsv, sql);
            }
            else {
                if ((cbosy.Text == "") && (cbosemester.Text == ""))
                {
                    sql = "Select s.sub_id,s.code,s.subject_name,s.description,s.unit,m.module,i_s.id from tbl_subject s" +
                           " inner join tbl_module m on m.m_id=s.module_id inner join tbl_instructor_subject i_s on i_s.subject_id" +
                           "=s.sub_id inner join tbl_instructor i on i.instructor_id= i_s.instructor_id where (((s.sub_id like '%" + val +
                       "%')||(s.code like '%" + val + "%')||(s.subject_name like '%" + val + "%')||(s.description like '%" +
                        val + "%')||(s.unit like '%" + val + "%')||(m.module like '%" + val + "%'))&&(i_s.instructor_id='" + this.ins_id +"'))";
                }
                else if ((cbosy.Text != "") && (cbosemester.Text == "")) {
                    sql = "Select s.sub_id,s.code,s.subject_name,s.description,s.unit,m.module,i_s.id from tbl_subject s" +
                           " inner join tbl_module m on m.m_id=s.module_id inner join tbl_instructor_subject i_s on i_s.subject_id" +
                           "=s.sub_id inner join tbl_instructor i on i.instructor_id=i_s.instructor_id inner join tbl_school_year "+
                           "sy on sy.sy_id=i_s.sy_id where (((s.sub_id like '%" + val +
                       "%')||(s.code like '%" + val + "%')||(s.subject_name like '%" + val + "%')||(s.description like '%" +
                        val + "%')||(s.unit like '%" + val + "%')||(m.module like '%" + val + "%'))&&(sy.school_year='"+ cbosy.Text +
                        "')&&(i_s.instructor_id='" + this.ins_id + "'))";
                }
                else if ((cbosy.Text == "") && (cbosemester.Text != ""))
                {
                    sql = "Select s.sub_id,s.code,s.subject_name,s.description,s.unit,m.module,i_s.id from tbl_subject s" +
                           " inner join tbl_module m on m.m_id=s.module_id inner join tbl_instructor_subject i_s on i_s.subject_id" +
                           "=s.sub_id inner join tbl_instructor i on i.instructor_id= i_s.instructor_id inner join tbl_semester sem "+
                           "on sem.semester_id=i_s.semester_id where (((s.sub_id like '%" + val +
                       "%')||(s.code like '%" + val + "%')||(s.subject_name like '%" + val + "%')||(s.description like '%" +
                        val + "%')||(s.unit like '%" + val + "%')||(m.module like '%" + val + "%'))&&(sem.semester='" + cbosemester.Text +
                        "')&&(i_s.instructor_id='" + this.ins_id + "'))";
                }
                else if ((cbosy.Text != "") && (cbosemester.Text != ""))
                {
                    sql = "Select s.sub_id,s.code,s.subject_name,s.description,s.unit,m.module,i_s.id from tbl_subject s" +
                           " inner join tbl_module m on m.m_id=s.module_id inner join tbl_instructor_subject i_s on i_s.subject_id" +
                           "=s.sub_id inner join tbl_instructor i on i.instructor_id= i_s.instructor_id inner join tbl_semester sem " +
                           "on sem.semester_id=i_s.semester_id inner join tbl_school_year " +
                           "sy on sy.sy_id=i_s.sy_id where (((s.sub_id like '%" + val +
                       "%')||(s.code like '%" + val + "%')||(s.subject_name like '%" + val + "%')||(s.description like '%" +
                        val + "%')||(s.unit like '%" + val + "%')||(m.module like '%" + val + "%'))&&(sy.school_year='" + cbosy.Text +
                        "')&&(i_s.instructor_id='" + this.ins_id + "')&&(sem.semester='" + cbosemester.Text + "'))";
                }
                Global_Vars.md.PopulateListView(lsv, sql);
            }
        }

        private void tb_search2_TextChanged(object sender, EventArgs e)
        {
            _search(tb_search2.Text, lsv2);
        }

       

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //lsv2.SelectedItems[0].SubItems[5].Text;
            }
            catch (Exception) { 
            
            }
        }

        private void cbosemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            _search(tb_search2.Text, lsv2);
        }

        private void cbosy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _search(tb_search2.Text, lsv2);
        }
    }
}
