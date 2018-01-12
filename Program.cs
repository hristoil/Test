using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = Console.ReadLine();

            int count = 0;

            int index = text.IndexOf(pattern);

            while (index != -1) 
            {
                count++;
                index = text.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
