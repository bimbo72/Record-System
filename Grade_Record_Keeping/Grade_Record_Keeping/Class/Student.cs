using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class Student:LEAD
    {
        private string _table_name= "tbl_student";
        private List<string> _fields = new List<string>(new string[]{"s_id","stud_id","fname","mname","lname"});
        private List<string> _values;
        public int s_id;
        public string stud_id;
        public string fname;
        public string mname;
        public string lname;
        public Student() {
            this.s_id = 0;
            this.stud_id = "";
            this.fname = "";
            this.mname = "";
            this.lname = "";
            this._values = new List<string>();
            base.table_name = this._table_name;
            base.fields = this._fields;
        }
        private List<string> AddValue() {
            this._values.Add(this.s_id.ToString());
            this._values.Add("'"+stud_id+"'");
            this._values.Add("'"+fname+"'");
            this._values.Add("'"+mname+"'");
            this._values.Add("'"+lname+"'");
            return _values;
        }
        public void InsertStudent() {           
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.INSERT());
        }
        public void LoadStudent(int id) {
            this._values= base.Load(id);
            this.s_id = Convert.ToInt32(this._values[0]);
            this.stud_id = this._values[1];
            this.fname = this._values[2];
            this.mname = this._values[3];
            this.lname = this._values[4];
        }
        public void UpdateStudent() {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.Update());
        }
        public void DeleteStudent(int id) {
            base.Delete(id);
        }
        public bool CheckIfExist(string _stud_id) {
            bool check = false;
            if (base._Count("stud_id", _stud_id)!=0) {
                check = true;
            }
            return check;
        }
    }
}
