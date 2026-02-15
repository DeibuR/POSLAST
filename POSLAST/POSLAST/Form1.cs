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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter your username or password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Form3 f3 = new Form3();
                f3.Show();
                Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            Visible = false;
        }
    }
}
