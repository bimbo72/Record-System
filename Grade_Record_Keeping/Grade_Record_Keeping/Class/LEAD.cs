using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class LEAD
    {
        public string table_name;
        public List<string> fields;
        public List<string> values;

        public LEAD() {
            this.table_name = "";
            this.fields = new List<string>();
            this.values = new List<string>();
        }
        //Insert
        public string INSERT()
        {
            string sql = "INSERT into " + this.table_name + " (";
            int _count = fields.Count;
            int x = 1;
            foreach (string f in fields)
            {
                sql = sql + f;
                if (x == _count)
                {
                    sql = sql + ")";
                }
                else
                {
                    sql = sql + ",";
                }
                x++;
            }
            sql = sql + " values(";
            _count = values.Count;
            x = 1;
            foreach (string v in values)
            {
                sql = sql + v;
                if (x == _count)
                {
                    sql = sql + ")";
                }
                else
                {
                    sql = sql + ",";
                }
                x++;
            }
            sql = sql + ";";
            return sql;
        }
        //Update
        public string Update() { 
         string sql="Update " + this.table_name + " set ";
         int _count = this.fields.Count;
         for (int x = 1; x < _count; x++) {
             sql = sql + fields[x] + "=" + values[x];
             if (x < _count-1) {
                 sql = sql + ",";
             }
         }
         sql = sql + " where " + fields[0]+"="+values[0]+";";
         return sql;
        }
        //Load
        public List<string> Load(int id) {
            this.values = new List<string>();
            string sql = "SELECT * from " + this.table_name + " where " + fields[0] + "=" + id + ";";
            Global_Vars.db.executeReader(sql);
            Global_Vars.db.reader.Read();
            for (int x = 0; x < fields.Count; x++) {
                this.values.Add(Global_Vars.db.reader[x].ToString());
            }
            Global_Vars.db.reader.Close();
            return this.values;
        }
        //Delete
        public void Delete(int id) {
            string sql = "Delete from " + this.table_name + " where " + this.fields[0] + "=" + id + ";";
            Global_Vars.db.executeNonReader(sql);

        }
        //Get Id From DropDown
        public int getID(string field_condition, string condition_val, string field_value_return)
        {
            int _id = 0;
            string sql = "SELECT " + field_value_return + " from " + this.table_name + " where " + field_condition + "='" + condition_val + "';";
            Global_Vars.db.executeReader(sql); {
                if (Global_Vars.db.reader.HasRows) {
                    Global_Vars.db.reader.Read();
                    _id = Convert.ToInt32((Global_Vars.db.reader[0]));
                }
            }
            Global_Vars.db.reader.Close();
            return _id;
        }
        public int _Count(string field_count, string field_condition) {
            int count = 0;
            string sql = "SELECT count(" + field_count + ") from " + this.table_name + " where " + field_count + "='" 
                + field_condition + "';";
            Global_Vars.db.executeReader(sql);
            if (Global_Vars.db.reader.HasRows) {
                Global_Vars.db.reader.Read();
                count = Convert.ToInt32((Global_Vars.db.reader[0]));
            }
            Global_Vars.db.reader.Close();
            return count;
        }
        //Search
        public string Search(string sql,string value,List<string> columns) {
           sql = sql + " where (";
           
               //s.sid LIKE '%" + this.tb_search2.Text + "%'
            return sql;
        }
    }
}
