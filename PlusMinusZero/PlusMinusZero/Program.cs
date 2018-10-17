using System;

/// <summary>
/// Show ratios of positive, negative, and zero nums in array
/// </summary>

namespace PlusMinusZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            short[] arr = { -4, 3, -9, 0, 4, 1 };

            // call method and print ratios
            ShowNumRatios(arr);

            // keep console open
            Console.Read();
        }

        private static void ShowNumRatios(short[] arr)
        {
            // initialize variables
            short posCount = 0, negCount = 0, zeroCount = 0;
            float posRatio = 0, negRatio = 0, zeroRatio = 0;
            short len = (short)arr.Length;
            short i;

            // loop through array, count each number type
            for (i = 0; i < len; i++)
            {
                if (arr[i] < 0)
                    negCount++;
                else if (arr[i] == 0)
                    zeroCount++;
                else
                    posCount++;
            }

            // find each ratio
            posRatio = posCount / (float)len;
            negRatio = negCount / (float)len;
            zeroRatio = zeroCount / (float)len;

            // output ratios
            Console.WriteLine("{0} is the ratio of positives", posRatio);
            Console.WriteLine("{0} is the ratio of negatives", negRatio);
            Console.WriteLine("{0} is the ratio of zeroes", zeroRatio);

            // function return statement
            return;
        }
    }
}
