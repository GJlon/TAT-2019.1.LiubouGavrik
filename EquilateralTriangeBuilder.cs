using System;

namespace Task_3
{
    /// <summary>
    /// class equilateral triangle builder, 
    /// heir to class Builder which overrides Triangle Build(...)
    /// </summary>
    class EquilateralTriangeBuilder : Builder
    {
        public override Triangle Build(Point point1, Point point2, Point point3)
        {
            double side12 = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            double side23 = Math.Sqrt(Math.Pow(point3.X - point2.X, 2) + Math.Pow(point3.Y - point2.Y, 2));
            double side31 = Math.Sqrt(Math.Pow(point3.X - point1.X, 2) + Math.Pow(point3.Y - point1.Y, 2));

            if (side12 - side23 < float.Epsilon && side23 - side31 < float.Epsilon || side12 - side31 < float.Epsilon)
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

        public EquilateralTriangeBuilder (Builder builder)
        {
            Successor = builder;
        }
    }
}
