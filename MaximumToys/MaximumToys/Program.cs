using System;

namespace MaximumToys
{
    class Program
    {
        static void Main(string[] args)
        {
            // test array
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            int maxExpenditure = 50;

            // call method, test output

            // show toy prices
            Console.WriteLine("Toy Prices: ");
            PrintArr(prices);

            // show number of toys
            Console.WriteLine(MaxToys(prices, maxExpenditure) + " toys can be bought with $" + maxExpenditure);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Method to find number of toys that can be purchased
        /// Determined based upon integer values in an array and budget 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int MaxToys(int[] arr, int n)
        {
            // initialize variables
            int toys = 0;
            int priceTotal = 0;
            int len = arr.Length;
            int i;

            // sort array
            QSort(arr, 0, len - 1);

            // traverse array, add number of toys until budget exceed
            for(i = 0; i < len; i++)
            {
                // add price of toy to total
                priceTotal += arr[i];

                // check if price total is below or equal to max budget. Increment if so
                if (priceTotal <= n)
                    toys++;
                // if greater, break loop. Array is sorted, no more toys can be purchased
                else
                    break;
            }

            // return count of toys
            return toys;
        }

        /// <summary>
        /// Partition array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static int Part(int[] arr, int start, int end)
        {
            // initialize variables
            int i = start - 1;
            int pivot = arr[end];
            int j;

            for (j = start; j < end; j++)
            {
                // check if element's value is less than pivot's value
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap i value and current value
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap updated index and pivot
            int tmp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = tmp;

            return i + 1;
        }

        /// <summary>
        /// Sort array using quicksort
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private static void QSort(int[] arr, int start, int end)
        {
            // stop calling subroutine once p + 1 is equal to array length
            if (start < end)
            {
                // value p is equal to index value returned in partition
                int p = Part(arr, start, end);

                // sort each side using recursion
                QSort(arr, start, p - 1);
                QSort(arr, p + 1, end);
            }
        }

        /// <summary>
        /// utility method to neatly display toy prices
        /// </summary>
        /// <param name="arr"></param>
        private static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}

