using System;
using System.Collections.Generic;

namespace task_Dev_7
{
    class WorkWithCommands
    {
        public WorkWithCommands(string document)
        {
            WorkWithDocument passengerCar = InfoPassengerCar.GetNum(@"C:\Users\TTN\Desktop\Task_6\Task_6\" + document);
            WorkWithDocument truck = InfoTruck.GetNum(@"C:\Users\TTN\Desktop\Task_6\Task_6\" + document);
        }

        Dictionary<int, Command> listOfCommands = new Dictionary<int, Command>(4);
        
        public void Run(string document)
        {
            WorkWithDocument readDocument = new WorkWithDocument(document);
            Invoker invoker = new Invoker();
            bool exit = false;
            listOfCommands.Add(1, new CountTypes(readDocument));
            listOfCommands.Add(2, new CountAll(readDocument));
            listOfCommands.Add(3, new AveragePrice(readDocument));
            listOfCommands.Add(4, new AveragePriceType(readDocument));

            while (exit != true)
            {
                Console.WriteLine("1.Count types;\n" + "2.Count all;\n" + "3.Average price;\n" + "4.Average price type.\n" + "5.Execute\n" + "6.Exite\n" + "Choose command: ");
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
                        Console.WriteLine("Execute");
                        exit = true;
                        break;

                    case 6:
                        Console.WriteLine("Exit");
                        exit = true;
                        break;
                }
            }
        }
    }
}

