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
    public partial class paymentUserControl1 : UserControl
    {
          
        private static paymentUserControl1 _instance;

        public static paymentUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new paymentUserControl1();
                }
                return _instance;
            }
        }
        public paymentUserControl1()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salgadoDatabase1DataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            this.Hide();
            obj.Show();
        }
    }
}
