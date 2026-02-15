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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            ApplyHoverEffect(button1);
            ApplyHoverEffect(button2);
            ApplyHoverEffect(button3);
            ApplyHoverEffect(button4);
            ApplyHoverEffect(button5);
            ApplyHoverEffect(button6);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
            private void ApplyHoverEffect(Button btn)
        {
            btn.MouseEnter += (s, e) => { btn.BackColor = ColorTranslator.FromHtml("#005F02"); btn.ForeColor = Color.White; };
            btn.MouseLeave += (s, e) => { btn.BackColor = ColorTranslator.FromHtml("#F2E3BB"); btn.ForeColor = Color.Black; };
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int quan1;
            int.TryParse(tb1.Text, out quan1);
            dataGridView1.Rows.Add("Espresso", quan1, "₱" + 100);
            CalculateTotal();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int quan2;
            int.TryParse(tb2.Text, out quan2);
            dataGridView1.Rows.Add("Cappuccino", quan2, "₱" + 120);
            CalculateTotal();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int quan3;
            int.TryParse(tb3.Text, out quan3);
            dataGridView1.Rows.Add("Americano", quan3, "₱" + 110);
            CalculateTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quan4;
            int.TryParse(tb4.Text, out quan4);
            dataGridView1.Rows.Add("Mocha", quan4, "₱" + 115);
            CalculateTotal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int quan5;
            int.TryParse(tb5.Text, out quan5);
            dataGridView1.Rows.Add("Cold Brew", quan5, "₱" + 100);
            CalculateTotal();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int quan6;
            int.TryParse(tb6.Text, out quan6);
            dataGridView1.Rows.Add("Macchiato", quan6, "₱" + 134);
            CalculateTotal();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int qty = 0;
                decimal price = 0;

                int.TryParse(row.Cells[1].Value?.ToString(), out qty);

                string priceText = row.Cells[2].Value?.ToString().Replace("₱", "");
                decimal.TryParse(priceText, out price);

                grandTotal += qty * price;
            }

            ttl.Text = "₱" + grandTotal.ToString("N2");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton1.ForeColor = ColorTranslator.FromHtml("#005F02");
            } 
            else
            {
                radioButton1.ForeColor = Color.White;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton2.ForeColor = ColorTranslator.FromHtml("#005F02");
            }
            else
            {
                radioButton2.ForeColor = Color.White;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton3.ForeColor = ColorTranslator.FromHtml("#005F02");
            }
            else
            {
                radioButton3.ForeColor = Color.White;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult  result =
            MessageBox.Show("Prooceed payment?", "Payment", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Payment Successful", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Payment Cancelled", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
