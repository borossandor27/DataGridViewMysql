using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataGridViewMysql
{
    public partial class Form_Befizetes : Form
    {
        
        public Form_Befizetes()
        {
            InitializeComponent();
        }

        private void Form_Befizetes_Load(object sender, EventArgs e)
        {
            textBox_Tag_id.Text = Program.kivalasztott_tag.Cells["ID"].Value.ToString();
            textBox_Tag_neve.Text = Program.kivalasztott_tag.Cells["Nev"].Value.ToString();
            textBox_Befizetes_napja.Text = DateTime.Today.ToString("yyyy-MM-dd");
            numericUpDown1.Focus();
            numericUpDown1.Select(0, 0);
        }

        private void Form_Befizetes_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.sql.CommandText = "INSERT INTO `befiz` (`azon`, `datum`, `osszeg`) VALUES (@id, @datum, @osszeg);";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@id", textBox_Tag_id.Text);
            Program.sql.Parameters.AddWithValue("@datum", textBox_Befizetes_napja.Text);
            Program.sql.Parameters.AddWithValue("@osszeg", numericUpDown1.Value.ToString());
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }
    }
}
