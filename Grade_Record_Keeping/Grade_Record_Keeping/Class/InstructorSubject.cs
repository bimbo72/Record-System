using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class InstructorSubject:LEAD
    {
        private string _table_name = "tbl_instructor_subject";
        private List<string> _fields = new List<string>(new string[] { "id", "instructor_id", "subject_id", "sy_id", "semester_id" });
        private List<string> _values;
        public int i_s_id,subject_id,semester_id,sy_id;
        public string instructor_id;
        public InstructorSubject() {
            this.i_s_id = 0;
            this.subject_id = 0;
            this.semester_id = 0;
            this.sy_id = 0;
            this.instructor_id = "";
            this._values = new List<string>();
            base.table_name = this._table_name;
            base.fields = this._fields;
        }
        private List<string> AddValue() {
            this._values.Add(this.i_s_id.ToString());
            this._values.Add("'" + this.instructor_id + "'");
            this._values.Add(this.subject_id.ToString());
            this._values.Add(this.sy_id.ToString());
            this._values.Add(this.semester_id.ToString());
            return _values;
        }
        public void InsertInstructorSubj()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.INSERT());
        }
        public void LoadInstructorSubj(int id)
        {
            this.values = base.Load(id);
            this.i_s_id = Convert.ToInt32(this._values[0]);
            this.instructor_id = this._values[1];
            this.subject_id =  Convert.ToInt32(this._values[2]);
            this.sy_id =  Convert.ToInt32(this._values[3]);
            this.semester_id =  Convert.ToInt32(this._values[4]);
        }
        public void UpdateInstructorSubj()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.Update());
        }
        public void DeleteInstructorSubj(int id)
        {
            base.Delete(id);
        }
    }
}
