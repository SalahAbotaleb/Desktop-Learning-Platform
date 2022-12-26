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
using System.Security.Cryptography;


namespace Learning_DB
{
    public partial class Inst1 : KryptonForm
    {
        Controller cont = new Controller();
        int InstructorID;
        int GoToClassroomID;
        DataTable d1;
        DataTable d2;
        public Inst1(int IID)
        {
            cont = new Controller();
            InstructorID = IID;
            InitializeComponent();
            User_Name.Text = "Instructor";

            DataTable InstructorData = cont.SelectInstructorByID(IID);
            User_NameLabel.Text = InstructorData.Rows[0]["Fname"].ToString() + " " + InstructorData.Rows[0]["LName"].ToString();
            FNameBox.Text = InstructorData.Rows[0]["FName"].ToString();
            LNameBox.Text = InstructorData.Rows[0]["LName"].ToString();
            UsernameBox.Text = InstructorData.Rows[0]["Username"].ToString();
            EmailBox.Text = InstructorData.Rows[0]["Email"].ToString();
            titletextbox.Text = InstructorData.Rows[0]["Title"].ToString();
            //DataTable
            d1 = new DataTable();
            d1 = cont.SelectCourses();

            d2 = new DataTable();
            d2 = cont.SelectClassrooms(IID);

            coursescombobox.DataSource = d1;
            coursescombobox.DisplayMember = "Course_Name";
            //coursescombobox.ValueMember = "Course_ID";

            classroomcombobox.DataSource = d2;
            classroomcombobox.DisplayMember = "Title";
            classroomcombobox.ValueMember = "Class_ID";
            accesscodetextbox_TextChanged(null, new EventArgs());
        }




        private void User_Name_Click(object sender, EventArgs e)
        {

        }


        private void Inst1_Load(object sender, EventArgs e)
        {

        }

        private void InstructorTextbox_FirstName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Instructor_LogOutButton_Click(object sender, EventArgs e)
        {
            Login_Form f = new Login_Form();
            f.Show();
            this.Hide();
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstructorTextbox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstructorTextbox_FirstName_Enter(object sender, EventArgs e)
        {
            if (FNameBox.Text == "Enter Instructor's First Name")
            {
                FNameBox.Text = "";
                FNameBox.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                FNameBox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void InstructorTextbox_FirstName_Leave(object sender, EventArgs e)
        {

        }

        private void InstructorTextbox_FirstName_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void AdminEStudentButton_Edit_Click(object sender, EventArgs e)
        {


        }

        private void AdminEInstructorButton_Edit_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminEInstructorButton_Edit_Click_1(object sender, EventArgs e)
        {
            if (fnametextbox.Text == "")
            {
                MessageBox.Show("Enter First Name");
                return;

            }
            if (lnametextbox.Text == "")
            {
                MessageBox.Show("Enter Last Name");
                return;
            }
            if (emailtextbox.Text == "")
            {
                MessageBox.Show("Enter Email");
                return;
            }
            if (usernametextbox.Text == "")
            {
                MessageBox.Show("Enter Username");
                return;
            }
            if (Title_textbox.Text == "")
            {
                MessageBox.Show("Enter Title");
                return;

            }

            Tuple<int, string> UpSt = cont.UpdateInstructor(fnametextbox.Text, lnametextbox.Text, emailtextbox.Text, usernametextbox.Text, OpenedSession.ID, passwordtextbox.Text, Title_textbox.Text);
            if (UpSt.Item1 == 0)
            {
                MessageBox.Show("Not Updated!");
            }
            else
            {
                MessageBox.Show("Instructor Updated succefully");

                fnametextbox.Text = "";
                lnametextbox.Text = "";
                emailtextbox.Text = "";
                passwordtextbox.Text = "";
                Title_textbox.Text = "";
                usernametextbox.Text = "";
            }
        }

        private void FNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addclassroombutton_Click(object sender, EventArgs e)
        {
            if (kryptonTextBox15.Text == "")
            {
                MessageBox.Show("Fill all fields.");
                return;
            }
            Tuple<int, string> result = cont.InsertClassroom(kryptonTextBox15.Text, Int16.Parse(kryptonTextBox6.Text), InstructorID);
            if (result.Item1 == 0)
            {
                MessageBox.Show(result.Item2);
                MessageBox.Show("Course doesn't exist");

            }
            else
            {
                MessageBox.Show("Classroom added successfuly");
                d2 = cont.SelectClassrooms(InstructorID);
                classroomcombobox.DataSource = d2;
                classroomcombobox.Refresh();
            }
        }

        private void kryptonTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void coursescombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            kryptonTextBox6.Text = d1.Rows[coursescombobox.SelectedIndex]["Course_ID"].ToString();

        }

        private void User_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void GoToClassroom_Click(object sender, EventArgs e)
        {

            Classroom c = new Classroom(GoToClassroomID);
            c.Show();

        }

        private void classroomcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            accesscodetextbox_TextChanged(null, new EventArgs());
        }

        private void accesscodetextbox_TextChanged(object sender, EventArgs e)
        {
            accesscodetextbox.Text = d2.Rows[classroomcombobox.SelectedIndex]["Access_code"].ToString();
            string storeID = d2.Rows[classroomcombobox.SelectedIndex]["Class_ID"].ToString();
            GoToClassroomID = Int32.Parse(storeID);
        }
    }
}