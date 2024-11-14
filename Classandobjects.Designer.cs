namespace Csharp_1
{
    partial class Classandobjects
    {
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Classandobjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "Classandobjects";
            this.Text = "Class and Object Example";
            this.Load += new System.EventHandler(this.Form9_Load); // This is where we assign the event handler.
            this.ResumeLayout(false);
        }

        #endregion
    }
}
