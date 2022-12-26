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

namespace Learning_DB
{
    public partial class Classroom : Form
    {
        Controller c;
        int Classroom_ID;
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
            d3 = c.SelectTopics();
            
            //not sure if we should restrict the topics to select from here by the courses relat
            //-ed to our classroom
            topicComboinQuestionBank.DataSource = d3;
            topicComboinQuestionBank.DisplayMember = "Topic";
            deleteQuestionTopic.DataSource = d3;
            deleteQuestionTopic.DisplayMember = "Topic";
            deleteQuestionTopic.ValueMember = "Topic";

            /// Assignment ComboBox
            AssignmentDataTable = c.SelectAssignmentForClass(Classroom_ID);
            assignmentcombobox.DataSource = AssignmentDataTable;
            assignmentcombobox.DisplayMember = "Title";
            assignmentcombobox.DisplayMember = "Assignment_ID";
            stdAssignmentDatatable = c.SelectStudentbyClassroom(Classroom_ID);
            studentnameComboBox.ValueMember= "Student_ID";
            studentnameComboBox.DisplayMember= "Student_ID";
           

            //view grades
            chooseexamCombo.DataSource = c.SelectExamsForClass(Classroom_ID);
            chooseexamCombo.DisplayMember = "Title";
            chooseexamCombo.ValueMember = "Exam_ID";


            //exam for classroom initialization
            examsForClassroom = c.SelectExamsForClass(Classroom_ID);

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
                int x = c.getLastQuestion();
                MessageBox.Show(x.ToString());
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
                    MessageBox.Show("Question Options added.");
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
            CreateExam c = new CreateExam(Classroom_ID, dateTimePicker2.Value);
            c.Show();
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

        }

        private void studentnameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseexamCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseexamCombo.SelectedIndex == -1) return;
            //examsForClassroom.Da
            int id=Int16.Parse(examsForClassroom.Rows[chooseexamCombo.SelectedIndex]["Exam_ID"].ToString());
            maxgradetxtbox.Text = c.SelectMaxGradeinExam(id).ToString();
            mingradeTextbox.Text = c.SelectMinGradeinExam(id).ToString();
        
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