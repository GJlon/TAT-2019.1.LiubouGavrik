using System;

namespace Task_3
{
    /// <summary>
    /// class parent with method GetSquare() and variables
    /// </summary>
    abstract class Triangle
    {
        /// <summary>
        /// points to build a triangle
        /// </summary>
        protected Point point1;
        protected Point point2;
        protected Point point3;

        /// <summary>
        /// sides of a triangle
        /// </summary>
        protected double side12;
        protected double side23;
        protected double side31;

        public Triangle(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            side12 = Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y));
            side23 = Math.Sqrt((point3.X - point2.X) * (point3.X - point2.X) + (point3.Y - point2.Y) * (point3.Y - point2.Y));
            side31 = Math.Sqrt((point3.X - point1.X) * (point3.X - point1.X) + (point3.Y - point1.Y) * (point3.Y - point1.Y));

            if (side12 + side23 <= side31 || side23 + side31 <= side12 || side31 + side12 <= side23)
            {
                throw new FormatException("This figure isn't a thiangle.");
            }
        }

        /// <summary>
        /// determination of the method for calculating the area of ​​the figure
        /// </summary>
        /// <returns></returns>
        abstract public double GetSquare();   
    }
}
