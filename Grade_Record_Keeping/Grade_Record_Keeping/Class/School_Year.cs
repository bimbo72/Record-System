using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class School_Year:LEAD
    {
        private string _table_name = "tbl_school_year";
        private List<string> _fields = new List<string>(new string[] { "sy_id", "school_year" });
        private List<string> _values;
        public int sy_id;
        public string sy_name;
        public School_Year() {
            this.sy_id = 0;
            this.sy_name = "";
            this._values = new List<string>();
            base.table_name = this._table_name;
            base.fields = this._fields;
        }
        private List<string> AddValue()
        {
            this._values.Add(this.sy_id.ToString());
            this._values.Add("'" + this.sy_name + "'");
            return _values;
        }
        public void InsertSchoolyear()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.INSERT());
        }
        public void UpdateSchoolYear()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.Update());
        }
        public void DeleteSchoolYear(int id)
        {
            base.Delete(id);
        }
        public void LoadSchoolyear(int id)
        {
            this._values = base.Load(id);
            this.sy_id = Convert.ToInt32(this._values[0]);
            this.sy_name = this._values[1];
        }
        public int getSyID(string val)
        {
            int id;
            id = base.getID("school_year", val, "sy_id");
            return id;
        }
    }
}
