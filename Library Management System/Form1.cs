﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
