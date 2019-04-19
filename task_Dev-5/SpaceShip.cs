namespace task_Dev_5
{
    /// <summary>
    /// class SpaceShip and its properties are described
    /// </summary>
    class SpaceShip : IFlyable
    {
        Point point;
        
        /// <summary>
        /// speed of spaceship
        /// </summary>
        double spaceShipFlightSpeed;

        /// <summary>
        /// flight time of the spacrship
        /// </summary>
        double flightTime;

        /// <summary>
        /// Variable storing distance of spaceship flight
        /// </summary>
        double distance;

        /// <summary>
        /// constructor of SpaceShip class for initializing parameters
        /// </summary>
        public SpaceShip()
        {
            spaceShipFlightSpeed = 8000;
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
            return "SpaceShip";
        }

        /// <summary>
        /// Returns the flight time of the object
        /// </summary>
        /// <returns></returns>
        public double GetFlyTime()
        {
            flightTime = distance / spaceShipFlightSpeed;
            return flightTime;
        }
    }
}
