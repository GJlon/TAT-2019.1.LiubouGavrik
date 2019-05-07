using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Heir of class Command. CountTypes describes number of car marks.
    /// </summary>
    class CountTypes : Command
    {
        InfoDocument readDocument;

        public CountTypes(InfoDocument readDocument)
        {
            this.readDocument = readDocument;
        }

        /// <summary>
        /// override method Execute
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(readDocument.GetCountTypes());
        }
    }
}
