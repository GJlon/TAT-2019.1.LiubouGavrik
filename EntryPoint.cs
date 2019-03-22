using System;
using System.Collections.Generic;

namespace task_Dev_3
{
    class EntryPoint
    {
        /// <summary>
        /// metod that allows to work with arguments from the command line
        /// </summary>
        /// <param name="args"></param>
        /// <returns>everything is good - 0</returns>
        /// <returns>return message if company doesn't have such specialists - 1</returns>
        /// <returns>other exceptions in the program - 2</returns>
        static int Main(string[] args)
        {
            try
            {
                int budget = 20;
                List<Employee> employeeList;
                Company company = new Company();
                employeeList = company.GetEmployees(new FirstCriteration(budget, company.employees));
                foreach (var k in employeeList)
                {
                    Console.WriteLine(k);
                }
                return 0;
            }
            catch(OverflowException over)
            {
                Console.WriteLine(over.Message);
                return 1;
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!");
                return 2;
            }
        }
    }
}
