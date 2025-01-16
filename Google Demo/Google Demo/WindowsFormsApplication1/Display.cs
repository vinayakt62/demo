using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Display : Form
    {
        NewRecord objNewRecord;
        static int AutoID = 0;
        DataTable objDataTable;
        String a, b;
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet.tblName' table. You can move, or remove it, as needed.
          //  this.tblNameTableAdapter1.Fill(this._C__PROGRAM_FILES_MICROSOFT_SQL_SERVER_MSSQL_1_MSSQL_DATA_GOOGLEDEMO_MDFDataSet.tblName);
            // TODO: This line of code loads data into the 'googleDemoDataSet.tblName' table. You can move, or remove it, as needed.
            //this.tblNameTableAdapter.Fill(this.googleDemoDataSet.tblName);

          //  UpdateRecord
            try
            {
                objNewRecord = new NewRecord();
                objDataTable = new DataTable();
                objDataTable = objNewRecord.Show();
                if (objDataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < objDataTable.Rows.Count; i++)
                    {
                        dataGridView1.DataSource = objDataTable;
                    }
                }
                objNewRecord.Dispose();
                objDataTable.Dispose();
            }
            catch (Exception ex)
            {

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
