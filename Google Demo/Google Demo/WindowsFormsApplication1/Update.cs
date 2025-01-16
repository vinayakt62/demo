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
    public partial class Update : Form
    {
        NewRecord objNewRecord;

        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {              
                        objNewRecord = new NewRecord();
                        objNewRecord.UpdateRecord(textBox2.Text,int.Parse(textBox1.Text));
                        MessageBox.Show("Password Updated Successfully", "Message");
                        objNewRecord.Dispose();                      
            }
            catch (Exception ex)
            {

            }
        }
    }
}
