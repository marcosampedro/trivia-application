// ProjectFinal, Marco Sampedro, CIS 345, Tuesday Thursday 10:30 AM
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class QuestionPool : Form
    {
        // declaring an instance for the other forms
        QuestionEntry entryForm;
        QuestionDetails updateForm;
        SearchQuestion searchForm;
        PlayGame gameForm;

        // binding list for the list of questions
        BindingList<Questions> questionList;

        // declaring an instance variable
        Questions selectedQuestion;

        public QuestionPool()
        {
            InitializeComponent();
        }

        private void EntryForm_QuestionCreated(object sender, Questions q)
        {
            questionList.Add(q); // questions being added to the list
        }

        // executed when this initial form is loaded
        private void QuestionPool_Load(object sender, EventArgs e)
        {
            questionList = new BindingList<Questions>();
            questionListBox.DataSource = questionList;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entryForm = new QuestionEntry();

            entryForm.Show();

            entryForm.QuestionCreated += new QuestionEventHandler(this.EntryForm_QuestionCreated);
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

            selectedQuestion = (Questions)questionListBox.SelectedItem;

            updateForm = new QuestionDetails();

            updateForm.QuestionUpdated += new QuestionEventHandler(this.UpdateForm_QuestionUpdated);

            // takes this from the detailForm instance (QuestionDetails class) to populate data
            updateForm.PopulateData(selectedQuestion);

            // opens and shows the detail form upon a double click of a listbox item
            updateForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opening the data file for write access
            FileStream file = new FileStream("data.dat", FileMode.Create, FileAccess.Write);

            // Declaring and instantiating an object, bf, of type BinaryFormatter
            BinaryFormatter bf = new BinaryFormatter();
            // Serialize reads the GradeBook object passed to it and because it is a serializable object, it serializes it to the file passed to it
            bf.Serialize(file, questionList);

            file.Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Opening the data file for read access only
                FileStream file = new FileStream("data.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                questionList = (BindingList <Questions>)bf.Deserialize(file);
                questionListBox.DataSource = questionList;
                file.Close();
            }
            catch (FileNotFoundException)
            {
                // leaving empty
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // implemented to cleanly exit out of the forms
            System.Environment.Exit(0);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem == null)
            {
                MessageBox.Show("Add a question or load a file first");
                return;
            }


            selectedQuestion = (Questions)questionListBox.SelectedItem;

            updateForm = new QuestionDetails();

            updateForm.QuestionUpdated += new QuestionEventHandler(this.UpdateForm_QuestionUpdated);

            // takes this from the detailForm instance (QuestionDetails class) to populate data
            updateForm.PopulateData(selectedQuestion);

            // opens and shows the detail form upon a double click of a listbox item
            updateForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Questions tmpQuestion;

            if(questionListBox.SelectedItem != null)
            {
                tmpQuestion = (Questions)questionListBox.SelectedItem; // downcasting the selected item as a Question
                questionList.Remove(tmpQuestion);
            }
            else
            {
                MessageBox.Show("Add a question or load a file first");
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem == null)
            {
                MessageBox.Show("Add a question or load a file first");
                return;
            }

            searchForm = new SearchQuestion(questionList); // calling the overloaded constructor

            searchForm.Show();
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem == null)
            {
                MessageBox.Show("Add a question or load a file first");
                return;
            }

            gameForm = new PlayGame(questionList); // calling overloaded constructor to pass the questionList 

            gameForm.Show();
        }
    }
}
