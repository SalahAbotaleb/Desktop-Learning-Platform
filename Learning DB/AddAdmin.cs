using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DbHandler;

namespace Learning_DB
{
    public partial class AddAdmin : KryptonForm
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Admin's First Name")
            {
                kryptonTextBox1.Text = "";
                kryptonTextBox1.ForeColor = Color.Black;
            }
            
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text = "Enter Admin's First Name";
                kryptonTextBox1.ForeColor = Color.Gray;

            }
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Admin's Last Name")
            {
                kryptonTextBox2.Text = "";
                kryptonTextBox2.ForeColor = Color.Black;
            }
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text = "Enter Admin's First Name";
                kryptonTextBox2.ForeColor = Color.Gray;

            }
        }

        private void kryptonTextBox3_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Enter Admin's Email")
            {
                kryptonTextBox3.Text = "";
                kryptonTextBox3.ForeColor = Color.Black;
            }
        }

        private void kryptonTextBox3_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text = "Enter Admin's First Name";
                kryptonTextBox3.ForeColor = Color.Gray;

            }
        }
    }
}
