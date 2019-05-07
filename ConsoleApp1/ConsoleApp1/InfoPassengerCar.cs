using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Class heir of WorkWithDocument. Used singleton
    /// </summary>
    class InfoPassengerCar : InfoDocument
    {
        /// <summary>
        /// Help to work with information about cars
        /// </summary>
        static InfoPassengerCar num;

        protected InfoPassengerCar(string document) : base(document)
        {}

        /// <summary>
        /// This method create InfoPassangerCar class objects
        /// </summary>
        public static InfoPassengerCar GetNum(string document)
        {
            if (num == null)
            {
                num = new InfoPassengerCar(document);
            }

            return num;
        }
    }
}
