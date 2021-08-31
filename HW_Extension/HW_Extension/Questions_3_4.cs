using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Extension
{
    static class IntExtension
    {
        #region Q3

        public static string ConvertOnesToString(int num)
        {
            if(num < 0 || num > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
            switch (num)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";

                default:
                    return "";
            }
        }

        public static string ConvertTensToString(int num)
        {

            switch (num)
            {
                case 20:
                    return "twenty";
                case 30:
                    return "thirty";
                case 40:
                    return "fourty";
                case 50:
                    return "fifty";
                case 60:
                    return "sixty";
                case 70:
                    return "seventy";
                case 80:
                    return "eighty";
                case 90:
                    return "ninty";
                case 100:
                    return "hundred";
                default:
                    return "";
            }
        }

        public static string Print(this int num)
        {
            if (num < 0)
            {
                return "negative";
            }
            else if (num >= 0 && num <= 10)
            {
                return IntExtension.ConvertOnesToString(num);
            }
            else if (num > 100)
            {
                return "Ad Kan!";
            }
            else if (num == 11)
            {
                return "eleven";
            }
            else if (num == 12)
            {
                return "twelve";
            }
            else if (num == 13)
            {
                return "tihrteen";
            }
            else if (num == 15)
            {
                return "fifteen";
            }
            else if (num == 18)
            {
                return "eighteen";
            }
            else if (num > 12 && num < 20)
            {
                int ones = num - 10;
                return IntExtension.ConvertOnesToString(ones) + "teen";
            }
            else if (num >= 20 && num < 100 && num % 10 == 0)
            {
                return IntExtension.ConvertTensToString(num);
            }
            else if (num == 100)
            {
                return "hundred";
            }
            else
            {
                int tens1 = num / 10;
                int ones1 = num - tens1 * 10;
                return IntExtension.ConvertTensToString(tens1 * 10) + " " + IntExtension.ConvertOnesToString(ones1);
            }
        }

        #endregion

        public static int MultipleBy(this int num, int multi)
        {
            return num * multi;
        }
    }
}
