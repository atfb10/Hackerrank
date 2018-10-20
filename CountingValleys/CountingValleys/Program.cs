using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string hike = "DDUDDDUDUUDD";
            int hikeLen = hike.Length;

            // call method and test
            Console.WriteLine("Hiker has crossed " + CountValleys(hikeLen, hike) + " valleys during his hike");

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Method to find and return count of valleys hiker enters
        /// A valley is defined as two consecutive downward movements D
        /// </summary>
        /// <param name="len"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        private static int CountValleys(int len, string str)
        {
            // initialize counters and hashset
            int valleyCounter = 0;
            int i;
            
            // convert string to char array
            char[] arr = str.ToCharArray();

            // traverse array
            for(i = 0; i < len; i++)
            {
                // first two cases ensure no walking off of array
                if(i == 0)
                {
                    // do nothing here
                }
                else if (i + 1 >= len)
                {
                    /*
                     * Special Case, last index of array
                     * Only check that the previous element before it was D
                     * Break Loop after as it is end of array
                     */
                    if (arr[i] == 'D' && arr[i - 1] == 'D')
                        valleyCounter++;

                    // end loop here
                    break;
                }
                else
                {
                    /* 
                     * meat and potatoes 
                     * If current index is D, previous was D and future is not D, add 1 
                     */
                    if((arr[i] == 'D' && arr[i - 1] == 'D') && arr[i + 1] != 'D')
                    {
                        // increment counter
                        valleyCounter++;
                    }
                }
            }

            // return the number of valleys
            return valleyCounter;
        }
    }
}
