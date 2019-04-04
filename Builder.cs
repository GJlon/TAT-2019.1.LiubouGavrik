using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class Builder
    {
        public Builder Successor { get; set; }

        public Builder (RightTriangleBuilder builder)
        {
            Successor = builder;
        }

        public Builder(Point point1, Point point2, Point point3);
    }
}
