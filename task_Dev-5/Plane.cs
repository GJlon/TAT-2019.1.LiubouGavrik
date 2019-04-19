namespace task_Dev_5
{
    /// <summary>
    /// class Plane and its properties are described
    /// </summary>
    class Plane : IFlyable
    {
        Point point;

        /// <summary>
        /// stores information about the speed of flight of the plane
        /// </summary>
        double planeFlightSpeed;

        /// <summary>
        /// flight time of the plane
        /// </summary>
        double flightTime;

        /// <summary>
        ///Variable storing distance of plane flight
        /// </summary>
        double distance;

        /// <summary>
        /// constructor of Plane class for initializing parameters
        /// </summary>
        public Plane()
        {
            planeFlightSpeed = 200;
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
            return "Plane";
        }

        /// <summary>
        /// Returns the flight time of the object
        /// </summary>
        /// <returns></returns>
        public double GetFlyTime()
        {
            while (distance <= 10)
            {
                flightTime += 10 / planeFlightSpeed;
                planeFlightSpeed += 10;
                distance -= 10;
            }

            flightTime += distance / planeFlightSpeed;
            return flightTime;
        }
    }
}
