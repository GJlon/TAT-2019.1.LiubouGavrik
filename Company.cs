using System.Collections.Generic;

namespace task_Dev_3
{
     /// <summary>
    ///  class is designed to store information about employees
    /// </summary>
    class Company
    {
        Employee junior = new Junior();
        Employee middle = new Middle();
        Employee senior = new Senior();
        Employee lead = new Lead(); 

        /// <summary>
        /// create two lists for employee storage
        /// </summary>
        public List<Employee> employees = new List<Employee>();
        List<Employee> choosedEmployees = new List<Employee>();
        int[] numberOfProgrammers;

        public Company()
        {
            for (int i = 0; i < 10; i++)
            {
                employees.Add(junior);
                employees.Add(middle);
                employees.Add(senior);
                employees.Add(lead);
            }
        }
        /// <summary>
        /// this method is for adding employees that returns selected employees
        /// </summary>
        public List<Employee> GetEmployees(Optimizer opt)
        {
            numberOfProgrammers = opt.Choose();
            for(int i=0; i<numberOfProgrammers[0]; i++)
            {
                choosedEmployees.Add(junior);
            }
            for (int i = 0; i < numberOfProgrammers[1]; i++)
            {
                choosedEmployees.Add(middle);
            }
            for (int i = 0; i < numberOfProgrammers[2]; i++)
            {
                choosedEmployees.Add(senior);
            }
            for (int i = 0; i < numberOfProgrammers[3]; i++)
            {
                choosedEmployees.Add(lead);
            }
            return choosedEmployees;
        }
    }
}
