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
using MetroSet_UI.Forms;


namespace Learning_DB
{
    public partial class AdminInterface : KryptonForm
    {
        public AdminInterface()
        {
            InitializeComponent();
            User_Name.Text = "Admin";
        }


        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {

        }

        private void User_Name_Click(object sender, EventArgs e)
        {

        }

        private void AdminTextBox_FirstName_Enter(object sender, EventArgs e)
        {
            if (AdminTextBox_FirstName.Text == "Enter Admin's First Name")
            {
                AdminTextBox_FirstName.Text = "";
                AdminTextBox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_FirstName.StateCommon.Content.Color1 = Color.Black;

            }
        }

        private void AdminTextBox_FirstName_Leave(object sender, EventArgs e)
        {
            if(AdminTextBox_FirstName.Text == "")
            {
                AdminTextBox_FirstName.Text = "Enter Admin's First Name";
                AdminTextBox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_FirstName.StateCommon.Content.Color1 = Color.Gray;

            }
        }

        private void AdminTextBox_LastName_Enter(object sender, EventArgs e)
        {
            if (AdminTextBox_LastName.Text == "Enter Admin's Last Name")
            {
                AdminTextBox_LastName.Text = "";
                AdminTextBox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_LastName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminTextBox_LastName_Leave(object sender, EventArgs e)
        {
            if (AdminTextBox_LastName.Text == "")
            {
                AdminTextBox_LastName.Text = "Enter Admin's Last Name";
                AdminTextBox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_LastName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminTextBox_Email_Enter(object sender, EventArgs e)
        {
            if (AdminTextBox_Email.Text == "Enter Admin's Email")
            {
                AdminTextBox_Email.Text = "";
                AdminTextBox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_Email.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminTextBox_Email_Leave(object sender, EventArgs e)
        {
            if (AdminTextBox_Email.Text == "")
            {
                AdminTextBox_Email.Text = "Enter Admin's Email";
                AdminTextBox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_Email.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminTextBox_Username_Enter(object sender, EventArgs e)
        {
            if (AdminTextBox_Username.Text == "Enter Admin's Username")
            {
                AdminTextBox_Username.Text = "";
                AdminTextBox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_Username.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminTextBox_Username_Leave(object sender, EventArgs e)
        {
            if (AdminTextBox_Username.Text == "")
            {
                AdminTextBox_Username.Text = "Enter Admin's Username";
                AdminTextBox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_Username.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminTextBox_Password_Enter(object sender, EventArgs e)
        {
            if (AdminTextBox_Password.Text == "Enter Admin's Password")
            {
                AdminTextBox_Password.Text = "";
                AdminTextBox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_Password.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminTextBox_Password_Leave(object sender, EventArgs e)
        {
            if (AdminTextBox_Password.Text == "")
            {
                AdminTextBox_Password.Text = "Enter Admin's Password";
                AdminTextBox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_Password.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminETextBox_FirstName_Enter(object sender, EventArgs e)
        {
            if (AdminETextBox_FirstName.Text == "Enter Admin's First Name")
            {
                AdminETextBox_FirstName.Text = "";
                AdminETextBox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_FirstName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_FirstName_Leave(object sender, EventArgs e)
        {
            if (AdminETextBox_FirstName.Text == "")
            {
                AdminETextBox_FirstName.Text = "Enter Admin's First Name";
                AdminETextBox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_FirstName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminETextBox_LastName_Enter(object sender, EventArgs e)
        {
            if (AdminETextBox_LastName.Text == "Enter Admin's Last Name")
            {
                AdminETextBox_LastName.Text = "";
                AdminETextBox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_LastName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_LastName_Leave(object sender, EventArgs e)
        {
            if (AdminETextBox_LastName.Text == "")
            {
                AdminETextBox_LastName.Text = "Enter Admin's Last Name";
                AdminETextBox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_LastName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminETextBox_Email_Enter(object sender, EventArgs e)
        {
            if (AdminETextBox_Email.Text == "Enter Admin's Email")
            {
                AdminETextBox_Email.Text = "";
                AdminETextBox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_Email.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_Email_Leave(object sender, EventArgs e)
        {
            if (AdminETextBox_Email.Text == "")
            {
                AdminETextBox_Email.Text = "Enter Admin's Email";
                AdminETextBox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_Email.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminETextBox_Username_Enter(object sender, EventArgs e)
        {
            if (AdminETextBox_Username.Text == "Enter Admin's Username")
            {
                AdminETextBox_Username.Text = "";
                AdminETextBox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_Username.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_Username_Leave(object sender, EventArgs e)
        {
            if (AdminETextBox_Username.Text == "")
            {
                AdminETextBox_Username.Text = "Enter Admin's Username";
                AdminETextBox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_Username.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminETextBox_ID_Enter(object sender, EventArgs e)
        {
            if (AdminETextBox_ID.Text == "Search by Admin's ID")
            {
                AdminETextBox_ID.Text = "";
                AdminETextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_ID.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_ID_Leave(object sender, EventArgs e)
        {
            if (AdminETextBox_ID.Text == "")
            {
                AdminETextBox_ID.Text = "Search by Admin's ID";
                AdminETextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminETextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEComboBox_Name_Enter(object sender, EventArgs e)
        {
            if (AdminEComboBox_Name.Text == "Search by Admin's Name")
            {
                AdminEComboBox_Name.Text = "";
                AdminEComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void AdminEComboBox_Name_Leave(object sender, EventArgs e)
        {
            if (AdminEComboBox_Name.Text == "")
            {
                AdminEComboBox_Name.Text = "Search by Admin's Name";
                AdminEComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
        }

        private void AdminHTextBox_ID_Enter(object sender, EventArgs e)
        {
            if (AdminHTextBox_ID.Text == "Search by Admin's ID")
            {
                AdminHTextBox_ID.Text = "";
                AdminHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminHTextBox_ID.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminHTextBox_ID_Leave(object sender, EventArgs e)
        {
            if (AdminHTextBox_ID.Text == "")
            {
                AdminHTextBox_ID.Text = "Search by Admin's ID";
                AdminHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminHComboBox_Name_Enter(object sender, EventArgs e)
        {
            if (AdminHComboBox_Name.Text == "Search by Admin's Name")
            {
                AdminHComboBox_Name.Text = "";
                AdminHComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminHComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void AdminHComboBox_Name_Leave(object sender, EventArgs e)
        {
            if (AdminHComboBox_Name.Text == "")
            {
                AdminHComboBox_Name.Text = "Search by Admin's Name";
                AdminHComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminHComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
        }

        private void InstructorHTextBox_ID_Enter(object sender, EventArgs e)
        {
            if (InstructorHTextBox_ID.Text == "Search by Instructor's ID")
            {
                InstructorHTextBox_ID.Text = "";
                InstructorHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorHTextBox_ID.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void InstructorHTextBox_ID_Leave(object sender, EventArgs e)
        {
            if (InstructorHTextBox_ID.Text == "")
            {
                InstructorHTextBox_ID.Text = "Search by Instructor's ID";
                InstructorHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void InstructorHComboBox_Name_Enter(object sender, EventArgs e)
        {
            if (InstructorHComboBox_Name.Text == "Search by Instructor's Name")
            {
                InstructorHComboBox_Name.Text = "";
                InstructorHComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorHComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void InstructorHComboBox_Name_Leave(object sender, EventArgs e)
        {
            if (InstructorHComboBox_Name.Text == "")
            {
                InstructorHComboBox_Name.Text = "Search by Instructor's Name";
                InstructorHComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorHComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
        }

        private void StudentHTextBox_ID_Enter(object sender, EventArgs e)
        {
            if (StudentHTextBox_ID.Text == "Search by Student's ID")
            {
                StudentHTextBox_ID.Text = "";
                StudentHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentHTextBox_ID.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void StudentHTextBox_ID_Leave(object sender, EventArgs e)
        {
            if (StudentHTextBox_ID.Text == "")
            {
                StudentHTextBox_ID.Text = "Search by Student's ID";
                StudentHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void StudentHComboBox_Name_Enter(object sender, EventArgs e)
        {
            if (StudentHComboBox_Name.Text == "Search by Student's Name")
            {
                StudentHComboBox_Name.Text = "";
                StudentHComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentHComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void StudentHComboBox_Name_Leave(object sender, EventArgs e)
        {
            if (StudentHComboBox_Name.Text == "")
            {
                StudentHComboBox_Name.Text = "Search by Student's Name";
                StudentHComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentHComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_LogOutButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login_Form login = new Login_Form();
            login.Show();
            
        }
    }
    
}
