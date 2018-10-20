using System;
using System.Collections.Generic;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            // test array
            int[] sockPairs = { 10, 20, 20, 10, 10, 30, 50, 10, 20 }; // 3 pairs
            int numSocks = sockPairs.Length;

            // call method and test
            Console.WriteLine("Number of pairs in array = " + CountPairs(sockPairs, numSocks));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// method to count pairs and return value
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int CountPairs(int[] arr, int n)
        {
            // initialize variables
            int numPairs = 0;
            int i;
            HashSet<int> myHash = new HashSet<int>();

            // loop through array and add items to hashset
            for (i = 0; i < n; i++)
            {
                // if items in hash, increment pair counter and remove item from hashset
                if (myHash.Contains(arr[i]))
                {
                    numPairs++;
                    myHash.Remove(arr[i]);
                }
                // item not in hashset already, add it once
                else
                {
                    myHash.Add(arr[i]);
                }
            }

            // return the number of pairs
            return numPairs;
        }
    }
}
