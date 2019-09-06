using System;

namespace task_Dev_5
{
    /// <summary>
    /// Revised structure Point in which coordinates x, y, z are defined
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// add three coordinates x,y,z
        /// </summary>
        public int x;
        public int y;
        public int z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// DistanceCalculation is a method that calculates the distance between given points
        /// </summary>
        /// <param name="point"></param>
        /// <param name="newPoint"></param>
        /// <returns></returns>
        public double DistanceCalculation(Point point, Point newPoint)
        {
            double distance = Math.Pow(newPoint.x - point.x, 2) + Math.Pow(newPoint.y - point.y, 2) + Math.Pow(newPoint.z - point.z, 2);
            return Math.Sqrt(distance);
        }
    }
}
