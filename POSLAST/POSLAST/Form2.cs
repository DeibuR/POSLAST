using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSLAST
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text==string.Empty ||  tb2.Text==string.Empty || tb3.Text == string.Empty)
            {
                MessageBox.Show("Please input your name, username and password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Form f1 = new Form1();
                f1.Show();
                Visible = false;
            }
        }
    }
}
