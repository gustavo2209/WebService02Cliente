using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebService02Cliente
{
    public partial class Form1 : Form
    {

        private BaldorWs.WebServiceBaldor baldor;

        public Form1()
        {
            InitializeComponent();
            baldor = new BaldorWs.WebServiceBaldor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] v = new string[3] { textBox1.Text, textBox2.Text, textBox3.Text };

            textBox5.Text = baldor.Promedio(v);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] v = new string[3] { textBox1.Text, textBox2.Text, textBox3.Text };

            textBox5.Text = baldor.Maximo(v);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] v = new string[3] { textBox1.Text, textBox2.Text, textBox3.Text };

            textBox5.Text = baldor.Minimo(v);
        }
    }
}
