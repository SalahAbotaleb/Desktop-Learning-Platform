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
    public partial class CreateExam : Form
    {
        DataTable d1;
        DataTable dtQuestbyTopic;
        int totalexampoints;
        int scalingfactor;
        Controller c;
        int ClassroomID;
        //int examDurationinMinutes;
        //string examTitle;
        //string examDescription;

        public CreateExam(int cid, DateTime dobj)
        {
            
            InitializeComponent();
            ClassroomID = cid;
            c=new Controller(); 
            d1 = new DataTable();
            d1 = c.SelectTopics(ClassroomID);
            choosetopiccombobox.DataSource = d1;
            choosetopiccombobox.DisplayMember = "Topic";
            totalexampoints = 0;    
            scalingfactor = 0;

            dtQuestbyTopic=new DataTable();
            dtQuestbyTopic = c.SelectQuestionsbyTopic(choosetopiccombobox.Text);
            addquestiontoexamcombobox.DataSource=dtQuestbyTopic;
            addquestiontoexamcombobox.DisplayMember = "Description";
            addquestiontoexamcombobox.ValueMember = "Question_ID";
            datetimetxtbox.Text = dobj.ToString();
        }

        private void CreateExam_Load(object sender, EventArgs e)
        {

        }

        private void choosetopiccombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //dtQuestbyTopic = new DataTable();
            dtQuestbyTopic = c.SelectQuestionsbyTopic(choosetopiccombobox.Text.ToString());
            addquestiontoexamcombobox.DataSource = dtQuestbyTopic;
            addquestiontoexamcombobox.DisplayMember = "Description";
            addquestiontoexamcombobox.ValueMember = "Description";
        }
        private void addquestiontoexamcombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            addquestiontoexamcombobox.DataSource = dtQuestbyTopic;
            //addquestiontoexamcombobox.Text=
            questionpointsTxtboxExam.Text = dtQuestbyTopic.Rows[addquestiontoexamcombobox.SelectedIndex]["Points"].ToString();
            totalexampointstxtbox.Text = (totalexampoints + Int16.Parse(questionpointsTxtboxExam.Text)).ToString();
            difficultyleveltxtbox.Text = dtQuestbyTopic.Rows[addquestiontoexamcombobox.SelectedIndex]["Difficulty_Level"].ToString();
            string s = totalexampointstxtbox.Text;
            scalingfactortextbox.Text = (100 / Decimal.Parse(s)).ToString();
        }

        private void choosetopiccombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void finishbutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("")

        }

        private void addquestionbutton_Click(object sender, EventArgs e)
        {

        }

        private void datetimetxtbox_Click(object sender, EventArgs e)
        {

        }

        private void totalexampointstxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
