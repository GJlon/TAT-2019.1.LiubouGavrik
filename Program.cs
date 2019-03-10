using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_1
{
    class Program
    {
        //metod that allows to work with arguments from the command line
        static void Main(string[] args)
        {
            //write args down in a string 's' and find length
            string str = args[0];
            int length = str.Length;

            if (String.IsNullOrEmpty(str) == true)
                Console.WriteLine("Error! Empty string");
            if (length <= 2)
                Console.WriteLine("Error! Enter more letters");

            var logic = new Logic(args);
            logic.ListNewStr(str, length);
           
           Console.ReadKey();
        }

        public class Logic
        {
            int flag = 0;
            string newstr;
            List<string> listNewStr;

            public Logic(string[] args)
            {
                listNewStr = new List<string>();
            }

            public List<string> ListNewStr(string s, int l)
            {
                for (int i = 0; i < l - 1; i++)
                {
                    if (s[i] != s[i + 1])
                    {
                        AddToNewStr(i);
                    }
                    else
                    {
                        flag = i;
                    }
                }
                return listNewStr;
            }

            public void AddToNewStr(int i)
            {
                for (int j = 1; j <= i - flag; j++)
                {
                    newstr = ToString().Substring(i - j, j + 1);
                    if (!listNewStr.Contains(newstr))
                    {
                        listNewStr.Add(newstr);
                        Console.WriteLine(newstr);
                        
                    }
                }
            }

        }
    }
}

