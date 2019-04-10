using System;

namespace Task_6
{
    /// <summary>
    /// Heir of class Command. CountTypes describes number of car brands.
    /// </summary>
    class CountTypes : Command
    {
        ReadDocument readDocument;

        public CountTypes(ReadDocument readDocument)
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
