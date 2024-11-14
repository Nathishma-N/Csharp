namespace Csharp_1
{
    partial class Decisionmaking
    {
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button decisionButton;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.decisionButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(50, 60);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(300, 200);
            this.outputTextBox.TabIndex = 0;

            // 
            // decisionButton
            // 
            this.decisionButton.Location = new System.Drawing.Point(50, 20);
            this.decisionButton.Name = "decisionButton";
            this.decisionButton.Size = new System.Drawing.Size(150, 30);
            this.decisionButton.TabIndex = 1;
            this.decisionButton.Text = "Run Decision Example";
            this.decisionButton.UseVisualStyleBackColor = true;
            this.decisionButton.Click += new System.EventHandler(this.DecisionButton_Click);

            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.decisionButton);
            this.Name = "Form7";
            this.Text = "Decision Making Example";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
