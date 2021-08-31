using System;
using System.Text.RegularExpressions;

namespace HW_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //var st = StringExtension.ReverseCase("HacKerU");
            //Console.WriteLine(st);

            //for (int i = 0; i < 101; i++)
            //{
            //    var integer = IntExtension.Print(i);
            //    Console.WriteLine(integer);
            //}

            int x = 2;
            Console.WriteLine(x.MultipleBy(7));

            int[] aa = new int[9];
            object aaa = "erer";

            if (aa.IsNull()) { Console.WriteLine("true"); }
            else { Console.WriteLine("false"); }


            var isValidId = StringExtension2.GetChekDigit("311546352");
            Console.WriteLine(isValidId);
        }
    }
}
