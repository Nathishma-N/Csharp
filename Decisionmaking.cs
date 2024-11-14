using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class Decisionmaking : Form
    {
        public Decisionmaking()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Initialize form controls
            this.Text = "Decision Making Example";

            // Button to run decision example
            Button decisionButton = new Button();
            decisionButton.Text = "Run Decision Example";
            decisionButton.Location = new Point(50, 20);
            decisionButton.Click += DecisionButton_Click;
            this.Controls.Add(decisionButton);

            // TextBox to display output
            TextBox outputTextBox = new TextBox();
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Location = new Point(50, 60);
            outputTextBox.Size = new Size(300, 300);
            outputTextBox.Multiline = true;
            outputTextBox.ScrollBars = ScrollBars.Vertical; // Add vertical scroll if needed
            this.Controls.Add(outputTextBox);
        }

        private void DecisionButton_Click(object sender, EventArgs e)
        {
            // Get TextBox control by name to display output
            TextBox outputTextBox = this.Controls["outputTextBox"] as TextBox;
            if (outputTextBox != null)
            {
                // Clear previous output
                outputTextBox.Clear();

                int number = 15;
                int day = 3; // Example value for switch statement
                int month = 6; // Example for nested switch

                StringBuilder output = new StringBuilder();

                // Simple if-else example
                if (number > 10)
                {
                    output.AppendLine("The number is greater than 10.");
                }
                else
                {
                    output.AppendLine("The number is 10 or less.");
                }

                // If-else-if ladder
                if (number < 10)
                {
                    output.AppendLine("The number is less than 10.");
                }
                else if (number == 10)
                {
                    output.AppendLine("The number is exactly 10.");
                }
                else
                {
                    output.AppendLine("The number is greater than 10.");
                }

                // Nested if
                if (number > 10)
                {
                    if (number < 20)
                    {
                        output.AppendLine("The number is between 10 and 20.");
                    }
                    else
                    {
                        output.AppendLine("The number is greater than 20.");
                    }
                }

                // Switch statement (for day of the week)
                switch (day)
                {
                    case 1:
                        output.AppendLine("It's Monday.");
                        break;
                    case 2:
                        output.AppendLine("It's Tuesday.");
                        break;
                    case 3:
                        output.AppendLine("It's Wednesday.");
                        break;
                    case 4:
                        output.AppendLine("It's Thursday.");
                        break;
                    case 5:
                        output.AppendLine("It's Friday.");
                        break;
                    default:
                        output.AppendLine("It's a weekend.");
                        break;
                }

                // Nested switch example (for seasons)
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        output.AppendLine("It's Winter season.");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        output.AppendLine("It's Spring season.");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        output.AppendLine("It's Summer season.");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        output.AppendLine("It's Autumn season.");
                        break;
                    default:
                        output.AppendLine("Invalid month.");
                        break;
                }

                // Display output in the TextBox
                outputTextBox.Text = output.ToString();
            }
        }
    }
}
