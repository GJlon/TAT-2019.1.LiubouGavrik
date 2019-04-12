using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;

namespace task_Dev_7
{
    /// <summary>
    /// class for working with a document, reading information and 
    /// implementing necessary methods
    /// </summary>
    class WorkWithDocument
    {
        /// <summary>
        /// variable created to work with the document
        /// </summary>
        XmlDocument xDoc;
        public IEnumerable<Cars> Car { get; private set; }

        public WorkWithDocument(string document)
        {
            xDoc = new XmlDocument();
            xDoc.Load(@"C:\Users\TTN\Desktop\Task_6\Task_6\" + document);
        }

        /// <summary>
        /// Method for getting count types of cars
        /// </summary>
        public int GetCountTypes()
        {
            return Car.GroupBy(car => car.Mark).Count();
        }

        /// <summary>
        /// Metod for getting count of all cars
        /// </summary>
        public int GetCountAll()
        {
            return Car.Select(car => car.Quantity).Sum();
        }

        /// <summary>
        /// Metod for getting average price of car
        /// </summary>
        public double GetAveragePrice()
        {
            return Car.Select(car => car.Cost).Average();
        }

        /// <summary>
        /// Metod for getting average price type
        /// </summary>
        public double GetAveragePriceType(string mark)
        {
            if (Car.Select(car => car.Mark).Contains(mark.ToLower()))
            {
                return Car.Where(car => car.Mark == mark.ToLower()).Select(car => car.Cost).Average();
            }
            else
            {
                throw new Exception("This mark doesn't found.");
            }
        }
    }
}

