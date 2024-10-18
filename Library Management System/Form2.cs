using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "pasindu", password = "pasindu123", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(username) && pass.Equals(password))
            {
                //login
                
                Form3 obj = new Form3();
                this.Hide();
                obj.Show();

            }
            else
            {
                //dont login
                MessageBox.Show("Try Again");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
