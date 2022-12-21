using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Learning_DB;

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
    }
}
