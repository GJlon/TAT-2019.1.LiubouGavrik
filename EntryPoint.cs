using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_3
{
    class EntryPoint
    {
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
