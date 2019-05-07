using System;

namespace task_Dev_7
{
    /// <summary>
    /// Class which describes total number of cars
    /// </summary>
    internal class CountAll : Command
    {
        InfoDocument readDocument;

        public CountAll(InfoDocument readDocument)
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
