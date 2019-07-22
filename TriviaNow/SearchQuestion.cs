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
    public partial class SearchQuestion : Form
    {
        QuestionDetails detailForm;
        BindingList<Questions> questionList;

        public SearchQuestion()
        {
            InitializeComponent();
        }

        // overloaded constructor to get the questionList when this constructor is called in the QuestionPool class
        public SearchQuestion(BindingList<Questions> list)
        {
            InitializeComponent();

            questionList = list;

            questionListBox.DataSource = questionList; // making the list box's data source as the passed on questionList
        }

        private void SearchQuestion_Load(object sender, EventArgs e)
        {
            searchTextBox.Focus(); // to start focus on the search textbox
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchPhrase = searchTextBox.Text;

            BindingList<Questions> searchList = new BindingList<Questions>();

            // searches for the phrase through all Question variables
            foreach (var question in questionList)
            {
                if (question.Question.ToUpper().Contains(searchPhrase.ToUpper()) ||
                    question.Feedback.ToUpper().Contains(searchPhrase.ToUpper()) ||
                    question.Answers[0].ToUpper().Contains(searchPhrase.ToUpper()) ||
                    question.Answers[1].ToUpper().Contains(searchPhrase.ToUpper()) ||
                    question.Answers[2].ToUpper().Contains(searchPhrase.ToUpper()) ||
                    question.Answers[3].ToUpper().Contains(searchPhrase.ToUpper()))
                {
                    searchList.Add(question);
                }
            }

            // populates the listbox with the variables containing the search phrase
            questionListBox.DataSource = searchList;

            searchTextBox.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            questionListBox.DataSource = questionList;

            searchTextBox.Clear();

            searchTextBox.Focus();
        }

        private void UpdateForm_QuestionUpdated(object sender, Questions q)
        {

            // reset the bindings so that the listbox updates
            // manual refresh
            questionList.ResetBindings();
        }

        private void questionListBox_DoubleClick(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem == null)
                return;

            Questions selectedQuestion = (Questions)questionListBox.SelectedItem;

            detailForm = new QuestionDetails();

            detailForm.QuestionUpdated += new QuestionEventHandler(this.UpdateForm_QuestionUpdated);

            // takes this from the detailForm instance (QuestionDetails class) to populate data
            detailForm.PopulateData(selectedQuestion);

            // opens and shows the detail form upon a double click of a listbox item
            detailForm.Show();
        }
    }
}
