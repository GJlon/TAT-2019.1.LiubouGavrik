using System;

namespace task_Dev_4
{
    /// <summary>
    ///entrance to the program
    /// <summary>
    class EntryPoint
    {
        /// <summary>
        /// metod that allows to work with arguments from the command line
        /// </summary>
        /// <param name="args"></param>
        /// <returns>everything is good - 0</returns>
        /// <returns>string has more than 100000 letters</returns>
        /// <returns>other exceptions in the program - 2</returns>
        static int Main(string[] args)
        {
            try
            {
                string format ="PDF";
                var lecture = new Lectures(format);
                lecture[0] = "Cloud technologies";
                lecture[1] = "Statistical radiophysics";
                lecture[2] = "Information theory";
                lecture[3] = "Cryptographic methods";

                Console.WriteLine(lecture.Description());

                return 0;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }
            catch
            {
                Console.WriteLine("");
                return 2;
            }
        }
    }
}
