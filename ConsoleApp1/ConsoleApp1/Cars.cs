using System;

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
            if(string.IsNullOrEmpty(mark))
            {
                throw new ArgumentNullException(nameof(mark));
            }

            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentNullException(nameof(model));
            }

            if(quantity<0)
            {
                throw new ArgumentException(nameof(quantity));
            }

            if(cost < 0)
            {
                throw new ArgumentException(nameof(cost));
            }

            this.Mark = mark;
            this.Model = model;
            this.Quantity = quantity;
            this.Cost = cost;
        }
    }
}
