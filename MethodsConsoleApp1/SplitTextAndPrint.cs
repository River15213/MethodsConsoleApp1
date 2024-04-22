using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsConsoleApp1
{
    internal class SplitTextAndPrint
    {
        public static string[] SeparationText(string text)
        {
            return text.Split(" ");
        }

        public static void PrintText(string[] text)
        {
            Console.WriteLine();
            foreach (string s in text)
            {
                Console.WriteLine(s);
            }
        }


    }
}
