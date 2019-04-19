using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_3
{
    class Junior:Employee
    {
        private const int salary = 1;
        private const int productivity = 1;
        public override int GetSalary()
        {
            return salary;
        }
        public override int GetProductivity()
        {
            return productivity;
        }
    }
}
