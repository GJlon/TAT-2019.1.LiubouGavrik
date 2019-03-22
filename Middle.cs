using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_3
{
    class Middle:Junior
    {
        private const int salary = 2;
        private const int productivity = 3;
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
