using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DatabaseOperation
    {
        DatabaseConnection objDBConnection;
        SqlCommand objSqlCommand;
        DataTable objDataTable;
        SqlDataAdapter objSqlDataAdapter;

        public DatabaseOperation()
        {
            objDBConnection = new DatabaseConnection();
        }
        public DataTable Select(string SelectQuery)
        {
            try
            {
                objDBConnection = new DatabaseConnection();
                objDBConnection.Open();
                objSqlDataAdapter = new SqlDataAdapter(SelectQuery, objDBConnection.GetConnectionObject());
                objDataTable = new DataTable();
                objSqlDataAdapter.Fill(objDataTable);

                objSqlDataAdapter.Dispose();
                objDBConnection.Close();
                objDBConnection.Dispose();
            }
            catch (Exception ex)
            {
                // Microsoft.VisualBasic.Interaction.MsgBox(Convert.ToString(ex), Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error in Select query.");
            }

            return objDataTable;
        }
        public void InsertOrUpdateOrDelete(string UpdateOrInsertOrDeleteQuery)
        {
            try
            {
                objDBConnection = new DatabaseConnection();
                objDBConnection.Open();
                objSqlCommand = new SqlCommand(UpdateOrInsertOrDeleteQuery, objDBConnection.GetConnectionObject());

                objSqlCommand.ExecuteNonQuery();

                objSqlCommand.Dispose();
                objDBConnection.Close();
                objDBConnection.Dispose();
            }
            catch (Exception ex)
            {
                //Microsoft.VisualBasic.Interaction.MsgBox(Convert.ToString(ex), Microsoft.VisualBasic.MsgBoxStyle.OkOnly, "Error......");
            }
        }
        public void Dispose()
        {
            objDBConnection.Dispose();
        }
    }
}
