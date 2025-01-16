using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    class DatabaseConnection
    {
        SqlConnection con;
        public DatabaseConnection()
        {
            setConnection();
        }
        void setConnection()
        {
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=C:\\PROGRAM FILES\\MICROSOFT SQL SERVER\\MSSQL.1\\MSSQL\\DATA\\GOOGLEDEMO.MDF;Integrated Security=True";
        }
        public void Open()
        {
            con.Open();
        }
        public void Close()
        {
            con.Close();
        }
        public SqlConnection GetConnectionObject()
        {
            return con;
        }
        public void Dispose()
        {
            con.Dispose();
        }
    }
}
