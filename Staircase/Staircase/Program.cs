using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int stairs = 6;

            // call method to print stairs
            PrintStairs(stairs);
            
            // keep console open
            Console.Read();
        }


        private static void PrintStairs(int n)
        {
            // initialize counters
            int i, j;

            // outer loop controls row
            for(i = 1; i <= n; i++)
            {
                // first inner loop controls spaces
                for (j = n; j > i; j--)
                    Console.Write(" ");

                // second inner loop controls #
                for (j = 1; j <= i; j++)
                    Console.Write("#");

                // move to next row
                Console.WriteLine();
            }
            
        }
    }
}
