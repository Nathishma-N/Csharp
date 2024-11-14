using System;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class variables : Form
    {
        public variables()
        {
            InitializeComponent();
        }

        // Main Method will not be used here, we'll call it on Form Load
        private void Form3_Load(object sender, EventArgs e)
        {
            // Compile Time Initialization of variable 'x'
            int x = 32;

            // Create an object to access 'y'
            Geeks gfg = new Geeks();

            // Display the values in the TextBox on Form3
            txtOutput.Text = "Value of x is " + x + Environment.NewLine + "Value of y is " + gfg.y;
        }

        private class Geeks
        {
            // Declaration, compiler provides the default value 0
            public int y;

            // Constructor (optional)
            public Geeks()
            {
                y = 0; // Default value of y
            }
        }

        // Declare a TextBox (txtOutput) in Form3
        private TextBox txtOutput;

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        // Initialize the components and add the TextBox for output

    }
}
