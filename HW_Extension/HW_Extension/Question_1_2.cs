using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Extension
{
    static class StringExtension
    {
        public static bool HasLowerChars(this string str)
        {
            if (str.ToUpper() == str)
            {
                return false;
            }
            return true;
        }

        public static string ReverseCase(this string str)
        {
            string newStr = "";
            foreach (var ch in str)
            {
                if (char.IsUpper(ch))
                {
                    newStr += char.ToLower(ch);
                }
                else
                {
                    newStr += char.ToUpper(ch);
                }
            }
            
            return newStr;
        }
    }
}
