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
    public partial class Sign_Up : KryptonForm
    {
        Controller Controller = new Controller();
        int AID = 20;
        public Sign_Up()
        {
            InitializeComponent();
            Sign_UpComboBox_UserType.DataSource = new List<string> { "Admin", "Instructor", "Student" };

        }

        private void Sign_UpButton_Click(object sender, EventArgs e)
        {
            if(Sign_UpTextbox_FirstName.Text == "")
            {
                MessageBox.Show("Please enter your first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Sign_UpTextbox_LastName.Text == "")
            {
                MessageBox.Show("Please enter your last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Sign_UpTextbox_Email.Text == "")
            {
                MessageBox.Show("Please enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(Sign_UpTextbox_Username.Text == "")
            {
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Sign_UpTextbox_Password.Text == "")
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Sign_UpComboBox_UserType.SelectedIndex == 0)
            {
                //Admin
                Tuple<int, string> result = Controller.InsertAdmin(Sign_UpTextbox_Username.Text, Sign_UpTextbox_FirstName.Text, Sign_UpTextbox_LastName.Text, Sign_UpTextbox_Email.Text, AID , Sign_UpTextbox_Password.Text);

                if (result.Item1 == 0)
                {
                    MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Tuple<int, string> edit = Controller.ActivateAdmin(Convert.ToInt32(Controller.SelectLastAdmin().Rows[0][0]), false);
                    if (edit.Item1 == 0)
                    {
                        MessageBox.Show(edit.Item2);
                    }
                    else
                    {
                        MessageBox.Show("You Successfully Signed Up as an Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else if (Sign_UpComboBox_UserType.SelectedIndex == 1)
            {
                //Instructor
                Tuple<int, string> result = Controller.InsertInstructor(Sign_UpTextbox_Username.Text, Sign_UpTextbox_FirstName.Text, Sign_UpTextbox_LastName.Text, Sign_UpTextbox_Email.Text, AID, Sign_UpTextbox_Password.Text, Sign_UpComboBox_Title.Text);
                if (result.Item1 == 0)
                {
                    MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Tuple<int, string> edit = Controller.ActivateInstructor(Convert.ToInt32(Controller.SelectLastInstructor().Rows[0][0]), false,AID);
                    if (edit.Item1 == 0)
                    {
                        MessageBox.Show(edit.Item2);
                    }
                    else
                    {
                        MessageBox.Show("You Successfully Signed Up as an Instructor", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (Sign_UpComboBox_UserType.SelectedIndex == 2)
            {
                //Student
                if (Sign_UpTextbox_Level.Text == "")
                {
                    MessageBox.Show("Please enter your level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToInt32(Sign_UpTextbox_Level.Text) < 1 || Convert.ToInt32(Sign_UpTextbox_Level.Text) > 12)
                {
                    MessageBox.Show("Please Enter Student's Level between 1 and 12 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Tuple<int, string> add = Controller.InsertStudent(Sign_UpTextbox_Username.Text, Sign_UpTextbox_FirstName.Text, Sign_UpTextbox_LastName.Text, Sign_UpTextbox_Email.Text, AID , Sign_UpTextbox_Password.Text, Sign_UpDateTimePicker_BOD.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(Sign_UpTextbox_Level.Text));
                if (add.Item1 == 0)
                {
                    MessageBox.Show(add.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Tuple<int, string> edit = Controller.ActivateStudent(Convert.ToInt32(Controller.SelectLastStudent().Rows[0][0]), false, AID);
                    if (edit.Item1 == 0)
                    {
                        MessageBox.Show(edit.Item2);
                    }
                    else
                    {
                        MessageBox.Show("You Successfully Signed Up as an Student", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            Sign_UpTextbox_FirstName.Clear();
            Sign_UpTextbox_LastName.Clear();
            Sign_UpTextbox_Email.Clear();
            Sign_UpTextbox_Username.Clear();
            Sign_UpTextbox_Password.Clear();
            Sign_UpTextbox_Level.Clear();
            Sign_UpComboBox_Title.SelectedIndex = -1;
            
        }

        private void Sign_UpComboBox_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sign_UpComboBox_UserType.SelectedIndex == 0)
            {
                Sign_UpComboBox_Title.Enabled = false;
                Sign_UpTextbox_Level.Enabled = false;
                Sign_UpDateTimePicker_BOD.Enabled = false;
                Sign_UpComboBox_Title.Text = "";
                Sign_UpTextbox_Level.Text = "";
            }
            else if(Sign_UpComboBox_UserType.SelectedIndex == 1)
            {
                Sign_UpComboBox_Title.Enabled = true;
                Sign_UpTextbox_Level.Enabled = false;
                Sign_UpDateTimePicker_BOD.Enabled = false;
                Sign_UpTextbox_Level.Text = "";
                Sign_UpComboBox_Title.DataSource = new List<string> { "Prof.", "Dr.", "Eng.", "Mr.", "Mrs." };


            }
            else if (Sign_UpComboBox_UserType.SelectedIndex == 2)
            {
                Sign_UpComboBox_Title.Enabled = false;
                Sign_UpTextbox_Level.Enabled = true;
                Sign_UpDateTimePicker_BOD.Enabled = true;
                Sign_UpComboBox_Title.SelectedIndex = -1;
            }
        }

        private void Sign_UpTextbox_Level_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void Sign_UpTextbox_Password_Enter(object sender, EventArgs e)
        {
            Sign_UpTextbox_Password.PasswordChar = '*';
            
        }
    }
}
