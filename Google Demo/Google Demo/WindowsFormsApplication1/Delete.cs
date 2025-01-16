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
    public partial class Delete : Form
    {
        NewRecord objNewRecord;
        bool a = false;
        int No;
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                No = int.Parse(textBox1.Text);
                objNewRecord = new NewRecord();
                a = objNewRecord.DeleteRecord(No);
                objNewRecord.Dispose();
                    MessageBox.Show("Recored Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record Not Found");
            }
        }
    }
}
