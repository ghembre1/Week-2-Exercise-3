using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to input a string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Makes the vowel count a number and establishes vowelcount
            int vowelCount = 0;

            // This makes it to where it checks every letter in the string
            foreach (char c in input)
            {
                // Checks for a vowel in the string the user inputs
                if ("aeiouAEIOU".Contains(c))
                {
                    // When it picks up a vowel it adds it to the vowel count
                    vowelCount++;
                }
            }

            // Writes text and displays the results of the vowel count
            Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
            Console.Read();
        }
    }
}
