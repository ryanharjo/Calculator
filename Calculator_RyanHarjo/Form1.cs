using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_RyanHarjo
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            Operation = "+";
        }
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            Operation = "-";
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            Operation = "*";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            Operation = "/";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txtDisplay.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txtDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {


                Result = (FirstNumber - SecondNumber);
                txtDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtDisplay.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txtDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }

            }
        }
    }
}
