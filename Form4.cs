using System;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Call the method to display data type values
            DisplayDataTypes();
        }

        private void DisplayDataTypes()
        {
            // Initialize the data types and display their values
            int a = 101;
            int c = 0xFace;
            int x = 0b101;

            // Set the output to the TextBox
            txtOutput.Text = $"Decimal: {a}{Environment.NewLine}Hexadecimal: {c}{Environment.NewLine}Binary: {x}";
        }
    }
}
