namespace Csharp_1
{
    partial class Form6
    {
        private System.Windows.Forms.TextBox txtOutput;

        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // txtOutput settings
            this.txtOutput.Location = new System.Drawing.Point(50, 50);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(300, 150);
            this.txtOutput.TabIndex = 0;

            // Form6 settings
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
