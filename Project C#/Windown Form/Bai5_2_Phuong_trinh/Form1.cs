using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_2_Phuong_trinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (!double.TryParse(txtA.Text.Trim(), out a) ||
                !double.TryParse(txtB.Text.Trim(), out b))
            {
                MessageBox.Show("Vui lòng nhập đúng hệ số a và b!");
                return;
            }

            if (radioBac1.Checked)
            {
                if (a == 0)
                {
                    if (b == 0)
                        txtKQ.Text = "Phương trình vô số nghiệm";
                    else
                        txtKQ.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    double x = -b / a;
                    txtKQ.Text = "x = " + x.ToString();
                }
            }
            else if (radioBac2.Checked)
            {
                if (!double.TryParse(txtC.Text.Trim(), out c))
                {
                    MessageBox.Show("Vui lòng nhập đúng hệ số c!");
                    return;
                }

                if (a == 0)
                {
                    txtKQ.Text = "Đây không phải phương trình bậc 2";
                    return;
                }

                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    txtKQ.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    txtKQ.Text = "Nghiệm kép x = " + x;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    txtKQ.Text = "x1 = " + x1 + " ; x2 = " + x2;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioBac1.Checked = true;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBac1.Checked)
            {
                lblC.Visible = false;
                txtC.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBac2.Checked)
            {
                lblC.Visible = true;
                txtC.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtB_Click(object sender, EventArgs e)
        {

        }
    }
}
