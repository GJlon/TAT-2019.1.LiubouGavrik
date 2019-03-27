using System;

namespace task_Dev_4
{
    class Lectures:Materials
    {
        static int amountOfLectures = 10;
        PresentationFormat presentationFormat;
        readonly string[] lecture = new string[amountOfLectures];

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

        enum PresentationFormat
        {
            Unknown, PPT, PDF
        }

        public string this[int i]
        {
            get
            {
                return lecture[i];
            }
            set
            {
                if (value != null && value.Length < 100000)
                {
                    lecture[i] = value;
                }
                else
                {
                    throw new FormatException("Error! This lecture has more than 100000 letters!");
                }             
            }
        }

        public string GetGuid()
        {
            return guid;
        }

        public override string ToString()
        {
            return "Lecture";
        }

    }
}
