using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Csharp_1
{
    public partial class Classandobjects : Form
    {
        public Classandobjects()
        {
            InitializeComponent();
        }

        // Ensure this method exists and matches the event handler name
        private void Form9_Load(object sender, EventArgs e)
        {
            // Set form title
            this.Text = "Class and Object Example";

            // Button to run the example
            Button classButton = new Button();
            classButton.Text = "Create and Display Object";
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
            // Create an object of Dog class
            Dog myDog = new Dog("Rex", "Bulldog", 4, "Brown");

            // Find the output TextBox by name
            TextBox outputTextBox = this.Controls["outputTextBox"] as TextBox;
            if (outputTextBox != null)
            {
                // Display object properties
                outputTextBox.Text = myDog.ToString();
            }
        }
    }

    // Dog class definition
    public class Dog
    {
        private string name;
        private string breed;
        private int age;
        private string color;

        // Constructor to initialize properties
        public Dog(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        public override string ToString()
        {
            return $"Hi! My name is {name}. I am a {breed}. I am {age} years old and my color is {color}.";
        }
    }
}
