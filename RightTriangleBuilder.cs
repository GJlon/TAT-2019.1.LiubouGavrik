using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class RightTriangleBuilder : Builder
    {
        public RightTriangleBuilder(Point point1, Point point2, Point point3) : base (point1,point1,point3)
        {
            if (side12 * side12 + side23 * side23 - side31 * side31 > float.Epsilon || side31 * side31 + side23 * side23 - side12 * side12 > float.Epsilon || side12 * side12 + side23 * side23 - side31 * side31 > float.Epsilon)
            {
                throw new Exception("This triangle isn't right triangle.");
            }
        }

    }
}
