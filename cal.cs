using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class cal : Form
    {
        int num1 = 0;
        int num2 = 0;
        int op = 0;
        double result;
        string arithmeticOperator;
        double firstNumber;
        public cal()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt1.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt1.Text += btn9.Text;
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            int index = txt1.Text.Length;
            index--;
            txt1.Text = txt1.Text.Remove(index);
            if (txt1.Text == "0")
            {

                txt1.Text = "0";

            }

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txt1.Text = " ";
        }

        private void btnaddsub_Click(object sender, EventArgs e)
        {
            result = double.Parse(txt1.Text);
            result = result * -1;
            txt1.Text = result.ToString();

        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txt1.Text);
            txt1.Clear();
            op = 1;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txt1.Text);
            txt1.Clear();
            op = 2;
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txt1.Text);
            txt1.Clear();
            op = 3;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txt1.Text);
            txt1.Clear();
            op = 4;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txt1.Text);
            int result = 0;
            switch (op)
            {
                case 1:
                    result = num1 * num2;
                    break;
                case 2:
                    result = num1 + num2;
                    break;
                case 3:
                    result = num1 - num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                case 5:
                    double pow = double.Parse(txt1.Text);
                    double ans = Math.Exp(pow * Math.Log(firstNumber * 4));
                    txt1.Text = ans.ToString();
                    break;
                case 6:
                    txt1.Text = (firstNumber % double.Parse(txt1.Text)).ToString();
                    break;



                default:
                    break;

            }
            txt1.Text = result.ToString();
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            double val = Math.PI;
            txt1.Text = val.ToString();
        }

        private void btnLOG_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Log10(val);
            txt1.Text = val.ToString();
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Sqrt(val);
            txt1.Text = val.ToString();
        }

        private void btnsquarepow_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Pow(val, 2);
            txt1.Text = val.ToString();

        }

        private void btnSINH_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Sinh(val);
            txt1.Text = val.ToString();
        }

        private void btnSIN_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Sin(val);
            txt1.Text = val.ToString();

        }

        private void btnDEC_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                txt1.Text = System.Convert.ToString(a, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncubepow_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Pow(val, 3);
            txt1.Text = val.ToString();
        }

        private void btnCOSH_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Cosh(val);
            txt1.Text = val.ToString();
        }

        private void btnCOS_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Cos(val);
            txt1.Text = val.ToString();
        }

        private void btnHEX_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                txt1.Text = System.Convert.ToString(a, 16);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = 1 / val;
            txt1.Text = val.ToString();
        }

        private void btnTANH_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Tanh(val);
            txt1.Text = val.ToString();
        }

        private void btnTAN_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Tan(val);
            txt1.Text = val.ToString();
        }

        private void btnBIN_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                txt1.Text = System.Convert.ToString(a, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txt1.Text);
            val = Math.Log(val);
            txt1.Text = val.ToString();
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txt1.Text);
            txt1.Clear();
            op = 5;
        }

        private void btnMOD_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txt1.Text);
            txt1.Clear();
            op = 6;
        }

        private void btnOCT_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                txt1.Text = System.Convert.ToString(a, 8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {

            double val = double.Parse(txt1.Text);
            val = val / 100;
            txt1.Text = val.ToString();
        }

        private void btndot_Click(object sender, EventArgs e)
        {



        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
