using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    /// <summary>
    /// Class gives an apportunity to work with Dictionary of commands
    /// </summary>
    class WorkWithCommands
    {
        public WorkWithCommands(string document1, string document2)
        {
            InfoDocument passengerCar = InfoPassengerCar.GetNum(@"C:\Users\TTN\TAT-2019.1.LiubouGavrik\ConsoleApp1\ConsoleApp1\" + document1);
            InfoDocument truck = InfoTruck.GetNum(@"C:\Users\TTN\TAT-2019.1.LiubouGavrik\ConsoleApp1\ConsoleApp1\" + document2);
            Invoker invoker = new Invoker();
            bool exit = false;

            Dictionary<int, Command> listOfCommands = new Dictionary<int, Command>(4);
            listOfCommands.Add(1, new CountTypes(passengerCar));
            listOfCommands.Add(2, new CountAll(passengerCar));
            listOfCommands.Add(3, new AveragePrice(passengerCar));
            listOfCommands.Add(4, new AveragePriceType(passengerCar));
            listOfCommands.Add(5, new CountTypes(truck));
            listOfCommands.Add(6, new CountAll(truck));
            listOfCommands.Add(7, new AveragePrice(truck));
            listOfCommands.Add(8, new AveragePriceType(truck));

            while (exit != true)
            {
                Console.WriteLine("0.Execute;\n"+"1.Count types;\n" + "2.Count all;\n" + "3.Average price;\n" +
                    "4.Average price type.\n" + "5.Count types truck;\n" + "6.Count all truck;\n" + 
                    "7.Average price truck;\n" + "8.Average price type truck.\n" + "9.Exit\n" + 
                     "Choose command: ");
                int command = Convert.ToInt32(Console.ReadLine());
                bool execFlag = false;

                switch (command)
                {
                    case 0:
                        execFlag = true;
                        command++;
                        goto case 1;

                    case 1:
                        invoker.SetCommand(listOfCommands[command]);
                        invoker.Run();

                        if (execFlag)
                        {
                            command++;
                            goto case 2;
                        }

                        break;

                    case 2:
                        invoker.SetCommand(listOfCommands[command]);
                        invoker.Run();

                        if (execFlag)
                        {
                            command++;
                            goto case 3;
                        }

                        break;

                    case 3:
                        invoker.SetCommand(listOfCommands[command]);
                        invoker.Run();

                        if (execFlag)
                        {
                            command++;
                            goto case 4;
                        }

                        break;

                    case 4:
                        invoker.SetCommand(listOfCommands[command]);
                        invoker.Run();

                        if (execFlag)
                        {
                            command++;
                            goto case 5;
                        }

                        break;

                    case 5:
                        invoker.SetCommand(listOfCommands[command]);
                        invoker.Run();

                        if (execFlag)
                        {
                            command++;
                            goto case 6;
                        }

                        break;

                    case 6:
                        invoker.SetCommand(listOfCommands[command]);
                        invoker.Run();

                        if (execFlag)
                        {
                            command++;
                            goto case 7;
                        }

                        break;

                    case 7:
                        invoker.SetCommand(listOfCommands[command]);
                        invoker.Run();

                        if (execFlag)
                        {
                            command++;
                            goto case 8;
                        }

                        break;

                    case 8:
                        invoker.SetCommand(listOfCommands[command]);
                        invoker.Run();
                        break;

                    case 9:
                        Console.WriteLine("Exit");
                        exit = true;
                        break;
                }
            }
        }
    }
}

