using System;

namespace task_Dev_4
{
    ///<summary>
    ///static class for implementing a GUID parameter
    ///<summary>
    static class RealizationOfGuid
    {
       ///<summary>
       ///special static method for GUID
       ///<summary> 
        public static string GuidToString(this string str)
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
    }
}
