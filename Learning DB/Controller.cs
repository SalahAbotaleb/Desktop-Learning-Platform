using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

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
        //    string query = "SELECT * FROM Employee;";
        //    return dbMan.ExecuteReader(query);
        //}


        //public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        //{
        //    string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
        //                    "Values ('" + Pname + "'," + pnumber + ",'" + Plocation + "'," + Dnum + ");";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public DataTable SelectDepNum()
        //{
        //    string query = "SELECT Dnumber FROM Department;";
        //    return dbMan.ExecuteReader(query);
        //}
        //public DataTable SelectDepLoc()
        //{
        //    string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
        //    return dbMan.ExecuteReader(query);
        //}

        //public DataTable SelectProject(string location)
        //{
        //    string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
        //     + " where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='" + location + "';";

        //    return dbMan.ExecuteReader(query);
        //}
    }
}
