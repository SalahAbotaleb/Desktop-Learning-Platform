using DbHandler;
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
            //topicComboinQuestionBank.DisplayMember = "Course";



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
                MessageBox.Show("Question added successfuly");
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

        }

        private void deletequestionbutton_Click(object sender, EventArgs e)
        {

            //int result = c.DeleteQuestionbyID();

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


        //some shitty shit code
        // private void material_title_Textbox_Enter(object sender, EventArgs e)
        //{
        //    if (material_title_Textbox.Text == "Enter Instructor's Username")
        //    {
        //        material_title_Textbox.Text = "";
        //        material_title_Textbox.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
        //        material_title_Textbox.StateCommon.Content.Color1 = Color.Black;
        //    }
        //}

        //private void material_title_Textbox_Leave(object sender, EventArgs e)
        //{
        //    if (material_title_Textbox.Text == "")
        //    {
        //        material_title_Textbox.Text = "Enter Instructor's Username";
        //        material_title_Textbox.StateCommon.Content.Font = new Font("JetBrains Mono", 12, System.Drawing.FontStyle.Italic);
        //        material_title_Textbox.StateCommon.Content.Color1 = Color.Gray;
        //    }
        //}
    }


}
