using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    public partial class Form1 : Form
    {
        float first, second, result;

        private void Addition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Subtraction_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Multiplication_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Division_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Evaluate_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
                first = float.Parse(textBox1.Text);
                second = float.Parse(textBox2.Text);
                    if (Division.Checked == true)
                    {
                        result = first / second;
                        MessageBox.Show(result.ToString());
                    }
                    
                    else if (Addition.Checked == true)
                    {
                        result = first + second;
                        MessageBox.Show(result.ToString());
                    }
                    
                    else if (Subtraction.Checked == true)
                    {
                        result = first - second;
                        MessageBox.Show(result.ToString());
                    }
                    
                    else if (Multiplication.Checked == true)
                    {
                        result = first * second;
                        MessageBox.Show(result.ToString());
                    }
            }
            else
                MessageBox.Show("Please enter valid input for the operands");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
