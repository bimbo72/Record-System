using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class Semester:LEAD
    {
        private string _table_name = "tbl_semester";
        private List<string> _fields = new List<string>(new string[] { "semester_id", "semester" });
        private List<string> _values;
        public int semester_id;
        public string semester_name;
        public Semester() {
            this.semester_id = 0;
            this.semester_name = "";
            this._values = new List<string>();
            base.table_name = this._table_name;
            base.fields = this._fields;
        }
        private List<string> AddValue()
        {
            this._values.Add(this.semester_id.ToString());
            this._values.Add("'" + this.semester_name + "'");
            return _values;
        }
        public void InsertSemester()
        {           
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.INSERT());
        }
        public void UpdateSemester()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.Update());
        }
        public void DeleteSemester(int id)
        {
            base.Delete(id);
        }
        public void LoadSemester(int id)
        {
            this._values = base.Load(id);
            this.semester_id = Convert.ToInt32(this._values[0]);
            this.semester_name = this._values[1];
        }
        public int getSemesterID(string val)
        {
            int id;
            id = base.getID("semester", val, "semester_id");
            return id;
        }
    }
}
