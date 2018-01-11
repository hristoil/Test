using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrStrings = Console.ReadLine().Split(' ');
            var asd = arrStrings.Reverse();
            Console.WriteLine(string.Join(" ", asd));
        }
    }
}
