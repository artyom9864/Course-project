using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzei
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "muzDataSet3.Скульптуры". При необходимости она может быть перемещена или удалена.
            this.скульптурыTableAdapter.Fill(this.muzDataSet3.Скульптуры);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.скульптурыTableAdapter.Update(this.muzDataSet3.Скульптуры);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var row = senderGrid.SelectedCells[0];
                var index = row.Value.ToString();

                switch (index)
                {
                    case "1":
                        skulpt2 sk = new skulpt2();
                        sk.ShowDialog();
                        break;
                    case "2":
                        Давид kart1 = new Давид();
                        kart1.ShowDialog();
                        break;
                    case "3":

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
