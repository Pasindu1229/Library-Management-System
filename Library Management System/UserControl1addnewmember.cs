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
    public partial class UserControl1addnewmember : UserControl
    {
        private static UserControl1addnewmember _instance;

        public static UserControl1addnewmember Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl1addnewmember();
                }
                return _instance;
            }
        }
        public UserControl1addnewmember()
        {
            InitializeComponent();
        }

        





        private void addnewbookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addnewbookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 obj = new Form3();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
