using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsConsoleApp1
{
    internal class SplitAndReversText
    {
        public static void SeparationAndReversText(string text)
        {
            var splitText = text.Split();

            for (int i = splitText.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(splitText[i]);
            }

            
            
        }
    }
}
