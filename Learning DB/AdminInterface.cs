using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbHandler;
using ComponentFactory.Krypton.Toolkit;


namespace Learning_DB
{
    public partial class AdminInterface : KryptonForm
    {
        public AdminInterface()
        {
            InitializeComponent();
            User_Name.Text = "Admin";
            MessageBox.Show("ssss");
        }

   

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ssss");
            User_Name.Text = "Admissssssssssn";
        }

     
    }
    
}
