using System;

namespace task_Dev_5
{
    /// <summary>
    /// The main class which implements the main method
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method of class EntryPoint
        /// </summary>
        /// <param name="args"></param>
        /// <returns 0> everything is good </returns>
        /// <returns 1> some error message </returns>
        static int Main(string[] args)
        {
            try
            {
                Point point = new Point(0, 0, 0);
                Point newPoint = new Point(100, 200, 800);

                Bird bird = new Bird();
                Console.WriteLine(bird.WhoAmI());
                bird.FlyTo(newPoint);
                Console.WriteLine(bird.GetFlyTime());

                Plane plane = new Plane();
                Console.WriteLine(plane.WhoAmI());
                plane.FlyTo(newPoint);
                Console.WriteLine(plane.GetFlyTime());

                SpaceShip spaceShip = new SpaceShip();
                Console.WriteLine(spaceShip.WhoAmI());
                spaceShip.FlyTo(newPoint);
                Console.WriteLine(spaceShip.GetFlyTime());
                return 0;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }
        }
    }
}
