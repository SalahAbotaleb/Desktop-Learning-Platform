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
    public partial class InstructorReports : KryptonForm
    {
        Controller Controller = new Controller();
        
        int Student_ID;
        int check = 0;
        //TODO ya zahar
        public InstructorReports()
        {
            InitializeComponent();
            InstructorStatistics.SelectedIndex = 0;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            InstructorStatistics.SelectedIndex = 1;

        }

        private void kryptonRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
            IRComboBox_StudentUsername.SelectedIndex = -1;
            IRComboBox_StudentUsername.Enabled = false;
            IRTextBox_StudentID.Enabled = true;
            IRTextBox_FName.Clear();
            IRTextBox_LName.Clear();

        }

        private void IRTextBox_StudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void IRTextBox_StudentID_Enter(object sender, EventArgs e)
        {
            if (IRTextBox_StudentID.Text == "Search by Student's ID")
            {
                IRTextBox_StudentID.Text = "";
                IRTextBox_StudentID.ForeColor = Color.Black;
            }
            IRTextBox_FName.Clear();
            IRTextBox_LName.Clear();
        }

        private void IRTextBox_StudentID_Leave(object sender, EventArgs e)
        {
            if (IRTextBox_StudentID.Text == "")
            {
                IRTextBox_StudentID.Text = "Search by Student's ID";
                IRTextBox_StudentID.ForeColor = Color.Gray;
            }
        }

        private void kryptonRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            check = 2;
            IRTextBox_StudentID.Text = "Search by Student's ID";
            IRTextBox_StudentID.ForeColor = Color.Gray;
            IRTextBox_StudentID.Enabled = false;
            IRComboBox_StudentUsername.Enabled = true;
            IRComboBox_StudentUsername.DataSource = Controller.SelectStudent_UsernameByClassroomID(7);
            IRComboBox_StudentUsername.DisplayMember = "Username";
            IRComboBox_StudentUsername.ValueMember = "StudentID";
            IRTextBox_FName.Clear();
            IRTextBox_LName.Clear();

        }

        private void IRButton_Search_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                if (IRTextBox_StudentID.Text == "Search by Student ID")
                {
                    MessageBox.Show("Please Enter a Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt = Controller.SelectStudentByClassroomID( 7   , Convert.ToInt32(IRTextBox_StudentID.Text));
                if ( dt!= null)
                {
                    IRTextBox_FName.Text = dt.Rows[0]["FName"].ToString();
                    IRTextBox_LName.Text = dt.Rows[0]["LName"].ToString();
                }
                else
                {
                    MessageBox.Show("Student ID Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (check == 2)
            {
                DataTable dt = Controller.SelectStudent_UsernameByClassroomID(7);

                if (dt != null)
                {
                    IRTextBox_FName.Text = dt.Rows[IRComboBox_StudentUsername.SelectedIndex]["FName"].ToString();
                    IRTextBox_LName.Text = dt.Rows[IRComboBox_StudentUsername.SelectedIndex]["LName"].ToString();
                }
                else
                {
                    MessageBox.Show("Student ID Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Search Method");
            }
        }
    }
}
