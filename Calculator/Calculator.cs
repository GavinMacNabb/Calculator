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
            input += ".";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            input += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            input += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            input += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            input += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            input += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            input += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            input += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            input += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            input += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            input += "9";
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
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {

        }

        private void button_neg_Click(object sender, EventArgs e)
        {

        }
    }
}
