using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Learning_DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DbHandler
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        internal Tuple<int,String> InsertSubmission(int studentID, int classID, string text)
        {
            //@Submission_Link varchar(200),@Student_ID int,@Assignment_ID int
            string StoredProcedureName = StoredProcedures.UpdateInstructor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Assignment_ID", classID);
            Parameters.Add("@Student_ID", studentID);
            Parameters.Add("@Submission_Link", text);

            return dbMan.ExecuteNonQuery(StoredProcedures.InsertSumbission, Parameters);
        }
        internal int SubmitAnswerForQuestion(int Question_ID,int Exam_ID,int Student_ID,bool isCorrect)
        {
            string sql= @"insert into Exams_Submission_Answers(Question_ID, Exam_ID, Student_ID, Is_Correct)
                         values("+Question_ID+", "+Exam_ID+","+Student_ID+" ,"+isCorrect+")";
            return dbMan.ExecuteNonQuery(sql);
        }
        internal int SubmitExam( int Student_ID, int Exam_ID,int Grade)
        {
            string sql = @"insert into Exam_Taken(student_id, exam_id, grade)
                         values(" + Student_ID + ", " + Exam_ID + "," + Grade + ")";
            return dbMan.ExecuteNonQuery(sql);
        }

        internal DataTable SelectQuestionsForExam(int Exam_ID)
        {
            String sql = @"select * from Exam_Questions where Exam_ID=" + Exam_ID;
            return dbMan.ExecuteReader(sql);
        }
        internal DataTable SelectExamsForClass(int classID)
        {
            String sql = @"Select *,dbo.fnSecondsFromTime(Duration) as DurationCount from Exam where Class_ID=" + classID;
            return dbMan.ExecuteReader(sql);
        }
        internal DataTable GetQuestionOptions(int Question_ID)
        {
            String sql = @"select * from Question_Options where Question_ID=" + Question_ID+ " order by newid()";
            return dbMan.ExecuteReader(sql);
        }
        internal DataTable GetQuestion(int Question_ID)
        {
            String sql = @"select * from Question where Question_ID="+Question_ID;
            return dbMan.ExecuteReader(sql);
        }

        //public DataTable SelectAllEmp()
        //{

        //    string StoredProcedureName = StoredProcedures.SelectAllEmployees;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}


        //public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        //{

        //    string StoredProcedureName = StoredProcedures.InsertProject;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Pname", Pname);
        //    Parameters.Add("@Pnumber", pnumber);
        //    Parameters.Add("@Plocation", Plocation);
        //    Parameters.Add("@Dnum", Dnum);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName,Parameters);
        //}

        //public DataTable SelectDepNum()
        //{
        //    string StoredProcedureName = StoredProcedures.SelectDepartmentNum;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);

        //}
        //public DataTable SelectDepLoc()
        //{
        //    String StoredProcedureName = StoredProcedures.SelectDepartmentLocation;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);

        //}
        public Tuple<int, string> UpdateInstructor(int ID, string username, string Fname, string Lname, string Email, string Title, string Password, int Done_By)
        {

            string StoredProcedureName = StoredProcedures.UpdateInstructor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@username", username);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Email", Email);
            Parameters.Add("@Title", Title);
            Parameters.Add("@Password", Password);
            Parameters.Add("@Done_By", Done_By);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        internal String CheckExamAvailability(int Exam_ID)
        {
            string StoredProcedureName = StoredProcedures.CheckExamAvailability;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Exam_ID", Exam_ID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters).Item2;
        }

        //public Tuple<int, string> InsertInstructor(string username, string Fname, string Lname, string Email, int added_by, string password, string Title)
        //{

        //    string StoredProcedureName = StoredProcedures.InsertInstructor;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@username", username);
        //    Parameters.Add("@Fname", Fname);
        //    Parameters.Add("@Lname", Lname);
        //    Parameters.Add("@Email", Email);
        //    Parameters.Add("@added_by", added_by);
        //    Parameters.Add("@password", password);
        //    Parameters.Add("@Title", Title);

        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //
        public Tuple<DataTable, string> ManageDoneOnStudent(int ID)
        {
            string StoredProcedureName = StoredProcedures.ManageDoneOnStudent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<DataTable, string> ManageDoneOnInstructor(int ID)
        {
            string StoredProcedureName = StoredProcedures.ManageDoneOnInstructor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<DataTable,string> ManageByAdmin(int ID)
        {
            string StoredProcedureName = StoredProcedures.ManageByAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> ActivateStudent(int ID, bool Status, int Done_By)
        {
            string StoredProcedureName = StoredProcedures.ActivateStudent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Status", Status);
            Parameters.Add("@Done_By", Done_By);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> ActivateAdmin(int ID, bool Status)
        {
            string StoredProcedureName = StoredProcedures.ActivateAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Status", Status);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> ActivateInstructor(int ID, bool Status, int Done_By)
        {
            string StoredProcedureName = StoredProcedures.ActivateInstructor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Status", Status);
            Parameters.Add("@Done_By", Done_By);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> UpdateCourse(int ID, string Course_Name, string Description, int Done_By)
        {
            string StoredProcedureName = StoredProcedures.UpdateCourse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Course_Name", Course_Name);
            Parameters.Add("@Description", Description);
            Parameters.Add("@Done_By", Done_By);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public Tuple<int, string> UpdateAdmin(int ID, string username, string Fname, string Lname, string Email)
        {

            string StoredProcedureName = StoredProcedures.UpdateAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@username", username);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> InsertCourse(string @Course_Name, string @Course_Description, int @Added_By)
        {

            string StoredProcedureName = StoredProcedures.InsertCourse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Course_Name", @Course_Name);
            Parameters.Add("@Course_Description", @Course_Description);
            Parameters.Add("@Added_By", @Added_By);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public Tuple<int, string> InsertAdmin(string username, string Fname, string Lname, string Email, int added_by, string password)
        {

            string StoredProcedureName = StoredProcedures.InsertAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Email", Email);
            Parameters.Add("@added_by", added_by);
            Parameters.Add("@password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> InsertClassroom(string title,int COURSEID, int added_by)
        {
            
            string StoredProcedureName = StoredProcedures.AddClassroom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Title", title);
            Parameters.Add("@Course_ID", COURSEID);
            Parameters.Add("@Created_By", added_by);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public Tuple<int, string> InsertStudent(string username, string Fname, string Lname, string Email, int added_by, string password, string Birth_Date, int Year)
        {
            string StoredProcedureName = StoredProcedures.InsertStudent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Email", Email);
            Parameters.Add("@added_by", added_by);
            Parameters.Add("@password", password);
            Parameters.Add("@Birth_Date", Birth_Date);
            Parameters.Add("@Year", Year);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> InsertInstructor(string username, string Fname, string Lname, string Email, int added_by, string password, string title)
        {

            string StoredProcedureName = StoredProcedures.InsertInstructor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Email", Email);
            Parameters.Add("@added_by", added_by);
            Parameters.Add("@password", password);
            Parameters.Add("@Title", title);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public Tuple<DataTable, string> LoginStudent(string username, string password)
        {
            string StoredProcedureName = StoredProcedures.Loginstudent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<DataTable, string> LoginAdmin(string username, string password)
        {
            string StoredProcedureName = StoredProcedures.Loginadmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<DataTable, string> LoginInstructor(string username, string password)
        {
            string StoredProcedureName = StoredProcedures.LoginInstructor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<DataTable, string> SearchClassroomForStudent(string code)
        {
            string StoredProcedureName = StoredProcedures.SelectClassroomByCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AccessCode", code);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<DataTable, string> SelectInstructorsForClassByCode(string code)
        {
            string StoredProcedureName = StoredProcedures.SelectInstructorsForClassByCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AccessCode", code);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> EnrollStudentByAccessCode(string code, int studentID)
        {
            string StoredProcedureName = StoredProcedures.EnrollStudentByAccessCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AccessCode", code);
            Parameters.Add("@StudentID", studentID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable SelectStudentByID(int SID)
        {
            string Query = "SELECT * FROM Student WHERE StudentID = " + SID + ";";
            return dbMan.ExecuteReader(Query);
        }
        //public DataTable SelectInstructorByID(int In_ID)
        //{
        //    string Query = "SELECT * FROM Instructor WHERE Instructor_ID = " + In_ID + ";";
        //    return dbMan.ExecuteReader(Query);
        //}
        public DataTable SelectCoursesbyID(int CId)
        {
            string Query = "SELECT * FROM Course WHERE Course_ID = " + CId + ";";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable SelectCourses()
        {
            string Query = "SELECT * FROM Course";
            return dbMan.ExecuteReader(Query);
        }
    

        public DataTable SelectClassrooms()
        {
            string Query = "SELECT * FROM Classroom";
            return dbMan.ExecuteReader(Query);
        }


        public DataTable SelectClassesForStudent(int SID)
        {
            string Query = "select Classroom.Class_ID,Title from Classroom, Student,Student_Enrolled_In where Classroom.Class_ID = Student_Enrolled_In.Class_ID AND Student_ID = StudentID AND StudentId = " + SID + ";";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectClassroomByID(int CID)
        {
            string Query = "SELECT * FROM Classroom WHERE Class_ID = " + CID + ";";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectStudent_UsernameByClassroomID(int CID)
        {
            string Query = "Select * From Student Where StudentID IN(Select Student_ID From Student_Enrolled_In Where Class_ID = " + CID + ");";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectStudentByClassroomID(int CID , int SID)
        {
            string Query = "Select * From Student Where StudentID IN(Select Student_ID From Student_Enrolled_In Where Class_ID = "+CID+" And Student_ID = "+SID+");";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectAdminToBeActivated()
        {
            string Query = "Select * From Admin Where Super_ID = 20 And Activated = 0 ";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectInstructorToBeActivated()
        {
            string Query = "Select * From Instructor Where Instructor_ID IN (Select Instructor_ID From Manage_Instructor Where  Admin_ID = 20 And Activated = 0)";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectStudentToBeActivated()
        {
            string Query = "Select * From Student Where StudentID IN(Select Student_ID From Manage_Student Where Admin_ID = 20 And Activated = 0)";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectLastAdmin()
        {
            string Query = "Select IDENT_CURRENT( 'Admin' ) ";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectLastInstructor()
        {
            string Query = "Select IDENT_CURRENT( 'Instructor' ) ";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectLastStudent()
        {
            string Query = "Select IDENT_CURRENT( 'Student' ) ";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectAllAdmin()
        {
            string Query = "SELECT * FROM Admin ";
            return dbMan.ExecuteReader(Query);
        }
        
        public DataTable SelectAdminByID(int AID)
        {
            string Query = "SELECT FName + \' \' + LName, Fname,Lname,Email,Username FROM Admin WHERE Admin_ID = " + AID + ";";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectAdminByID_SuperID(int SSID, int AID)
        {
            string Query = "SELECT Fname,Lname,Email,Username FROM Admin WHERE Super_ID = " + SSID + " AND Admin_ID = " + AID + ";";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectAdminBySuper_ID(int AID)
        {
            string Query = "SELECT FName, LName, Email, Username FROM Admin WHERE Super_ID = " + AID + ";";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable SelectAdminUsernameByID(int AID)
        {
            string Query = "SELECT Username,Admin_ID FROM Admin WHERE Super_ID = " + AID + ";";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectAllInstructor_Username()
        {
            string Query = "SELECT * FROM Instructor";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectCourseByID(int CID)
        {
            string Query = "SELECT * FROM Course WHERE Course_ID = " + CID + ";";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectAllCourse_Name()
        {
            string Query = "SELECT * FROM Course";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectAllStudent_Username()
        {
            string Query = "SELECT * FROM Student";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectInstructorByID(int IID)
        {
            string Query = "SELECT Fname,Lname,Email,Username,Title FROM Instructor WHERE Instructor_ID = " + IID + ";";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable SelectClassroomForInstructorbyIn_ID(int CID)
        {
            string Query = "SELECT Title, Class_ID, Access_code FROM Classroom, Instructor WHERE Classroom.= " + CID + ";";
            return dbMan.ExecuteReader(Query);
        }

        public Tuple<DataTable, string> SelectInstructorsForClassByID(int CID)
        {
            string StoredProcedureName = StoredProcedures.SelectInstructorsForClassByID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ClassID", CID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        //public Tuple<DataTable, string> SelectClassforInstructorbyID(int Inst_ID)
        //{
        //    string StoredProcedureName = StoredProcedures.SelectClassforInstructorbyID;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Ins_ID", Inst_ID);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        public Tuple<DataTable, string> SelectClassInfoForStudent(int CID)
        {
            string StoredProcedureName = StoredProcedures.SelectClassInfoForStudent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", CID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> UpdateStudent(string Fname, String Lname, String Email, int year, string Username, int SID)
        {
            string StoredProcedureName = StoredProcedures.UpdateStudent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Email", Email);
            Parameters.Add("@username", Username);
            Parameters.Add("@ID", SID);
            Parameters.Add("@year", year);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public Tuple<int, string> UpdateInstructor(string Fname, String Lname, String Email, string Username, int IID, string password, string title)
        {
            string StoredProcedureName = StoredProcedures.UpdateInstructor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Email", Email);
            Parameters.Add("@username", Username);
            Parameters.Add("@ID", IID);
            Parameters.Add("@Title", title);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable SelectAssignmentForClass(int CID)
        {
            string Query = "SELECT * FROM Assignment WHERE Class_ID = " + CID + ";";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectMaterialsForClass(int CID)
        {
            string Query = "SELECT Title, Link FROM Material WHERE Class_ID = " + CID + " ;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectEventsForClass(int CID)
        {
            string Query = "SELECT Title, Date FROM Event WHERE Class_ID = " + CID + " ;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectPostsForClass(int CID)
        {
            string Query = @"SELECT Class_ID,Timestamp,Posts.Title,Instructor.Title + ' ' + FName + ' ' + Lname + ': ' + Announcement as Announcement,Posts.Instructor_ID 
                            FROM Posts,Instructor 
                            WHERE Posts.Instructor_ID = Instructor.Instructor_ID AND Class_ID = " + CID + " ORDER BY Timestamp DESC;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectCommentsForClass(int CID, string timestamp)
        {
            string Query = @"select name + ': ' + Comment as Comment,Date
                            from Comment_On_Post
                            join (SELECT FName + ' ' + LName as name , StudentID as id
                            FROM Student
                            union
                            SELECT Title + ' ' + FName + ' ' + LName as name, Instructor_ID as id
                            FROM Instructor) as Names on Comment_Owner_ID = id
                            where Class_ID =  " + CID + @" And Timestamp = '" + timestamp + @"'
                            ORDER BY Date DESC;";
            return dbMan.ExecuteReader(Query);
        }

        //added by Mohamed Gamal
        // functions for AddQuestiontoExam and AddQuestion
        public DataTable SelectQuestions()
        {
            string Query = "SELECT * FROM Question ;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectTopics()
        {
            string Query = "SELECT * FROM Course_Topics ;";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable SelectQuestionsbyTopic(string topicName)
        {
            string Query = "SELECT * FROM Question WHERE Topic='" + topicName + "';";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable SelectTopicName(string topicName)
        {

            //it should be selecting only topics related to the course that's related to
            //my classroom

            string Query = "SELECT * FROM Question WHERE Topic='" + topicName + "';";
            return dbMan.ExecuteReader(Query);
        }


        public Tuple<int, string> AddQuestion(string topic, int classroomID, int points, int difficulty, string description)
        {
            string StoredProcedureName = StoredProcedures.AddQuestion;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Topic", topic);
            Parameters.Add("@Classroom_ID", classroomID);
            Parameters.Add("@Points", points);
            Parameters.Add("@Difficulty_level", difficulty);
            Parameters.Add("@Description", description);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public Tuple<int, string> AddQuestionToExam(int examid, int questionid)
        {
            string StoredProcedureName = StoredProcedures.AddQuestionToExam;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Exam_ID", examid);
            Parameters.Add("@Question_ID", questionid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable DeleteQuestionbyID(int Q_ID)
        {
            string Query = "DELETE FROM QUESTION WHERE QUESTION.Question_ID=" + Q_ID + ";";
            return dbMan.ExecuteReader(Query);
        }

        //public DataTable SelectQuestionsThatHaveNoAnswersbyTopic(string topic)
        //{
        //    string Query = "Select * FROM QUESTION WHERE QUESTION.Question_ID=" + topic + ";";
        //    return dbMan.ExecuteReader(Query);
        //}

        public Tuple<int, string> AddNewMaterial(int Classroom_id, string link, string title)
        {
            string StoredProcedureName = StoredProcedures.AddNewMaterial;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Class_ID",Classroom_id);
            Parameters.Add("@Link",link);
            Parameters.Add("@Title",title);
          
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public Tuple<int, string> AddQuestionOption(int QID, string option, bool IsAnswer)
        {
            string StoredProcedureName = StoredProcedures.AddQuestionOption;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Question_ID", QID);
            Parameters.Add("@option", option);
            Parameters.Add("@IsAnswer", IsAnswer);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

       

        internal Tuple<int, string> AddComment(string CID, string TS, int iD, string Comm)
        {
            string StoredProcedureName = StoredProcedures.CommentOnPost;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@class_id", CID);
            Parameters.Add("@timestamp", TS);
            Parameters.Add("@Comment_Owner_ID", iD);
            Parameters.Add("@comment", Comm);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int getLastQuestion()
        {
            string Query = "Select top 1 Question_ID from Question order by Question_ID desc";
            return dbMan.ExecuteNonQuery(Query);
        }

        public DataTable SelectStudentbyClassroom(int C_ID)
        {
            string Query = "SELECT * FROM STUDENT WHERE StudentID in ( SELECT Student_ID FROM Student_Enrolled_In Where Class_ID="+C_ID+");";
            return dbMan.ExecuteReader(Query);
        }

        public int SelectMaxGradeinExam(int EID)
        {
            string Query = "Select Max(Marks) from Exam Where Exam_ID=" + EID + ";"; 
            return dbMan.ExecuteNonQuery(Query);
        }

        public int SelectMinGradeinExam(int EID)
        {
            string Query = "Select Min(Marks) from Exam Where Exam_ID=" + EID + ";";
            return dbMan.ExecuteNonQuery(Query);
        }
        public Tuple<int, string> AddAssignment(DateTime Deadline, string Description, int Class_ID, string Title,int Total_Grade)
        {
            string StoredProcedureName = StoredProcedures.AddAssignment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Deadline", Deadline);
            Parameters.Add("@Description", Description);
            Parameters.Add("@Class_ID", Class_ID);
            Parameters.Add("@Title", Title);
            Parameters.Add("@Total_Grade", Total_Grade);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        

    }
}
