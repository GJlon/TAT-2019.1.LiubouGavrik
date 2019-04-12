using System;

namespace ConsoleApp1
{
    /// <summary>
    /// class which describes average car cost
    /// </summary>
    class AveragePrice : Command
    {
        InfoDocument readDocument;

        public AveragePrice(InfoDocument readDocument)
        {
            this.readDocument = readDocument;
        }

        /// <summary>
        /// override method Execute() which used to call the GetAveragePrice() method
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(readDocument.GetAveragePrice());
        }
    }
}
