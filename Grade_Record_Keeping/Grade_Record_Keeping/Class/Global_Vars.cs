using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grade_Record_Keeping.Class
{
    class Global_Vars
    {
        public static Db db = new Db();
        public static Module md = new Module();
        public static SqlScriptSelect sss = new SqlScriptSelect();
    }
}
