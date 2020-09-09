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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 kat1 = new Form6();
            kat1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 kat2 = new Form7();
            kat2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 kat3 = new Form8();
            kat3.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
