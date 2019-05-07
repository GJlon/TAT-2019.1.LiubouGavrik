namespace task_Dev_7
{
    internal class InfoTruck : InfoDocument
    {
        static InfoTruck num;

        /// <summary>
        /// Constructor with parameter. Invoke inherited class constructor
        /// </summary>
        /// <param name="fileName">xml-file name</param>
        protected InfoTruck(string document) : base(document)
        { }

        /// <summary>
        /// This method create InfoTruck class objects
        /// </summary>
        public static InfoTruck GetNum(string document)
        {
            if (num == null)
            {
                num = new InfoTruck(document);
            }

            return num;
        }
    }
}
