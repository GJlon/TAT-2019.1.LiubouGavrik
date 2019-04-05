using System;

namespace Task_3
{
    /// <summary>
    /// equilateral triangle is a heir of class Triangle. This class implemented override GetSquare method
    /// </summary>
    class EquilateralTriange : Triangle
    {
        public EquilateralTriange(Point point1, Point point2, Point point3) : base(point1, point2, point3)
        {
            if (side12 - side23 > float.Epsilon && side23 - side31 > float.Epsilon || side12 - side31 > float.Epsilon)
            {
                throw new Exception("This triangle isn't equilateral triangle.");
            }
        }

        /// <summary>
        /// override GetSquare method
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            double p = side12 + side23 + side31;
            return 0.25 * (Math.Sqrt(p * (side12 + side23 - side31) * (side23 + side31 - side12) * (side31 + side12 - side23)));
        }
    }
}
