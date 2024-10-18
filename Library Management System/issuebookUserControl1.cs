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
    public partial class issuebookUserControl1 : UserControl
    {
        private static issuebookUserControl1 _instance;

        public static issuebookUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new issuebookUserControl1();
                }
                return _instance;
            }
        }
        public issuebookUserControl1()
        {
            InitializeComponent();
        }

        private void issuebooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.issuebooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salgadoDatabase1DataSet1);

        }

        private void author_s_NameTextBox_TextChanged(object sender, EventArgs e)
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
