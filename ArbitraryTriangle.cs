using System;

namespace Task_3
{
    /// <summary>
    /// arbitrary triangle is a heir of class Triangle. This class implemented override GetSquare method. 
    /// Also you can get a description of the created object
    /// </summary>
    class ArbitraryTriangle : Triangle
    {
        public ArbitraryTriangle(Point point1, Point point2, Point point3) : base(point1, point2, point3)
        {
            if (side12 + side23 <= side31 || side23 + side31 <= side12 || side31 + side12 <= side23)
            {
                throw new FormatException("This figure isn't a arbitrary thiangle.");
            }

            else
            {
                Console.WriteLine("It is orbitrary triangle");
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
