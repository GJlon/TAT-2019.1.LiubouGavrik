namespace task_Dev_7
{
    /// <summary>
    /// Class Cars which has such elemenst as mark; model; quantity; cost.
    /// </summary>
    class Cars
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }

        public Cars(string mark, string model, int quantity, int cost)
        {
            this.Mark = mark;
            this.Model = model;
            this.Quantity = quantity;
            this.Cost = cost;
        }
    }
}
