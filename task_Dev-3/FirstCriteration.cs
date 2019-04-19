using System;
using System.Collections.Generic;

namespace task_Dev_3
{
    /// <summary>
    /// implemented algorithm for the first criterion: maximum performance 
    ///at a fixed amount
    /// </summary>
    class FirstCriteration : Optimizer
    {
        private float[,] quotientPS = new float[3, 4];
        public FirstCriteration(int budget, List<Employee> employees):base(budget, employees)
        {
            quotientPS[0, 0] = junior.GetProductivity() / junior.GetSalary();
            quotientPS[0, 1] = middle.GetProductivity() / middle.GetSalary();
            quotientPS[0, 2] = senior.GetProductivity() / senior.GetSalary();
            quotientPS[0, 3] = lead.GetProductivity() / lead.GetSalary();
            quotientPS[1, 0] = numberOfJunior;
            quotientPS[1, 1] = numberOfMiddle;
            quotientPS[1, 2] = numberOfSenior;
            quotientPS[1, 3] = numberOfLead;
            quotientPS[2, 0] = junior.GetSalary();
            quotientPS[2, 1] = middle.GetSalary();
            quotientPS[2, 2] = senior.GetSalary();
            quotientPS[2, 3] = lead.GetSalary();
        }

        public override int[] Choose()
        {
            int indexMaxQuotient=0;
            float maxQuotient = 0;
            while (projectBudget > lead.GetSalary())
            {
                if (quotientPS[0, 0] == 0 && quotientPS[0, 1] == 0 && quotientPS[0, 2] == 0 && quotientPS[0, 3] == 0)
                {
                    throw new OverflowException("Company don't have such specialist");
                }
                for (int i = 0; i < 4; i++)
                {
                    if (quotientPS[0, i] > maxQuotient)
                    {
                        maxQuotient = quotientPS[0, i];
                        indexMaxQuotient = i;
                    }
                }
                if (quotientPS[1, indexMaxQuotient] < projectBudget / quotientPS[2, indexMaxQuotient])
                {
                    numberOfProgrammers[indexMaxQuotient] = (int)quotientPS[1, indexMaxQuotient];
                }
                else
                {
                    numberOfProgrammers[indexMaxQuotient] = (int)(projectBudget / quotientPS[2, indexMaxQuotient]);
                }
                quotientPS[0, indexMaxQuotient] = 0;
                projectBudget -= (int)quotientPS[2, indexMaxQuotient] * numberOfProgrammers[indexMaxQuotient];
                indexMaxQuotient = 0;
                maxQuotient = 0;
            }
            while (projectBudget > 0)
            {
                if (projectBudget >= senior.GetSalary())
                {
                    numberOfProgrammers[2]++;
                    projectBudget -= (int)senior.GetSalary();
                }

                if (projectBudget >= middle.GetSalary())
                {
                    numberOfProgrammers[1]++;
                    projectBudget -= (int)middle.GetSalary();
                }

                if (projectBudget >= junior.GetSalary())
                {
                    numberOfProgrammers[0]++;
                    projectBudget -= (int)junior.GetSalary();
                }
            }
            return numberOfProgrammers;
        }             
    }
}

