namespace Task_3
{
    /// <summary>
    /// parenttal class Builder. Provides work with Successor
    /// </summary>
    abstract class Builder
    {
        public Builder Successor { get; set; }

        public abstract Triangle Build(Point point1, Point point2, Point point3);
    }
}
