using System;

namespace Task_6
{
    /// <summary>
    /// Class which describes total number of cars
    /// </summary>
    class CountAll : Command
    {
        ReadDocument readDocument;

        public CountAll(ReadDocument readDocument)
        {
            this.readDocument = readDocument;
        }

        /// <summary>
        /// override method Execute
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(readDocument.GetCountAll());
        }
    }
}
