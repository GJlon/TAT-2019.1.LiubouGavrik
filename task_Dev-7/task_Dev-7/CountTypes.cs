using System;

namespace task_Dev_7
{
    /// <summary>
    /// Heir of class Command. CountTypes describes number of car marks.
    /// </summary>
    internal class CountTypes : Command
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
