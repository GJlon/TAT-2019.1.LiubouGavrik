using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_7
{
        /// <summary>
        /// class which describes average car cost
        /// </summary>
        class AveragePrice : Command
        {
            WorkWithDocument readDocument;

            public AveragePrice(WorkWithDocument readDocument)
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
