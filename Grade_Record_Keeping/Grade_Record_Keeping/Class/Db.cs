using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Grade_Record_Keeping
{
    class Db
    {
        public string _server = "";
        public string _username = "";
        public string _pw = "";
        public string _db = "";
        public MySqlConnection conn;
        public MySqlDataReader reader;
        public MySqlCommand comm;

        public bool Connection()
        {
            string connection = "server=" + this._server +
               ";uid=" + this._username + ";pwd=" + this._pw +
               ";database=" + this._db + ";";

            this.conn = new MySqlConnection();
            this.conn.ConnectionString = connection;
            try
            {
                this.conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }
        public void CloseConnection()
        {
            this.conn.Close();
        }
        public MySqlDataReader executeReader(string sql)
        {
            try
            {
                this.comm = new MySqlCommand();
                this.comm.Connection = this.conn;
                this.comm.CommandText = sql;
                this.reader = this.comm.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            return this.reader;

        }
        public void executeNonReader(string sql)
        {
            try
            {
                this.comm = new MySqlCommand();
                this.comm.Connection = this.conn;
                this.comm.CommandText = sql;
                this.comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
