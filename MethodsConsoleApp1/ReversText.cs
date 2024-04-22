using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsConsoleApp1
{
    internal class ReversText
    {
        public static string[] ReversWorld(string[] strings)
        {
            return strings.Reverse().ToArray();
        } 
    }
}
