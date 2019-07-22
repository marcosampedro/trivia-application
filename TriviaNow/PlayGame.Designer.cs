namespace TriviaNow
{
    partial class PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.filmPictureBox = new System.Windows.Forms.PictureBox();
            this.triviaTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.choiceOneButton = new System.Windows.Forms.Button();
            this.choiceTwoButton = new System.Windows.Forms.Button();
            this.choiceThreeButton = new System.Windows.Forms.Button();
            this.choiceFourButton = new System.Windows.Forms.Button();
            this.correctWrongLabel = new System.Windows.Forms.Label();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.closeTriviaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmPictureBox
            // 
            this.filmPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("filmPictureBox.Image")));
            this.filmPictureBox.Location = new System.Drawing.Point(41, 26);
            this.filmPictureBox.Name = "filmPictureBox";
            this.filmPictureBox.Size = new System.Drawing.Size(144, 146);
            this.filmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filmPictureBox.TabIndex = 0;
            this.filmPictureBox.TabStop = false;
            // 
            // triviaTitleLabel
            // 
            this.triviaTitleLabel.AutoSize = true;
            this.triviaTitleLabel.Font = new System.Drawing.Font("Britannic Bold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triviaTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.triviaTitleLabel.Location = new System.Drawing.Point(231, 44);
            this.triviaTitleLabel.Name = "triviaTitleLabel";
            this.triviaTitleLabel.Size = new System.Drawing.Size(590, 119);
            this.triviaTitleLabel.TabIndex = 1;
            this.triviaTitleLabel.Text = "Trivia Now!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(843, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.questionNumberLabel.Location = new System.Drawing.Point(1, 185);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(409, 46);
            this.questionNumberLabel.TabIndex = 3;
            this.questionNumberLabel.Text = "questionNumberLabel";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.scoreLabel.Location = new System.Drawing.Point(741, 185);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(216, 46);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "scoreLabel";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.feedbackLabel.Location = new System.Drawing.Point(285, 594);
            this.feedbackLabel.MaximumSize = new System.Drawing.Size(450, 0);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(191, 31);
            this.feedbackLabel.TabIndex = 5;
            this.feedbackLabel.Text = "feedbackLabel";
            this.feedbackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.questionLabel.Location = new System.Drawing.Point(298, 249);
            this.questionLabel.MaximumSize = new System.Drawing.Size(450, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(202, 36);
            this.questionLabel.TabIndex = 6;
            this.questionLabel.Text = "questionLabel";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiceOneButton
            // 
            this.choiceOneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.choiceOneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(39)))));
            this.choiceOneButton.Location = new System.Drawing.Point(241, 359);
            this.choiceOneButton.Name = "choiceOneButton";
            this.choiceOneButton.Size = new System.Drawing.Size(235, 73);
            this.choiceOneButton.TabIndex = 7;
            this.choiceOneButton.Text = "choiceOneButton";
            this.choiceOneButton.UseVisualStyleBackColor = false;
            this.choiceOneButton.Click += new System.EventHandler(this.answerButtons_Click);
            // 
            // choiceTwoButton
            // 
            this.choiceTwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.choiceTwoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(39)))));
            this.choiceTwoButton.Location = new System.Drawing.Point(539, 359);
            this.choiceTwoButton.Name = "choiceTwoButton";
            this.choiceTwoButton.Size = new System.Drawing.Size(235, 73);
            this.choiceTwoButton.TabIndex = 8;
            this.choiceTwoButton.Text = "choiceTwoButton";
            this.choiceTwoButton.UseVisualStyleBackColor = false;
            this.choiceTwoButton.Click += new System.EventHandler(this.answerButtons_Click);
            // 
            // choiceThreeButton
            // 
            this.choiceThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.choiceThreeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(39)))));
            this.choiceThreeButton.Location = new System.Drawing.Point(241, 461);
            this.choiceThreeButton.Name = "choiceThreeButton";
            this.choiceThreeButton.Size = new System.Drawing.Size(235, 71);
            this.choiceThreeButton.TabIndex = 9;
            this.choiceThreeButton.Text = "choiceThreeButton";
            this.choiceThreeButton.UseVisualStyleBackColor = false;
            this.choiceThreeButton.Click += new System.EventHandler(this.answerButtons_Click);
            // 
            // choiceFourButton
            // 
            this.choiceFourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.choiceFourButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(39)))));
            this.choiceFourButton.Location = new System.Drawing.Point(539, 461);
            this.choiceFourButton.Name = "choiceFourButton";
            this.choiceFourButton.Size = new System.Drawing.Size(235, 71);
            this.choiceFourButton.TabIndex = 10;
            this.choiceFourButton.Text = "choiceFourButton";
            this.choiceFourButton.UseVisualStyleBackColor = false;
            this.choiceFourButton.Click += new System.EventHandler(this.answerButtons_Click);
            // 
            // correctWrongLabel
            // 
            this.correctWrongLabel.AutoSize = true;
            this.correctWrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctWrongLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.correctWrongLabel.Location = new System.Drawing.Point(435, 548);
            this.correctWrongLabel.Name = "correctWrongLabel";
            this.correctWrongLabel.Size = new System.Drawing.Size(260, 31);
            this.correctWrongLabel.TabIndex = 11;
            this.correctWrongLabel.Text = "correctWrongLabel";
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.nextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(39)))));
            this.nextQuestionButton.Location = new System.Drawing.Point(775, 564);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(236, 61);
            this.nextQuestionButton.TabIndex = 12;
            this.nextQuestionButton.Text = "Next Question";
            this.nextQuestionButton.UseVisualStyleBackColor = false;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.gameOverLabel.Location = new System.Drawing.Point(12, 638);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(233, 46);
            this.gameOverLabel.TabIndex = 13;
            this.gameOverLabel.Text = "Game Over";
            // 
            // closeTriviaButton
            // 
            this.closeTriviaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.closeTriviaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeTriviaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(39)))));
            this.closeTriviaButton.Location = new System.Drawing.Point(241, 658);
            this.closeTriviaButton.Name = "closeTriviaButton";
            this.closeTriviaButton.Size = new System.Drawing.Size(366, 63);
            this.closeTriviaButton.TabIndex = 14;
            this.closeTriviaButton.Text = "Close Trivia Form";
            this.closeTriviaButton.UseVisualStyleBackColor = false;
            this.closeTriviaButton.Click += new System.EventHandler(this.closeTriviaButton_Click);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1036, 703);
            this.Controls.Add(this.closeTriviaButton);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.correctWrongLabel);
            this.Controls.Add(this.choiceFourButton);
            this.Controls.Add(this.choiceThreeButton);
            this.Controls.Add(this.choiceTwoButton);
            this.Controls.Add(this.choiceOneButton);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.triviaTitleLabel);
            this.Controls.Add(this.filmPictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayGame";
            this.Text = "PlayGame";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filmPictureBox;
        private System.Windows.Forms.Label triviaTitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button choiceOneButton;
        private System.Windows.Forms.Button choiceTwoButton;
        private System.Windows.Forms.Button choiceThreeButton;
        private System.Windows.Forms.Button choiceFourButton;
        private System.Windows.Forms.Label correctWrongLabel;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button closeTriviaButton;
    }
}