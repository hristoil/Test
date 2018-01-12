using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCharsFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "LEGO STAR WARS. The Force Awakens";

            int index = str.IndexOf('.');          

            Console.WriteLine(str.Substring(index+2));


        }
    }
}
