using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    /// <summary>
    /// class for working with a document, reading information and 
    /// implementing necessary methods
    /// </summary>
    class InfoDocument
    {
        /// <summary>
        /// variable created to work with the document
        /// </summary>
        XDocument xDoc;

        public InfoDocument(string document)
        {
            try
            {
                xDoc = XDocument.Load(document);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine(document);
                Console.WriteLine("Error! Don't find document.");
            }
        }

        /// <summary>
        /// Method for getting count types of cars
        /// </summary>
        public int GetCountTypes()
        {
            int countOfType = 0;
            
            foreach (XElement car in xDoc.Element("cars").Elements("car"))
            {
                countOfType++;
            }

            return countOfType;
        }

        /// <summary>
        /// Metod for getting count of all cars
        /// </summary>
        public int GetCountAll()
        {
            int countAll = 0;

            foreach (XElement car in xDoc.Element("cars").Elements("car"))
            {
                countAll += Int32.Parse(car.Element("quantity").Value);
            }

            return countAll;
        }       

        /// <summary>
        /// Metod for getting average price of car
        /// </summary>
        public double GetAveragePrice()
        {
            int averagePrice = 0;
            int price = 0;
            int cost = 0;
            int countOfModels = 0;

            foreach (XElement car in xDoc.Element("cars").Elements("car"))
            {
                cost = Int32.Parse(car.Element("cost").Value);
                price += Int32.Parse(car.Element("cost").Value);
                countOfModels++;
            }

            averagePrice = price / countOfModels;
        
            return averagePrice;
        }

        /// <summary>
        /// Metod for getting average price type
        /// </summary>
        public double GetAveragePriceType(string mark)
        {
            int costOfType = 0;
            int countOfType = 0;

            foreach (XElement car in xDoc.Element("cars").Elements("car"))
            {
                if (car.Element("mark").Value == mark)
                {
                    costOfType += Int32.Parse(car.Element("cost").Value);
                    countOfType++;
                }
            }

            if (countOfType <= 0)
            {
                Console.WriteLine("Error! Don't have count of type.");
            }
            
            return costOfType/countOfType;
        }  
    }
}
