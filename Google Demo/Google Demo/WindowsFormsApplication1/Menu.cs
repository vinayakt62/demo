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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            a.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display d = new Display();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete dd = new Delete();
            dd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Select s = new Select();
            s.Show();
        }
    }
}
