using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_4
{
    /// <summary>
    /// seminar class heir materials
    /// </summary>
    class Seminars : Materials
    {
        /// <summary>
        /// seminar tasks
        /// </summary>
        string tasks;
        /// <summary>
        /// implemented a dictionary in which answers to questions and questions are stored
        /// </summary>
        Dictionary <string, string> QuestionsAnswers;
        ///<summary>
        ///check if something is written in the constructor
        ///<summary>
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
        ///<summary>
        ///matching method
        ///<summary>
        public void AddTestAnswer(string question, string answer)
        {
            QuestionsAnswers[question] = answer;
        }
        ///<summary>
        ///override method ToString()
        ///<summary>
        public override string ToString()
        {
            return "Seminar";
        }
    }
}
