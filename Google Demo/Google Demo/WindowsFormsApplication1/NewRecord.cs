using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    class NewRecord
    {
        DatabaseOperation objDBOperations;
        DataTable objDataTable;
        string strQuery = "";

        public void Dispose()
        {
            objDBOperations.Dispose();
        }
        public void InsertDetails(string Name)
        {
            objDBOperations = new DatabaseOperation();
            strQuery = "Insert into tblName values(N'" + Name + "')";
            objDBOperations.InsertOrUpdateOrDelete(strQuery);
            objDBOperations.Dispose();
        }
        public DataTable SelectDetails(int no)
        {
            objDBOperations = new DatabaseOperation();
            objDataTable = objDBOperations.Select("SELECT [Nam] FROM tblName where No=" + no);
            objDBOperations.Dispose();
            return objDataTable;
        }
        public bool DeleteRecord(int no)
        {
            try
            {
                objDBOperations = new DatabaseOperation();
                strQuery = "Delete From tblName  where No=" + no;
                objDBOperations.InsertOrUpdateOrDelete(strQuery);
                objDBOperations.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public void UpdateRecord(string NewName, int  no)
        {           
            objDBOperations = new DatabaseOperation();
            objDataTable = new DataTable();
            string strQuery = "UPDATE tblName SET Name =N'" + NewName + "' WHERE No=" + no + "";
            objDBOperations.InsertOrUpdateOrDelete(strQuery);
            objDBOperations.Dispose();      
        }
        public DataTable Show()
        {
            objDBOperations = new DatabaseOperation();
            objDataTable = objDBOperations.Select("SELECT Name,No from tblName");
            objDBOperations.Dispose();
            return objDataTable;
        }
    }
}
