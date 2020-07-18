using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        /*
         * In this problem you will be given an integer. For integer x you need to print from 1 to x using fizzbuzz format.
         * 
         * Fizzbuzz format dictates that if the number is divisible by 3 you print the word "fizz".
         * 
         * If the number is divisible by 5 you print the word "buzz".
         * 
         * If the number is divisible by 15, you print the word "fizzbuzz".
         */

        public static void FzBz(int fzInt)
        {
            for (int i = 1; i < fzInt; i++)//Setting a loop that counts until the specified integer value is met.
            {
                if (i % 15 == 0)//Checking to see if "i" is divisible by 15. This must be checked for first or else numbers divisible by 15 will be treated as a number divisible by 5 or 3 by default and we won't get "fizzbuzz"
                {
                    Console.WriteLine("fizzbuzz");
                }

                else if (i % 3 == 0)//Checks to see if "i" is divisble by 3. If true, output "fizz"
                {
                    Console.WriteLine("fizz");
                }

                else if (i % 5 == 0)//Checks to see if "i" is divisble by 5. If true output "buzz"
                {
                    Console.WriteLine("buzz");
                }

                else
                {
                    Console.WriteLine(i);//If "i" is not divisble by 15, 5, or 3; output the number value of "i".
                }
            }
        }

        static void Main(string[] args)
        {
            FzBz(48);

           

                
            
        }
    }
}
