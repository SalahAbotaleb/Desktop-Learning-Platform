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
    public partial class StudentClassroom : KryptonForm
    {
        int ClassID;
        int StudentID;
        Controller cont = new Controller();
        int counter = 0;
        public StudentClassroom(int classID,int StudentID)
        {
            InitializeComponent();
            this.ClassID = classID;
            this.StudentID = StudentID;

            updateall();
        }

        private void StudentClassroom_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            counter++;
            updateall();
        }
        public void updateall()
        {
            DataTable dt = cont.SelectAssignmentForClass(ClassID);
            AssignmentTitlelabel.Text = dt.Rows[counter]["Title"].ToString();
            DescriptionBox.Text = dt.Rows[counter]["Description"].ToString();
            DeadlineDateLabel.Text = dt.Rows[counter]["Deadline"].ToString();
            HisGradeLabel.Text = "/" + dt.Rows[counter]["Total_Grade"].ToString();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            counter--;
            updateall();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(SubmissionLinkBox.Text != null)
            {
                cont.InsertSubmission(StudentID, ClassID, SubmissionLinkBox.Text);
            }
        }
    }
}
