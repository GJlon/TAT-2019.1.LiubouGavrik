using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_4
{
    class Seminars : Materials
    {
        string tasks;
        Dictionary <string, string> QuestionsAnswers;

        public Seminars(string tasks)
        {
            if (tasks.Length > 0)
            {
                this.tasks = tasks;
            }
            else
            {
                throw new FormatException("Error! Task shouldn't be empty!");
            }
            QuestionsAnswers = null;
        }

        public void AddTestAnswer(string question, string answer)
        {
            QuestionsAnswers[question] = answer;
        }

        public override string ToString()
        {
            return "Seminar";
        }
    }
}
