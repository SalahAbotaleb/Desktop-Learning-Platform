using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        bool isAnswersShowing = false;
        int ClassID;
        int StudentID;
        Controller controller = new Controller();
        int Assignment_Page_Counter = 0;
        int Exam_Page_Count = 0;
        int Post_Count = 0;
        DataTable Assignment_dt;
        DataTable Exam_dt;
        DataTable Post_dt;
        DataTable Comments_dt;
        int h, m, s;
        int duration;
        Exam exam;
        List<Tuple<int, int>> ls;
        System.Timers.Timer Time_Remaining;
        public StudentClassroom(int classID,int StudentID)
        {
            InitializeComponent();
            this.ClassID = classID;
            this.StudentID = StudentID;
            Assignment_dt = controller.SelectAssignmentForClass(ClassID);
            Exam_dt = controller.SelectExamsForClass(ClassID);
            Post_dt = controller.SelectPostsForClass(ClassID);
            
            UpdatePostsPage();


            ComboBoxSelectExam.DisplayMember = "Title";
            ComboBoxSelectExam.ValueMember = "Exam_ID";
            ComboBoxSelectExam.DataSource = Exam_dt;
            ComboBoxSelectExam.DisplayMember = "Title";
            UpdateAssignmentPage();
            kryptonRichQuestionDescription.Hide();
            kryptonLabelQuestionNumber.Hide();
            TextBoxTimer.Hide();
            label9.Hide();
            LabelPoints.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            label8.Hide();
            SubmitExam.Hide();
            kryptonButtonNextQues.Hide();
            kryptonButtonPrevQues.Hide();
            metroSetProgressBar1.Hide();
            kryptonLabelYouGot.Hide();
            viewcorrection.Hide();
            exitexam.Hide();
            exitExam2.Hide();
            SolvedStatus.Hide();
        }
        
        private void UpdateExamPage()
        {
            if (isAnswersShowing == true)
            {
                if(ls[Exam_Page_Count].Item1 == ls[Exam_Page_Count].Item2)
                    SolvedStatus.Text="You Solved Correctly";
                else
                    SolvedStatus.Text = "You Solved Incorrectly";
                radioButton1.Checked = (ls[Exam_Page_Count].Item1 == 0);
                radioButton2.Checked = (ls[Exam_Page_Count].Item1 == 1);
                radioButton3.Checked = (ls[Exam_Page_Count].Item1 == 2);
                radioButton4.Checked = (ls[Exam_Page_Count].Item1 == 3);
                radioButton1.Hide();
                radioButton2.Hide();
                radioButton3.Hide();
                radioButton4.Hide();
            }
            else {
                        radioButton1.Checked = (exam.selectedOption() == 0);
                        radioButton2.Checked = (exam.selectedOption() == 1);
                        radioButton3.Checked = (exam.selectedOption() == 2);
                        radioButton4.Checked = (exam.selectedOption() == 3);
                        radioButton1.Hide();
                        radioButton2.Hide();
                        radioButton3.Hide();
                        radioButton4.Hide();
                    }
            kryptonLabelQuestionNumber.Text = "Question " + (Exam_Page_Count+1).ToString() + " Out of " + exam.QuestionsCount().ToString();
            kryptonRichQuestionDescription.Text = exam.getCurrQuesDescription();
            LabelPoints.Text = exam.GetCurrQuesPoints().ToString();
            string[] options = exam.getCurrQuesOptions();
            if (options[0] != null)
            {
                radioButton1.Text = options[0];
                radioButton1.Show();
            }
            if (options[1] != null)
            {
                radioButton2.Text = options[1];
                radioButton2.Show();
            }
            if (options[2] != null)
            {
                radioButton3.Text = options[2];
                radioButton3.Show();
            }
            if (options[3] != null)
            {
                radioButton4.Text = options[3];
                radioButton4.Show();
            }
        }

        private void StudentClassroom_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Assignment_Page_Counter == Assignment_dt.Rows.Count-1)
                return;
            Assignment_Page_Counter++;
            UpdateAssignmentPage();
        }
        public void UpdateAssignmentPage()
        {

            if (Assignment_dt == null)
                return;
            AssignmentTitlelabel.Text = Assignment_dt.Rows[Assignment_Page_Counter]["Title"].ToString();
            DescriptionBox.Text = Assignment_dt.Rows[Assignment_Page_Counter]["Description"].ToString();
            DeadlineDateLabel.Text = Assignment_dt.Rows[Assignment_Page_Counter]["Deadline"].ToString();
            HisGradeLabel.Text = "/" + Assignment_dt.Rows[Assignment_Page_Counter]["Total_Grade"].ToString();
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
            Comments_dt = controller.SelectCommentsForClass(ClassID, Post_dt.Rows[Post_Count]["Timestamp"].ToString());
            CommentsDataGrid.DataSource = Comments_dt;
            CommentsDataGrid.Refresh();
        }
        
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (Assignment_Page_Counter == 0)
                return;
            Assignment_Page_Counter--;
            UpdateAssignmentPage();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(SubmissionLinkBox.Text != null)
            {
                Tuple<int, string> tp = controller.InsertSubmission(StudentID, Convert.ToInt32(Assignment_dt.Rows[Assignment_Page_Counter]["Assignment_ID"]), SubmissionLinkBox.Text);
                if (tp.Item1==1)
                    MessageBox.Show("Submission Successfuly");
                else
                    
                    MessageBox.Show(tp.Item2);
            }
        }

        private void ButtonEnterExam_Click(object sender, EventArgs e)
        {
            if (true)
            {
                isAnswersShowing = false;
                //Exam_dt != null&&cont.CheckExamAvailability(Convert.ToInt32(ComboBoxSelectExam.SelectedValue)) =="Enter"
                exitExam2.Hide();
                ComboBoxSelectExam.Hide();
                TextboxExamDate.Hide();
                TextBoxExamID.Hide();
                TextBoxExmDuration.Hide();
                label3.Hide();
                label7.Hide();
                label4.Hide();
                label6.Hide();
                ButtonEnterExam.Hide();
                /********/
                kryptonRichQuestionDescription.Show();
                kryptonLabelQuestionNumber.Show();
                TextBoxTimer.Show();
                label9.Show();
                LabelPoints.Show();
                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Show();
                radioButton4.Show();
                label8.Show();
                SubmitExam.Show();
                kryptonButtonNextQues.Show();
                kryptonButtonPrevQues.Show();
                metroSetProgressBar1.Show();
                /********/
                Time_Remaining = new System.Timers.Timer();
                duration = Convert.ToInt32(Exam_dt.Rows[ComboBoxSelectExam.SelectedIndex]["DurationCount"]);
                Time_Remaining.Interval = 1000; //1000 second
                Time_Remaining.Elapsed += OnTimedEvent;
                Time_Remaining.Start();
                /********/

                exam = new Exam(StudentID, Convert.ToInt32(ComboBoxSelectExam.SelectedValue), controller, Convert.ToInt32(Exam_dt.Rows[ComboBoxSelectExam.SelectedIndex]["Marks"]));
                UpdateExamPage();
                /********/
            }
            else
            {
               MessageBox.Show("This Exam isn't running now, Can't enter exam");
            }
        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
            s+=1;
            if(s==60)
                {
                    s = 0;
                    m += 1;

                }
            if(m==60)
                {
                    m = 0;
                    h+=1;
                }
            TextBoxTimer.Text = String.Format("{0}:{1}:{2}",h.ToString(),m.ToString(),s.ToString());
                int elapsed = h * 3600 + m * 60 + s;
                if (elapsed == duration)
                {
                    EndExam();
                }
                else
                {
                    float prec = ((float)elapsed / (float)duration)*100;
                    metroSetProgressBar1.Value = Convert.ToInt32(prec);
                }
            }));
        }

        private void ComboBoxSelectExam_DropDownClosed(object sender, EventArgs e)
        {
            if (Exam_dt == null)
                return;
            TextboxExamDate.Text = Exam_dt.Rows[ComboBoxSelectExam.SelectedIndex]["Date"].ToString();
            TextBoxExmDuration.Text = Exam_dt.Rows[ComboBoxSelectExam.SelectedIndex]["Duration"].ToString();
            TextBoxExamID.Text = Exam_dt.Rows[ComboBoxSelectExam.SelectedIndex]["Exam_ID"].ToString();
        }
        private void EndExam()
        {
            Exam_Page_Count = 0;
            exam.submitExam();
            kryptonRichQuestionDescription.Hide();
            kryptonLabelQuestionNumber.Hide();
            TextBoxTimer.Hide();
            label9.Hide();
            LabelPoints.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            label8.Hide();
            SubmitExam.Hide();
            kryptonButtonNextQues.Hide();
            kryptonButtonPrevQues.Hide();
            metroSetProgressBar1.Hide();
       
        }
        private void SubmitExam_Click(object sender, EventArgs e)
        {
            EndExam();
            kryptonLabelYouGot.Text = String.Format("You got {0} out of {1}", exam.getMarks().ToString(), exam.getTotalMarks());
            kryptonLabelYouGot.Show();
            viewcorrection.Show();
            exitexam.Show();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                exam.AnswerCurrent(0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                exam.AnswerCurrent(1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                exam.AnswerCurrent(2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                exam.AnswerCurrent(3);
        }

        private void exitexam_Click(object sender, EventArgs e)
        {
            kryptonLabelYouGot.Hide();
            viewcorrection.Hide();
            exitexam.Hide();
            ComboBoxSelectExam.Show();
            TextboxExamDate.Show();
            TextBoxExamID.Show();
            TextBoxExmDuration.Show();
            label3.Show();
            label7.Show();
            label4.Show();
            label6.Show();
            ButtonEnterExam.Show();
            h = 0;
            m = 0;
            s = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void viewcorrection_Click(object sender, EventArgs e)
        {
            isAnswersShowing = true;
            kryptonLabelYouGot.Hide();
            exitexam.Hide();
            viewcorrection.Hide();
            exitExam2.Show();
            kryptonRichQuestionDescription.Show();
            kryptonLabelQuestionNumber.Show();
            label9.Show();
            LabelPoints.Show();
            radioButton1.Show();
            radioButton2.Show();
            radioButton3.Show();
            radioButton4.Show();
            label8.Show();
            kryptonButtonNextQues.Show();
            kryptonButtonPrevQues.Show();
            Exam_Page_Count = 0;
            exam.resetCount();
            SolvedStatus.Show();
            ls = exam.ReviewAnswers();
            UpdateExamPage();
            
        }

        private void exitExam2_Click(object sender, EventArgs e)
        {
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            label8.Hide();
            LabelPoints.Hide();
            label9.Hide();
            exitExam2.Hide();
            kryptonLabelQuestionNumber.Hide();
            kryptonRichQuestionDescription.Hide();
            SolvedStatus.Hide();
            kryptonLabelYouGot.Hide();
            viewcorrection.Hide();
            exitexam.Hide();
            ComboBoxSelectExam.Show();
            TextboxExamDate.Show();
            TextBoxExamID.Show();
            TextBoxExmDuration.Show();
            label3.Show();
            label7.Show();
            label4.Show();
            label6.Show();
            ButtonEnterExam.Show();
            h = 0;
            m = 0;
            s = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }

        private void PostsSubmitButton_Click(object sender, EventArgs e)
        {
            if (Post_dt != null && AddedCommentBox.Text != "")
            {

                if (controller.AddComment(Post_dt.Rows[Post_Count]["Class_ID"].ToString(), Post_dt.Rows[Post_Count]["Timestamp"].ToString(), OpenedSession.ID, AddedCommentBox.Text).Item1 != 0)
                {
                    AddedCommentBox.Text = "";
                    Comments_dt = controller.SelectCommentsForClass(ClassID, Post_dt.Rows[Post_Count]["Timestamp"].ToString());
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
            Post_dt = controller.SelectPostsForClass(ClassID);
            Post_Count = 0;
            UpdatePostsPage();
            
        }

        private void kryptonButtonNextQues_Click(object sender, EventArgs e)
        {
            if (Exam_Page_Count == exam.QuestionsCount()-1)
                return;
            Exam_Page_Count++;
            exam.CurrentQuestionIncr();
            this.UpdateExamPage();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            if (Exam_Page_Count ==0)
                return;
            Exam_Page_Count--;
            exam.CurrentQuestionDecr();
            this.UpdateExamPage();
        }
    }
}
