using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roy_CalculatorProject
{
    public partial class Calculator : Form
    {
        string input = string.Empty;        //String storing user input
        string operand1 = string.Empty;     //String storing first operand
        string operand2 = string.Empty;     //string storing second operand
        double results = 0.0;               //calculated result

        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input; 
        }

        private void buttonDeci_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            char operation = default(char);
            if (operation == '+')
            {
                results = num1 + num2;
                textBox1.Text = results.ToString();
            }

            else if (operation == '-')
            {
                results = num1 - num2;
                textBox1.Text = results.ToString();
            }
            else if (operation == '*')
            {
                results = num1 * num2;
                textBox1.Text = results.ToString();
            }
            else if (operation == '/')
            {
                if (num1 !=0)
                {
                    results = num1 / num2;
                    textBox1.Text = results.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }
                
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }
    }
}
