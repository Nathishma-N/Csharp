using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class Jumbstatements : Form
    {
        public Jumbstatements()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // Set form title
            this.Text = "Jump Statements Example";

            // Button to run the example
            Button jumpButton = new Button();
            jumpButton.Text = "Run Jump Statements";
            jumpButton.Location = new Point(50, 20);
            jumpButton.Click += JumpButton_Click;
            this.Controls.Add(jumpButton);

            // TextBox for output
            TextBox outputTextBox = new TextBox();
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Location = new Point(50, 60);
            outputTextBox.Size = new Size(300, 200);
            outputTextBox.Multiline = true;
            this.Controls.Add(outputTextBox);
        }

        private void JumpButton_Click(object sender, EventArgs e)
        {
            // Find the output TextBox by name
            TextBox outputTextBox = this.Controls["outputTextBox"] as TextBox;
            if (outputTextBox != null)
            {
                outputTextBox.Clear(); // Clear previous output
                StringBuilder output = new StringBuilder();

                // Demonstrating `break` and `continue`
                output.AppendLine("Loop with break and continue:");
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 3) continue;  // Skip number 3
                    if (i == 5) break;     // Stop the loop when i is 5
                    output.AppendLine($"Number: {i}");
                }

                // Demonstrating `goto`
                output.AppendLine("\nGoto Example:");
                int j = 1;
            label1:
                output.AppendLine($"Goto Number: {j}");
                j++;
                if (j <= 2) goto label1;  // Repeat the label twice

                // Demonstrating `return`
                output.AppendLine("\nReturn Example:");
                output.AppendLine(ReturnExample());

                // Demonstrating `throw`
                try
                {
                    output.AppendLine("\nThrow Example:");
                    ThrowExample();
                }
                catch (Exception ex)
                {
                    output.AppendLine($"Exception caught: {ex.Message}");
                }

                // Display output in TextBox
                outputTextBox.Text = output.ToString();
            }
        }

        // Method demonstrating `return` statement
        private string ReturnExample()
        {
            return "This is a return statement example.";
        }

        // Method demonstrating `throw` statement
        private void ThrowExample()
        {
            throw new InvalidOperationException("This is a throw statement example.");
        }
    }
}
