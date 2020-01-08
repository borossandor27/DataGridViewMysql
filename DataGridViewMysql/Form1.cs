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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *  A születési évnél évente változik a maximum érték,
             *  ezért csak dinamikusan határozható meg
             * 
             */
            numericUpDown_SzuletesiEv.Minimum = DateTime.Today.AddYears(-200).Year;
            numericUpDown_SzuletesiEv.Maximum = DateTime.Today.Year;
            numericUpDown_SzuletesiEv.Value = DateTime.Today.AddYears(-35).Year;

            Tagok_Adattabla_beallitasai();
            Tagok_Adattabla_Update();
            Befizetesek_Adattabla_beallitasai();
        }

        private void Tagok_Adattabla_beallitasai()
        {
            /*
             * A dataGridView elem tervező nézetben is állítható,
             * de most ez is dinamikusan van meghatározva
             */
            dataGridView_Tagok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Tagok.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Tagok.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView_Tagok.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_Tagok.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dataGridView_Tagok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_Tagok.MultiSelect = false;
            dataGridView_Tagok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //-- Az id oszlop --------------------------------------------------
            DataGridViewColumn column_ID = new DataGridViewColumn();
            {
                column_ID.Name = "ID";
                column_ID.DataPropertyName = "ID";
                column_ID.CellTemplate = new DataGridViewTextBoxCell();
                column_ID.Visible = false;
            }
            dataGridView_Tagok.Columns.Insert(0, column_ID);

            //-- A név oszlop --------------------------------------------------
            DataGridViewTextBoxColumn column_Nev = new DataGridViewTextBoxColumn();
            {
                column_Nev.HeaderText = "Név";
                column_Nev.Name = "Nev";
                column_Nev.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Tagok.Columns.Insert(1, column_Nev);

            DataGridViewTextBoxColumn column_Orszag = new DataGridViewTextBoxColumn();
            {
                column_Orszag.HeaderText = "Ország";
                column_Orszag.Name = "Orszag";
                column_Orszag.CellTemplate = new DataGridViewTextBoxCell();
                column_Orszag.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView_Tagok.Columns.Insert(2, column_Orszag);

            DataGridViewColumn column_Iranyitoszam = new DataGridViewColumn();
            {
                column_Iranyitoszam.HeaderText = "Irányítószám";
                column_Iranyitoszam.Name = "Iranyitoszam";
                column_Iranyitoszam.ValueType = typeof(int);
                column_Iranyitoszam.CellTemplate = new DataGridViewTextBoxCell();
                column_Iranyitoszam.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView_Tagok.Columns.Insert(3, column_Iranyitoszam);

            DataGridViewColumn column_SzuletesiEv = new DataGridViewColumn();
            {
                column_SzuletesiEv.HeaderText = "Születési Év";
                column_SzuletesiEv.Name = "SzuletesiEv";
                column_SzuletesiEv.ValueType = typeof(int);
                column_SzuletesiEv.CellTemplate = new DataGridViewTextBoxCell();
                column_SzuletesiEv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView_Tagok.Columns.Insert(4, column_SzuletesiEv);

        }
        private void Tagok_Adattabla_Update()
        {
            Program.sql.CommandText = "SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel` ORDER BY `nev`;";
            using (MySqlDataReader dr = Program.sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    int uj_sor_index = dataGridView_Tagok.Rows.Add();

                    DataGridViewRow uj_sor = dataGridView_Tagok.Rows[uj_sor_index];
                    uj_sor.Cells["ID"].Value = dr.GetInt32("azon");
                    uj_sor.Cells["Nev"].Value = dr.GetString("nev");
                    uj_sor.Cells["Orszag"].Value = dr.GetString("orsz");
                    uj_sor.Cells["Iranyitoszam"].Value = dr.GetInt32("irszam");
                    uj_sor.Cells["SzuletesiEv"].Value = dr.GetInt32("szulev");
                }
            }
        }

        private void Befizetesek_Adattabla_beallitasai()
        {
            dataGridView_Befizetesek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Befizetesek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewColumn column_ID = new DataGridViewColumn();
            {
                column_ID.HeaderText = "ID";
                column_ID.Name = "ID";
                column_ID.Visible = false;
                column_ID.CellTemplate = new DataGridViewTextBoxCell();
            }
            DataGridViewColumn column_Datum = new DataGridViewColumn();
            {
                column_Datum.HeaderText = "Befizetés dátuma";
                column_Datum.Name = "Datum";
                column_Datum.ValueType = typeof(DateTime);
                column_Datum.DefaultCellStyle.Format = "yyyy-MM-dd";
                column_Datum.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_Datum.CellTemplate = new DataGridViewTextBoxCell();
            }
            DataGridViewColumn column_Osszeg = new DataGridViewColumn();
            {
                column_Osszeg.HeaderText = "Befizetett összeg";
                column_Osszeg.Name = "Osszeg";
                column_Osszeg.ValueType = typeof(int);
                column_Osszeg.DefaultCellStyle.Format = "c0";
                column_Osszeg.CellTemplate = new DataGridViewTextBoxCell();
                column_Osszeg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dataGridView_Befizetesek.Columns.Insert(0, column_ID);
            dataGridView_Befizetesek.Columns.Insert(1, column_Datum);
            dataGridView_Befizetesek.Columns.Insert(2, column_Osszeg);
        }

        private void dataGridView_Tagok_SelectionChanged(object sender, EventArgs e)
        {
            //-- A táblázaton belül kattintott a felhasználó ------------------------
            DataGridViewRow kivalasztott = dataGridView_Tagok.SelectedRows[0];
            dataGridView_Befizetesek.Rows.Clear();
            if (kivalasztott.Cells["ID"].Value != null)
            {
                textBox_Nev.Text = kivalasztott.Cells["Nev"].Value.ToString();
                textBox_Orszag.Text = kivalasztott.Cells["Orszag"].Value.ToString();
                numericUpDown_Iranyitoszam.Value = (int)kivalasztott.Cells["Iranyitoszam"].Value;
                numericUpDown_SzuletesiEv.Value = (int)kivalasztott.Cells["SzuletesiEv"].Value;
                //-- Befizetések táblázat frissítése -----------------
                Befizetesek_Tabla_Update((int)kivalasztott.Cells["ID"].Value);
            }
            else
            {
                textBox_Nev.Text = "";
                textBox_Orszag.Text = "";
                numericUpDown_Iranyitoszam.Value = numericUpDown_Iranyitoszam.Minimum;
                numericUpDown_SzuletesiEv.Value = numericUpDown_SzuletesiEv.Maximum;
            }
        }
        private void Befizetesek_Tabla_Update(int id)
        {
            //-- Befizetések táblázat frissítése -----------------
            Program.sql.Parameters.Clear();
            Program.sql.CommandText = "SELECT `datum`,`osszeg`  FROM `befiz` WHERE `azon` = @id;";
            Program.sql.Parameters.AddWithValue("@id", id);
            try
            {
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    dataGridView_Befizetesek.Rows.Clear();
                    while (dr.Read())
                    {
                        int row_index = dataGridView_Befizetesek.Rows.Add();
                        DataGridViewRow row = dataGridView_Befizetesek.Rows[row_index];
                        row.Cells["Datum"].Value = dr.GetDateTime("datum");
                        row.Cells["Osszeg"].Value = dr.GetInt32("osszeg");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.kivalasztott_tag = dataGridView_Tagok.SelectedRows[0];
            Program.form_Befizetes.ShowDialog();
            this.Show();
            Befizetesek_Tabla_Update((int)Program.kivalasztott_tag.Cells["ID"].Value);
        }
    }
}
