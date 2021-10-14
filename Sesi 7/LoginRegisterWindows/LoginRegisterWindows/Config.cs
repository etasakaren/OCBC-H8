using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms; //For MessageBox
using System.Data; //For adding data function classes


namespace LoginRegisterWindows
{
    public class Config
    {
        string connectionString = "";
        public MySqlConnection connection = null;
        public string server = "localhost";
        public string user = "root";
        public string password = "root";
        DataSet ds;
        DataTable dt;
        public string table = "user_info";
        public string connectionType = "";
        string recordSource = "";

        DataGridView tempData;

        public Config()
        {

        }

        public void Connect(string database_name)
        {
            try
            {
                connectionString = "Server = " + server + ";" + "Database = " + database_name + ";" + "UID = " + user + ";" + "Password = " + password + ";";
                connection = new MySqlConnection(connectionString);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public void ExecuteSql(string sql_command)
        {
            Nowquiee(sql_command);
        }

        public void Nowquiee(string sql_comm)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(connectionString);
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sql_comm, cs);
                myc.ExecuteNonQuery();

                cs.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Execute(string sql_command)
        {
            recordSource = sql_command;
            connectionType = table;
            dt = new DataTable(connectionType);

            try
            {
                string command = recordSource.ToUpper();

                MySqlDataAdapter da2 = new MySqlDataAdapter(recordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, connectionType);
                //da2.Fill(tempds);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public string Results(int row, string columnName)
        {
            try
            {
                return dt.Rows[row][columnName].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return "";
            }
        }

        public void ExecuteSelect(string sql_command)
        {
            recordSource = sql_command;
            connectionType = table;

            dt = new DataTable(connectionType);
            try
            {
                string command = recordSource.ToUpper();
                MySqlDataAdapter da = new MySqlDataAdapter(recordSource, connection);
                ds = new DataSet();
                da.Fill(ds, connectionType);
                da.Fill(dt);
                tempData = new DataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public int Count()
        {
            return dt.Rows.Count;
        }
    }
}

