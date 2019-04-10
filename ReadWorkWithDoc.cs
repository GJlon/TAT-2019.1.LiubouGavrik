using System;
using System.Collections.Generic;
using System.Xml;

namespace Task_6
{
    /// <summary>
    /// class for working with a document, reading information and 
    /// implementing necessary methods
    /// </summary>
    class ReadWorkWithDoc
    {
        /// <summary>
        /// variable created to work with the document
        /// </summary>
        XmlDocument xDoc;

        public ReadWorkWithDoc(string document)
        {
            xDoc = new XmlDocument();
            xDoc.Load(@"C:\Users\TTN\Desktop\Task_6\Task_6\" + document);
        }

        /// <summary>
        /// Method for getting count types of cars
        /// </summary>
        public int GetCountTypes()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            List<string> allTypesOfCars = new List<string>();

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "mark")
                    {
                        if (!allTypesOfCars.Contains(childnode.InnerText))
                        {
                            allTypesOfCars.Add(childnode.InnerText);
                        }
                    }
                }
            }
            return allTypesOfCars.Count;
        }

        /// <summary>
        /// Metod for getting count of all cars
        /// </summary>
        public int GetCountAll()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int countAll = 0;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "quantity")
                    {
                        countAll += Int32.Parse(childnode.InnerText);
                    }
                }
            }
            return countAll;
        }       

        /// <summary>
        /// Metod for getting average price of car
        /// </summary>
        public double GetAveragePrice()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int averagePrice = 0;
            int price = 0;
            int cost = 0;
            int countOfModels = 0;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "cost")
                    {
                        cost = Int32.Parse(childnode.InnerText);
                        price += Int32.Parse(childnode.InnerText);
                        countOfModels++;
                    }
                }
                averagePrice = price / countOfModels;
            }
            return averagePrice;
        }

        /// <summary>
        /// Method for getting count of type
        /// </summary>
        /// <param name="mark"></param>
        public int GetCountOfType(string mark)
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int countOfType = 0;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "mark")
                    {
                        if (childnode.InnerText == mark)
                        {
                            foreach (XmlNode childnode1 in xnode.ChildNodes)
                            {
                                if (childnode1.Name == "model")
                                {
                                    countOfType ++;
                                }
                            }
                        }
                    }
                }
            }
            return countOfType;
        }

        /// <summary>
        /// Metod for getting average price type
        /// </summary>
        public double GetAveragePriceType(string mark)
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int costOfType = 0;
            int countOfType = GetCountOfType(mark);
            GetCountOfType(mark);

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "mark")
                    {
                        if (childnode.InnerText == mark)
                        {
                            foreach (XmlNode childnode1 in xnode.ChildNodes)
                            {
                                if (childnode1.Name == "cost")
                                {
                                    costOfType += Int32.Parse(childnode1.InnerText);
                                }
                            }
                        }
                    }
                }
            }
            return costOfType/countOfType;
        }  
    }
}
