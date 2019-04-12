using System;

namespace task_Dev_7
{
    /// <summary>
    /// Class which describes total number of cars
    /// </summary>
    class CountAll : Command
    {
        WorkWithDocument readDocument;

        public CountAll(WorkWithDocument readDocument)
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
