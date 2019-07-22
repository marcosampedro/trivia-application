// ProjectFinal, Marco Sampedro, CIS 345, Tuesday Thursday 10:30 AM
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
    // form to update questions/see the question's details
    public partial class QuestionDetails : Form
    {
        // creating a new event
        public event QuestionEventHandler QuestionUpdated;
        private Questions currentQuestion;

        public QuestionDetails()
        {
            InitializeComponent();
        }

        // done to populate the labels with the object's Questions class variables
        // this method will be called in the QuestionPool class
        public void PopulateData(Questions question)
        {
            currentQuestion = question;

            questionTextBox.Text = currentQuestion.Question;
            choice1TextBox.Text = currentQuestion.Answers[0];
            choice2TextBox.Text = currentQuestion.Answers[1];
            choice3TextBox.Text = currentQuestion.Answers[2];
            choice4TextBox.Text = currentQuestion.Answers[3];
            feedbackTextBox.Text = currentQuestion.Feedback;
            correctChoiceTextBox.Text = currentQuestion.CorrectNumber;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // ensures that all textboxes are filled and that none are left empty
            if (questionTextBox.Text == String.Empty || choice1TextBox.Text == String.Empty ||
                choice2TextBox.Text == String.Empty || choice2TextBox.Text == String.Empty ||
                choice4TextBox.Text == String.Empty || feedbackTextBox.Text == String.Empty ||
                correctChoiceTextBox.Text == String.Empty)
            {
                MessageBox.Show("Enter all data.");
                return;
            }

            // ensures that the data entered is between 1-4
            try
            {
                if (Convert.ToInt32(correctChoiceTextBox.Text) < 1 || Convert.ToInt32(correctChoiceTextBox.Text) > 4)
                {
                    MessageBox.Show("Correct Choice should be between 1-4.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Correct Choice should be a NUMBER between 1-4.");
                return;
            }

            Questions tmpQuestion = new Questions(questionTextBox.Text, choice1TextBox.Text,
                choice2TextBox.Text, choice3TextBox.Text, choice4TextBox.Text,
                feedbackTextBox.Text, correctChoiceTextBox.Text);

            currentQuestion.Question = questionTextBox.Text;
            currentQuestion.Answers[0] = choice1TextBox.Text;
            currentQuestion.Answers[1] = choice2TextBox.Text;
            currentQuestion.Answers[2] = choice3TextBox.Text;
            currentQuestion.Answers[3] = choice4TextBox.Text;
            currentQuestion.Feedback = feedbackTextBox.Text;
            currentQuestion.CorrectNumber = correctChoiceTextBox.Text;

            if (QuestionUpdated != null)
                QuestionUpdated(this, tmpQuestion);

            this.Close();
        }
    }
}
