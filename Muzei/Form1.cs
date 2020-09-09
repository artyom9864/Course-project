using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Muzei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string defpath = "users.xml";

        private void Registracia_Load(object sender, EventArgs e)
        {
            if (!File.Exists(defpath)) CreateXMLDocument(defpath);
        }

        private void CreateXMLDocument(string filepath)
        {
            XmlTextWriter xtw = new XmlTextWriter(filepath, Encoding.UTF32);
            xtw.WriteStartDocument();
            xtw.WriteStartElement("users");
            xtw.WriteEndDocument();
            xtw.Close();
        }


        private string MaxID(string filepath)
        {
            List<int> idList = new List<int>();
            int id;
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(filepath, FileMode.Open);
            xd.Load(fs);
            XmlNodeList list = xd.GetElementsByTagName("user");
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    XmlElement user = (XmlElement)xd.GetElementsByTagName("user")[i];
                    id = Convert.ToInt32(user.GetAttribute("id"));
                    idList.Add(id);
                }
                int result = 0;
                foreach (int j in idList)
                    if (j > result)
                        result = j;
                result++;
                fs.Close();
                return result.ToString();
            }
            else
            {
                fs.Close();
                return "1";
            }
        }


       

        private void WriteToXMLDocument(string filepath, string name, string pwd)
        {
            if (!File.Exists(defpath)) CreateXMLDocument(defpath);
            string id = MaxID(filepath);
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(filepath, FileMode.Open);
            xd.Load(fs);

            XmlElement user = xd.CreateElement("user");
            user.SetAttribute("id", id);

            XmlElement login = xd.CreateElement("login");
            XmlElement pass = xd.CreateElement("password");

            XmlText tLogin = xd.CreateTextNode(name);
            XmlText tPassword = xd.CreateTextNode(pwd);

            login.AppendChild(tLogin);
            pass.AppendChild(tPassword);

            user.AppendChild(login);
            user.AppendChild(pass);

            xd.DocumentElement.AppendChild(user);

            fs.Close();
            xd.Save(filepath);
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "") & !(textBox2.Text == ""))
            {
                if ((textBox2.Text == textBox3.Text))
                {
                    WriteToXMLDocument(defpath, textBox1.Text, textBox2.Text);
                    MessageBox.Show("Регистрация прошла успешно!");
                    Close();
                }
                else
                    MessageBox.Show("Парроли не совпадают");

            }
            else MessageBox.Show("Введите имя пользователя и пароль");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
