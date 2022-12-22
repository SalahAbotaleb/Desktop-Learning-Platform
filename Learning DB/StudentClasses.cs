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
    public partial class StudentClasses : KryptonForm
    {
        Controller cont;
        int StudentID;
        public StudentClasses(int SID)
        {
            InitializeComponent();
            cont = new Controller();
            StudentID = SID;

            User_NameLabel.Text = cont.SelectStudentNameByID(StudentID).Rows[0][0].ToString();
            ClassroomComboBox.DataSource = cont.SelectClassesForStudent(SID);
            ClassroomComboBox.DisplayMember = "Title";
            ClassroomComboBox.ValueMember = "Class_ID";


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

        }
        private void ClassroomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable ClassData = cont.SelectClassDataForStudent(StudentID, ClassroomComboBox.SelectedValue.ToString());
            
        }
    }
}
