using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DbHandler
{
    public class DBManager
    {
        static string DB_Connection_String = @"Data Source=dbms-project.database.windows.net;Initial Catalog=Learning_Platform;Persist Security Info=True;User ID=adminS;Password=Salah123";
        SqlConnection myConnection;

    public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open();
                Console.WriteLine("The DB connection is opened successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("The DB connection is failed");
                Console.WriteLine(e.ToString());
            }
        }

        public Tuple<int,string> ExecuteNonQuery(string storedProcedureName, Dictionary<string, object> parameters)
        {
            //if returned value is 0
            //there are error, the message will be send in second parameter as string
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                foreach (KeyValuePair<string, object> Param in parameters)
                {
                    myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                }
                return Tuple.Create(myCommand.ExecuteNonQuery(),"");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Tuple.Create(0,ex.Message);
            }
        }

        public Tuple<DataTable,string> ExecuteReader(string storedProcedureName, Dictionary<string, object> parameters)
        {
            //if returned value is null (Datatable)
            //the message will be send in second parameter as string
            DataTable dt = null;
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in parameters)
                    {
                        myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                    }
                }

                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return Tuple.Create(dt,"");
                }
                else
                {
                    reader.Close();
                    return Tuple.Create(dt, "");
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Tuple.Create(dt, ex.Message);
            }
        }

        public Tuple<Object, string> ExecuteScalar(string storedProcedureName, Dictionary<string, object> parameters)
        {
            //if returned value is null (Object)
            //the message will be send in second parameter as string
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in parameters)
                    {
                        myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                    }
                }

                return Tuple.Create(myCommand.ExecuteScalar(),"");            

            }
            catch (Exception ex)
            {
                Object ob = null;
                Console.WriteLine(ex.Message);
                return Tuple.Create(ob, ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    }

