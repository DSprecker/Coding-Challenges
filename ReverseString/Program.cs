using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        /*
         * In this problem you will be given a string. You will need to return the string in reverse.
         * 
         * Example:
         * the_string="LaunchCode"
         * 
         * the_reversed_string="edoChcnuaL"
         */

        public static String StringReverse(string s)
        {
            char[] stringReverseArray = s.ToCharArray();//Take the string that was passed into the method and store it into an array of char's
            Array.Reverse(stringReverseArray);//Uses Reverse method from the Array class to reverse the order of char's.


            return (new string(stringReverseArray));//returns the result of the reversed string. Must be explicitly converted into a string. 
        }//end StringReverse

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase: ");
            string testString = Console.ReadLine();
            string returnString = StringReverse(testString);

            Console.WriteLine(returnString);
            

       
        }// Main();
    }//end Program;
}//end namespace
    


