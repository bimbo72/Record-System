using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class SubjectModule:LEAD
    {
        private string _table_name = "tbl_module";
        private List<string> _fields = new List<string>(new string[] { "m_id", "module" });
        private List<string> _values;
        public int m_id;
        public string module;
        public SubjectModule() {
            this.m_id = 0;
            this.module = "";
            this._values = new List<string>();
            base.table_name = this._table_name;
            base.fields = this._fields;
        }
        private List<string> AddValue()
        {
            this.values.Add(this.m_id.ToString());
            this.values.Add("'" + this.module + "'");
            return _values;
        }
        public void InsertModule()
        {           
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.INSERT());
        }
        public void UpdateModule()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.Update());
        }
        public void DeleteModule(int id)
        {
            base.Delete(id);
        }
        public void LoadModule(int id)
        {
            this._values = base.Load(id);
            this.m_id = Convert.ToInt32(this._values[0]);
            this.module = this._values[1];
        }
         public int getModuleID(string val) {
            int id;
            id = base.getID("module", val, "m_id");
            return id;
        }
    }
}
