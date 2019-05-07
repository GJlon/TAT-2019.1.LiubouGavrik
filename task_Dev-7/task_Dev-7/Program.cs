using System;

namespace task_Dev_7
{
    /// <summary>
    /// This program is created for working with xml-file.
    /// </summary>
    class Program
    {
        /// <summary>
        /// the main class method in which the dictionary is created, 
        /// the switch case is implemented, 
        /// and there is an exception handling
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            { 
                WorkWithCommands command = new WorkWithCommands(args[0], args[1]);
                
                if (args.Length < 2)
                {
                    throw new FormatException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error! Didn't find file.");
            }
        }
    }
}
