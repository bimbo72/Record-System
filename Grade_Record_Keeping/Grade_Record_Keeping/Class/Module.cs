using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Windows.Forms;
using Grade_Record_Keeping.Forms;
namespace Grade_Record_Keeping.Class
{
    class Module
    {
        public void LoadListHeader(ListView lsv, List<string> lst) {
            foreach (string l in lst) {
                lsv.Columns.Add(l);
            }
        }
        
        public void PopulateListView(ListView lsv, string sql)
        {
            ListViewItem lsv_item;
            Global_Vars.db.executeReader(sql);
            lsv.Items.Clear();
            if (Global_Vars.db.reader.HasRows)
            {
                while (Global_Vars.db.reader.Read())
                {
                    lsv_item = lsv.Items.Add(Global_Vars.db.reader.GetValue(0).ToString());
                    for (int x = 1; x <= Global_Vars.db.reader.FieldCount - 1; x++)
                    {
                        lsv_item.SubItems.Add(Global_Vars.db.reader.GetValue(x).ToString());
                    }
                }
            }
            Global_Vars.db.reader.Close();
            this.ListViewAutoSize(lsv);

        }
       
        public void PopulateCombobox(ComboBox cbo, string sql)
        {
            cbo.Items.Clear();
            Global_Vars.db.executeReader(sql);
            if (Global_Vars.db.reader.HasRows)
            {
                while (Global_Vars.db.reader.Read())
                {
                    cbo.Items.Add(Global_Vars.db.reader.GetValue(1).ToString());
                }

            }
            Global_Vars.db.reader.Close();
        }
        public void ListViewAutoSize(ListView lsv) {
            lsv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    
    }
}
