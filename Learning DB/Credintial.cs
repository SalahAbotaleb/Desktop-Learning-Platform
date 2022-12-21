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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Learning_DB
{
    public partial class Credintial : KryptonForm
    {
        public Credintial()
        {
            InitializeComponent();
            kryptonLabel2.Visible = false;
        }


        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter your Username")
            {
                kryptonTextBox1.Text = "";
                kryptonTextBox1.ForeColor = Color.Black;
            }

        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text = "Enter your Username";
                kryptonTextBox1.ForeColor = Color.Gray;
            }
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter your Password")
            {
                kryptonTextBox2.Text = "";
                kryptonTextBox2.ForeColor = Color.Black;
            }
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text = "Enter your Password";
                kryptonTextBox2.ForeColor = Color.Gray;
            }
        }

        bool valid = true; // for validation (will be changed in future validation in username and password)
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (valid)
            {
                kryptonLabel2.Visible = true;

            }
            AdminInterface A = new AdminInterface();
            A.Show();
        }
    }
}
