using System;

namespace Arrays_LeftRotatation
{
    class Program
    {
        static void Main(string[] args)
        {
            // test array
            int[] test = { 1, 2, 3, 4, 5 };
            int[] shifted = new int[test.Length];
            int shift = 4;

            // call method and show result
            Console.WriteLine("Array shifted left by {0}", shift);
            shifted = RotateLeft(test, shift);
            PrintArr(shifted);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Method that takes in array and int as args
        /// Shifts elements in arr parameter according to input in shiftAmt param
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="shiftAmt"></param>
        /// <returns></returns>
        private static int[] RotateLeft(int[] arr, int shiftAmt)
        {
            // initialize variables
            int i, j;
            int iCounter = 0;
            int jCounter = 0;
            int n = arr.Length;
            int[] temp = new int[shiftAmt];
            int[] newArr = new int[arr.Length];

            // put items to be appended to be right of array in temp
            for (i = 0; i < shiftAmt; i++)
                temp[iCounter++] = arr[i];

            // put items to be moved to front of array in new array
            for (j = shiftAmt; j < n; j++)
                newArr[jCounter++] = arr[j];

            // append temp to the new array
            for (i = 0; i < shiftAmt; i++)
                newArr[jCounter++] = arr[i];

            // return the shifted array
            return newArr;
        }

        /// <summary>
        /// Utility function to print values in array
        /// </summary>
        /// <param name="arr"></param>
        private static void PrintArr(int[] arr)
        {
            int i;
            int n = arr.Length;

            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
