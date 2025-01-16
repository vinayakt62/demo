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
    public partial class Add : Form
    {
        NewRecord objNewRecord;

        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objNewRecord = new NewRecord();

                objNewRecord.InsertDetails(textBox1.Text);
                objNewRecord.Dispose();

                MessageBox.Show("Record Save Successfully.");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
