using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Dev_7
{
    /// <summary>
    /// Class heir of WorkWithDocument. Used singleton
    /// </summary>
    class InfoPassengerCar : WorkWithDocument
    {
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
