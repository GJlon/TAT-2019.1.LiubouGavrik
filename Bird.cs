using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_5
{
    /// <summary>
    /// class Bird and its properties are described
    /// </summary>
    class Bird : IFlyable
    {
        Point point;

        /// <summary>
        /// stores information about the speed of flight of the bird
        /// </summary>
        double birdFlightSpeed;

        /// <summary>
        /// flight time of the bird
        /// </summary>
        double flightTime;

        /// <summary>
        /// /Variable storing distance of bird flight
        /// </summary>
        double distance;

        /// <summary>
        /// constructor of Bird class for initializing parameters
        /// </summary>
        public Bird()
        {
            flightTime = 0;
            distance = 0;
        }

        /// <summary>
        /// Method which searchs distances
        /// </summary>
        /// <param name="newPoint"></param>
        public void FlyTo(Point newPoint)
        {
            Point distanceCalculation = new Point();
            distance = distanceCalculation.DistanceCalculation(point, newPoint);
            
        }

        /// <summary>
        /// Method which returns the description of the object
        /// </summary>
        /// <returns></returns>
        public string WhoAmI()
        {
            return "Bird";
        }

        /// <summary>
        /// Returns the flight time of the object
        /// </summary>
        /// <returns></returns>
        public double GetFlyTime()
        {
            Random random = new Random();
            birdFlightSpeed = random.Next(0, 20);
            flightTime = distance / birdFlightSpeed;
            return flightTime;
        }
    }
}
