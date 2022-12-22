using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Learning_DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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
        public DataTable SelectStudentNameByID(int SID)
        {
            string Query = "SELECT FName + \' \' + LName FROM Student WHERE StudentID = " + SID + ";";
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

    }   
}
