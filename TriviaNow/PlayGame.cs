// ProjectFinal, Marco Sampedro, CIS 345, Tuesday Thursday 10:30 AM
using System.Media; // added to access SoundPlayer class
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class PlayGame : Form
    {
        private BindingList<Questions> questionList;
        // this is a list that will consist of three (random) questions displayed to the user
        private BindingList<Questions> triviaQuestionList;
        private int questionNumber = 0;
        private int totalScore = 0;

        SoundPlayer soundPlayer;


        public PlayGame()
        {
            InitializeComponent();
        }

        public PlayGame(BindingList<Questions> list)
        {
            InitializeComponent();

            questionList = list;
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {
            RandomQuestion();
            ShowQuestionInfo();

            gameOverLabel.Visible = false;
            closeTriviaButton.Visible = false;
        }

        private void RandomQuestion()
        {
            Random randomNumber = new Random();

            triviaQuestionList = new BindingList<Questions>();

            for (int i = 0; i < 3;)
            {
                int placement = randomNumber.Next(0, questionList.Count);
                Questions tmpQuestion = questionList[placement];

                // the if is utilized to ensure no duplicate questions are added to the trivia list (which contains three questions)
                if (!triviaQuestionList.Contains(tmpQuestion)) 
                {
                    triviaQuestionList.Add(tmpQuestion);
                    i++;
                }
            }
        }

        private void ShowQuestionInfo()
        {
            Questions quizQuestion = triviaQuestionList[questionNumber];

            questionLabel.Text = quizQuestion.Question;
            choiceOneButton.Text = quizQuestion.Answers[0];
            choiceTwoButton.Text = quizQuestion.Answers[1];
            choiceThreeButton.Text = quizQuestion.Answers[2];
            choiceFourButton.Text = quizQuestion.Answers[3];
            feedbackLabel.Text = quizQuestion.Feedback;

            questionNumberLabel.Text = $"Question {questionNumber + 1} out of 3";
            scoreLabel.Text = $"Total Score: {totalScore}";

            feedbackLabel.Visible = false;
            correctWrongLabel.Visible = false;
            nextQuestionButton.Visible = false;

            // enables the buttons
            choiceOneButton.Enabled = true;
            choiceTwoButton.Enabled = true;
            choiceThreeButton.Enabled = true;
            choiceFourButton.Enabled = true;
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionNumber < 2)
            {
                questionNumber++;
            }
            else if (questionNumber == 2)
            {
                feedbackLabel.Visible = false;
                correctWrongLabel.Visible = false;
                nextQuestionButton.Visible = false;
                questionLabel.Visible = false;
                choiceOneButton.Visible = false;
                choiceTwoButton.Visible = false;
                choiceThreeButton.Visible = false;
                choiceFourButton.Visible = false;
                questionNumberLabel.Visible = false;

                // repositions the label's location on the form
                scoreLabel.Top = 200;
                scoreLabel.Left = 185;

                // repositions the label's location on the form
                gameOverLabel.Visible = true;
                gameOverLabel.Top = 160;
                gameOverLabel.Left = 192;

                // repositions the label's location on the form
                closeTriviaButton.Visible = true;
                closeTriviaButton.Top = 260;
                closeTriviaButton.Left = 160;
            }

            // calls the method to show the next question in the triviaQuestionList
            ShowQuestionInfo();

        }

        private void answerButtons_Click(object sender, EventArgs e)
        {
            feedbackLabel.Visible = true;

            // disables the buttons
            choiceOneButton.Enabled = false;
            choiceTwoButton.Enabled = false;
            choiceThreeButton.Enabled = false;
            choiceFourButton.Enabled = false;

            nextQuestionButton.Visible = true;

            // downcasts the object as type Button
            Button tmpButton = (Button)sender;

            Questions currentQuestion = triviaQuestionList[questionNumber];

            // choiceAnswer stores the correct answer found in the Answer list from the Question class (using the element number minus one)
            string choiceAnswer = currentQuestion.Answers[Convert.ToInt32(currentQuestion.CorrectNumber) - 1];

            if (tmpButton.Text == choiceAnswer)
            {
                correctWrongLabel.Visible = true;
                correctWrongLabel.ForeColor = Color.Green; // change's the label's text's color
                correctWrongLabel.Text = "Correct!";

                totalScore = totalScore + 1;
                scoreLabel.Text = $"Total Score: {totalScore}";

                // plays .wav file located in the bin/debug folder
                soundPlayer = new SoundPlayer("CorrectSound.wav");
                soundPlayer.Load();
                soundPlayer.Play();
            }
            else
            {
                correctWrongLabel.Visible = true;
                correctWrongLabel.ForeColor = Color.Red; // change's the label's text's color
                correctWrongLabel.Text = "Wrong!";

                // plays .wav file located in the bin/debug folder
                soundPlayer = new SoundPlayer("WrongSound.wav");
                soundPlayer.Load();
                soundPlayer.Play();
            }
        }

        private void closeTriviaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
