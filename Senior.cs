using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_3
{
    class Senior:Middle
    {
        private const int salary = 5;
        private const int productivity = 7;
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
