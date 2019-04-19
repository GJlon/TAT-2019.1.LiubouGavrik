using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_3
{
    class Lead:Senior
    {
        private const int salary = 8;
        private const int productivity = 11;
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
