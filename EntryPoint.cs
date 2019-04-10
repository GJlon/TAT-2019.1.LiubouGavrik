using System;
using System.Collections.Generic;

namespace Task_6
{
    /// <summary>
    /// This program is created for working with xml-file.
    /// </summary>
    class EntryPoint
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
                ReadWorkWithDoc readDocument = new ReadWorkWithDoc(args[0]);
                Invoker invoker = new Invoker();
                bool exit = false;

                Dictionary<int, Command> listOfCommands = new Dictionary<int, Command>(4);
                listOfCommands.Add(1, new CountTypes(readDocument));
                listOfCommands.Add(2, new CountAll(readDocument));
                listOfCommands.Add(3, new AveragePrice(readDocument));
                listOfCommands.Add(4, new AveragePriceType(readDocument));

                while (exit != true)
                {
                    Console.WriteLine("1.Count types;\n" + "2.Count all;\n" + "3.Average price;\n" + "4.Average price type.\n" + "5.Exit\n" + "Choose command: ");
                    int command = Convert.ToInt32(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            invoker.SetCommand(listOfCommands[command]);
                            invoker.Run();
                            break;

                        case 2:
                            invoker.SetCommand(listOfCommands[command]);
                            invoker.Run();
                            break;

                        case 3:
                            invoker.SetCommand(listOfCommands[command]);
                            invoker.Run();
                            break;

                        case 4:
                            invoker.SetCommand(listOfCommands[command]);
                            invoker.Run();
                            break;

                        case 5:
                            Console.WriteLine("exit");
                            exit = true;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Didn't find file.");
            }
        }
    }
}
