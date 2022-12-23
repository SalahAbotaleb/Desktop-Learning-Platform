﻿using ComponentFactory.Krypton.Toolkit;
using DbHandler;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Learning_DB
{
    public partial class StudentClasses : KryptonForm
    {
        Controller cont;
        int StudentID;
        public StudentClasses(int SID)
        {
            InitializeComponent();
            cont = new Controller();
            StudentID = SID;

            DataTable StudentData = cont.SelectStudentByID(SID);
            User_NameLabel.Text = StudentData.Rows[0]["Fname"].ToString() + " " + StudentData.Rows[0]["LName"].ToString();
            ClassroomComboBox.DataSource = cont.SelectClassesForStudent(SID);
            ClassroomComboBox.DisplayMember = "Title";
            ClassroomComboBox.ValueMember = "Class_ID";
            InstructorInClassComboBox.DataSource = cont.SelectInstructorsForClassByID(Convert.ToInt32(ClassroomComboBox.SelectedValue)).Item1;
            InstructorInClassComboBox.DisplayMember = "Instructor Name";
            CourseNameInClassBox.Text = cont.SelectClassInfoForStudent(Convert.ToInt32(ClassroomComboBox.SelectedValue)).Item1.Rows[0]["Course Name"].ToString();

            FNameBox.Text = StudentData.Rows[0]["FName"].ToString();
            LNameBox.Text = StudentData.Rows[0]["LName"].ToString();
            UsernameBox.Text = StudentData.Rows[0]["Username"].ToString();
            LevelBox.Text = StudentData.Rows[0]["year"].ToString();
            IDBox.Text = StudentData.Rows[0]["StudentID"].ToString();
            EmailBox.Text = StudentData.Rows[0]["Email"].ToString();


        }
        private void AccessCodeBox_Enter(object sender, EventArgs e)
        {
            if (AccessCodeBox.Text == "Enter Classroom's Access Code")
            {
                AccessCodeBox.Text = "";
                AccessCodeBox.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Regular);
                AccessCodeBox.StateCommon.Content.Color1 = Color.Black;

            }
        }

        private void AccessCodeBox_Leave(object sender, EventArgs e)
        {
            if (AccessCodeBox.Text == "")
            {
                AccessCodeBox.Text = "Enter Classroom's Access Code";
                AccessCodeBox.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
                AccessCodeBox.StateCommon.Content.Color1 = Color.Gray;

            }
        }

        private void SearchClassButton_Click(object sender, EventArgs e)
        {
            if (AccessCodeBox.Text != "Enter Classroom's Access Code")
            {
                Tuple<DataTable, string> ClassroomData = cont.SearchClassroomForStudent(AccessCodeBox.Text);
                if (ClassroomData.Item1 == null)
                {
                    ClassroomTitleBox.Visible = false;
                    InstructorLabel.Visible = false;
                    InstructorComboBox.Visible = false;
                    ClassLabel.Visible = false;
                    ConfirmEnrollButton.Visible = false;
                    CourseNameBox.Visible = false;
                    CourseNameLabel.Visible = false;

                    MessageBox.Show(ClassroomData.Item2);
                }

                else
                {
                    ClassroomTitleBox.Visible = true;
                    InstructorLabel.Visible = true;
                    InstructorComboBox.Visible = true;
                    ClassLabel.Visible = true;
                    ConfirmEnrollButton.Visible = true;
                    CourseNameBox.Visible = true;
                    CourseNameLabel.Visible = true;

                    CourseNameBox.Text = ClassroomData.Item1.Rows[0]["Course Name"].ToString();
                    ClassroomTitleBox.Text = ClassroomData.Item1.Rows[0]["Classroom Title"].ToString();
                    InstructorComboBox.DataSource = cont.SelectInstructorsForClassByCode(AccessCodeBox.Text).Item1;
                    InstructorComboBox.DisplayMember = "Instructor Name";
                }
            }

        }

        private void ConfirmEnrollButton_Click(object sender, EventArgs e)
        {
            Tuple<int, string> EnrollmentError = cont.EnrollStudentByAccessCode(AccessCodeBox.Text, StudentID);
            if (EnrollmentError.Item1 == 0)
            {
                MessageBox.Show(EnrollmentError.Item2);
            }
            else
            {
                MessageBox.Show("Enrolled Succefuly");
                ClassroomComboBox.DataSource = cont.SelectClassesForStudent(StudentID);
                ClassroomComboBox.DisplayMember = "Title";
                ClassroomComboBox.ValueMember = "Class_ID";


            }

        }

        private void ClassroomComboBox_DropDownClosed(object sender, EventArgs e)
        {
            CourseNameInClassBox.Text = cont.SelectClassInfoForStudent(Convert.ToInt32(ClassroomComboBox.SelectedValue)).Item1.Rows[0]["Course Name"].ToString();
            InstructorInClassComboBox.DataSource = cont.SelectInstructorsForClassByID(Convert.ToInt32(ClassroomComboBox.SelectedValue)).Item1;
            InstructorInClassComboBox.DisplayMember = "Instructor Name";

        }

        private void AdminEStudentButton_Edit_Click(object sender, EventArgs e)
        {
            if(FNameBox.Text == "")
            {
                MessageBox.Show("Enter First Name");
                return;
                
            }
            if(FNameBox.Text == "")
            {
                MessageBox.Show("Enter Last Name");
                return;
            }
            if(EmailBox.Text == "")
            {
                MessageBox.Show("Enter Email");
                return;
            }
            if(UsernameBox.Text == "")
            {
                MessageBox.Show("Enter Username");
                return;
            }
            Tuple<int, string> UpSt = cont.UpdateStudent(FNameBox.Text, LNameBox.Text, EmailBox.Text,Convert.ToInt32(LevelBox.Text), UsernameBox.Text, StudentID);
            if (UpSt.Item1 == 0)
            {
                MessageBox.Show(UpSt.Item2);
            }
            else
            {
                MessageBox.Show("Updated succefully");
            }
        }

        private void Admin_LogOutButton_Click(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            l.Show();
            this.Hide();
        }

        private void FNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
