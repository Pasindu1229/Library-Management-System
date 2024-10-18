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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void addnewbookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(! panel2.Controls.Contains(UserControl1addnewmember.Instance))
            {
                panel2.Controls.Add(UserControl1addnewmember.Instance);
                UserControl1addnewmember.Instance.Dock = DockStyle.Fill;
                UserControl1addnewmember.Instance.BringToFront();
            }
            else
            {
                UserControl1addnewmember.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(UserControl1addnewbook.Instance))
            {
                panel2.Controls.Add(UserControl1addnewbook.Instance);
                UserControl1addnewbook.Instance.Dock = DockStyle.Fill;
                UserControl1addnewbook.Instance.BringToFront();
            }
            else
            {
                UserControl1addnewbook.Instance.BringToFront();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(issuebookUserControl1.Instance))
            {
                panel2.Controls.Add(issuebookUserControl1.Instance);
                issuebookUserControl1.Instance.Dock = DockStyle.Fill;
                issuebookUserControl1.Instance.BringToFront();
            }
            else
            {
                issuebookUserControl1.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(returnbookUserControl1.Instance))
            {
                panel2.Controls.Add(returnbookUserControl1.Instance);
                returnbookUserControl1.Instance.Dock = DockStyle.Fill;
                returnbookUserControl1.Instance.BringToFront();
            }
            else
            {
                returnbookUserControl1.Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(paymentUserControl1.Instance))
            {
                panel2.Controls.Add(paymentUserControl1.Instance);
                paymentUserControl1.Instance.Dock = DockStyle.Fill;
                paymentUserControl1.Instance.BringToFront();
            }
            else
            {
                paymentUserControl1.Instance.BringToFront();
            }
        }
    }
}
