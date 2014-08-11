using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Grade_Record_Keeping.Forms;
using Grade_Record_Keeping.Class;
namespace Grade_Record_Keeping
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //-------------------------------------
            Global_Vars.db._server = "localhost";
            Global_Vars.db._username = "ruff";
            Global_Vars.db._pw = "ruff";
            Global_Vars.db._db = "record_system";
            if (Global_Vars.db.Connection())
            {
                Application.Run(new frmMain());
            }
            else {
                MessageBox.Show("Not Connected in Database");
            }
        }
    }
}
