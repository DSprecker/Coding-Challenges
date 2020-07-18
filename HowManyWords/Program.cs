using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyWords
{
    class Program
    {

        //In this problem, you will be given a string. Your string is a representation of a phrase. It can contain words, and spaces. You need to return the number of words in the phrase.

       //Example: the_string = "The dog jumps over the cat."
       //num_of_words=6;
       //public static int how_many_words(String s){

            public static int WordCount(string s)
        {
            int word = 0;
            

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || s[i] == '\n' || s[i] == '\t')
                {
                    word++;
                }
            }

            return (word + 1);
        }
       
        static void Main(string[] args)
        {
            bool again = true;

            while (again) { 
            Console.WriteLine("Please input a string:");
            string s = Console.ReadLine();

            int w =  WordCount(s);

            Console.WriteLine($"Your string has {w} words!");
            

            }

        }
    }
}
