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
    // custom delegate created to hold a reference to event handler
    public delegate void QuestionEventHandler(object sender, Questions q);

    public partial class QuestionEntry : Form
    {
        // custom event created to be raised when a new question has been created
        public event QuestionEventHandler QuestionCreated;

        public QuestionEntry()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
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

            // instantiates using the overloaded Questions constructor (containing all variables)
            Questions tmpQuestion = new Questions(questionTextBox.Text, choice1TextBox.Text,
                choice2TextBox.Text, choice3TextBox.Text, choice4TextBox.Text,
                feedbackTextBox.Text, correctChoiceTextBox.Text);

            if (QuestionCreated != null)
                QuestionCreated(this, tmpQuestion);

            questionTextBox.Clear();
            choice1TextBox.Clear();
            choice2TextBox.Clear();
            choice3TextBox.Clear();
            choice4TextBox.Clear();
            feedbackTextBox.Clear();
            correctChoiceTextBox.Clear();

            this.Close();
        }
    }
}
