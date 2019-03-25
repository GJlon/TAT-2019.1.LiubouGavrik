using System;
using System.Collections.Generic;

namespace task_Dev_1
{
    class SubstringSearch
    {

        /// <summary>
        /// "flag" is used to record the element's ID, which is repeated in the 
        ///string (initially initialized to zero)
        /// </summary>
        int flag = 0;
        /// <summary>
        /// "newString" is a variable created to write the found substring
        /// </summary>
        string newSubstring;
        /// <summary>
        /// list in which the subsequences are added
        /// </summary>
        List<string> listWithNewStrings;
        /// <summary>
        /// original string
        /// </summary>
        string originalString;
        public SubstringSearch(string originalString)
        {
            if (String.IsNullOrEmpty(originalString) || originalString.Length < 2)
            {
                throw new FormatException();
            }
                listWithNewStrings = new List<string>();
            this.originalString = originalString;
        }
        /// <summary>
        /// go through the sequence and search for duplicate charters, transfer 
        /// the "flag" to a new position and send the corresponding character 
        /// </summary>
        /// <returns></returns>
        public List<string> ListWithNewStrings()
        {
            for (int i = 0; i < originalString.Length - 1; i++)
            {
                if (originalString[i] != originalString[i + 1])
                {
                    AddToNewStr(i+1);
                }
                else
                {
                    flag = i + 1;
                }
            }
            return listWithNewStrings;
        }
        /// <summary>
        /// receiving and recoding of subsequences in the list and comparing 
        /// of subsequences for the identity of the same in the list
        /// </summary>
        /// <param name="i"></param>
        public void AddToNewStr(int i)
        {
            for (int j = 1; j <= i - flag; j++)
            {
                newSubstring = originalString.Substring(i - j, j + 1);
                if (!listWithNewStrings.Contains(newSubstring))
                {
                    listWithNewStrings.Add(newSubstring);
                }
            }
        }

    }
}

