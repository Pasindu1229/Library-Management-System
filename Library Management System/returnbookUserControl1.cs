using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class returnbookUserControl1 : UserControl
    {
        private static returnbookUserControl1 _instance;

        public static returnbookUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new returnbookUserControl1();
                }
                return _instance;
            }
        }
        public returnbookUserControl1()
        {
            InitializeComponent();
        }

        private void returnbooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.returnbooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salgadoDatabase1DataSet1);

        }

        private void data_ReturnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            this.Hide();
            obj.Show();
        }
    }
}
