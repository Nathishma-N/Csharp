using System;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Displaying the value of 'a' in txtOutput
            int a = 10;
            string output = $"The value of a is: {a}";

            // Setting the TextBox text to show the result
            txtOutput.Text = output;
        }
    }
}
