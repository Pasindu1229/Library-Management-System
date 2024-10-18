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
    
    public partial class UserControl1addnewbook : UserControl
    {
        private static UserControl1addnewbook _instance;

        public static UserControl1addnewbook Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl1addnewbook();
                }
                return _instance; 
            }
        }
        public UserControl1addnewbook()
        {
            InitializeComponent();
        }

        private void addnewbookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addnewbookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1COMPLETE_PROJECTDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            this.Hide();
            obj.Show();
        }

        private void author_s_NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
