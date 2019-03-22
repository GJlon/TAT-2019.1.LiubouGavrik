using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_3
{
    abstract class Optimizer
    {
        protected int projectBudget;
        protected int[] numberOfProgrammers = new int[4];
        protected int numberOfJunior;
        protected int numberOfMiddle;
        protected int numberOfSenior;
        protected int numberOfLead;

        protected Junior junior = new Junior();
        protected Middle middle = new Middle();
        protected Senior senior = new Senior();
        protected Lead lead = new Lead();

        protected Employee[] employees;

        public Optimizer() { }
        public Optimizer(int budget, List<Employee> employees)
        {
            projectBudget = budget;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is Lead)
                {
                    numberOfLead++;
                    continue;
                }
                if (employees[i] is Senior)
                {
                    numberOfSenior++;
                    continue;
                }
                if (employees[i] is Middle)
                {
                    numberOfMiddle++;
                    continue;
                }
                if (employees[i] is Junior)
                {
                    numberOfJunior++;
                    continue;
                }
            }
        }
        public abstract int[] Choose();
    }
}
