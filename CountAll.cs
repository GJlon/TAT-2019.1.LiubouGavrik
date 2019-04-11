using System;

namespace Task_6
{
    /// <summary>
    /// Class which describes total number of cars
    /// </summary>
    class CountAll : Command
    {
        ReadWorkWithDoc readDocument;

        public CountAll(ReadWorkWithDoc readDocument)
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
