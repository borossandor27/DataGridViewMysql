using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dataGridView_Tagok.ColumnCount = 6;
            //-- Az id oszlop --------------------------------------------------
            dataGridView_Tagok.Columns[0].Name = "id";
            //-- A kijelölés oszlop --------------------------------------------------
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            {
                column.HeaderText = "V";
                column.Name = "Kijelolve";
                column.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.DisplayedCells;
                column.FlatStyle = FlatStyle.Standard;
                column.ThreeState = true;
                column.CellTemplate = new DataGridViewCheckBoxCell();
                column.CellTemplate.Style.BackColor = Color.Beige;
            }
            dataGridView_Tagok.Columns.Insert(1, column);

            //-- A név oszlop --------------------------------------------------
            DataGridViewColumn column_Nev = new DataGridViewColumn();
            {
                column_Nev.HeaderText = "Név";
            }
            dataGridView_Tagok.Columns.Insert(2, column_Nev);

        }
    }
}
