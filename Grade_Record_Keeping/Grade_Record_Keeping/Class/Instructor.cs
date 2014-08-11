using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class Instructor:LEAD
    {
        private string _table_name= "tbl_instructor";
        private List<string> _fields = new List<string>(new string[]{"i_id","instructor_id","fname","mname","lname"});
        private List<string> _values;
        public int i_id;
        public string instructor_id;
        public string fname;
        public string mname;
        public string lname;
        public Instructor() {
            this.i_id = 0;
            this.instructor_id = "";
            this.fname = "";
            this.mname = "";
            this.lname = "";
            this._values = new List<string>();
            base.table_name = this._table_name;
            base.fields = this._fields;
        }
        private List<string> AddValue() {
            this._values.Add(this.i_id.ToString());
            this._values.Add("'"+instructor_id+"'");
            this._values.Add("'"+fname+"'");
            this._values.Add("'"+mname+"'");
            this._values.Add("'"+lname+"'");
            return _values;
        }
        public void InsertInstructor() {           
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.INSERT());
        }
        public void LoadInstructor(int id) {
            this._values= base.Load(id);
            this.i_id = Convert.ToInt32(this._values[0]);
            this.instructor_id = this._values[1];
            this.fname = this._values[2];
            this.mname = this._values[3];
            this.lname = this._values[4];
        }
        public void UpdateInstructor() {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.Update());
        }
        public void DeleteInstructor(int id) {
            base.Delete(id);
        }
    }
}
