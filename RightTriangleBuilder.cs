using System;

namespace Task_3
{
    /// <summary>
    /// class right triangle, 
    /// heir to class triangle overrides method for calculating area
    /// </summary>
    class RightTriangle : Triangle
    {
        public RightTriangle(Point point1, Point point2, Point point3) : base(point1, point2, point3 )
        {
            if (side12 * side12 + side23 * side23 - side31 * side31 < double.Epsilon && side31 * side31 + side23 * side23 - side12 * side12 < double.Epsilon)
            {
                throw new FormatException("This triangle isn't right triangle.");
            }

            else if (side12 * side12 + side23 * side23 - side31 * side31 < double.Epsilon && side12 * side12 + side23 * side23 - side31 * side31 < double.Epsilon)
            {
                throw new FormatException("This triangle isn't right triangle.");
            }

            else if (side31 * side31 + side12 * side12 - side23 * side23 < double.Epsilon && side12 * side12 + side23 * side23 - side31 * side31 < double.Epsilon)
            {
                throw new FormatException("This triangle isn't right triangle.");
            }
        }

        /// <summary>
        /// override implementation of method GetSquare()
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            double p = side12 + side23 + side31;
            return 0.25 * (Math.Sqrt(p * (side12 + side23 - side31) * (side23 + side31 - side12) * (side31 + side12 - side23)));
        }
    }
}
