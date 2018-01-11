using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int[] mumbers = new int[input.Length];
            bool foundSum = false;

            for (int i = 0; i < input.Length; i++)
            {
                mumbers[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < mumbers.Length - 1; i++)
            {
                for (int j = i+1; j < mumbers.Length; j++)
                {
                    for (int k = 0; k < mumbers.Length; k++)
                    {
                        if (mumbers[i]+ mumbers[j] == mumbers[k])
                        {
                            Console.WriteLine("{0} + {1} == {2}",mumbers[i], mumbers[j], mumbers[k]);
                            foundSum = true;
                            break;
                        }
                      
                    }
                }
            }
            if (!foundSum)
            {
                Console.WriteLine("No");                 
            }
                
            

        }
    }
}
