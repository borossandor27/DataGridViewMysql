using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataGridViewMysql
{
    static class Program
    {
        public static Form foAblak = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;

        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            foAblak = new Form1();
            Application.Run(foAblak);
        }
    }
}
