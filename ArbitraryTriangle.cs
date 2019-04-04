using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class ArbitraryTriangle : Triangle
    {
        public ArbitraryTriangle()
        {
        }

        public override double GetSquare()
        {
            float p = side12 + side23 + side31;
            return 0.25 * (Math.Sqrt(p * (side12 + side23 - side31) * (side23 + side31 - side12) * (side31 + side12 - side23)));
        }
    }
}
