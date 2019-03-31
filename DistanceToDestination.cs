using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_5
{
    class DistanceToDestination
    {
        public int Calculation(Point point, Point newPoint)
        {
            double result = (newPoint.x - point.x) ^ 2 + (newPoint.y - point.y) ^ 2 + (newPoint.z - point.z) ^ 2;
            return Convert.ToInt32(Math.Sqrt(result));
        }
    }
}
