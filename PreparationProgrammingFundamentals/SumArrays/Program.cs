using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] biggerArray = new int[Math.Max(arr1.Length, arr2.Length)];
            int sum = 0;

            for (int i = 0; i <= biggerArray.Length; i++)
            {
                sum = arr1[i % biggerArray.Length] + arr2[i % biggerArray.Length];
              
                Console.Write(sum + " ");
            }

            Console.WriteLine();


        }
    }
}
