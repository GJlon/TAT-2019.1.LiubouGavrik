using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskDev2
{
    /// <summary>
    /// Class Program. Сlass for getting phonemes of the word
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method of class EntryPoint
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        /// <returns>everything is good - 0</returns>
        /// <returns>string has english letters of more then one "+" - 1</returns>
        /// <returns>other exceptions in the program - 2</returns>
        static int Main(string[] args)
        {
            try
            {
                string originalString = args[0].ToLower();
                int length = originalString.Length;

                Phoneme phoneme = new Phoneme(args[0]);
                phoneme.CheckingEnglishLetters();
                phoneme.CheckingPositionOfPlus();

                Console.WriteLine(phoneme.ReturnString(length));

                return 0;
            }
            catch (FormatException exs)
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
