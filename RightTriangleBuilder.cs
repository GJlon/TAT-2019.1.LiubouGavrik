using System;

namespace Task_3
{
    /// <summary>
    /// class right triangle builder, 
    /// heir to class Builder which overrides Triangle Build(...)
    /// </summary>
    class RightTriangleBuilder : Builder
    {
        public override Triangle Build(Point point1, Point point2, Point point3) 
        {
            if (point1.Y == point3.Y && point1.X == point2.X)
            {
                return new RightTriangle(point1, point2, point3);
            }

            else if (Successor != null)
            {
                return Successor.Build(point1, point2, point3);
            }

            else
            {
                throw new Exception("Problems.");
            }
        }

        public RightTriangleBuilder ( Builder builder)
        {
            Successor = builder;
        }
    }
}
