using System;
using System.Text;

namespace task_Dev_4
{
    /// <summary>
    /// This class is a class descendant of materials. It implements schlness lecture
    /// </summary>
    class Lectures:Materials
    {
        /// <summary>
        /// the name of the lecture will be written in this variable
        /// </summary>
        string text;
        /// <summary>
        /// amount of lectures
        /// </summary>
        static int amountOfLectures = 4;
        /// <summary>
        /// variable for presentation format
        /// </summary>        
        PresentationFormat presentationFormat;
        /// <summary>
        /// The following variables are used to create enum and it is easier to work with strings.
        /// </summary>        
        readonly string[] lecture = new string[amountOfLectures];
        StringBuilder lectureDescription = new StringBuilder();
        int amountOfSeminars;
        int amountOfLaboratoryWorks;
        /// <summary>
        /// A constructor is implemented in which the lecture format is checked.
        /// </summary> 
        public Lectures( string presentationFormat)
        {
            if (presentationFormat == PresentationFormat.PDF.ToString())
            {
                this.presentationFormat = PresentationFormat.PDF;
            }
            else
            {
                this.presentationFormat = PresentationFormat.Unknown;
            }
            if (presentationFormat == PresentationFormat.PPT.ToString())
            {
                this.presentationFormat = PresentationFormat.PPT;
            }
        }
        /// <summary>
        /// enum
        /// </summary> 
        enum PresentationFormat
        {
            Unknown, PPT, PDF
        }
        /// <summary>
        /// extension method
        /// </summary> 
        public string this[int i]
        {
            get
            {
                return lecture[i];
            }
            set
            {
                amountOfSeminars = 7;
                amountOfLaboratoryWorks = 5;

                if (value != null && value.Length < 100000)
                {
                    text = value;
                    lecture[i] = value;
                }
                else
                {
                    throw new FormatException("Error! This lecture has more than 100000 letters!");
                }             
            }
        }
        /// <summary>
        /// GUID
        /// </summary> 
        public string GetGuid()
        {
            return guid;
        }
        /// <summary>
        /// description metod
        /// </summary> 
        public string Description()
        {
            lectureDescription.Append(text);
            lectureDescription.Append(" :seminars and laboratory works");
            lectureDescription.Append("\n");
            lectureDescription.Append(amountOfSeminars);
            lectureDescription.Append("\n");
            lectureDescription.Append(amountOfLaboratoryWorks);
            return lectureDescription.ToString();
        }
        /// <summary>
        /// override ToString()
        /// </summary> 
        public override string ToString()
        {
            return "Lecture";
        }
    }
}
