using System;

namespace Compare_The_Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int[] arr1 = { 44, 90, 52 };
            int[] arr2 = { 88, 13, 52 };
            int[] comparision = new int[2];

            // call methods and print result
            comparision = CompareTrips(arr1, arr2);
            PrintArr(comparision);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Function to compare the triplet 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static int[] CompareTrips(int[] arr1, int[] arr2)
        {
            // initialize variables
            int[] compareScores = new int[2];
            int firstArrCounter = 0, secondArrCounter = 0;

            // compare each index score and increment based upon winner
            if (arr1[0] > arr2[0])
                firstArrCounter++;
            else if(arr2[0] > arr1[0])
                secondArrCounter++;

            if (arr1[1] > arr2[1])
                firstArrCounter++;
            else if (arr2[1] > arr1[1])
                secondArrCounter++;

            if (arr1[2] > arr2[2])
                firstArrCounter++;
            else if (arr2[2] > arr1[2])
                secondArrCounter++;

            // add scores to array
            compareScores[0] = firstArrCounter;
            compareScores[1] = secondArrCounter;

            // return the array
            return compareScores;
        }

        /// <summary>
        /// Utility function to neatly print two array values
        /// </summary>
        /// <param name="arr"></param>
        private static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
