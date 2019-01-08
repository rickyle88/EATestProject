using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Helpers
{
    //Extension Class rules to be followed
    //1. Make static class
    //2. Make static method
    //3. First parameter of methods should be the type followed by this
    public static class DatabaseHelperExtensions
    {
        //Open the connection
        public static SqlConnection DBConnect(this SqlConnection sqlConnection, string connectionString)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception e)
            {
                LogHelpers.Write("Error: " + e.Message);
                
            }
            return null;
        }

        //Closing the connection
        public static void DBClose(this SqlConnection sqlConnection)
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                LogHelpers.Write("Error: " + e.Message);
                
            }
        }

        //Execution
        public static DataTable ExecuteQuery(this SqlConnection sqlConnection, string queryString)
        {
            DataSet dataSet;
            try
            {
                //Checking the state of the connection
                if(sqlConnection == null || ( (sqlConnection != null) && (sqlConnection.State == ConnectionState.Closed || sqlConnection.State == ConnectionState.Broken)))
                {
                    sqlConnection.Open();
                }

                SqlDataAdapter dataAdaptor = new SqlDataAdapter();
                dataAdaptor.SelectCommand = new SqlCommand(queryString, sqlConnection);
                dataAdaptor.SelectCommand.CommandType = CommandType.Text;

                dataSet = new DataSet();
                dataAdaptor.Fill(dataSet, "Table");

                return dataSet.Tables["table"];


            }
            catch (Exception e)
            {
                dataSet = null;
                sqlConnection.Close();
                LogHelpers.Write("Error: " + e.Message);
                return null;
            }
            finally
            {
                sqlConnection.Close();
                dataSet = null;
            }
        }

    }
}
