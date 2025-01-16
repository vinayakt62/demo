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
    public partial class Select : Form
    {
        NewRecord objNewRecord;
        DataTable objDataTable;
        public Select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int strpno = int.Parse(textBox1.Text);
                objNewRecord = new NewRecord();
                objDataTable = new DataTable();

                objDataTable = objNewRecord.SelectDetails(strpno);
                textBox2.Text = objDataTable.Rows[0][0].ToString();
                
                objDataTable.Dispose();
                objNewRecord.Dispose();
            }
            catch (Exception ex)
            { 
            }
        }
    }
}
