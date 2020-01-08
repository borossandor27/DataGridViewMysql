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
        public static Form form_Befizetes = null;
        public static MySqlConnection conn = null;  //-- egységes adabáziskapcsolat miatt
        public static MySqlCommand sql = null;      //-- parancsok fogadása, futtatása
        public static DataGridViewRow kivalasztott_tag = null;    //-- Form-ok közötti adatádasáshoz

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
            form_Befizetes = new Form_Befizetes();
            Application.Run(foAblak);
        }
    }
}
