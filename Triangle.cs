using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class Triangle
    {
        protected Point point1;
        protected Point point2;
        protected Point point3;
        protected double side12;
        protected double side23;
        protected double side31;

        public Triangle(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point1 = point2;
            this.point3 = point3;
            side12 = Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y));
            side23 = Math.Sqrt((point3.X - point2.X) * (point3.X - point2.X) + (point3.Y - point2.Y) * (point3.Y - point2.Y));
            side31 = Math.Sqrt((point3.X - point1.X) * (point3.X - point1.X) + (point3.Y - point1.Y) * (point3.Y - point1.Y));

            if (side12 + side23 <= side31 || side23 + side31 <= side12 || side31 + side12 <= side23)
            {
                throw new FormatException("This figure isn't a thiangle.");
            }
        }

        public double GetSide()
        {
            return Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y));
        }

        abstract public double GetSquare();   
    }
}
