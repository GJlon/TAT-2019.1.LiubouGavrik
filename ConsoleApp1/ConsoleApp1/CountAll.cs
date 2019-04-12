using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Class which describes total number of cars
    /// </summary>
    class CountAll : Command
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
