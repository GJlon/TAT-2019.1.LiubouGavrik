using System;

namespace task_Dev_4
{
    static class RealizationOfGuid
    {
        public static string GuidToString(this string str)
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
    }
}
