namespace Csharp_1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        // Declare txtOutput here
        private System.Windows.Forms.TextBox txtOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Initialize the components
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // txtOutput (TextBox) settings
            this.txtOutput.Location = new System.Drawing.Point(50, 50); // Set the position
            this.txtOutput.Multiline = true; // Allow multiple lines of text
            this.txtOutput.Name = "txtOutput"; // Set the name of the TextBox
            this.txtOutput.Size = new System.Drawing.Size(300, 150); // Set the size
            this.txtOutput.TabIndex = 0; // Set the tab index for the control

            // Form2 settings
            this.ClientSize = new System.Drawing.Size(800, 450); // Set the size of the form
            this.Controls.Add(this.txtOutput); // Add the TextBox to the form controls
            this.Name = "Form2"; // Set the form name
            this.Text = "Form2"; // Set the form title
            this.Load += new System.EventHandler(this.Form2_Load); // Attach the Load event
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
