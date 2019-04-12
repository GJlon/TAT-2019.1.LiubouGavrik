using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp1
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
        XDocument xDoc;

        public WorkWithDocument(string document)
        {
            xDoc = XDocument.Load(document);
        }

        /// <summary>
        /// Method for getting count types of cars
        /// </summary>
        public int GetCountTypes()
        {
            int countType = 0;

            foreach (XElement carElement in xDoc.Element("cars").Elements("car"))
            {
                Console.WriteLine(carElement.Element("mark").Value);
                countType++;
            }

            return countType;
        }

        /// <summary>
        /// Metod for getting count of all cars
        /// </summary>
        public int GetCountAll()
        {
            int countAllAuto = 0;

            foreach (XElement carElement in xDoc.Element("cars").Elements("car"))
            {
                countAllAuto += Int32.Parse(carElement.Element("quantity").Value);
            }

            return countAllAuto;
        }

        /// <summary>
        /// Metod for getting average price of car
        /// </summary>
        public double GetAveragePrice()
        {
            int averagePrice = 0;
            int countType = 0;

            foreach (XElement carElement in xDoc.Element("cars").Elements("car"))
            {
                averagePrice += Int32.Parse(carElement.Element("cost").Value);
                countType += 1;
            }

            return averagePrice;
        }

        /// <summary>
        /// Metod for getting average price type
        /// </summary>
        public double GetAveragePriceType(string mark)
        {
            double averagePriceType = 0;
            int quantity = 0;

            foreach (XElement carElement in xDoc.Element("cars").Elements("car"))
            {
                if (carElement.Element("mark").Value == mark)
                {
                    averagePriceType += Int32.Parse(carElement.Element("cost").Value);
                    quantity++;
                }

                else
                {
                    throw new Exception("This mark doesn't found.");
                }
            }

            return averagePriceType / quantity;
        }
    }
}

