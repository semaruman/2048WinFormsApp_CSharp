namespace _2048WinFormsApp
{
    partial class MainForm
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
            label2 = new Label();
            scoreLabel = new Label();
            label3 = new Label();
            theBestScoreLabel = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(26, 22);
            label2.Name = "label2";
            label2.Size = new Size(64, 29);
            label2.TabIndex = 0;
            label2.Text = "Счёт:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            scoreLabel.Location = new Point(112, 22);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(25, 29);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(26, 62);
            label3.Name = "label3";
            label3.Size = new Size(238, 29);
            label3.TabIndex = 2;
            label3.Text = "Наилучший результат:";
            // 
            // theBestScoreLabel
            // 
            theBestScoreLabel.AutoSize = true;
            theBestScoreLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            theBestScoreLabel.Location = new Point(291, 62);
            theBestScoreLabel.Name = "theBestScoreLabel";
            theBestScoreLabel.Size = new Size(25, 29);
            theBestScoreLabel.TabIndex = 3;
            theBestScoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 531);
            Controls.Add(theBestScoreLabel);
            Controls.Add(label3);
            Controls.Add(scoreLabel);
            Controls.Add(label2);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label scoreLabel;
        private Label label3;
        private Label theBestScoreLabel;
    }
}
