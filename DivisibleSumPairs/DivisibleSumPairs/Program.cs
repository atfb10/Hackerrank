using System;
using System.Collections.Generic;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] arr = { 1, 3, 2, 6, 1, 2 };
            int sum = 3;

            // call method and show results
            Console.WriteLine(SumPairs(arr, sum) + " is the number of divisible sum pairs."); 

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Method that takes in argument of array and number n
        /// Finds the number of pairs that are divisible by n
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int SumPairs(int[] arr, int n)
        {
            // initialize variables
            int count = 0;
            int i;
            int j;
            int len = arr.Length;

            // outer loop moves through index
            for(i = 0; i < len; i++)
            {
                /* 
                 * inner loop moves from current index to right
                 * Adds index values of outer loop and inner loop
                 * If divible, then add one to the counter
                 * If not divisible by n, iterate inner loop again
                 */
                for(j = i; j < len; j++)
                {
                    if ((arr[i] + arr[j]) % n == 0)
                    {
                        count++;
                        break; // keeps from adding additional j's 
                    }
                                            
                }
            }

            // return count of sum pairs
            return count;
        }
    }
}
