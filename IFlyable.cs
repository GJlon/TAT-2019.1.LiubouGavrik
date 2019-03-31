namespace task_Dev_5
{
    /// <summary>
    /// intrface IFlyable contains methods that will be used in classes Bird, SpaceShip, Plane
    /// </summary>
    interface IFlyable
    {
        /// <summary>
        /// Method for working with points of reference and arrival (distance)
        /// </summary>
        /// <param name="newPoint"></param>
        void FlyTo(Point newPoint);

        /// <summary>
        /// Object initialization method
        /// </summary>
        /// <returns></returns>
        string WhoAmI();

        /// <summary>
        /// Method to get flight time
        /// </summary>
        /// <returns></returns>
        double GetFlyTime();
    }
}
