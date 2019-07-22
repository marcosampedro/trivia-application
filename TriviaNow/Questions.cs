// ProjectFinal, Marco Sampedro, CIS 345, Tuesday Thursday 10:30 AM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    // serializable to use File I/O on this class
    [Serializable]
    public class Questions
    {
        private string question;
        private List<string> answers;
        private string feedback;
        private string correctNumber;

        public Questions(string question, string choiceOne, string choiceTwo, string choiceThree, string choiceFour, string feedback, string correctNumber)
        {
            this.answers = new List<string>();

            this.question = question;
            this.answers.Add(choiceOne);
            this.answers.Add(choiceTwo);
            this.answers.Add(choiceThree);
            this.answers.Add(choiceFour);
            this.feedback = feedback;
            this.correctNumber = correctNumber;
        }

        public string Question { get => question; set => question = value; }
        public List<string> Answers { get => answers; set => answers = value; }
        public string Feedback { get => feedback; set => feedback = value; }
        public string CorrectNumber { get => correctNumber; set => correctNumber = value; }

        public override string ToString()
        {
            return question;
        }
    }
}
