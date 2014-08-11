using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Grade_Record_Keeping.Class
{
    class SqlScriptSelect
    {
        public string SqlPopulate(String name)
        {
            string sql="";
            switch (name)
            {
                case "frmListStudents":
                    sql = "select s_id,stud_id,fname,mname,lname from tbl_student"; break;
                case "frmListCourse":
                    sql = "select course_id,course_initial,course_name from tbl_course"; break;
                case "frmListSemester":
                    sql = "select semester_id,semester from tbl_semester"; break;
                case "frmListSchoolYear":
                    sql = "select sy_id,school_year from tbl_school_year"; break;
                case "frmListInstructor": case "frmListInstructorAssign":
                    sql = "select i_id,instructor_id,fname,mname,lname from tbl_instructor"; break;
                case "frmListSubjectModule":
                    sql = "select m_id,module from tbl_module"; break;
                case "frmListGradeStatus":
                    sql = "select gs_id,status_i,status_name from tbl_grade_status"; break;
                case "frmListSubjects":
                    sql = "Select s.sub_id,s.code,s.description,s.unit,m.module from tbl_subject s" +
                    " inner join tbl_module m on m.m_id=s.module_id"; break;
                   
            }
            return sql;
        }
        //return fields
        public List<string> _Fields(String name) {
            List<string> fields = new List<string>();
            switch (name)
            {
                case "frmListStudent":
                    fields = new List<string>(new string[] { "s_id", "stud_id", "fname", "mname", "lname" }); break;
                case "frmListCourse":
                    fields = new List<string>(new string[] { "course_id", "course_initial", "course_name" }); break;
                case "frmListSemester":
                    fields = new List<string>(new string[] { "semester_id", "semester"}); break;
                case "frmListSchoolYear":      
                    fields = new List<string>(new string[] { "sy_id", "school_year" }); break;
                case "frmListInstructor":
                case "AssignSubjectsInstructor":
                    fields = new List<string>(new string[] { "i_id", "instructor_id", "fname", "mname", "lname" }); break;
                case "frmListSubjectModule":
                    fields = new List<string>(new string[] { "m_id", "module" }); break;
                case "frmListGradeStatus":
                    fields = new List<string>(new string[] { "gs_id", "status_i", "status_name" }); break;
                case "frmListSubject":
                    fields = new List<string>(new string[] { "s.sub_id", "s.code", "s.subject_name", 
                        "s.description", "s.unit","m.module" }); break;
            }
            return fields;        
        }
    }
}
