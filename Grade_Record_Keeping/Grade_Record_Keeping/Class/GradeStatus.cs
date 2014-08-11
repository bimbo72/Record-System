using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class GradeStatus:LEAD
    {
        private string _table_name = "tbl_grade_status";
        private List<string> _fields = new List<string>(new string[] { "gs_id", "status_i", "status_name" });
        private List<string> _values;
        public string status_name;
        public string status_i;
        public int g_id;
        public GradeStatus() {
            this._values = new List<string>();
            this.g_id = 0;
            this.status_i = "";
            this.status_name = "";
            base.table_name = this._table_name;
            base.fields = this._fields;
        }
        private List<string> AddValue()
        {
            this._values.Add(this.g_id.ToString());
            this._values.Add("'" + this.status_i + "'");
            this._values.Add("'" + this.status_name + "'");
            return _values;
        }
        public void InsertGradeStatus()
        {      
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.INSERT());
        }
        public void UpdateGradeStatus()
        {
            base.values = this.AddValue();
            Global_Vars.db.executeNonReader(base.Update());
        }
        public void DeleteGradeStatus(int id)
        {
            base.Delete(id);
        }
        public void LoadGradeStatus(int id)
        {
            this._values = base.Load(id);
            this.g_id = Convert.ToInt32(this._values[0]);
            this.status_i = this._values[1];
            this.status_name = this._values[2];
        }
    }
}
