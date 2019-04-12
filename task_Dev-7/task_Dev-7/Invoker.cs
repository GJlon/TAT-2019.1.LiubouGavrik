using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_7
{
    /// <summary>
    /// Class Invoker is command initiator which calls the command to 
    /// perform our request
    /// </summary>
    class Invoker
    {
        Command command;

        /// <summary>
        /// correlates "command" and received "c"
        /// </summary>
        /// <param name="c"></param>
        public void SetCommand(Command c)
        {
            command = c;
        }

        /// <summary>
        /// Method to call Execute()
        /// </summary>
        public void Run()
        {
            command.Execute();
        }
    }
}
