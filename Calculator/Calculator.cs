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
    public partial class Calculator : Form
    {
        string input = string.Empty;        //String storing user input
        string operand1 = string.Empty;     //String storing first operand
        string operand2 = string.Empty;     //String storing second operand
        char operation;                     //Char for operation
        double result = 0.0;                //Calculated result
        public Calculator()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += ".";
            this.label1.Text += input;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "0";
            this.label1.Text += input;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "1";
            this.label1.Text += input;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "2";
            this.label1.Text += input;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "3";
            this.label1.Text += input;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "4";
            this.label1.Text += input;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "5";
            this.label1.Text += input;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "6";
            this.label1.Text += input;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "7";
            this.label1.Text += input;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "8";
            this.label1.Text += input;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            input += "9";
            this.label1.Text += input;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void button_equ_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            this.textBox1.Text = "0";
            this.input = String.Empty;
            this.operand1 = String.Empty;
            this.operand2 = String.Empty;
        }

        private void button_neg_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
