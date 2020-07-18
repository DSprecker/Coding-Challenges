using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_
{
    class Program
    {

        /*
           *  Each new term in the Fibonacci sequence is generated
              by adding the previous two terms. By starting with
              1 and 2, the first 10 terms will be:

              1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

              By considering the terms in the Fibonacci sequence
              whose values do not exceed four million, find the
              sum of the even-valued terms.
           */


        public static void Fibonacci(int length, int limit)
        {
            bool generate = true;
            int fib = 0;
            int O = 0;
            int nacci = 1;
            int evenValue = 0;

            while (generate)
            {
                if (fib >= length || O >= length || nacci >= length)
                {
                    generate = false;
                }
                fib = O + nacci;
                Console.WriteLine(fib);
                O = nacci;
                nacci = fib;



                if (fib % 2 == 0 && fib <= limit)
                {
                    evenValue = fib + evenValue;
                }
            }

            Console.WriteLine("The sum of all even number values is = {0}", evenValue);


        }


        static void Main(string[] args)
        {


            Fibonacci(500000, 4000000);

        }
    }
}
