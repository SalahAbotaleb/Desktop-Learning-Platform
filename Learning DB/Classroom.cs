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
        int totalexampoints;
        int scalingfactor;
        int TodeleteQuestionID;
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
            DataTable dt;//= new DataTable();
            dt = c.SelectClassroomByID(Classroom_ID);
            kryptonTextBox15.Text = dt.Rows[0]["Title"].ToString();
            kryptonTextBox14.Text = dt.Rows[0]["Access_code"].ToString();


     

            //QuestionBank datatable
            d3 = new DataTable();
            d3 = c.SelectTopics();
            
            //not sure if we should restrict the topics to select from here by the courses relat
            //-ed to our classroom
            topicComboinQuestionBank.DataSource = d3;
            topicComboinQuestionBank.DisplayMember = "Topic";
            deleteQuestionTopic.DataSource = d3;
            deleteQuestionTopic.DisplayMember = "Topic";



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
            //if(DetermineQuesType_comboBox.Text=="")
            //if (!op1.Checked || !op2.Checked) { 

            //    return;
            //}
            //else
            //{
            //}
            //MetroSetRadioButton b = new MetroSetRadioButton();
            //string answer;
            AddQuestionQuestioBank.Enabled = true;

            string option1 = op1_textbox.Text;
            string option2 = op2_textbox.Text;
            string option3 = op3_textbox.Text;
            string option4 = op4_textbox.Text;
            //if (DetermineQuesType_comboBox.Text == "MCQ") { if (op1.Checked) { b = op1;
            //        answer = op1_textbox.Text;
            //    }
            //    if (op2.Checked) {
            //        b = op2;
            //        answer = op2_textbox.Text;
            //    }
            //    if (op3.Checked) {
            //        b = op3;
            //        answer = op3_textbox.Text;
            //    }
            //    if (op4.Checked) {
            //        b = op4;
            //        answer = op4_textbox.Text;
            //    }
            //}
            //else if (DetermineQuesType_comboBox.Text == "T/F")
            //{
            //    if (True_RadioButton.Checked) {
            //        b = True_RadioButton;
            //        answer = "True";

            //    }
            //    else
            //    {
            //        b = false_radiobutton;
            //        answer = "False";
            //    }
            //}
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
                if (DetermineQuesType_comboBox.Text == "T/F") {
                    if (True_RadioButton.Checked)
                    {
                        Tuple<int, string> s = c.AddQuestionOption(x, "True", true);
                        Tuple<int, string> s1 = c.AddQuestionOption(x, "False", false);
                    
                    }
                }else if(DetermineQuesType_comboBox.Text == "MCQ")
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
                AddQuestionQuestioBank.Enabled=false;
            }
        }

        

        private void totalexampointstxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void questionpointsTxtboxExam_TextChanged(object sender, EventArgs e)
        {

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
            TodeleteQuestionID = Int16.Parse(Qtxtboxin_Del_Ques.ValueMember);
        }

        private void deletequestionbutton_Click(object sender, EventArgs e)
        {

            //int result = c.DeleteQuestionbyID(TodeleteQuestionID);
            //if (result == 0)
            //{
            //    //MessageBox.Show(result);
            //    MessageBox.Show("Question couldn't be deleted.");

            //}
            //else
            //{
            //    MessageBox.Show("Question deleted successfuly");
            //}
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

        private void DetermineQuesType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
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
            }else if(DetermineQuesType_comboBox.Text == "MCQ")
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


      
    }


}
