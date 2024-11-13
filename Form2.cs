using System;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Call the method to display data type values
            DisplayDataTypes();
        }

        private void DisplayDataTypes()
        {
            // Declare various data types and initialize them
            char a = 'G';
            int i = 89;
            short s = 56;
            long l = 4564;
            uint ui = 95;
            ushort us = 76;
            ulong ul = 3624573;
            double d = 8.358674532;
            float f = 3.7330645f;
            decimal dec = 389.5m;

            // Format the output string
            string output = "char: " + a + Environment.NewLine +
                            "integer: " + i + Environment.NewLine +
                            "short: " + s + Environment.NewLine +
                            "long: " + l + Environment.NewLine +
                            "float: " + f + Environment.NewLine +
                            "double: " + d + Environment.NewLine +
                            "decimal: " + dec + Environment.NewLine +
                            "Unsigned integer: " + ui + Environment.NewLine +
                            "Unsigned short: " + us + Environment.NewLine +
                            "Unsigned long: " + ul;

            // Display the formatted string in the TextBox
            txtOutput.Text = output;
        }
    }
}
