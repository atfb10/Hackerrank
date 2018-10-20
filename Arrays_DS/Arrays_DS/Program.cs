using System;

namespace Arrays_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int[] arr = { 1, 4, 3, 2 };

            // call method to print array in reverse
            ReversePrint(arr);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Method to print array in reverse
        /// </summary>
        /// <param name="arr"></param>
        private static void ReversePrint(int[] arr)
        {
            // initialize num of items and counter
            int n = arr.Length - 1;
            int i;

            // print in reverse and end line after all have been printed
            for (i = n; i >= 0; i--)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // function return
            return;
        }
    }
}
