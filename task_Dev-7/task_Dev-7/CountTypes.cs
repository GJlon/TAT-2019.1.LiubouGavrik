using System;

namespace task_Dev_7
{
    /// <summary>
    /// Heir of class Command. CountTypes describes number of car brands.
    /// </summary>
    class CountTypes : Command
    {
        WorkWithDocument readDocument;

        public CountTypes(WorkWithDocument readDocument)
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
