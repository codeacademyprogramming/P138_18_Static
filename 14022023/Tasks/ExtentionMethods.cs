using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal static class ExtentionMethods
    {
        public static string ToCapitalize(this string str)
        {
            string newStr = Char.ToUpper(str[0]) + str.Substring(1).ToLower();

            return newStr;
        }

        public static int Add(this int num, int value)
        {
            return num + value;
        }

        public static bool HasDigit(this string str)
        {
            if (str == null) return false;

            foreach (var cr in str)
            {
                if (char.IsDigit(cr))
                    return true;
            }

            return false;
        }

        public static bool ContainsOnlyLetter(this string str)
        {
            if(str == null) return false;

            foreach (var cr in str)
            {
                if (!char.IsLetter(cr))
                    return false;
            }

            return true;
        }

        public static int CountChar(this string str, char wantedChar)
        {
            if (str == null) return 0;

            int count = 0;  
            foreach (var cr in str)
            {
                if (cr == wantedChar)
                    count++;
            }

            return count;
        }



    }
}
