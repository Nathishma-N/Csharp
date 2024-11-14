using System;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class operators : Form
    {
        public operators()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DisplayArithmeticOperations();
        }

        private void DisplayArithmeticOperations()
        {
            int result;
            int x = 10, y = 5;

            result = (x + y);
            txtOutput.Text += "Addition Operator: " + result + Environment.NewLine;

            result = (x - y);
            txtOutput.Text += "Subtraction Operator: " + result + Environment.NewLine;

            result = (x * y);
            txtOutput.Text += "Multiplication Operator: " + result + Environment.NewLine;

            result = (x / y);
            txtOutput.Text += "Division Operator: " + result + Environment.NewLine;

            result = (x % y);
            txtOutput.Text += "Modulo Operator: " + result + Environment.NewLine;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
