namespace winFormHw1task1
{
    partial class Form1
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
            TextLabel = new Label();
            NoButton = new Button();
            YesButton = new Button();
            SuspendLayout();
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Font = new Font("Microsoft Uighur", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TextLabel.Location = new Point(37, 79);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(361, 38);
            TextLabel.TabIndex = 0;
            TextLabel.Text = "Is HTML a programming language?";
            // 
            // NoButton
            // 
            NoButton.BackColor = Color.DarkSeaGreen;
            NoButton.Location = new Point(37, 214);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(112, 34);
            NoButton.TabIndex = 1;
            NoButton.Text = "No,It's not";
            NoButton.UseVisualStyleBackColor = false;
            NoButton.Click += NoButton_Click;
            // 
            // YesButton
            // 
            YesButton.BackColor = Color.LightCoral;
            YesButton.Location = new Point(286, 214);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(112, 34);
            YesButton.TabIndex = 2;
            YesButton.Text = "Yes,It is";
            YesButton.UseVisualStyleBackColor = false;
            YesButton.Click += YesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(431, 442);
            Controls.Add(YesButton);
            Controls.Add(NoButton);
            Controls.Add(TextLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Html";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextLabel;
        private Button NoButton;
        private Button YesButton;
    }
}
