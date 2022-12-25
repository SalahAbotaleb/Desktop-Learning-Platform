using DbHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Learning_DB
{
    internal class Question
    {
        public string Description { set; get; }
        public string []options;
        bool[] is_answer;
        int[] Answer_ID;
        bool isCorrect=false;
        int Question_ID;
        int student_ID;
        int Exam_ID;
        public int points;
        int load_index;
        public int answer_index;
        public int selected_index=-1;
        Controller Controller;
        public Question(int Question_ID,int Student_ID, Controller Controller, int exam_ID)
        {
            isCorrect = false;
            options = new string[4];
            is_answer = new bool[4];
            Answer_ID = new int[4];
            load_index = 0;
            this.Controller = Controller;
            this.Question_ID = Question_ID;
            this.student_ID = Student_ID;
            Exam_ID = exam_ID;

            DataTable Ques = Controller.GetQuestion(Question_ID);
            points = Convert.ToInt32(Ques.Rows[0]["Points"]);
            Description = Ques.Rows[0]["Description"].ToString();
            DataTable dt = Controller.GetQuestionOptions(Question_ID);
            if (dt == null)
                return;
            foreach (DataRow dr in dt.Rows)
            {
                options[load_index] = dr["Answer_Description"].ToString();
                is_answer[load_index] = dr["Is_Answer"].Equals(true);
                Answer_ID[load_index] = Convert.ToInt32((dr["Answer_ID"]));
                if (is_answer[load_index] == true)
                    answer_index = load_index;
                load_index++;
            }
        }
        public bool submit_Question()
        {
             if (selected_index!=-1 && selected_index == answer_index)
                   isCorrect = true;
            
            Controller.SubmitAnswerForQuestion(Question_ID, Exam_ID, student_ID, isCorrect);

            return isCorrect;
        }
    }
    internal class Exam
    {
        int Student_ID;
        int Exam_ID;
        int CurrQuestion;
        int PointsWin=0;
        int totalPoints=0;
        int count;
        int TotalMarks;
        int ActualMarks;
        Controller Controller;
        List<Question> questions = new List<Question>();
        List<Tuple<int, int>> ls = new List<Tuple<int, int>>();
        public Exam(int Student_ID, int Exam_ID, Controller Controller,int Marks)
        {

            this.Student_ID = Student_ID;
            this.Exam_ID = Exam_ID;
            this.Controller = Controller;
            TotalMarks = Marks;
            DataTable dt = Controller.SelectQuestionsForExam(Exam_ID);
            if (dt == null)
                return;
            foreach (DataRow question in dt.Rows)
            {

                questions.Add(new Question(Convert.ToInt32(question["Question_ID"]), Student_ID, Controller, Exam_ID));
            }
            count = questions.Count;
        }
        public void CurrentQuestionIncr()
        {
            if (CurrQuestion == questions.Count())
                return;
            CurrQuestion++;
        }
        public void CurrentQuestionDecr()
        {
            if (CurrQuestion == 0)
                return;
            CurrQuestion--;
        }
        public string getCurrQuesDescription()
        {
            return questions[CurrQuestion].Description;
        }
        public string[] getCurrQuesOptions()
        {
            return questions[CurrQuestion].options;
        }
        public void InsertAnswer(int idx)
        {
            questions[CurrQuestion].selected_index = idx;
        }
        public void submitExam()
        {
            foreach (Question question in questions)
            {
                if (question.submit_Question() == true)
                {
                    PointsWin+=question.points;
                }
                totalPoints+=question.points;
                ls.Add(new Tuple<int, int>(question.answer_index, question.selected_index));
            }
            ActualMarks = (int)(((float)PointsWin * (float)TotalMarks) / (float)totalPoints);
            Controller.SubmitExam(Student_ID, Exam_ID, PointsWin);
        }
        public int getMarks()
        {
            return PointsWin;
        }
        public int getTotalMarks()
        {
            return totalPoints;
        }
        public int getPoints()
        {
            return TotalMarks;
        }
        public List<Tuple<int, int>> ReviewAnswers()
        {
            return ls;
        }
        public int QuestionsCount()
        {
            return count;
        }
        public int GetCurrQuesPoints()
        {
            return questions[CurrQuestion].points;
        }
        public void AnswerCurrent(int idx)
        {
            questions[CurrQuestion].selected_index = idx;
        }
        public int selectedOption()
        { return questions[CurrQuestion].selected_index; }
        public void resetCount()
        {
            CurrQuestion = 0;
        }
    }
}
