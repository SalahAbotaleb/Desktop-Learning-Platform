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
        Controller Controller = new Controller();
        public AdminInterface()
        {
            InitializeComponent();
            User_Name.Text = "Admin";
            Controller = new Controller();
            
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
            if (AdminEAdminTextBox_FirstName.Text == "Enter Admin's First Name")
            {
                AdminEAdminTextBox_FirstName.Text = "";
                AdminEAdminTextBox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_FirstName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_FirstName_Leave(object sender, EventArgs e)
        {
            if (AdminEAdminTextBox_FirstName.Text == "")
            {
                AdminEAdminTextBox_FirstName.Text = "Enter Admin's First Name";
                AdminEAdminTextBox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_FirstName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminETextBox_LastName_Enter(object sender, EventArgs e)
        {
            if (AdminEAdminTextBox_LastName.Text == "Enter Admin's Last Name")
            {
                AdminEAdminTextBox_LastName.Text = "";
                AdminEAdminTextBox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_LastName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_LastName_Leave(object sender, EventArgs e)
        {
            if (AdminEAdminTextBox_LastName.Text == "")
            {
                AdminEAdminTextBox_LastName.Text = "Enter Admin's Last Name";
                AdminEAdminTextBox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_LastName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminETextBox_Email_Enter(object sender, EventArgs e)
        {
            if (AdminEAdminTextBox_Email.Text == "Enter Admin's Email")
            {
                AdminEAdminTextBox_Email.Text = "";
                AdminEAdminTextBox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_Email.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_Email_Leave(object sender, EventArgs e)
        {
            if (AdminEAdminTextBox_Email.Text == "")
            {
                AdminEAdminTextBox_Email.Text = "Enter Admin's Email";
                AdminEAdminTextBox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_Email.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminETextBox_Username_Enter(object sender, EventArgs e)
        {
            if (AdminEAdminTextBox_Username.Text == "Enter Admin's Username")
            {
                AdminEAdminTextBox_Username.Text = "";
                AdminEAdminTextBox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_Username.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_Username_Leave(object sender, EventArgs e)
        {
            if (AdminEAdminTextBox_Username.Text == "")
            {
                AdminEAdminTextBox_Username.Text = "Enter Admin's Username";
                AdminEAdminTextBox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_Username.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminETextBox_ID_Enter(object sender, EventArgs e)
        {
            if (AdminEAdminTextBox_ID.Text == "Search by Admin's ID")
            {
                AdminEAdminTextBox_ID.Text = "";
                AdminEAdminTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_ID.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminETextBox_ID_Leave(object sender, EventArgs e)
        {
            if (AdminEAdminTextBox_ID.Text == "")
            {
                AdminEAdminTextBox_ID.Text = "Search by Admin's ID";
                AdminEAdminTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEComboBox_Name_Enter(object sender, EventArgs e)
        {
            if (Instructor_Title_ComboBox.Text == "Search by Admin's Name")
            {
                Instructor_Title_ComboBox.Text = "";
                Instructor_Title_ComboBox.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                Instructor_Title_ComboBox.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void AdminEComboBox_Name_Leave(object sender, EventArgs e)
        {

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

        private void InstructorTextbox_FirstName_Enter(object sender, EventArgs e)
        {
            if (InstructorTextbox_FirstName.Text == "Enter Instructor's First Name")
            {
                InstructorTextbox_FirstName.Text = "";
                InstructorTextbox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_FirstName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void InstructorTextbox_FirstName_Leave(object sender, EventArgs e)
        {
            if (InstructorTextbox_FirstName.Text == "")
            {
                InstructorTextbox_FirstName.Text = "Enter Instructor's First Name";
                InstructorTextbox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_FirstName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void InstructorTextbox_LastName_Enter(object sender, EventArgs e)
        {
            if (InstructorTextbox_LastName.Text == "Enter Instructor's Last Name")
            {
                InstructorTextbox_LastName.Text = "";
                InstructorTextbox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_LastName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void InstructorTextbox_LastName_Leave(object sender, EventArgs e)
        {
            if (InstructorTextbox_LastName.Text == "")
            {
                InstructorTextbox_LastName.Text = "Enter Instructor's Last Name";
                InstructorTextbox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_LastName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void InstructorTextbox_Email_Enter(object sender, EventArgs e)
        {
            if (InstructorTextbox_Email.Text == "Enter Instructor's Email")
            {
                InstructorTextbox_Email.Text = "";
                InstructorTextbox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_Email.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void InstructorTextbox_Email_Leave(object sender, EventArgs e)
        {
            if (InstructorTextbox_Email.Text == "")
            {
                InstructorTextbox_Email.Text = "Enter Instructor's Email";
                InstructorTextbox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_Email.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void InstructorTextbox_Username_Enter(object sender, EventArgs e)
        {
            if (InstructorTextbox_Username.Text == "Enter Instructor's Username")
            {
                InstructorTextbox_Username.Text = "";
                InstructorTextbox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_Username.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void InstructorTextbox_Username_Leave(object sender, EventArgs e)
        {
            if (InstructorTextbox_Username.Text == "")
            {
                InstructorTextbox_Username.Text = "Enter Instructor's Username";
                InstructorTextbox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_Username.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void InstructorTextbox_Password_Enter(object sender, EventArgs e)
        {
            if (InstructorTextbox_Password.Text == "Enter Instructor's Password")
            {
                InstructorTextbox_Password.Text = "";
                InstructorTextbox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_Password.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void InstructorTextbox_Password_Leave(object sender, EventArgs e)
        {
            if (InstructorTextbox_Password.Text == "")
            {
                InstructorTextbox_Password.Text = "Enter Instructor's Password";
                InstructorTextbox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_Password.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void Instructor_Title_ComboBox_Enter(object sender, EventArgs e)
        {
            if (Instructor_Title_ComboBox.Text == "Select Instructor's Title")
            {
                Instructor_Title_ComboBox.Text = "";
                Instructor_Title_ComboBox.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                Instructor_Title_ComboBox.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void Instructor_Title_ComboBox_Leave(object sender, EventArgs e)
        {
            if (Instructor_Title_ComboBox.Text == "")
            {
                Instructor_Title_ComboBox.Text = "Select Instructor's Title";
                Instructor_Title_ComboBox.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                Instructor_Title_ComboBox.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEInstructorTextbox_FirstName_Enter(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_FirstName.Text == "Enter Instructor's First Name")
            {
                AdminEInstructorTextbox_FirstName.Text = "";
                AdminEInstructorTextbox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_FirstName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEInstructorTextbox_FirstName_Leave(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_FirstName.Text == "")
            {
                AdminEInstructorTextbox_FirstName.Text = "Enter Instructor's First Name";
                AdminEInstructorTextbox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_FirstName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEInstructorTextbox_LastName_Enter(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_LastName.Text == "Enter Instructor's Last Name")
            {
                AdminEInstructorTextbox_LastName.Text = "";
                AdminEInstructorTextbox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_LastName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEInstructorTextbox_LastName_Leave(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_LastName.Text == "")
            {
                AdminEInstructorTextbox_LastName.Text = "Enter Instructor's Last Name";
                AdminEInstructorTextbox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_LastName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEInstructorTextbox_Email_Enter(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_Email.Text == "Enter Instructor's Email")
            {
                AdminEInstructorTextbox_Email.Text = "";
                AdminEInstructorTextbox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_Email.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEInstructorTextbox_Email_Leave(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_Email.Text == "")
            {
                AdminEInstructorTextbox_Email.Text = "Enter Instructor's Email";
                AdminEInstructorTextbox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_Email.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEInstructorTextbox_Username_Enter(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_Username.Text == "Enter Instructor's Username")
            {
                AdminEInstructorTextbox_Username.Text = "";
                AdminEInstructorTextbox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_Username.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEInstructorTextbox_Username_Leave(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_Username.Text == "")
            {
                AdminEInstructorTextbox_Username.Text = "Enter Instructor's Username";
                AdminEInstructorTextbox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_Username.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEInstructorTextbox_Title_Enter(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_Title.Text == "Enter Instructor's Title")
            {
                AdminEInstructorTextbox_Title.Text = "";
                AdminEInstructorTextbox_Title.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_Title.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void AdminEInstructorTextbox_Title_Leave(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_Title.Text == "")
            {
                AdminEInstructorTextbox_Title.Text = "Enter Instructor's Title";
                AdminEInstructorTextbox_Title.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_Title.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEInstructorTextbox_ID_Enter(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_ID.Text == "Search by Instructor's ID")
            {
                AdminEInstructorTextbox_ID.Text = "";
                AdminEInstructorTextbox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_ID.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEInstructorTextbox_ID_Leave(object sender, EventArgs e)
        {
            if (AdminEInstructorTextbox_ID.Text == "")
            {
                AdminEInstructorTextbox_ID.Text = "Search by Instructor's ID";
                AdminEInstructorTextbox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEInstructorCombobox_Name_Enter(object sender, EventArgs e)
        {
            if (AdminEInstructorCombobox_Name.Text == "Choose Instructor's Title")
            {
                AdminEInstructorCombobox_Name.Text = "";
                AdminEInstructorCombobox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorCombobox_Name.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void AdminEInstructorCombobox_Name_Leave(object sender, EventArgs e)
        {
            if (AdminEInstructorCombobox_Name.Text == "")
            {
                AdminEInstructorCombobox_Name.Text = "Choose Instructor's Title";
                AdminEInstructorCombobox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorCombobox_Name.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEStudentTextBox_FirstName_Enter(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_FirstName.Text == "Enter Student's First Name")
            {
                AdminEStudentTextBox_FirstName.Text = "";
                AdminEStudentTextBox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_FirstName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEStudentTextBox_FirstName_Leave(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_FirstName.Text == "")
            {
                AdminEStudentTextBox_FirstName.Text = "Enter Student's First Name";
                AdminEStudentTextBox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_FirstName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEStudentTextBox_LastName_Enter(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_LastName.Text == "Enter Student's Last Name")
            {
                AdminEStudentTextBox_LastName.Text = "";
                AdminEStudentTextBox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_LastName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEStudentTextBox_LastName_Leave(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_LastName.Text == "")
            {
                AdminEStudentTextBox_LastName.Text = "Enter Student's Last Name";
                AdminEStudentTextBox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_LastName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEStudentTextBox_Email_Enter(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_Email.Text == "Enter Student's Email")
            {
                AdminEStudentTextBox_Email.Text = "";
                AdminEStudentTextBox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_Email.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEStudentTextBox_Email_Leave(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_Email.Text == "")
            {
                AdminEStudentTextBox_Email.Text = "Enter Student's Email";
                AdminEStudentTextBox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_Email.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEStudentTextBox_Username_Enter(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_Username.Text == "Enter Student's Username")
            {
                AdminEStudentTextBox_Username.Text = "";
                AdminEStudentTextBox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_Username.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEStudentTextBox_Username_Leave(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_Username.Text == "")
            {
                AdminEStudentTextBox_Username.Text = "Enter Student's Username";
                AdminEStudentTextBox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_Username.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEStudentTextBox_Level_Enter(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_Level.Text == "Enter Student's Level")
            {
                AdminEStudentTextBox_Level.Text = "";
                AdminEStudentTextBox_Level.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_Level.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEStudentTextBox_Level_Leave(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_Level.Text == "")
            {
                AdminEStudentTextBox_Level.Text = "Enter Student's Level";
                AdminEStudentTextBox_Level.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_Level.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEStudentTextBox_ID_Enter(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_ID.Text == "Search by Student's ID")
            {
                AdminEStudentTextBox_ID.Text = "";
                AdminEStudentTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_ID.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminEStudentTextBox_ID_Leave(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_ID.Text == "")
            {
                AdminEStudentTextBox_ID.Text = "Search by Student's ID";
                AdminEStudentTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEStudentTextBox_Name_Enter(object sender, EventArgs e)
        {
            if (AdminEStudentTextBox_Name.Text == "Choose Student's Name")
            {
                AdminEStudentTextBox_Name.Text = "";
                AdminEStudentTextBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentTextBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void AdminECourseTextBox_Name_Enter(object sender, EventArgs e)
        {
            if (AdminECourseTextBox_Name.Text == "Enter Course Name")
            {
                AdminECourseTextBox_Name.Text = "";
                AdminECourseTextBox_Name.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminECourseTextBox_Name.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminECourseTextBox_Name_Leave(object sender, EventArgs e)
        {
            if (AdminECourseTextBox_Name.Text == "")
            {
                AdminECourseTextBox_Name.Text = "Enter Course Name";
                AdminECourseTextBox_Name.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminECourseTextBox_Name.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminECourseTextBox_Description_Enter(object sender, EventArgs e)
        {
            if (AdminECourseTextBox_Description.Text == "Enter Course's Description")
            {
                AdminECourseTextBox_Description.Text = "";
                AdminECourseTextBox_Description.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminECourseTextBox_Description.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminECourseTextBox_Description_Leave(object sender, EventArgs e)
        {
            if (AdminECourseTextBox_Description.Text == "")
            {
                AdminECourseTextBox_Description.Text = "Enter Course's Description";
                AdminECourseTextBox_Description.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminECourseTextBox_Description.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminECourseTextBox_ID_Enter(object sender, EventArgs e)
        {
            if (AdminECourseTextBox_ID.Text == "Enter Course's ID")
            {
                AdminECourseTextBox_ID.Text = "";
                AdminECourseTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminECourseTextBox_ID.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminECourseTextBox_ID_Leave(object sender, EventArgs e)
        {
            if (AdminECourseTextBox_ID.Text == "")
            {
                AdminECourseTextBox_ID.Text = "Enter Course's ID";
                AdminECourseTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminECourseTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminECourseComboBox_Name_Enter(object sender, EventArgs e)
        {
            if (AdminECourseComboBox_Name.Text == "Choose Course's Name")
            {
                AdminECourseComboBox_Name.Text = "";
                AdminECourseComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminECourseComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Black;
            }
        }

        private void AdminECourseComboBox_Name_Leave(object sender, EventArgs e)
        {
            if (AdminECourseComboBox_Name.Text == "")
            {
                AdminECourseComboBox_Name.Text = "Choose Course's Name";
                AdminECourseComboBox_Name.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminECourseComboBox_Name.StateCommon.ComboBox.Content.Color1 = Color.Gray;
            }
        }

        private void StudentTextbox_FirstName_Enter(object sender, EventArgs e)
        {
            if (StudentTextbox_FirstName.Text == "Enter Student's First Name")
            {
                StudentTextbox_FirstName.Text = "";
                StudentTextbox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_FirstName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void StudentTextbox_FirstName_Leave(object sender, EventArgs e)
        {
            if (StudentTextbox_FirstName.Text == "")
            {
                StudentTextbox_FirstName.Text = "Enter Student's First Name";
                StudentTextbox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_FirstName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void StudentTextbox_LastName_Enter(object sender, EventArgs e)
        {
            if (StudentTextbox_LastName.Text == "Enter Student's Last Name")
            {
                StudentTextbox_LastName.Text = "";
                StudentTextbox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_LastName.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void StudentTextbox_LastName_Leave(object sender, EventArgs e)
        {
            if (StudentTextbox_LastName.Text == "")
            {
                StudentTextbox_LastName.Text = "Enter Student's Last Name";
                StudentTextbox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_LastName.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void StudentTextbox_Email_Enter(object sender, EventArgs e)
        {
            if (StudentTextbox_Email.Text == "Enter Student's Email")
            {
                StudentTextbox_Email.Text = "";
                StudentTextbox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_Email.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void StudentTextbox_Email_Leave(object sender, EventArgs e)
        {
            if (StudentTextbox_Email.Text == "")
            {
                StudentTextbox_Email.Text = "Enter Student's Email";
                StudentTextbox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_Email.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void StudentTextbox_Username_Enter(object sender, EventArgs e)
        {
            if (StudentTextbox_Username.Text == "Enter Student's Username")
            {
                StudentTextbox_Username.Text = "";
                StudentTextbox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_Username.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void StudentTextbox_Username_Leave(object sender, EventArgs e)
        {
            if (StudentTextbox_Username.Text == "")
            {
                StudentTextbox_Username.Text = "Enter Student's Username";
                StudentTextbox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_Username.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void StudentTextbox_Password_Enter(object sender, EventArgs e)
        {
            if (StudentTextbox_Password.Text == "Enter Student's Password")
            {
                StudentTextbox_Password.Text = "";
                StudentTextbox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_Password.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void StudentTextbox_Password_Leave(object sender, EventArgs e)
        {
            if (StudentTextbox_Password.Text == "")
            {
                StudentTextbox_Password.Text = "Enter Student's Password";
                StudentTextbox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_Password.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void StudentTextbox_Level_Enter(object sender, EventArgs e)
        {
            if (StudentTextbox_Level.Text == "Enter Student's Level")
            {
                StudentTextbox_Level.Text = "";
                StudentTextbox_Level.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_Level.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void StudentTextbox_Level_Leave(object sender, EventArgs e)
        {
            if (StudentTextbox_Level.Text == "")
            {
                StudentTextbox_Level.Text = "Enter Student's Level";
                StudentTextbox_Level.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_Level.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void StudentTextbox_BOD_Enter(object sender, EventArgs e)
        {
            if (StudentTextbox_BOD.Text == "Enter Student's Birth Date")
            {
                StudentTextbox_BOD.Text = "";
                StudentTextbox_BOD.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_BOD.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void StudentTextbox_BOD_Leave(object sender, EventArgs e)
        {
            if (StudentTextbox_BOD.Text == "")
            {
                StudentTextbox_BOD.Text = "Enter Student's Birth Date";
                StudentTextbox_BOD.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_BOD.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void AdminEStudentTextBox_Name_Leave(object sender, EventArgs e)
        {
            
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            Tuple<int, string> result = Controller.InsertAdmin(AdminTextBox_Username.Text, AdminTextBox_FirstName.Text, AdminTextBox_LastName.Text, AdminTextBox_Email.Text, OpenedSession.ID, AdminTextBox_Password.Text);
            if (result.Item1 == 0)
            {
                MessageBox.Show(result.Item2);
            }
            else
            {
                MessageBox.Show("Admin added successfuly");
            }
        }
    }
    
}
