using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class Course:LEAD
    {
        private string _table_name = "tbl_course";
        private List<string> _fields = new List<string>(new string[] { "course_id", "course_initial", "course_name" });
        private List<string> _values;
        public string course_name;
        public string course_initial;
        public int course_id;
        public Course() {
            this._values = new List<string>();
            this.course_id = 0;
            this.course_initial = "";
            this.course_name = "";
            base.table_name = this._table_name;
            base.fields = this._fields;
        }
        private List<string> AddValue()
        {
            this._values.Add(this.course_id.ToString());
            this._values.Add("'" + this.course_initial + "'");
            this._values.Add("'" + this.course_name + "'");
            return _values;
        }
        public void InsertCourse()
        {      
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.INSERT());
        }
        public void UpdateCourse()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.Update());
        }
        public void DeleteCourse(int id)
        {
            base.Delete(id);
        }
        public void LoadCourse(int id)
        {
            this._values = base.Load(id);
            this.course_id = Convert.ToInt32(this._values[0]);
            this.course_initial = this._values[1];
            this.course_name = this._values[2];
        }
    }
}
