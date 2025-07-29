namespace DailyMood
{
    partial class LettersForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LetterBox = new TextBox();
            SendButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // LetterBox
            // 
            LetterBox.Location = new Point(31, 32);
            LetterBox.Multiline = true;
            LetterBox.Name = "LetterBox";
            LetterBox.Size = new Size(590, 270);
            LetterBox.TabIndex = 0;
            // 
            // SendButton
            // 
            SendButton.BackColor = Color.Honeydew;
            SendButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SendButton.Location = new Point(503, 317);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(118, 29);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(341, 317);
            button1.Name = "button1";
            button1.Size = new Size(145, 29);
            button1.TabIndex = 2;
            button1.Text = "Add a reaction";
            button1.UseVisualStyleBackColor = false;
            // 
            // LettersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(button1);
            Controls.Add(SendButton);
            Controls.Add(LetterBox);
            Name = "LettersForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LetterBox;
        private Button SendButton;
        private Button button1;
    }
}
