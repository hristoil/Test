using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNeighbourElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = 0;
            while (nums.Length>1)
            {
                for (int i = 0; i < nums.Length-1; i++)
                {
                    int[] condensed = new int[nums.Length - 1];
                    condensed[i] = nums[i] + nums[i + 1];
                    nums[i] = condensed[i];
                    sum = nums[i] + nums[i + 1];
                }
                Console.WriteLine(sum);
            }
            


        }
    }
}
