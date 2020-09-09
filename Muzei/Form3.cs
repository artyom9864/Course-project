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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 personal = new Form4();
            personal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 muz = new Form5();
            muz.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://127.0.0.1/index.php");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"Get_Me_Started.chm";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
