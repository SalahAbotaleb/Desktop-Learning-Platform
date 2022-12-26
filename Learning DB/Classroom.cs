using DbHandler;
using MetroSet_UI.Controls;
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


namespace Learning_DB
{
    public partial class Classroom : KryptonForm
    {
        Controller c;
        int Classroom_ID;
        int Post_Count = 0;
        DataTable Post_dt;
        DataTable Comments_dt;
        DataTable res;
        DataTable d1;
        DataTable d3;
        DataTable dtQuestbyTopic;
        DataTable stdAssignmentDatatable;
        DataTable AssignmentDataTable;
        DataTable examsForClassroom;
        int ViewExamID = 0;
        public Classroom(int C_ID)
        {
            Classroom_ID = C_ID;
            InitializeComponent();
            c = new Controller();
            Post_dt = c.SelectPostsForClass(Classroom_ID);
            UpdatePostsPage();


            //initializing the AddQuestionToExam Button to be disabled
            //AddQuestionQuestioBank.Enabled = false;
            DetermineQuesType_comboBox.SelectedItem = null;
            op1.Hide();
            op2.Hide();
            op3.Hide();
            op4.Hide();
            op1_textbox.Hide();
            op2_textbox.Hide();
            op3_textbox.Hide();
            op4_textbox.Hide();
            True_RadioButton.Hide();
            false_radiobutton.Hide();
            DataTable dt;
            dt = c.SelectClassroomByID(Classroom_ID);
            kryptonTextBox15.Text = dt.Rows[0]["Title"].ToString();
            kryptonTextBox14.Text = dt.Rows[0]["Access_code"].ToString();

            d3 = new DataTable();
            d3 = c.SelectTopics(Classroom_ID);
            
            //not sure if we should restrict the topics to select from here by the courses relat
            //-ed to our classroom
            topicComboinQuestionBank.DataSource = d3;
            topicComboinQuestionBank.DisplayMember = "Topic";
            deleteQuestionTopic.DataSource = d3;
            deleteQuestionTopic.DisplayMember = "Topic";
            deleteQuestionTopic.ValueMember = "Topic";

            /// Assignment ComboBox
            AssignmentDataTable = c.SelectAssignmentForClass(Classroom_ID);
            assignmentcombobox.DisplayMember = "Title";
            assignmentcombobox.ValueMember = "Assignment_ID";
            assignmentcombobox.DataSource = AssignmentDataTable;
            
            //stdAssignmentDatatable = c.SelectStudentbyClassroom(Classroom_ID);
            //studentnameComboBox.ValueMember= "Student_ID";
            //studentnameComboBox.DisplayMember= "Student_ID";


            //view grades
            chooseexamCombo.DataSource = c.SelectExamsForClass(Classroom_ID);
            chooseexamCombo.DisplayMember = "Title";
            chooseexamCombo.ValueMember = "Exam_ID";


            //exam for classroom initialization
            examsForClassroom = c.SelectExamsForClass(Classroom_ID);

        }
        public void UpdatePostsPage()
        {

            if (Post_dt == null)
            {
                PostDateLabel.Visible = false;
                AnnouncementBox.Visible = false;
                AnnouncementLabel.Visible = false;
                CommentsDataGrid.Visible = false;
                CommentsLabel.Visible = false;
                AddCommentLabel.Visible = false;
                AddedCommentBox.Visible = false;
                PostsSubmitButton.Visible = false;
                PostsNextButton.Visible = false;
                PostsPreviousButton.Visible = false;
                return;
            }
            PostDateLabel.Visible = true;
            AnnouncementBox.Visible = true;
            AnnouncementLabel.Visible = true;
            CommentsDataGrid.Visible = true;
            CommentsLabel.Visible = true;
            AddCommentLabel.Visible = true;
            AddedCommentBox.Visible = true;
            PostsSubmitButton.Visible = true;
            PostsNextButton.Visible = true;
            PostsPreviousButton.Visible = true;
            PostDateLabel.Text = Post_dt.Rows[Post_Count]["Timestamp"].ToString();
            PostTitleLabel.Text = Post_dt.Rows[Post_Count]["Title"].ToString();
            AnnouncementBox.Text = Post_dt.Rows[Post_Count]["Announcement"].ToString();
            Comments_dt = c.SelectCommentsForClass(Classroom_ID, Post_dt.Rows[Post_Count]["Timestamp"].ToString());
            CommentsDataGrid.DataSource = Comments_dt;
            CommentsDataGrid.Refresh();
        }
        private void PostsSubmitButton_Click(object sender, EventArgs e)
        {
            if (Post_dt != null && AddedCommentBox.Text != "")
            {

                if (c.AddComment(Classroom_ID.ToString(), Post_dt.Rows[Post_Count]["Timestamp"].ToString(), OpenedSession.ID, AddedCommentBox.Text).Item1 != 0)
                {
                    AddedCommentBox.Text = "";
                    Comments_dt = c.SelectCommentsForClass(Classroom_ID, Post_dt.Rows[Post_Count]["Timestamp"].ToString());
                    CommentsDataGrid.DataSource = Comments_dt;
                    CommentsDataGrid.Refresh();
                }
                else
                {
                    MessageBox.Show("Error Adding Comment");
                }

            }
        }
        private void PostsNextButton_Click(object sender, EventArgs e)
        {
            if (Post_Count == Post_dt.Rows.Count - 1)
                return;
            Post_Count++;
            UpdatePostsPage();

        }
        private void PostsPreviousButton_Click(object sender, EventArgs e)
        {
            if (Post_Count == 0)
                return;
            Post_Count--;
            UpdatePostsPage();
        }
        private void PostsRefreshButton_Click(object sender, EventArgs e)
        {
            Post_dt = c.SelectPostsForClass(Classroom_ID);
            Post_Count = 0;
            UpdatePostsPage();

        }
        private void copyaccesscode_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(kryptonTextBox14.Text);
        }

        private void kryptonTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void questioncombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //accesscodetextbox.Text = d2.Rows[classroomcombobox.SelectedIndex]["Access_code"].ToString();

        }

      

        private void ChooseTopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void topicComboinQuestionBank_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void AddQuestionQuestioBank_Click(object sender, EventArgs e)
        {
          
            AddQuestionQuestioBank.Enabled = true;

            string option1 = op1_textbox.Text;
            string option2 = op2_textbox.Text;
            string option3 = op3_textbox.Text;
            string option4 = op4_textbox.Text;
 
            if (questionDescriptQB.Text == "")
            {
                MessageBox.Show("Cannot Insert an Empty Question!");
                return;
            }
            Tuple<int, string> result = c.AddQuestion(topicComboinQuestionBank.Text, Classroom_ID, Convert.ToInt16(pointsUpdownQB.Value), Convert.ToInt16(diffUpDownQB.Value), questionDescriptQB.Text); //cont.Upd(kryptonTextBox15.Text, kryptonTextBox14.Text, Convert.ToInt16(coursescombobox.Text));
            if (result.Item1 == 0)
            {
                MessageBox.Show(result.Item2);
                MessageBox.Show("Question couldn't be added");

            }
            else
            {
                int x = Convert.ToInt32(c.getLastQuestion().Rows[0][0]);
                if (DetermineQuesType_comboBox.Text == "T/F") {
                    if (True_RadioButton.Checked)
                    {
                        Tuple<int, string> s = c.AddQuestionOption(x, "True", true);
                        Tuple<int, string> s1 = c.AddQuestionOption(x, "False", false);
                        MessageBox.Show("Question Options added.");

                    }
                }
                else if(DetermineQuesType_comboBox.Text == "MCQ")
                {
                    if (op1.Checked) { 
                        Tuple<int, string> s1 = c.AddQuestionOption(x, option1, true); 
                        Tuple<int, string> s2= c.AddQuestionOption(x, option2, false); 
                        Tuple<int, string> s3= c.AddQuestionOption(x, option3, false); 
                        Tuple<int, string> s4= c.AddQuestionOption(x, option4, false); 
                    }else if (op2.Checked)
                    {
                        Tuple<int, string> s1 = c.AddQuestionOption(x, option1, false);
                        Tuple<int, string> s2 = c.AddQuestionOption(x, option2, true) ;
                        Tuple<int, string> s3 = c.AddQuestionOption(x, option3, false);
                        Tuple<int, string> s4 = c.AddQuestionOption(x, option4, false);
                    }else if(op3.Checked)
                    {
                        Tuple<int, string> s1 = c.AddQuestionOption(x, option1, false);
                        Tuple<int, string> s2 = c.AddQuestionOption(x, option2, false);
                        Tuple<int, string> s3 = c.AddQuestionOption(x, option3, true);
                        Tuple<int, string> s4 = c.AddQuestionOption(x, option4, false);
                    }else if (op4.Checked)
                    {
                        Tuple<int, string> s1 = c.AddQuestionOption(x, option1, false);
                        Tuple<int, string> s2 = c.AddQuestionOption(x, option2, false);
                        Tuple<int, string> s3 = c.AddQuestionOption(x, option3, false);
                        Tuple<int, string> s4 = c.AddQuestionOption(x, option4, true);
                    }
                }
                MessageBox.Show("Question added successfuly");
                AddQuestionQuestioBank.Enabled=true;
            }
        }

        

     

        private void addquestionbutton_Click(object sender, EventArgs e)
        {


            Tuple<int, string> result = c.AddQuestion(topicComboinQuestionBank.Text, Classroom_ID, Convert.ToInt16(pointsUpdownQB.Value), Convert.ToInt16(diffUpDownQB.Value), questionDescriptQB.Text); //cont.Upd(kryptonTextBox15.Text, kryptonTextBox14.Text, Convert.ToInt16(coursescombobox.Text));
            if (result.Item1 == 0)
            {
                MessageBox.Show(result.Item2);
                MessageBox.Show("Question couldn't be added");

            }
            else
            {
                MessageBox.Show("Question added successfuly");
            }

        }

        private void createexambtn_Click(object sender, EventArgs e)
        {
            CreateExam ct = new CreateExam(Classroom_ID, dateTimePicker2.Value);
            c.addExam(Convert.ToInt32(kryptonTextBox2.Text), dateTimePicker2.Value.ToString("yyyy-MM-dd"), dateTimePicker1.Value.ToString("hh:mm:ss"), Classroom_ID, examtitletextbox.Text);
            ct.Show();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void questionDescriptQB_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteQuestionTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = c.SelectQuestionsbyTopic(deleteQuestionTopic.Text);
            Qtxtboxin_Del_Ques.DataSource = dt;
            Qtxtboxin_Del_Ques.DisplayMember = "Description";
            Qtxtboxin_Del_Ques.ValueMember = "Question_ID";
            //TodeleteQuestionID = Int16.Parse(Qtxtboxin_Del_Ques.ValueMember);
        }

        private void deletequestionbutton_Click(object sender, EventArgs e)
        {

            int result=0;// = c.DeleteQuestionbyID(TodeleteQuestionID);
            if (result == 0)
            {
                //MessageBox.Show(result);
                MessageBox.Show("Question couldn't be deleted.");

            }
            else
            {
                MessageBox.Show("Question deleted successfuly");
            }
        }

        private void Qtxtboxin_Del_Ques_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void material_title_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uploadmaterialbtn_Click(object sender, EventArgs e)
        {

            Tuple<int, string> result = c.AddNewMaterial(Classroom_ID, linktextbox.Text, material_title_Textbox.Text);
            if (result.Item1 == 0)
            {
                MessageBox.Show(result.Item2);
                MessageBox.Show("Material couldn't be uploaded to the sytem");

            }
            else
            {
                MessageBox.Show("Material Uploaded successfuly");
            }
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chooseQuestioninAddAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void op1_CheckedChanged(object sender)
        {

        }

       

        private void DetermineQuesType_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (DetermineQuesType_comboBox.Text == "T/F")
            {
                op1.Hide();
                op2.Hide();
                op3.Hide();
                op4.Hide();
                op1_textbox.Hide();
                op2_textbox.Hide();
                op3_textbox.Hide();
                op4_textbox.Hide();
                True_RadioButton.Show();
                false_radiobutton.Show();
            }
            else if (DetermineQuesType_comboBox.Text == "MCQ")
            {
                op1.Show();
                op2.Show();
                op3.Show();
                op4.Show();
                op1_textbox.Show();
                op2_textbox.Show();
                op3_textbox.Show();
                op4_textbox.Show();
                True_RadioButton.Hide();
                false_radiobutton.Hide();
            }
        }

        private void gradeAssignemnt_Click(object sender, EventArgs e)
        {

        }

        private void assignmentcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            res = c.SelectStudentbyClassroomandAss(Convert.ToInt32(assignmentcombobox.SelectedValue));
            StudentIDComboBox.DataSource = res;
            StudentIDComboBox.ValueMember = "Student_ID";
            StudentIDComboBox.DisplayMember = "Student_ID";
            kryptonTextBox1.Text = res.Rows[assignmentcombobox.SelectedIndex]["Fname"].ToString()+" "+ res.Rows[assignmentcombobox.SelectedIndex]["Lname"].ToString();
            Submission_Link.Text=res.Rows[assignmentcombobox.SelectedIndex]["Submission_Link"].ToString();

        }

        private void studentnameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseexamCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (chooseexamCombo.SelectedIndex == -1) return;
            ////examsForClassroom.Da
            //int id=Int16.Parse(examsForClassroom.Rows[chooseexamCombo.SelectedIndex]["Exam_ID"].ToString());
            //maxgradetxtbox.Text = c.SelectMaxGradeinExam(id).ToString();
            //mingradeTextbox.Text = c.SelectMinGradeinExam(id).ToString();
        
        }

        private void mingradeTextbox_TextChanged(object sender, EventArgs e)
        {
            int id = Int16.Parse(examsForClassroom.Rows[chooseexamCombo.SelectedIndex]["Exam_ID"].ToString());
        }

        private void maxgradetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewStudentGradesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chooseexamCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //fe error fl code dah, bydrb hna
            if (chooseexamCombo.SelectedIndex == -1) return;
            if (examsForClassroom == null)
                return;
            //examsForClassroom.Da
            int id = Int16.Parse(examsForClassroom.Rows[chooseexamCombo.SelectedIndex]["Exam_ID"].ToString());
            maxgradetxtbox.Text = c.SelectMaxGradeinExam(id).ToString();
            mingradeTextbox.Text = c.SelectMinGradeinExam(id).ToString();

        }

        private void AddAssignment_Button_Click(object sender, EventArgs e)
        {
            if (assignmentTitleTxtBox.Text== "" || assignmentLinkTxtBox.Text == "")
            {
                MessageBox.Show("Error! Fill all the required fields.");
                    return;
            }
            else
            {
                
                Tuple<int, string> result = c.AddAssignment(AssignmentDeadlineDateTime.Value,
                    assignment_description.Text, Classroom_ID, assignmentTitleTxtBox.Text, Convert.ToInt32(assignmenttotalgradNumeric.Value));
                if (result.Item1 == 0)
                {
                    MessageBox.Show(result.Item2);
                    MessageBox.Show("Assignment couldn't be uploaded to the sytem");

                }
                else
                {
                    MessageBox.Show("Assignment Uploaded successfuly");
                }

            }
        }

        private void assignmenttotalgradNumeric_Click(object sender, EventArgs e)
        {

        }

        private void AssignGrade_Click(object sender, EventArgs e)
        {
            if (assignmentGradeTxtbox.Text == "")
            {
                MessageBox.Show("Enter value");
                return;
            }
            c.SetGrade(Convert.ToInt32(assignmentcombobox.SelectedValue), Convert.ToInt32(StudentIDComboBox.SelectedValue), Convert.ToInt32(assignmentGradeTxtbox.Text));
            MessageBox.Show("Grade entered successufly");
        }

        private void Exittstat_Click(object sender, EventArgs e)
        {
            InstructorReports IR = new InstructorReports(Classroom_ID);
            IR.Show();
        }

        private void uploadPost_Click(object sender, EventArgs e)
        {
            if (addpostTitletextbox.Text != "" || AddpostAnnouncementBox.Text != "")
            {
                c.AddAnnouncement(Classroom_ID,addpostTitletextbox.Text, AddpostAnnouncementBox.Text, OpenedSession.ID);
                MessageBox.Show("Post Uploaded successfuly");
            }
            else
            {
                MessageBox.Show("Error! Fill all the required fields.");
            }
        }
    }


}


//private void DetermineQuesType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
//{
//    if (DetermineQuesType_comboBox.Text == "T/F")
//    {
//        op1.Hide();
//        op2.Hide();
//        op3.Hide();
//        op4.Hide();
//    op1_textbox.Hide();
//    op2_textbox.Hide();
//    op3_textbox.Hide();
//    op4_textbox.Hide();
//        True_RadioButton.Show();
//        false_radiobutton.Show();
//    }else if(DetermineQuesType_comboBox.Text == "MCQ")
//    {
//        op1.Show();
//        op2.Show();
//        op3.Show();
//        op4.Show();
//        op1_textbox.Show();
//        op2_textbox.Show();
//        op3_textbox.Show();
//        op4_textbox.Show();
//        True_RadioButton.Hide();
//        false_radiobutton.Hide();
//    }
//}


//private void totalexampointstxtbox_TextChanged(object sender, EventArgs e)
//{

//}

//private void questionpointsTxtboxExam_TextChanged(object sender, EventArgs e)
//{

//}