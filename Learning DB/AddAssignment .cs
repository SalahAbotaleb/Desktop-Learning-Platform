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
using MetroSet_UI.Forms;

namespace Learning_DB
{
    public partial class AddAssignment : KryptonForm
    {
        public AddAssignment()
        {
            InitializeComponent();
            ChooseCourse_ComboBox.DataSource = StoredProcedures.SelectClassforInstructorbyID;
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

        private void Course_Label_Click(object sender, EventArgs e)
        {

        }

        private void ChooseCourse_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
