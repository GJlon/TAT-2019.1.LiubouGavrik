using System;

namespace Task_3
{
    /// <summary>
    /// Entry point of this programm
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method of class Program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Point point1 = new Point(3,4);
            Point point2 = new Point(8,9);
            Point point3 = new Point(11,15);

            Builder mainBuilder = new RightTriangleBuilder(new EquilateralTriangeBuilder(new ArbitraryTriangleBuilder(null)));
            Triangle triangle = mainBuilder.Build(point1, point2, point3);
            Console.WriteLine(triangle.GetSquare());
        }
    }
}
