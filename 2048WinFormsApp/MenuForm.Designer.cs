namespace _2048WinFormsApp
{
    partial class MenuForm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            playGameButton = new Button();
            exitButton = new Button();
            label3 = new Label();
            theBestScoreLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // playGameButton
            // 
            playGameButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            playGameButton.Location = new Point(147, 355);
            playGameButton.Name = "playGameButton";
            playGameButton.Size = new Size(153, 64);
            playGameButton.TabIndex = 0;
            playGameButton.Text = "Играть";
            playGameButton.UseVisualStyleBackColor = true;
            playGameButton.Click += playGameButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(147, 438);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(153, 64);
            exitButton.TabIndex = 2;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(62, 9);
            label3.Name = "label3";
            label3.Size = new Size(238, 29);
            label3.TabIndex = 3;
            label3.Text = "Наилучший результат:";
            // 
            // theBestScoreLabel
            // 
            theBestScoreLabel.AutoSize = true;
            theBestScoreLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            theBestScoreLabel.Location = new Point(329, 9);
            theBestScoreLabel.Name = "theBestScoreLabel";
            theBestScoreLabel.Size = new Size(25, 29);
            theBestScoreLabel.TabIndex = 4;
            theBestScoreLabel.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 303);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 531);
            Controls.Add(pictureBox1);
            Controls.Add(theBestScoreLabel);
            Controls.Add(label3);
            Controls.Add(exitButton);
            Controls.Add(playGameButton);
            Name = "MenuForm";
            Text = "2048. Главное меню";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playGameButton;
        private Button exitButton;
        private Label label3;
        private Label theBestScoreLabel;
        private PictureBox pictureBox1;
    }
}