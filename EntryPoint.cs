using System;

namespace task_Dev_1
{
    /// <summary>
    /// gets a sequence of characters from the command line, 
    /// displays all subsequences that don't contain duplicate characters
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// metod that allows to work with arguments from the command line
        /// </summary>
        /// <param name="args"></param>
        /// <returns>everything is good - 0</returns>
        /// <returns>string is empty or has less than 2 letters - 1</returns>
        /// <returns>other exceptions in the program - 2</returns>
        static int Main(string[] args)
        {
            try
            {         
                string originalString = args[0];
                SubstringSearch s = new SubstringSearch(originalString);
                foreach(string substringS in s.ListWithNewStrings())
                {
                    Console.WriteLine(substringS);
                }
                return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine( "Error!Enter more letters!");
                return 1;
            }
            catch(Exception)
            {
                Console.WriteLine("Error!!!");
                return 2;
            }
           
        }
    }
}
