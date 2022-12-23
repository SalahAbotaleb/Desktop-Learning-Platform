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
        public Tuple<int, string> UpdateInstructor(int ID, string username, string Fname, string Lname, string Email, string Title, string Password , int Done_By)
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
        public Tuple<int, string> InsertInstructor(string username, string Fname, string Lname, string Email, int added_by, string password, string Title)
        {

            string StoredProcedureName = StoredProcedures.InsertInstructor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Email", Email);
            Parameters.Add("@added_by", added_by);
            Parameters.Add("@password", password);
            Parameters.Add("@Title", Title);

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

        public Tuple <int,string> UpdateAdmin(int ID, string username, string Fname, string Lname, string Email)
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
        public Tuple<int,string> InsertAdmin(string username ,string Fname,string Lname,string Email ,int added_by ,string password)
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
        public Tuple<DataTable,string> LoginStudent(string username, string password)
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
        public DataTable SelectAdminByID(int AID)
        {
            string Query = "SELECT FName + \' \' + LName, Fname,Lname,Email,Username FROM Admin WHERE Admin_ID = " + AID + ";";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable SelectAdminByID_SuperID(int SSID ,int AID)
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
        public DataTable SelectInstructorByID(int IID)
        {
            string Query = "SELECT Fname,Lname,Email,Username,Title FROM Instructor WHERE Instructor_ID = " + IID + ";";
            return dbMan.ExecuteReader(Query);
        }
        public Tuple<DataTable, string> SelectInstructorsForClassByID(int CID)
        {
            string StoredProcedureName = StoredProcedures.SelectInstructorsForClassByID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ClassID", CID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<DataTable, string> SelectClassInfoForStudent(int CID)
        {
            string StoredProcedureName = StoredProcedures.SelectClassInfoForStudent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", CID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public Tuple<int, string> UpdateStudent(string Fname, String Lname, String Email,int year,string Username, int SID )
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
    }   
}
