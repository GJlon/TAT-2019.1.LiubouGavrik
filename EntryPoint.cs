using System;

namespace task_Dev_2
{
    class EntryPoint
    {   /// <summary>
        /// Main method of class EntryPoint
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        static int Main(string[] args)
        {
            try
            {
                string originalString = args[0].ToLower();
                int length = originalString.Length;

                Phoneme s = new Phoneme(args[0]);
                s.CheckingEnglishLetters();
                s.CheckingPositionOfPlus();

                Console.WriteLine(s.ReturnString(length));
                return 0;
            }
            catch(FormatException exs)
            {
                Console.WriteLine(exs.Message);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 2;
            }
        }
    }
}
