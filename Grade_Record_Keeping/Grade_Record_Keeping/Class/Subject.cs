using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class Subject:LEAD
    {
        private string _table_name = "tbl_subject";
        private List<string> _fields = new List<string>(new string[] { "sub_id", "code","description","unit","module_id" });
        private List<string> _values;
        public int sub_id,unit,module_id;
        public string code,description;
        public Subject() {
            this.sub_id = 0;
            this.unit = 0;
            this.module_id = 0;
            this.code = "";
            this.description = "";
            this._values = new List<string>();
            base.table_name = this._table_name;
            base.fields = this._fields;
        }
        private List<string> AddValue()
        {
            this._values.Add(this.sub_id.ToString());
            this._values.Add("'" + this.code + "'");
            this._values.Add("'" + this.description + "'");
            this._values.Add(this.unit.ToString());
            this._values.Add(this.module_id.ToString());
            return _values;
        }
        public void InsertSubject()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.INSERT());
        }
        public void LoadSubject(int id)
        {
            this._values = base.Load(id);
            this.sub_id = Convert.ToInt32(this._values[0]);
            this.code = this._values[1];
            this.description = this._values[2];
            this.unit = Convert.ToInt32(this._values[3]);
            this.module_id = Convert.ToInt32(this._values[4]);
        }
        public void UpdateSubject()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.Update());
        }
        public void DeleteSubject(int id)
        {
            base.Delete(id);
        }
       
    }
}
