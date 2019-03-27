using System;

namespace task_Dev_4
{
    class EntryPoint
    {
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
