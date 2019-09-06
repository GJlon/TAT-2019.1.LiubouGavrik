namespace Task_6
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
        public void SetCommand(Command command)
        {
            command = command;
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
