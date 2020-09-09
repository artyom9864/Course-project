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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

       

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "muzDataSet2.Фотографии". При необходимости она может быть перемещена или удалена.
            this.фотографииTableAdapter.Fill(this.muzDataSet2.Фотографии);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid1 = (DataGridView)sender;

            if (senderGrid1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var sels = senderGrid1.SelectedCells[0];
                var index1 = sels.Value.ToString();

                switch (index1)
                {
                    case "1":
                        obed foto1 = new obed();
                        foto1.ShowDialog();
                        break;
                    case "2":
                        photo2 ph = new photo2();
                        ph.ShowDialog();
                        break;
                    case "3":

                        break;
                    default:
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.фотографииTableAdapter.Update(this.muzDataSet2.Фотографии);

        }
    }
}

