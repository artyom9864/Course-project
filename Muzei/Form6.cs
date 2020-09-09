using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Muzei
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "muzDataSet1.Картины". При необходимости она может быть перемещена или удалена.
            this.картиныTableAdapter.Fill(this.muzDataSet1.Картины);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var row = senderGrid.SelectedRows[0];
                var index = row.Cells[0].Value.ToString();

                switch (index)
                {
                    case "1":
                        Kartina1 kart1 = new Kartina1();
                        kart1.ShowDialog();
                        break;
                    case "2":
                        kartina2 kart2 = new kartina2();
                        kart2.ShowDialog();
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
            this.картиныTableAdapter.Update(this.muzDataSet1.Картины);

        }
    }
}

       /* public static DataTable dt = new DataTable();

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dataGridView2.DataSource = null;
            try
            {
                OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Muz.accdb");
                connect.Open();
                dt.Rows.Clear();
                dt.Columns.Clear();
                OleDbCommand command = connect.CreateCommand();

                command.CommandText = "SELECT Картины.Наименование AS ss1, Картины.Артикул AS ss2, Картины.Количество AS ss3, Картины.Цена AS ss4 " +
                                        "FROM Картины ";
                                        //"WHERE (((Картины.[№])="+ dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() + "));";
                MessageBox.Show(command.CommandText);
                OleDbDataReader read = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (read.HasRows)
                {
                    MessageBox.Show(read[0].ToString());
                    dt.Load(read);
                }
                read.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView2.DataSource = dt; 
        }
    }
}*/
