using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection
{
    class Program
    {
        /*
         * Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: the first element will represent a list of comma-separated numbers sorted in ascending order, the second element will represent a second list of comma-separated numbers (also sorted). Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order. If there is no intersection, return the string false.
         * 
         * Examples: 
         * 
         * Input: new string[] { "1,3,4,7,13", "1,2,4,13,15" }
         * Output: 1, 4, 13
         * 
         * Input new string [] {"1, 3, 9, 10, 17, 18" "1,4,9,10" }
         * Output: 1,9,10
         */

        public static string FindIntersection(string[] strArr)
        {
            List<string> i1 = new List<string>(strArr[0].Split(',').ToList());
            List<string> i2 = new List<string>(strArr[1].Split(',').ToList());
            List<string> i3 = new List<string>(i1.Concat(i2).ToList());
            




            return strArr[0];
        }

        static void Main(string[] args)
        {
            string[] s = new string[] { "1,3,4,7,13", "1,2,4,13,15" };
            //List<string> i1 = new List<string>(s[0].Split(',').ToList());
            //List<string> i2 = new List<string>(s[1].Split(',').ToList());

            //List<string> i3 = new List<string>(i1.Concat(i2).ToList());

            List<string> i1 = new List<string>(s[0].Split(',').ToList());
            List<string> i2 = new List<string>(s[1].Split(',').ToList());

            List<string> i3 = new List<string>(i1.Concat(i2).ToList());

            foreach (string item in i3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
