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
        int checkA = 0;
        int checkI = 0;
        public AdminInterface()
        {
            InitializeComponent();
            AdminName_Label.Text = Controller.SelectAdminByID(OpenedSession.ID).Rows[0][0].ToString();
            Instructor_Title_ComboBox.DataSource = new List<string> { "Prof.", "Dr.", "Eng.", "Mr.", "Mrs." };
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

        private void AdminEInstructorCombobox_Name_Enter(object sender, EventArgs e)
        {

        }

        private void AdminEInstructorCombobox_Name_Leave(object sender, EventArgs e)
        {

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
                MessageBox.Show("Admin Added Successfuly");
            }
        }

        private void AdminEAdminButton_Edit_Click(object sender, EventArgs e)
        {
            if (checkA == 1)
            {
                if (AdminEAdminTextBox_ID.Text == "Search by Admin's ID")
                {
                    MessageBox.Show("Please Enter Admin's ID");
                    return;
                }
                Tuple<int, string> edit = Controller.UpdateAdmin(Convert.ToInt32(AdminEAdminTextBox_ID.Text), AdminEAdminTextBox_Username.Text, AdminEAdminTextBox_FirstName.Text, AdminEAdminTextBox_LastName.Text, AdminEAdminTextBox_Email.Text);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Admin Updated Successfuly");
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
                Tuple<int, string> edit = Controller.UpdateAdmin(Convert.ToInt32(AdminEAdminComboBox_Username.SelectedValue), AdminEAdminTextBox_Username.Text, AdminEAdminTextBox_FirstName.Text, AdminEAdminTextBox_LastName.Text, AdminEAdminTextBox_Email.Text);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Admin Updated Successfuly");
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method");
                return;
            }
        }

        private void AdminEAdminButton_Search_Click(object sender, EventArgs e)
        {

            if (checkA == 1)
            {
                if (AdminEAdminTextBox_ID.Text == "Search by Admin's ID")
                {
                    MessageBox.Show("Please Enter Admin's ID");
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
                    MessageBox.Show("No Available Admin");
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
                    MessageBox.Show("No Available Admin");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method");
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
            DataTable dt = Controller.SelectAdminBySuper_ID(OpenedSession.ID);
            if (dt != null)
            {
                AdminEAdminComboBox_Username.DataSource = Controller.SelectAdminUsernameByID(OpenedSession.ID);
                AdminEAdminComboBox_Username.DisplayMember = "Username";
                AdminEAdminComboBox_Username.ValueMember = "Admin_ID";
                AdminEAdminTextBox_ID.Text = "Search by Admin's ID";
                AdminEAdminTextBox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEAdminTextBox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
            else
            {
                MessageBox.Show("No Available Admin");
                return;
            }
        }

        private void AddInstructorButton_Click(object sender, EventArgs e)
        {
            Tuple<int, string> result = Controller.InsertInstructor(InstructorTextbox_Username.Text, InstructorTextbox_FirstName.Text, InstructorTextbox_LastName.Text, InstructorTextbox_Email.Text, OpenedSession.ID, InstructorTextbox_Password.Text, Instructor_Title_ComboBox.Text);
            if (result.Item1 == 0)
            {
                MessageBox.Show(result.Item2);
            }
            else
            {
                MessageBox.Show("Instructor Added Successfuly");
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
                AdminEInstructorCombobox_Username.DataSource = Controller.SelectAllInstructor_Username();
                AdminEInstructorCombobox_Username.DisplayMember = "Username";
                AdminEInstructorCombobox_Username.ValueMember = "Instructor_ID";
                AdminEInstructorTextbox_ID.Text = "Search by Instructor's ID";
                AdminEInstructorTextbox_ID.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AdminEInstructorTextbox_ID.StateCommon.Content.Color1 = Color.Gray;
            }
            else
            {
                MessageBox.Show("No Available Instructor");
                return;
            }
        }

        private void AdminEInstructorButton_Search_Click(object sender, EventArgs e)
        {
            if (checkI == 1)
            {
                if (AdminEInstructorTextbox_ID.Text == "Search by Instructor's ID")
                {
                    MessageBox.Show("Please Enter an Instructor's ID");
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
                    MessageBox.Show("No Available Instructor");
                    return;
                }

            }
            else if (checkI == 2)
            {
                AdminEInstructorComboBox_Title.DataSource = new List<string> { "Prof.", "Dr.", "Eng.", "Mr.", "Mrs." };

                DataTable dt = Controller.SelectAllInstructor_Username();
                if (dt != null)
                {
                    AdminEInstructorTextbox_FirstName.Text = Controller.SelectAllInstructor_Username().Rows[AdminEInstructorCombobox_Username.SelectedIndex][2].ToString();
                    AdminEInstructorTextbox_LastName.Text = Controller.SelectAllInstructor_Username().Rows[AdminEInstructorCombobox_Username.SelectedIndex][3].ToString();
                    AdminEInstructorTextbox_Email.Text = Controller.SelectAllInstructor_Username().Rows[AdminEInstructorCombobox_Username.SelectedIndex][5].ToString();
                    AdminEInstructorTextbox_Username.Text = Controller.SelectAllInstructor_Username().Rows[AdminEInstructorCombobox_Username.SelectedIndex][0].ToString();
                    AdminEInstructorComboBox_Title.Text = Controller.SelectAllInstructor_Username().Rows[AdminEInstructorCombobox_Username.SelectedIndex][6].ToString();

                }
                else
                {
                    MessageBox.Show("No Available Instructor");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Searching Method");
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
                    MessageBox.Show("Please Enter an Instructor's ID");
                    return;
                }
                Tuple<int, string> edit = Controller.UpdateInstructor(Convert.ToInt32(AdminEInstructorTextbox_ID.Text), AdminEInstructorTextbox_Username.Text, AdminEInstructorTextbox_FirstName.Text, AdminEInstructorTextbox_LastName.Text, AdminEInstructorTextbox_Email.Text, AdminEInstructorComboBox_Title.Text, null, OpenedSession.ID);
                if (edit.Item1 == 0)
                {
                    MessageBox.Show(edit.Item2);
                }
                else
                {
                    MessageBox.Show("Instructor Updated Successfuly");
                }
            }
            else if (checkI == 2)
            {
                if(AdminEInstructorTextbox_FirstName.Text == "Enter Instructor's First Name")
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
                if(AdminEInstructorTextbox_Username.Text == "Enter Instructor's Username")
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

        }

        private void AdminRadioButton_SearchID_CheckedChanged(object sender, EventArgs e)
        {
            AdminEAdminTextBox_ID.Enabled = true;
            AdminEAdminComboBox_Username.Enabled = false;
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

        private void kryptonButton4_Click_1(object sender, EventArgs e)
        {
            Tuple<int, string> result = Controller.InsertInstructor(InstructorTextbox_Username.Text,InstructorTextbox_FirstName.Text,InstructorTextbox_LastName.Text, InstructorTextbox_Email.Text, OpenedSession.ID,InstructorTextbox_Password.Text, AdminEInstructorTextbox_Title.Text);
            if (result.Item1 == 0)
            {
                MessageBox.Show(result.Item2);
            }
            else
            {
                MessageBox.Show("Instructor added successfuly");
            }
        }

        private void InstructorTextbox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {

        }

        private void AdminEInstructorButton_Edit_Click(object sender, EventArgs e)
        {

        }

        private void AdminEInstructorTextbox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminEAdminTextBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
