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
using System.Runtime.Remoting.Messaging;

namespace Learning_DB
{
    public partial class AdminInterface : KryptonForm
    {
        Controller Controller = new Controller();
        int checkA = 0;
        int checkI = 0;
        int checkS = 0;
        int checkC = 0;
        int checkH = 0;
        bool okA = false;
        bool okI = false;
        bool okS = false;
        public AdminInterface()
        {
            InitializeComponent();
            AdminName_Label.Text = Controller.SelectAdminByID(OpenedSession.ID).Rows[0][0].ToString();
            Instructor_Title_ComboBox.DataSource = new List<string> { "Prof.", "Dr.", "Eng.", "Mr.", "Mrs." };
            AdminRComboBox_Username.DataSource = Controller.SelectAdminToBeActivated();
            AdminRComboBox_Username.DisplayMember = "Username";
            AdminRComboBox_Username.ValueMember = "Admin_ID";
            InstructorRComboBox_Username.DataSource = Controller.SelectInstructorToBeActivated();
            InstructorRComboBox_Username.DisplayMember = "Username";
            InstructorRComboBox_Username.ValueMember = "Instructor_ID";
            StudentRComboBox_Username.DataSource = Controller.SelectStudentToBeActivated();
            StudentRComboBox_Username.DisplayMember = "Username";
            StudentRComboBox_Username.ValueMember = "StudentID";
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
            if (AdminTextBox_FirstName.Text == "")
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
                AdminTextBox_Password.PasswordChar = '*';
                AdminTextBox_Password.Text = "";
                AdminTextBox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminTextBox_Password.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void AdminTextBox_Password_Leave(object sender, EventArgs e)
        {
            if (AdminTextBox_Password.Text == "")
            {
                AdminTextBox_Password.PasswordChar = '\0';
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
                InstructorTextbox_Password.PasswordChar = '*';
                InstructorTextbox_Password.Text = "";
                InstructorTextbox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_Password.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void InstructorTextbox_Password_Leave(object sender, EventArgs e)
        {
            if (InstructorTextbox_Password.Text == "")
            {
                InstructorTextbox_Password.PasswordChar = '\0';
                InstructorTextbox_Password.Text = "Enter Instructor's Password";
                InstructorTextbox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                InstructorTextbox_Password.StateCommon.Content.Color1 = Color.Gray;
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
            if (AdminEStudentComboBox_Username.Text == "Choose Student's Name")
            {
                AdminEStudentComboBox_Username.Text = "";
                AdminEStudentComboBox_Username.StateCommon.ComboBox.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEStudentComboBox_Username.StateCommon.ComboBox.Content.Color1 = Color.Black;
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
            if (AdminECourseTextBox_ID.Text == "Search by Course's ID")
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
                AdminECourseTextBox_ID.Text = "Search by's ID";
                AdminECourseTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminECourseTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
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
                StudentTextbox_Password.PasswordChar = '*';
                StudentTextbox_Password.Text = "";
                StudentTextbox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                StudentTextbox_Password.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void StudentTextbox_Password_Leave(object sender, EventArgs e)
        {
            if (StudentTextbox_Password.Text == "")
            {
                StudentTextbox_Password.PasswordChar = '\0';
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

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            if (AdminTextBox_FirstName.Text == "Enter Admin's First Name" || AdminTextBox_FirstName.Text == "")
            {
                MessageBox.Show("Please Enter Admin's Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AdminTextBox_LastName.Text == "Enter Admin's Last Name" || AdminTextBox_LastName.Text == "")
            {
                MessageBox.Show("Please Enter Admin's Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AdminTextBox_Email.Text == "Enter Admin's Email" || AdminTextBox_Email.Text == "")
            {
                MessageBox.Show("Please Enter Admin's Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AdminTextBox_Username.Text == "Enter Admin's Username" || AdminTextBox_Username.Text == "")
            {
                MessageBox.Show("Please Enter Admin's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AdminTextBox_Password.Text == "Enter Admin's Password" || AdminTextBox_Password.Text == "")
            {
                MessageBox.Show("Please Enter Admin's Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tuple<int, string> result = Controller.InsertAdmin(AdminTextBox_Username.Text, AdminTextBox_FirstName.Text, AdminTextBox_LastName.Text, AdminTextBox_Email.Text, OpenedSession.ID, AdminTextBox_Password.Text);
                if (result.Item1 == 0)
                {
                    MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Admin Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminTextBox_FirstName.Text = "Enter Admin's First Name";
                    AdminTextBox_LastName.Text = "Enter Admin's Last Name";
                    AdminTextBox_Email.Text = "Enter Admin's Email";
                    AdminTextBox_Username.Text = "Enter Admin's Username";
                    AdminTextBox_Password.Text = "Enter Admin's Password";
                }
            }

        }

        private void AdminEAdminButton_Edit_Click(object sender, EventArgs e)
        {
            if (checkA == 1)
            {
                if (AdminEAdminTextBox_ID.Text == "Search by Admin's ID")
                {
                    MessageBox.Show("Please Enter Admin's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Tuple<int, string> edit = Controller.UpdateAdmin(Convert.ToInt32(AdminEAdminTextBox_ID.Text), AdminEAdminTextBox_Username.Text, AdminEAdminTextBox_FirstName.Text, AdminEAdminTextBox_LastName.Text, AdminEAdminTextBox_Email.Text);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Admin Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (checkA == 2)
            {
                if (AdminEAdminTextBox_FirstName.Text == "Enter Admin's First Name")
                {
                    MessageBox.Show("Please Enter Admin's First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AdminEAdminTextBox_LastName.Text == "Enter Admin's Last Name")
                {
                    MessageBox.Show("Please Enter Admin's Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AdminEAdminTextBox_Email.Text == "Enter Admin's Email")
                {
                    MessageBox.Show("Please Enter Admin's Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AdminEAdminTextBox_Username.Text == "Enter Admin's Username")
                {
                    MessageBox.Show("Please Enter Admin's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Tuple<int, string> edit = Controller.UpdateAdmin(Convert.ToInt32(AdminEAdminComboBox_Username.SelectedValue), AdminEAdminTextBox_Username.Text, AdminEAdminTextBox_FirstName.Text, AdminEAdminTextBox_LastName.Text, AdminEAdminTextBox_Email.Text);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Admin Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AdminEAdminButton_Search_Click(object sender, EventArgs e)
        {

            if (checkA == 1)
            {
                if (AdminEAdminTextBox_ID.Text == "Search by Admin's ID")
                {
                    MessageBox.Show("Please Enter Admin's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt = Controller.SelectAdminByID_SuperID(OpenedSession.ID, Convert.ToInt32(AdminEAdminTextBox_ID.Text));
                if (dt != null)
                {
                    AdminEAdminTextBox_FirstName.Text = dt.Rows[0]["FName"].ToString();
                    AdminEAdminTextBox_LastName.Text = dt.Rows[0]["LName"].ToString();
                    AdminEAdminTextBox_Email.Text = dt.Rows[0]["Email"].ToString();
                    AdminEAdminTextBox_Username.Text = dt.Rows[0]["Username"].ToString();
                }
                else
                {
                    MessageBox.Show("No Available Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (checkA == 2)
            {
                DataTable dt = Controller.SelectAdminBySuper_ID(OpenedSession.ID);
                if (dt != null)
                {


                    AdminEAdminTextBox_FirstName.Text = Controller.SelectAdminBySuper_ID(OpenedSession.ID).Rows[AdminEAdminComboBox_Username.SelectedIndex][0].ToString();
                    AdminEAdminTextBox_LastName.Text = Controller.SelectAdminBySuper_ID(OpenedSession.ID).Rows[AdminEAdminComboBox_Username.SelectedIndex][1].ToString();
                    AdminEAdminTextBox_Email.Text = Controller.SelectAdminBySuper_ID(OpenedSession.ID).Rows[AdminEAdminComboBox_Username.SelectedIndex][2].ToString();
                    AdminEAdminTextBox_Username.Text = Controller.SelectAdminBySuper_ID(OpenedSession.ID).Rows[AdminEAdminComboBox_Username.SelectedIndex][3].ToString();
                }
                else
                {
                    MessageBox.Show("No Available Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AdminEAdminTextBox_FirstName.StateCommon.Content.Color1 = Color.Black;
            AdminEAdminTextBox_LastName.StateCommon.Content.Color1 = Color.Black;
            AdminEAdminTextBox_Email.StateCommon.Content.Color1 = Color.Black;
            AdminEAdminTextBox_Username.StateCommon.Content.Color1 = Color.Black;
        }

        private void AdminRadioButton_SearchID_Click(object sender, EventArgs e)
        {
            checkA = 1;
        }

        private void AdminRadioButton_SearchUsername_Click(object sender, EventArgs e)
        {
            checkA = 2;
            AdminEAdminTextBox_ID.Text = "Search by Admin's ID";
            AdminEAdminTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            AdminEAdminTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            DataTable dt = Controller.SelectAdminBySuper_ID(OpenedSession.ID);
            if (dt != null)
            {
                AdminEAdminComboBox_Username.DataSource = Controller.SelectAdminUsernameByID(OpenedSession.ID);
                AdminEAdminComboBox_Username.DisplayMember = "Username";
                AdminEAdminComboBox_Username.ValueMember = "Admin_ID";

            }
            else
            {
                MessageBox.Show("No Available Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AddInstructorButton_Click(object sender, EventArgs e)
        {
            if (InstructorTextbox_FirstName.Text == "Enter Instructor's First Name" || InstructorTextbox_FirstName.Text == "")
            {
                MessageBox.Show("Please Enter Instructor's First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (InstructorTextbox_LastName.Text == "Enter Instructor's Last Name" || InstructorTextbox_LastName.Text == "")
            {
                MessageBox.Show("Please Enter Instructor's Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (InstructorTextbox_Email.Text == "Enter Instructor's Email" || InstructorTextbox_Email.Text == "")
            {
                MessageBox.Show("Please Enter Instructor's Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (InstructorTextbox_Username.Text == "Enter Instructor's Username" || InstructorTextbox_Username.Text == "")
            {
                MessageBox.Show("Please Enter Instructor's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (InstructorTextbox_Password.Text == "Enter Instructor's Password" || InstructorTextbox_Password.Text == "")
            {
                MessageBox.Show("Please Enter Instructor's Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tuple<int, string> result = Controller.InsertInstructor(InstructorTextbox_Username.Text, InstructorTextbox_FirstName.Text, InstructorTextbox_LastName.Text, InstructorTextbox_Email.Text, OpenedSession.ID, InstructorTextbox_Password.Text, Instructor_Title_ComboBox.Text);
                if (result.Item1 == 0)
                {
                    MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Instructor Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InstructorTextbox_FirstName.Text = "Enter Instructor's First Name";
                    InstructorTextbox_FirstName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                    InstructorTextbox_FirstName.StateCommon.Content.Color1 = Color.Gray;
                    InstructorTextbox_LastName.Text = "Enter Instructor's Last Name";
                    InstructorTextbox_LastName.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                    InstructorTextbox_LastName.StateCommon.Content.Color1 = Color.Gray;
                    InstructorTextbox_Email.Text = "Enter Instructor's Email";
                    InstructorTextbox_Email.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                    InstructorTextbox_Email.StateCommon.Content.Color1 = Color.Gray;
                    InstructorTextbox_Username.Text = "Enter Instructor's Username";
                    InstructorTextbox_Username.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                    InstructorTextbox_Username.StateCommon.Content.Color1 = Color.Gray;
                    InstructorTextbox_Password.Text = "Enter Instructor's Password";
                    InstructorTextbox_Password.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                    InstructorTextbox_Password.StateCommon.Content.Color1 = Color.Gray;
                    
                }
            }
            
        }

        private void InstructorRadioButton_SearchID_Click(object sender, EventArgs e)
        {
            checkI = 1;
        }

        private void InstructorRadioButton_SearchUsername_Click(object sender, EventArgs e)
        {
            checkI = 2;
            AdminEInstructorTextbox_ID.Text = "Search by Instructor's ID";
            AdminEInstructorTextbox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            AdminEInstructorTextbox_ID.StateCommon.Content.Color1 = Color.Gray;
            DataTable dt = Controller.SelectAllInstructor_Username();
            if (dt != null)
            {
                AdminEInstructorCombobox_Username.DataSource = dt;
                AdminEInstructorCombobox_Username.DisplayMember = "Username";
                AdminEInstructorCombobox_Username.ValueMember = "Instructor_ID";
            }
            else
            {
                MessageBox.Show("No Available Instructor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AdminEInstructorButton_Search_Click(object sender, EventArgs e)
        {
            if (checkI == 1)
            {
                if (AdminEInstructorTextbox_ID.Text == "Search by Instructor's ID")
                {
                    MessageBox.Show("Please Enter an Instructor's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AdminEInstructorComboBox_Title.DataSource = new List<string> { "Prof.", "Dr.", "Eng.", "Mr.", "Mrs." };

                DataTable dt = Controller.SelectInstructorByID(Convert.ToInt32(AdminEInstructorTextbox_ID.Text));
                if (dt != null)
                {
                    AdminEInstructorTextbox_FirstName.Text = dt.Rows[0][0].ToString();
                    AdminEInstructorTextbox_LastName.Text = dt.Rows[0][1].ToString();
                    AdminEInstructorTextbox_Email.Text = dt.Rows[0][2].ToString();
                    AdminEInstructorTextbox_Username.Text = dt.Rows[0][3].ToString();
                    AdminEInstructorComboBox_Title.Text = dt.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No Available Instructor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (checkI == 2)
            {
                AdminEInstructorComboBox_Title.DataSource = new List<string> { "Prof.", "Dr.", "Eng.", "Mr.", "Mrs." };

                DataTable dt = Controller.SelectAllInstructor_Username();
                if (dt != null)
                {
                    AdminEInstructorTextbox_FirstName.Text = dt.Rows[AdminEInstructorCombobox_Username.SelectedIndex][2].ToString();
                    AdminEInstructorTextbox_LastName.Text = dt.Rows[AdminEInstructorCombobox_Username.SelectedIndex][3].ToString();
                    AdminEInstructorTextbox_Email.Text = dt.Rows[AdminEInstructorCombobox_Username.SelectedIndex][5].ToString();
                    AdminEInstructorTextbox_Username.Text = dt.Rows[AdminEInstructorCombobox_Username.SelectedIndex][0].ToString();
                    AdminEInstructorComboBox_Title.Text = dt.Rows[AdminEInstructorCombobox_Username.SelectedIndex][6].ToString();

                }
                else
                {
                    MessageBox.Show("No Available Instructor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AdminEInstructorTextbox_FirstName.StateCommon.Content.Color1 = Color.Black;
            AdminEInstructorTextbox_LastName.StateCommon.Content.Color1 = Color.Black;
            AdminEInstructorTextbox_Email.StateCommon.Content.Color1 = Color.Black;
            AdminEInstructorTextbox_Username.StateCommon.Content.Color1 = Color.Black;
        }

        private void AdminEAdminTextBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void AdminEInstructorTextbox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void AdminEStudentTextBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void AdminEInstructorButton_Edit_Click(object sender, EventArgs e)
        {
            if (checkI == 1)
            {
                if (AdminEInstructorTextbox_ID.Text == "Search by Instructor's ID")
                {
                    MessageBox.Show("Please Enter an Instructor's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Tuple<int, string> edit = Controller.UpdateInstructor(Convert.ToInt32(AdminEInstructorTextbox_ID.Text), AdminEInstructorTextbox_Username.Text, AdminEInstructorTextbox_FirstName.Text, AdminEInstructorTextbox_LastName.Text, AdminEInstructorTextbox_Email.Text, AdminEInstructorComboBox_Title.Text, null, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Instructor Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (checkI == 2)
            {
                if (AdminEInstructorTextbox_FirstName.Text == "Enter Instructor's First Name")
                {
                    MessageBox.Show("Please Enter an Instructor's First Name");
                    return;
                }
                if (AdminEInstructorTextbox_LastName.Text == "Enter Instructor's Last Name")
                {
                    MessageBox.Show("Please Enter an Instructor's Last Name");
                    return;
                }
                if (AdminEInstructorTextbox_Email.Text == "Enter Instructor's Email")
                {
                    MessageBox.Show("Please Enter an Instructor's Email");
                    return;
                }
                if (AdminEInstructorTextbox_Username.Text == "Enter Instructor's Username")
                {
                    MessageBox.Show("Please Enter an Instructor's Username");
                    return;
                }

                Tuple<int, string> edit = Controller.UpdateInstructor(Convert.ToInt32(AdminEInstructorCombobox_Username.SelectedValue), AdminEInstructorTextbox_Username.Text, AdminEInstructorTextbox_FirstName.Text, AdminEInstructorTextbox_LastName.Text, AdminEInstructorTextbox_Email.Text, AdminEInstructorComboBox_Title.Text, null, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Instructor Updated Successfuly");
                }
            }
        }

        private void InstructorRadioButton_SearchUsername_CheckedChanged(object sender, EventArgs e)
        {
            AdminEInstructorCombobox_Username.Enabled = true;
            AdminEInstructorTextbox_ID.Enabled = false;
        }

        private void InstructorRadioButton_SearchID_CheckedChanged(object sender, EventArgs e)
        {
            AdminEInstructorCombobox_Username.Enabled = false;
            AdminEInstructorTextbox_ID.Enabled = true;
            AdminEInstructorCombobox_Username.SelectedIndex = -1;

        }

        private void AdminRadioButton_SearchID_CheckedChanged(object sender, EventArgs e)
        {
            AdminEAdminTextBox_ID.Enabled = true;
            AdminEAdminComboBox_Username.Enabled = false;
            AdminEAdminComboBox_Username.SelectedIndex = -1;
        }

        private void AdminRadioButton_SearchUsername_CheckedChanged(object sender, EventArgs e)
        {
            AdminEAdminTextBox_ID.Enabled = false;
            AdminEAdminComboBox_Username.Enabled = true;
        }

        private void AdminEAdminButton_Activate_Click(object sender, EventArgs e)
        {
            if (checkA == 1)
            {
                if (AdminEAdminTextBox_ID.Text == "Search by Admin's ID")
                {
                    MessageBox.Show("Please Enter Admin's ID");
                    return;
                }
                Tuple<int, string> edit = Controller.ActivateAdmin(Convert.ToInt32(AdminEAdminTextBox_ID.Text), true);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Admin Activated Successfuly");
                }
            }
            else if (checkA == 2)
            {
                if (AdminEAdminTextBox_FirstName.Text == "Enter Admin's First Name")
                {
                    MessageBox.Show("Please Enter Admin's First Name");
                    return;
                }
                if (AdminEAdminTextBox_LastName.Text == "Enter Admin's Last Name")
                {
                    MessageBox.Show("Please Enter Admin's Last Name");
                    return;
                }
                if (AdminEAdminTextBox_Email.Text == "Enter Admin's Email")
                {
                    MessageBox.Show("Please Enter Admin's Email");
                    return;
                }
                if (AdminEAdminTextBox_Username.Text == "Enter Admin's Username")
                {
                    MessageBox.Show("Please Enter Admin's Username");
                    return;
                }
                Tuple<int, string> edit = Controller.ActivateAdmin(Convert.ToInt32(AdminEAdminComboBox_Username.SelectedValue), true);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Admin Activated Successfuly");
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method");
                return;
            }
        }

        private void AdminEAdminButton_DeActivate_Click(object sender, EventArgs e)
        {
            if (checkA == 1)
            {
                if (AdminEAdminTextBox_ID.Text == "Search by Admin's ID")
                {
                    MessageBox.Show("Please Enter Admin's ID");
                    return;
                }
                Tuple<int, string> edit = Controller.ActivateAdmin(Convert.ToInt32(AdminEAdminTextBox_ID.Text), false);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Admin Deactivated Successfuly");
                }
            }
            else if (checkA == 2)
            {
                if (AdminEAdminTextBox_FirstName.Text == "Enter Admin's First Name")
                {
                    MessageBox.Show("Please Enter Admin's First Name");
                    return;
                }
                if (AdminEAdminTextBox_LastName.Text == "Enter Admin's Last Name")
                {
                    MessageBox.Show("Please Enter Admin's Last Name");
                    return;
                }
                if (AdminEAdminTextBox_Email.Text == "Enter Admin's Email")
                {
                    MessageBox.Show("Please Enter Admin's Email");
                    return;
                }
                if (AdminEAdminTextBox_Username.Text == "Enter Admin's Username")
                {
                    MessageBox.Show("Please Enter Admin's Username");
                    return;
                }
                Tuple<int, string> edit = Controller.ActivateAdmin(Convert.ToInt32(AdminEAdminComboBox_Username.SelectedValue), false);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Admin Deactivated Successfuly");
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method");
                return;
            }

        }

        private void AdminEInstructorButton_Activate_Click(object sender, EventArgs e)
        {
            if (checkI == 1)
            {
                if (AdminEInstructorTextbox_ID.Text == "Search by Instructor's ID")
                {
                    MessageBox.Show("Please Enter Instructor's ID");
                    return;
                }
                Tuple<int, string> edit = Controller.ActivateInstructor(Convert.ToInt32(AdminEInstructorTextbox_ID.Text), true, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Instructor Activated Successfuly");
                }
            }
            else if (checkI == 2)
            {
                if (AdminEInstructorTextbox_FirstName.Text == "Enter Instructor's First Name")
                {
                    MessageBox.Show("Please Enter Instructor's First Name");
                    return;
                }
                if (AdminEInstructorTextbox_LastName.Text == "Enter Instructor's Last Name")
                {
                    MessageBox.Show("Please Enter Instructor's Last Name");
                    return;
                }
                if (AdminEInstructorTextbox_Email.Text == "Enter Instructor's Email")
                {
                    MessageBox.Show("Please Enter Instructor's Email");
                    return;
                }
                if (AdminEInstructorTextbox_Username.Text == "Enter Instructor's Username")
                {
                    MessageBox.Show("Please Enter Instructor's Username");
                    return;
                }
                Tuple<int, string> edit = Controller.ActivateInstructor(Convert.ToInt32(AdminEInstructorCombobox_Username.SelectedValue), true, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Instructor Activated Successfuly");
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method");
                return;
            }
        }

        private void AdminEInstructorButton_DeActivate_Click(object sender, EventArgs e)
        {
            if (checkI == 1)
            {
                if (AdminEInstructorTextbox_ID.Text == "Search by Instructor's ID")
                {
                    MessageBox.Show("Please Enter Instructor's ID");
                    return;
                }
                Tuple<int, string> edit = Controller.ActivateInstructor(Convert.ToInt32(AdminEInstructorTextbox_ID.Text), false, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Instructor Deactivated Successfuly");
                }
            }
            else if (checkI == 2)
            {
                if (AdminEInstructorTextbox_FirstName.Text == "Enter Instructor's First Name")
                {
                    MessageBox.Show("Please Enter Instructor's First Name");
                    return;
                }
                if (AdminEInstructorTextbox_LastName.Text == "Enter Instructor's Last Name")
                {
                    MessageBox.Show("Please Enter Instructor's Last Name");
                    return;
                }
                if (AdminEInstructorTextbox_Email.Text == "Enter Instructor's Email")
                {
                    MessageBox.Show("Please Enter Instructor's Email");
                    return;
                }
                if (AdminEInstructorTextbox_Username.Text == "Enter Instructor's Username")
                {
                    MessageBox.Show("Please Enter Instructor's Username");
                    return;
                }
                Tuple<int, string> edit = Controller.ActivateInstructor(Convert.ToInt32(AdminEInstructorCombobox_Username.SelectedValue), false, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Instructor Deactivated Successfuly");
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method");
                return;
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentTextbox_FirstName.Text == "Enter Student's First Name" || StudentTextbox_FirstName.Text == "")
            {
                MessageBox.Show("Please Enter Student's First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (StudentTextbox_LastName.Text == "Enter Student's Last Name" || StudentTextbox_LastName.Text == "")
            {
                MessageBox.Show("Please Enter Student's Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (StudentTextbox_Email.Text == "Enter Student's Email" || StudentTextbox_Email.Text == "")
            {
                MessageBox.Show("Please Enter Student's Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (StudentTextbox_Username.Text == "Enter Student's Username" || StudentTextbox_Username.Text == "")
            {
                MessageBox.Show("Please Enter Student's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (StudentTextbox_Password.Text == "Enter Student's Password" || StudentTextbox_Password.Text == "")
            {
                MessageBox.Show("Please Enter Student's Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (StudentTextbox_Level.Text == "Enter Student's Level" || StudentTextbox_Level.Text == "")
            {
                MessageBox.Show("Please Enter Student's Level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(StudentTextbox_Level.Text) < 1 || Convert.ToInt32(StudentTextbox_Level.Text) > 12)
            {
                MessageBox.Show("Please Enter Student's Level between 1 and 12 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tuple<int, string> add = Controller.InsertStudent(StudentTextbox_Username.Text, StudentTextbox_FirstName.Text, StudentTextbox_LastName.Text, StudentTextbox_Email.Text, OpenedSession.ID, StudentTextbox_Password.Text, StudentDateTimePicker_BOD.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(StudentTextbox_Level.Text));
                if (add.Item1 == 0)
                {
                    MessageBox.Show(add.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Student Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void StudentRadioButton_SearchID_CheckedChanged(object sender, EventArgs e)
        {
            AdminEStudentComboBox_Username.Enabled = false;
            AdminEStudentTextBox_ID.Enabled = true;
            checkS = 1;
            AdminEStudentComboBox_Username.SelectedIndex = -1;
        }

        private void StudentRadioButton_SearchUsername_CheckedChanged(object sender, EventArgs e)
        {
            AdminEStudentComboBox_Username.Enabled = true;
            AdminEStudentTextBox_ID.Enabled = false;
            AdminEStudentTextBox_ID.Text = "Search by Student's ID";
            checkS = 2;
            AdminEStudentTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            AdminEStudentTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            DataTable dt = Controller.SelectAllStudent_Username();
            if (dt != null)
            {
                AdminEStudentComboBox_Username.DataSource = dt;
                AdminEStudentComboBox_Username.DisplayMember = "Username";
                AdminEStudentComboBox_Username.ValueMember = "StudentID";
            }
            else
            {
                MessageBox.Show("No Available Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void AdminEStudentButton_Search_Click(object sender, EventArgs e)
        {
            if (checkS == 1)
            {
                if (AdminEStudentTextBox_ID.Text == "Search by Student's ID")
                {
                    MessageBox.Show("Please Enter an Student's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt = Controller.SelectStudentByID(Convert.ToInt32(AdminEStudentTextBox_ID.Text));
                if (dt != null)
                {
                    AdminEStudentTextBox_Username.Text = dt.Rows[0]["Username"].ToString();
                    AdminEStudentTextBox_FirstName.Text = dt.Rows[0]["FName"].ToString();
                    AdminEStudentTextBox_LastName.Text = dt.Rows[0]["LName"].ToString();
                    AdminEStudentTextBox_Email.Text = dt.Rows[0]["Email"].ToString();
                    AdminEStudentTextBox_Level.Text = dt.Rows[0]["year"].ToString();
                }
                else
                {
                    MessageBox.Show("No Available Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (checkS == 2)
            {
                DataTable dt = Controller.SelectAllStudent_Username();
                if (dt != null)
                {
                    AdminEStudentTextBox_Username.Text = dt.Rows[AdminEStudentComboBox_Username.SelectedIndex][0].ToString();
                    AdminEStudentTextBox_FirstName.Text = dt.Rows[AdminEStudentComboBox_Username.SelectedIndex][2].ToString();
                    AdminEStudentTextBox_LastName.Text = dt.Rows[AdminEStudentComboBox_Username.SelectedIndex][3].ToString();
                    AdminEStudentTextBox_Email.Text = dt.Rows[AdminEStudentComboBox_Username.SelectedIndex][5].ToString();
                    AdminEStudentTextBox_Level.Text = dt.Rows[AdminEStudentComboBox_Username.SelectedIndex][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Available Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AdminEStudentTextBox_Username.StateCommon.Content.Color1 = Color.Black;
            AdminEStudentTextBox_FirstName.StateCommon.Content.Color1 = Color.Black;
            AdminEStudentTextBox_LastName.StateCommon.Content.Color1 = Color.Black;
            AdminEStudentTextBox_Email.StateCommon.Content.Color1 = Color.Black;
            AdminEStudentTextBox_Level.StateCommon.Content.Color1 = Color.Black;
        }

        private void AdminEStudentButton_Edit_Click(object sender, EventArgs e)
        {
            if (checkS == 1)
            {
                if (AdminEStudentTextBox_ID.Text == "Search by Student's ID")
                {
                    MessageBox.Show("Please Enter an Student's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AdminEStudentTextBox_Username.Text == "Enter Student's Username" || AdminEStudentTextBox_Username.Text == "")
                {
                    MessageBox.Show("Please Enter Student's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (AdminEStudentTextBox_FirstName.Text == "Enter Student's First Name" || AdminEStudentTextBox_FirstName.Text == "")
                {
                    MessageBox.Show("Please Enter Student's First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (AdminEStudentTextBox_LastName.Text == "Enter Student's Last Name" || AdminEStudentTextBox_LastName.Text == "")
                {
                    MessageBox.Show("Please Enter Student's Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (AdminEStudentTextBox_Email.Text == "Enter Student's Email" || AdminEStudentTextBox_Email.Text == "")
                {
                    MessageBox.Show("Please Enter Student's Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (AdminEStudentTextBox_Level.Text == "Enter Student's Level" || AdminEStudentTextBox_Level.Text == "")
                {
                    MessageBox.Show("Please Enter Student's Level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(AdminEStudentTextBox_Level.Text) < 1 || Convert.ToInt32(AdminEStudentTextBox_Level.Text) > 12)
                {
                    MessageBox.Show("Please Enter Student's Level between 1 and 12 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Tuple<int, string> edit = Controller.UpdateStudent(AdminEStudentTextBox_FirstName.Text, AdminEStudentTextBox_LastName.Text, AdminEStudentTextBox_Email.Text, Convert.ToInt32(AdminEStudentTextBox_Level.Text), AdminEStudentTextBox_Username.Text, Convert.ToInt32(AdminEStudentTextBox_ID.Text));
                    if (edit.Item1 == 0)
                    {
                        MessageBox.Show(edit.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Student Edited Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (checkS == 2)
            {
                if (AdminEStudentComboBox_Username.Text == "Search by Student's Username")
                {
                    MessageBox.Show("Please Enter an Student's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AdminEStudentTextBox_Username.Text == "Enter Student's Username" || AdminEStudentTextBox_Username.Text == "")
                {
                    MessageBox.Show("Please Enter Student's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (AdminEStudentTextBox_FirstName.Text == "Enter Student's First Name" || AdminEStudentTextBox_FirstName.Text == "")
                {
                    MessageBox.Show("Please Enter Student's First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (AdminEStudentTextBox_LastName.Text == "Enter Student's Last Name" || AdminEStudentTextBox_LastName.Text == "")
                {
                    MessageBox.Show("Please Enter Student's Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (AdminEStudentTextBox_Email.Text == "Enter Student's Email" || AdminEStudentTextBox_Email.Text == "")
                {
                    MessageBox.Show("Please Enter Student's Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (AdminEStudentTextBox_Level.Text == "Enter Student's Level" || AdminEStudentTextBox_Level.Text == "")
                {
                    MessageBox.Show("Please Enter Student's Level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(AdminEStudentTextBox_Level.Text) < 1 || Convert.ToInt32(AdminEStudentTextBox_Level.Text) > 12)
                {
                    MessageBox.Show("Please Enter Student's Level between 1 and 12 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Tuple<int, string> edit = Controller.UpdateStudent(AdminEStudentTextBox_FirstName.Text, AdminEStudentTextBox_LastName.Text, AdminEStudentTextBox_Email.Text, Convert.ToInt32(AdminEStudentTextBox_Level.Text), AdminEStudentTextBox_Username.Text, Convert.ToInt32(AdminEStudentComboBox_Username.SelectedValue));
                    if (edit.Item1 == 0)
                    {
                        MessageBox.Show(edit.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Student Edited Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void AdminEStudentButton_Activate_Click(object sender, EventArgs e)
        {
            if (checkS == 1)
            {
                if (AdminEStudentTextBox_ID.Text == "Search by Student's ID")
                {
                    MessageBox.Show("Please Enter an Student's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Tuple<int, string> activate = Controller.ActivateStudent(Convert.ToInt32(AdminEStudentTextBox_ID.Text), true, OpenedSession.ID);
                if (activate.Item1 == 0)
                {
                    MessageBox.Show(activate.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Student Activated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (checkS == 2)
            {
                if (AdminEStudentComboBox_Username.Text == "Search by Student's Username")
                {
                    MessageBox.Show("Please Enter an Student's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Tuple<int, string> activate = Controller.ActivateStudent(Convert.ToInt32(AdminEStudentComboBox_Username.SelectedValue), true, OpenedSession.ID);
                if (activate.Item1 == 0)
                {
                    MessageBox.Show(activate.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Student Activated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AdminEStudentButton_DeActivate_Click(object sender, EventArgs e)
        {
            if (checkS == 1)
            {
                if (AdminEStudentTextBox_ID.Text == "Search by Student's ID")
                {
                    MessageBox.Show("Please Enter an Student's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Tuple<int, string> deactivate = Controller.ActivateStudent(Convert.ToInt32(AdminEStudentTextBox_ID.Text), false, OpenedSession.ID);
                if (deactivate.Item1 == 0)
                {
                    MessageBox.Show(deactivate.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Student Deactivated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (checkS == 2)
            {
                if (AdminEStudentComboBox_Username.Text == "Search by Student's Username")
                {
                    MessageBox.Show("Please Enter an Student's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Tuple<int, string> deactivate = Controller.ActivateStudent(Convert.ToInt32(AdminEStudentComboBox_Username.SelectedValue), false, OpenedSession.ID);
                if (deactivate.Item1 == 0)
                {
                    MessageBox.Show(deactivate.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Student Deactivated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (CourseTextbox_Name.Text == "Enter Course Name" || CourseTextbox_Name.Text == "")
            {
                MessageBox.Show("Please Enter Course Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CourseTextbox_Description.Text == "Enter Course Description" || CourseTextbox_Description.Text == "")
            {
                MessageBox.Show("Please Enter Course Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tuple<int, string> add = Controller.InsertCourse(CourseTextbox_Name.Text, CourseTextbox_Description.Text, OpenedSession.ID);
                if (add.Item1 == 0)
                {
                    MessageBox.Show(add.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Course Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void CourseRadioButton_SearchID_CheckedChanged(object sender, EventArgs e)
        {
            AdminECourseComboBox_Name.Enabled = false;
            AdminECourseTextBox_ID.Enabled = true;
            checkC = 1;
        }

        private void CourseRadioButton_SearchUsername_CheckedChanged(object sender, EventArgs e)
        {
            AdminECourseComboBox_Name.Enabled = true;
            AdminECourseTextBox_ID.Enabled = false;
            checkC = 2;
            AdminECourseTextBox_ID.Text = "Search by Course's ID";
            AdminECourseTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            AdminECourseTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            DataTable dt = Controller.SelectAllCourse_Name();
            if (dt != null)
            {
                AdminECourseComboBox_Name.DataSource = dt;
                AdminECourseComboBox_Name.DisplayMember = "Course_Name";
                AdminECourseComboBox_Name.ValueMember = "Course_ID";
            }
            else
            {
                MessageBox.Show("No Courses Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void AdminECourseButton_Search_Click(object sender, EventArgs e)
        {
            if (checkC == 1)
            {
                if (AdminECourseTextBox_ID.Text == "Search by Course's ID")
                {
                    MessageBox.Show("Please Enter an Course's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt = Controller.SelectCoursesbyID(Convert.ToInt32(AdminECourseTextBox_ID.Text));
                if (dt != null)
                {
                    AdminECourseTextBox_Name.Text = dt.Rows[0]["Course_Name"].ToString();
                    AdminECourseTextBox_Description.Text = dt.Rows[0]["Description"].ToString();
                }
                else
                {
                    MessageBox.Show("No Course Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (checkC == 2)
            {
                DataTable dt = Controller.SelectAllCourse_Name();
                if (dt != null)
                {
                    AdminECourseTextBox_Name.Text = dt.Rows[AdminECourseComboBox_Name.SelectedIndex]["Course_Name"].ToString();
                    AdminECourseTextBox_Description.Text = dt.Rows[AdminECourseComboBox_Name.SelectedIndex]["Description"].ToString();
                }
                else
                {
                    MessageBox.Show("No Course Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AdminECourseTextBox_Name.StateCommon.Content.Color1 = Color.Black;
            AdminECourseTextBox_Description.StateCommon.Content.Color1 = Color.Black;
        }

        private void AdminECourseButton_Edit_Click(object sender, EventArgs e)
        {
            if (checkC == 1)
            {
                if (AdminECourseTextBox_ID.Text == "Search by Course's ID")
                {
                    MessageBox.Show("Please Enter an Course's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Tuple<int, string> edit = Controller.UpdateCourse(Convert.ToInt32(AdminECourseTextBox_ID.Text), AdminECourseTextBox_Name.Text, AdminECourseTextBox_Description.Text, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Course Edited Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (checkC == 2)
            {
                Tuple<int, string> edit = Controller.UpdateCourse(Convert.ToInt32(AdminECourseComboBox_Name.SelectedValue), AdminECourseTextBox_Name.Text, AdminECourseTextBox_Description.Text, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Course Edited Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AdminHRadioButton_SearchID_CheckedChanged(object sender, EventArgs e)
        {
            checkH = 1;

            AdminHTextBox_ID.Enabled = true;
            AdminHComboBox_Username.Enabled = false;
            InstructorHTextBox_ID.Enabled = false;
            InstructorHComboBox_Username.Enabled = false;
            StudentHTextBox_ID.Enabled = false;
            StudentHComboBox_Username.Enabled = false;
            AdminHComboBox_Username.SelectedIndex = -1;
            InstructorHComboBox_Username.SelectedIndex = -1;
            StudentHComboBox_Username.SelectedIndex = -1;
            InstructorHTextBox_ID.Text = "Search by Instructor's ID";
            InstructorHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            InstructorHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            StudentHTextBox_ID.Text = "Search by Student's ID";
            StudentHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            StudentHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
        }

        private void AdminHRadioButton_SearchUsername_CheckedChanged(object sender, EventArgs e)
        {
            checkH = 2;

            AdminHTextBox_ID.Enabled = false;
            AdminHComboBox_Username.Enabled = true;
            InstructorHTextBox_ID.Enabled = false;
            InstructorHComboBox_Username.Enabled = false;
            StudentHTextBox_ID.Enabled = false;
            StudentHComboBox_Username.Enabled = false;
            AdminHTextBox_ID.Text = "Search by Admin's ID";
            AdminHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            AdminHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            InstructorHTextBox_ID.Text = "Search by Instructor's ID";
            InstructorHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            InstructorHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            InstructorHComboBox_Username.SelectedIndex = -1;
            StudentHTextBox_ID.Text = "Search by Student's ID";
            StudentHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            StudentHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            StudentHComboBox_Username.SelectedIndex = -1;
            DataTable dt = Controller.SelectAllAdmin();
            if (dt != null)
            {
                AdminHComboBox_Username.DataSource = dt;
                AdminHComboBox_Username.DisplayMember = "Username";
                AdminHComboBox_Username.ValueMember = "Admin_ID";
            }
            else
            {
                MessageBox.Show("No Admin Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void InstructorHRadioButton_SearchID_CheckedChanged(object sender, EventArgs e)
        {
            checkH = 3;

            AdminHTextBox_ID.Enabled = false;
            AdminHComboBox_Username.Enabled = false;
            InstructorHTextBox_ID.Enabled = true;
            InstructorHComboBox_Username.Enabled = false;
            StudentHTextBox_ID.Enabled = false;
            StudentHComboBox_Username.Enabled = false;
            AdminHTextBox_ID.Text = "Search by Admin's ID";
            AdminHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            AdminHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            AdminHComboBox_Username.SelectedIndex = -1;
            StudentHTextBox_ID.Text = "Search by Student's ID";
            StudentHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            StudentHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            StudentHComboBox_Username.SelectedIndex = -1;
            InstructorHComboBox_Username.SelectedIndex = -1;


        }

        private void InstructorHRadioButton_SearchUsername_CheckedChanged(object sender, EventArgs e)
        {
            checkH = 4;

            AdminHTextBox_ID.Enabled = false;
            AdminHComboBox_Username.Enabled = false;
            InstructorHTextBox_ID.Enabled = false;
            InstructorHComboBox_Username.Enabled = true;
            StudentHTextBox_ID.Enabled = false;
            StudentHComboBox_Username.Enabled = false;
            AdminHTextBox_ID.Text = "Search by Admin's ID";
            AdminHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            AdminHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            AdminHComboBox_Username.SelectedIndex = -1;
            StudentHTextBox_ID.Text = "Search by Student's ID";
            StudentHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            StudentHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            StudentHComboBox_Username.SelectedIndex = -1;
            InstructorHTextBox_ID.Text = "Search by Instructor's ID";
            InstructorHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            InstructorHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            DataTable dt = Controller.SelectAllInstructor_Username();
            if (dt != null)
            {
                InstructorHComboBox_Username.DataSource = dt;
                InstructorHComboBox_Username.DisplayMember = "Username";
                InstructorHComboBox_Username.ValueMember = "Instructor_ID";
            }
            else
            {
                MessageBox.Show("No Instructor Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void StudentHRadioButton_SearchID_CheckedChanged(object sender, EventArgs e)
        {
            checkH = 5;

            AdminHTextBox_ID.Enabled = false;
            AdminHComboBox_Username.Enabled = false;
            InstructorHTextBox_ID.Enabled = false;
            InstructorHComboBox_Username.Enabled = false;
            StudentHTextBox_ID.Enabled = true;
            StudentHComboBox_Username.Enabled = false;
            AdminHTextBox_ID.Text = "Search by Admin's ID";
            AdminHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            AdminHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            AdminHComboBox_Username.SelectedIndex = -1;
            InstructorHTextBox_ID.Text = "Search by Instructor's ID";
            InstructorHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            InstructorHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            InstructorHComboBox_Username.SelectedIndex = -1;
            StudentHComboBox_Username.SelectedIndex = -1;

        }

        private void StudentHRadioButton_Username_CheckedChanged(object sender, EventArgs e)
        {
            checkH = 6;

            AdminHTextBox_ID.Enabled = false;
            AdminHComboBox_Username.Enabled = false;
            InstructorHTextBox_ID.Enabled = false;
            InstructorHComboBox_Username.Enabled = false;
            StudentHTextBox_ID.Enabled = false;
            StudentHComboBox_Username.Enabled = true;
            AdminHTextBox_ID.Text = "Search by Admin's ID";
            AdminHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            AdminHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            AdminHComboBox_Username.SelectedIndex = -1;
            InstructorHTextBox_ID.Text = "Search by Instructor's ID";
            InstructorHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            InstructorHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            InstructorHComboBox_Username.SelectedIndex = -1;
            StudentHTextBox_ID.Text = "Search by Student's ID";
            StudentHTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
            StudentHTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            DataTable dt = Controller.SelectAllStudent_Username();
            if (dt != null)
            {
                StudentHComboBox_Username.DataSource = dt;
                StudentHComboBox_Username.DisplayMember = "Username";
                StudentHComboBox_Username.ValueMember = "StudentID";
            }
            else
            {
                MessageBox.Show("No Student Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AdminHTextBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void AdminECourseTextBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void InstructorHTextBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void StudentHTextBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void HistoryButton_Search_Click(object sender, EventArgs e)
        {
            if (checkH == 1)
            {
                if (AdminHTextBox_ID.Text == "Search by Admin's ID" || AdminHTextBox_ID.Text == "")
                {
                    MessageBox.Show("Please Enter Admin's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Tuple<DataTable, string> dt = Controller.ManageByAdmin(Convert.ToInt32(AdminHTextBox_ID.Text));
                    if (dt.Item1 != null)
                    {
                        HistoryDataGridView.DataSource = dt.Item1;
                        HistoryDataGridView.Refresh();

                    }
                    else
                    {
                        MessageBox.Show(dt.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (checkH == 2)
            {
                if (AdminHComboBox_Username.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Admin's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Tuple<DataTable, string> dt = Controller.ManageByAdmin(Convert.ToInt32(AdminHComboBox_Username.SelectedValue));
                    if (dt.Item1 != null)
                    {
                        HistoryDataGridView.DataSource = dt.Item1;
                        HistoryDataGridView.Refresh();

                    }
                    else
                    {
                        MessageBox.Show(dt.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (checkH == 3)
            {
                if (InstructorHTextBox_ID.Text == "Search by Instructor's ID" || InstructorHTextBox_ID.Text == "")
                {
                    MessageBox.Show("Please Enter Instructor's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Tuple<DataTable, string> dt = Controller.ManageDoneOnInstructor(Convert.ToInt32(InstructorHTextBox_ID.Text));
                    if (dt.Item1 != null)
                    {
                        HistoryDataGridView.DataSource = dt.Item1;
                        HistoryDataGridView.Refresh();

                    }
                    else
                    {
                        MessageBox.Show(dt.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (checkH == 4)
            {
                if (InstructorHComboBox_Username.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Instructor's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Tuple<DataTable, string> dt = Controller.ManageDoneOnInstructor(Convert.ToInt32(InstructorHComboBox_Username.SelectedValue));
                    if (dt.Item1 != null)
                    {
                        HistoryDataGridView.DataSource = dt.Item1;
                        HistoryDataGridView.Refresh();

                    }
                    else
                    {
                        MessageBox.Show(dt.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (checkH == 5)
            {
                if (StudentHTextBox_ID.Text == "Search by Student's ID" || StudentHTextBox_ID.Text == "")
                {
                    MessageBox.Show("Please Enter Student's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Tuple<DataTable, string> dt = Controller.ManageDoneOnStudent(Convert.ToInt32(StudentHTextBox_ID.Text));
                    if (dt.Item1 != null)
                    {
                        HistoryDataGridView.DataSource = dt.Item1;
                        HistoryDataGridView.Refresh();

                    }
                    else
                    {
                        MessageBox.Show(dt.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (checkH == 6)
            {
                if (StudentHComboBox_Username.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Student's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Tuple<DataTable, string> dt = Controller.ManageDoneOnStudent(Convert.ToInt32(StudentHComboBox_Username.SelectedValue));
                    if (dt.Item1 != null)
                    {
                        HistoryDataGridView.DataSource = dt.Item1;
                        HistoryDataGridView.Refresh();

                    }
                    else
                    {
                        MessageBox.Show(dt.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void StudentTextbox_Level_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
        }

        private void AdminRButton_Search_Click(object sender, EventArgs e)
        {

            DataTable dt = Controller.SelectAdminToBeActivated();
            if (dt != null)
            {
                AdminRTextBox_FirstName.Text = dt.Rows[AdminRComboBox_Username.SelectedIndex]["FName"].ToString();
                AdminRTextBox_LastName.Text = dt.Rows[AdminRComboBox_Username.SelectedIndex]["LName"].ToString();
                AdminRTextBox_Email.Text = dt.Rows[AdminRComboBox_Username.SelectedIndex]["Email"].ToString();
                AdminRTextBox_ID.Text = dt.Rows[AdminRComboBox_Username.SelectedIndex]["Admin_ID"].ToString();
                AdminRTextBox_FirstName.Enabled = false;
                AdminRTextBox_LastName.Enabled = false;
                AdminRTextBox_Email.Enabled = false;
                AdminRTextBox_ID.Enabled = false;
                okA = true;
            }
            else
            {
                MessageBox.Show("There are no Admins in waiting list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void AdminRButton_Activate_Click(object sender, EventArgs e)
        {
            if (okA)
            {
                Tuple<int, string> edit = Controller.ActivateAdmin(Convert.ToInt32(AdminRComboBox_Username.SelectedValue), true);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AdminRComboBox_Username.DataSource = Controller.SelectAdminToBeActivated();
                    MessageBox.Show("Admin Activated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Search for Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void InstructorRButton_Search_Click(object sender, EventArgs e)
        {
            DataTable dt = Controller.SelectInstructorToBeActivated();
            if(dt != null)
            {
                InstructorRTextBox_FirstName.Text = dt.Rows[InstructorRComboBox_Username.SelectedIndex]["FName"].ToString();
                InstructorRTextBox_LastName.Text = dt.Rows[InstructorRComboBox_Username.SelectedIndex]["LName"].ToString();
                InstructorRTextBox_Email.Text = dt.Rows[InstructorRComboBox_Username.SelectedIndex]["Email"].ToString();
                InstructorRTextBox_ID.Text = dt.Rows[InstructorRComboBox_Username.SelectedIndex]["Instructor_ID"].ToString();
                InstructorRTextBox_Title.Text = dt.Rows[InstructorRComboBox_Username.SelectedIndex]["Title"].ToString();
                InstructorRTextBox_FirstName.Enabled = false;
                InstructorRTextBox_LastName.Enabled = false;
                InstructorRTextBox_Email.Enabled = false;
                InstructorRTextBox_ID.Enabled = false;
                InstructorRTextBox_Title.Enabled = false;
                okI = true;
            }
            else
            {
                MessageBox.Show("There are no Instructors in waiting list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void InstructorRButton_Activate_Click(object sender, EventArgs e)
        {
            if (okI)
            {
                Tuple<int, string> edit = Controller.ActivateInstructor(Convert.ToInt32(InstructorRComboBox_Username.SelectedValue), true , OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InstructorRComboBox_Username.DataSource = Controller.SelectInstructorToBeActivated();
                    MessageBox.Show("Instructor Activated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Please Search for Instructor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void StudentRButton_Search_Click(object sender, EventArgs e)
        {
            DataTable dt = Controller.SelectStudentToBeActivated();
            if(dt != null)
            {
                StudentRTextBox_FirstName.Text = dt.Rows[StudentRComboBox_Username.SelectedIndex]["FName"].ToString();
                StudentRTextBox_LastName.Text = dt.Rows[StudentRComboBox_Username.SelectedIndex]["LName"].ToString();
                StudentRTextBox_Email.Text = dt.Rows[StudentRComboBox_Username.SelectedIndex]["Email"].ToString();
                StudentRTextBox_ID.Text = dt.Rows[StudentRComboBox_Username.SelectedIndex]["StudentID"].ToString();
                StudentRTextBox_Level.Text = dt.Rows[StudentRComboBox_Username.SelectedIndex]["year"].ToString();
                StudentRTextBox_FirstName.Enabled = false;
                StudentRTextBox_LastName.Enabled = false;
                StudentRTextBox_Email.Enabled = false;
                StudentRTextBox_ID.Enabled = false;
                StudentRTextBox_Level.Enabled = false;
                okS = true;
            }
            else
            {
                MessageBox.Show("There are no Students in waiting list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void StudentRButton_Activate_Click(object sender, EventArgs e)
        {
            if (okS)
            {
                Tuple<int, string> edit = Controller.ActivateStudent(Convert.ToInt32(StudentRComboBox_Username.SelectedValue), true, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StudentRComboBox_Username.DataSource = Controller.SelectStudentToBeActivated();
                    StudentRComboBox_Username.DisplayMember = "Username";
                    StudentRComboBox_Username.ValueMember = "StudentID";
                    MessageBox.Show("Student Activated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Please Search for Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
