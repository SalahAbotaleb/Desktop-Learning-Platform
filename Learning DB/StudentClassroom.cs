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
        int Assignment_Page_Counter = 0;
        int Exam_Page_Count = 0;
        DataTable Assignment_dt;
        DataTable Exam_dt;
        int h, m, s;
        int duration;
        System.Timers.Timer Time_Remaining;
        public StudentClassroom(int classID,int StudentID)
        {
            InitializeComponent();
            this.ClassID = classID;
            this.StudentID = StudentID;
            Assignment_dt = cont.SelectAssignmentForClass(ClassID);
            Exam_dt = cont.SelectExamsForClass(ClassID);
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
        }

        private void UpdateExamPage()
        {
            
            
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
           
            AssignmentTitlelabel.Text = Assignment_dt.Rows[Assignment_Page_Counter]["Title"].ToString();
            DescriptionBox.Text = Assignment_dt.Rows[Assignment_Page_Counter]["Description"].ToString();
            DeadlineDateLabel.Text = Assignment_dt.Rows[Assignment_Page_Counter]["Deadline"].ToString();
            HisGradeLabel.Text = "/" + Assignment_dt.Rows[Assignment_Page_Counter]["Total_Grade"].ToString();
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
                Tuple<int, string> tp = cont.InsertSubmission(StudentID, Convert.ToInt32(Assignment_dt.Rows[Assignment_Page_Counter]["Assignment_ID"]), SubmissionLinkBox.Text);
                if (tp.Item1==1)
                    MessageBox.Show("Submission Successfuly");
                else
                    
                    MessageBox.Show(tp.Item2);
            }
        }

        private void ButtonEnterExam_Click(object sender, EventArgs e)
        {
            //if (Exam_dt != null&&cont.CheckExamAvailability(Convert.ToInt32(ComboBoxSelectExam.SelectedValue)) =="Enter")
            {
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

        }
        private void SubmitExam_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
