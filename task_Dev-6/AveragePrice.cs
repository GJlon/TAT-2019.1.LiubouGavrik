﻿using System;

namespace Task_6
{
    /// <summary>
    /// class which describes average car cost
    /// </summary>
    class AveragePrice : Command
    {
        ReadDocument readDocument;

        public AveragePrice(ReadDocument readDocument)
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
