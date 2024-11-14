using System;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class addition : Form
    {
        public addition()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This method can be used to initialize the form when it loads.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the numbers from the text boxes
                double number1 = double.Parse(txtNumber1.Text);
                double number2 = double.Parse(txtNumber2.Text);

                // Perform the addition
                double result = number1 + number2;

                // Display the result
                lblResult.Text = "Result: " + result.ToString();
            }
            catch (FormatException)
            {
                // Handle invalid input
                lblResult.Text = "Please enter valid numbers.";
            }
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            datatypes form2 = new datatypes();
            // Show Form2
            form2.Show();
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
