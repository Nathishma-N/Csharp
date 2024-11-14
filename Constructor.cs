using System;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class Constructor : Form
    {
        public Constructor()
        {
            InitializeComponent();
        }

        // Ensure this method exists and matches the event handler name
        private void Form9_Load(object sender, EventArgs e)
        {
            // Set form title
            this.Text = "Constructor Example";

            // Button to run the example
            Button classButton = new Button();
            classButton.Text = "Create and Display Car Object";
            classButton.Location = new Point(50, 20);
            classButton.Click += ClassButton_Click;
            this.Controls.Add(classButton);

            // TextBox for output
            TextBox outputTextBox = new TextBox();
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Location = new Point(50, 60);
            outputTextBox.Size = new Size(300, 200);
            outputTextBox.Multiline = true;
            this.Controls.Add(outputTextBox);
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            // Create an object of Car class using the constructor
            Car myCar = new Car("Toyota", "Camry", 2020, "Black");

            // Find the output TextBox by name
            TextBox outputTextBox = this.Controls["outputTextBox"] as TextBox;
            if (outputTextBox != null)
            {
                // Display object properties
                outputTextBox.Text = myCar.ToString();
            }
        }
    }

    // Car class definition
    public class Car
    {
        // Instance Variables
        private string make;
        private string model;
        private int year;
        private string color;

        // Constructor to initialize properties
        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        // Method to return the string representation of the Car object
        public override string ToString()
        {
            return $"This car is a {year} {make} {model} in {color} color.";
        }
    }
}
