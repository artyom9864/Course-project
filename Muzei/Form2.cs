using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Muzei
{
    public partial class Form2 : Form
    {

        private int x = 0; private int y = 0;


        public Form2()
        {
            InitializeComponent();
        }

        public string defpath = "users.xml";
        public string filepath;

    

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }



       

       


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button1.PerformClick();
            }
        }


        private void Avtorizacia_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }


        private void Avtorizacia_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }



        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("users.xml");

            string name, pwd;
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(defpath, FileMode.Open);
            xd.Load(fs);
            XmlNodeList list = xd.GetElementsByTagName("user");

            for (int i = 0; i < list.Count; i++)
            {
                XmlElement user = (XmlElement)xd.GetElementsByTagName("login")[i];
                XmlElement pass = (XmlElement)xd.GetElementsByTagName("password")[i];
                name = user.InnerText;
                pwd = pass.InnerText;
                if ((textBox1.Text == name) & (textBox2.Text == pwd))
                {
                    this.Hide();
                    Form3 frm = new Form3();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                    break;
                }
                else if (i == list.Count - 1) MessageBox.Show("Неверный логин или пароль");
            }
            fs.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ну, тогда не судьба(");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
