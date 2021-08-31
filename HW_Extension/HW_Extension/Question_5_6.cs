using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Extension
{
    static class ObjectExtension
    {
        public static bool IsNull(this object obj)
        {
            if(obj == null) { return true; }
            return false;
        }
    }


    static class StringExtension2
    {
        public static bool GetChekDigit(this string str)
        {
            if (str.Length != 9)
            {
                return false;
            }

            int[] count = new int[] { 1, 2, 1, 2, 1, 2, 1, 2 };
            int x, y = 0;
            int checkDigit = int.Parse(Convert.ToString(str[8]));

            for (int i = 0; i < count.Length; i++)
            {
                x = count[i] * int.Parse(Convert.ToString(str[i]));
                if(x > 9)
                {
                    x = (x / 10) + (x % 10);
                }
                y += x;
            }
            return checkDigit == 10 - (y % 10);
        }

        
    }
}
