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
        Controller cont=new Controller();
        int InstructorID;
        DataTable d1;
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
            d1= new DataTable();
                d1 = cont.SelectClassroomForInstructorbyIn_ID(InstructorID);
            //dataGridView1.DataSource = d1;

            DataTable d2 = new DataTable();
                d2=cont.SelectClassrooms();
            coursescombobox.ValueMember = "Course_Name";
            coursescombobox.DataSource=d2;
            //coursescombobox.DisplayMember = "Course_Name";
            coursescombobox.ValueMember = "Course_Name";
            //Classroom.Hide();
            classroomcombobox.DataSource = d2;//cont.SelectClassroomForInstructorbyIn_ID(IID);        
            
            accesscodetextbox.Text = d2.Rows[0]["Access_code"].ToString();
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
            if (kryptonTextBox5.Text == "")
            {
                MessageBox.Show("Enter First Name");
                return;

            }
            if (kryptonTextBox4.Text == "")
            {
                MessageBox.Show("Enter Last Name");
                return;
            }
            if (kryptonTextBox3.Text == "")
            {
                MessageBox.Show("Enter Email");
                return;
            }
            if (kryptonTextBox2.Text == "")
            {
                MessageBox.Show("Enter Username");
                return;
            }
            if (kryptonTextBox1.Text == "")
            {
                MessageBox.Show("Enter Title");
                return;

            }

            Tuple<int, string> UpSt = cont.UpdateInstructor(kryptonTextBox5.Text, kryptonTextBox4.Text, kryptonTextBox3.Text, Convert.ToInt32(kryptonTextBox2.Text), kryptonTextBox1.Text, InstructorID);
            if (UpSt.Item1 == 0)
            {
                MessageBox.Show(UpSt.Item2);
            }
            else
            {
                MessageBox.Show("Instructor  Updated succefully");
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
            Tuple<int, string> result = cont.InsertClassroom(kryptonTextBox15.Text, kryptonTextBox14.Text,Convert.ToInt16(coursescombobox.Text));
            if (result.Item1 == 0)
            {
                MessageBox.Show(result.Item2);
                MessageBox.Show("Course doesn't exist");

            }
            else
            {
                MessageBox.Show("Classroom added successfuly");
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

        }

        private void User_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void GoToClassroom_Click(object sender, EventArgs e)
        {
            Classroom c = new Classroom(7);
            c.Show();

        }

        private void classroomcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void accesscodetextbox_TextChanged(object sender, EventArgs e)
        {
            accesscodetextbox.Text = d1.Rows[0]["Access_Code"].ToString();
        }
    }
}