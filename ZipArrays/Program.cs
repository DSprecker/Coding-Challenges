using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipArrays
{
    class Program
    {
        /*
         * In this problem you are given 2 arrays of identical size. You need to zip the two arrays together, maintaining their order.
         * 
         * Example:
         * 
         * array1 = [1, 5, 2]
         * 
         * array_two = [3, 6, 4]
         * 
         * zipped_array=[1,3,5,6,2,4]
         */

        public static int[] ZipArray (int[] z1, int[] z2)
        {
            int[] zippedArray = new int[z1.Count() + z2.Count()];//Declared a new int array with the size of both arrays combined
            int j = 0;//Initialize variable to utilize in the loop. To zip both arrays together, we must add the entirety of one array first but skipping an index with each new addition from the first array, then we will use a new variable to fill in the empty indexes with the second array.

            for (int i = 0; i < z1.Count(); i++)//Utilizing "for" loop with the condition being the count of the first array.
            {
                zippedArray[j] = z1[i];//First iteration will add the first index of z1 to the first index of zippedArray.
                j = j + 2;//Adding two to the variable we are using to represent the indexes in zippedArray so we can skip an index in order to have that "zipping" functionality. The next iteration will add z1[1] to zippedArray[3], and so on.
            }

            int k = 1;//Declared a new variable to function the same way "j" did for our first loop. Using "j" would require extra work to prevent crashing. It might break the "DRY" principle, but it's a much simpler process. 

            for (int i = 0; i < z2.Count(); i++)//Again, utilizing "for" loop but this time for z2 with the condition being the count.
            {
                zippedArray[k] = z2[i];//First iteration will add z2[0] to zippedArray[1], thanks to our "k" variable. The next iteration will add z2[1] to zippedArray[3], and so on.
                k = k + 2;//Incrementing 2 to "k" to skip indexes and "zip" the array.
            }

            return (zippedArray);//Return the finished array
        }

        static void Main(string[] args)
        {
            int[] t1 = new int[] { 4, 24, 44, 64, 84, 104 };
            int[] t2 = new int[] { 14, 34, 54, 74, 94, 114 };

            //NOTE!!! 
            //In order for the ZipArray() to not crash, we need to pass arrays of the same size. Could potentially add functionality to check the sizes of both arrays in order for the method to execute fully. Pass on that for now. 

            int[] za = ZipArray(t1, t2);//za will be the returned int[] (zippedArray) of the ZipArray().

            foreach (int number in za)//Iterate through each number in za and see our new "zipped" array.
            {
                Console.WriteLine(number);//Tah-Dah!
            }

            
        }
    }
}
