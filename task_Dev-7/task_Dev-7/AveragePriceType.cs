using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_7
{
        /// <summary>
        /// class which describes average cost of cars of each brand. 
        /// It's heir of class Command.
        /// </summary>
        class AveragePriceType : Command
        {
            WorkWithDocument readDocument;

            public AveragePriceType(WorkWithDocument readDocument)
            {
                this.readDocument = readDocument;
            }

            /// <summary>
            /// override method Execute() which used to call the GetAveragePriceType() method
            /// </summary>
            public override void Execute()
            {
                Console.WriteLine("Enter mark:");
                string mark = Console.ReadLine();
                Console.WriteLine(readDocument.GetAveragePriceType(mark));
            }
        }
}
