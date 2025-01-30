using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration
            string word = "";
            int count = 0;
            int vowel = 0;

            //print out the prompt to ask for string input
            Console.WriteLine("Enter a string:");
            //collect the user input for string
            word = Console.ReadLine().ToLower();

            //enter loop to until the counter is greater than the word length
            while (count < word.Length)
            {
                //checks if the character is a, e, i, o, u, and increases the number of vowels if so
                if (Convert.ToChar(word[count]) == Convert.ToChar("a") || Convert.ToChar(word[count]) == Convert.ToChar("e") || Convert.ToChar(word[count]) == Convert.ToChar("i") || Convert.ToChar(word[count]) == Convert.ToChar("o") || Convert.ToChar(word[count]) == Convert.ToChar("u"))
                {
                    //increase the value of the number of values by 1
                    vowel++;
                   
                }
                //increase the counter by 1
                count++;
            }
            //output the number of vowels
            Console.WriteLine($"There are {vowel} vowels in the string");

            //pause screen to read output
            Console.ReadLine();
        }
    }
}
