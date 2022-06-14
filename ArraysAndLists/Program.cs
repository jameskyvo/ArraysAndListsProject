using System;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var oddCount = 0;
            var evenCount = 0;

            //TODO:

            // Create an int Array and populate numbers 1-10
            var oneToTen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Create two Lists of type int.
            //  Name one List "evens"
            var evens = new int[5];
            // Name the other List "odds"
            var odds = new int[5];
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (int numbers in oneToTen) 
            {
                if (numbers % 2 == 0)
                {
                    Console.WriteLine($"{numbers} is even! Adding it to the evens array.");
                    evens[evenCount] = numbers;
                    evenCount++;
                }
                else
                {
                    Console.WriteLine($"{numbers} is odd! Adding it to the odds array.");
                    odds[oddCount] = numbers;
                    oddCount++;
                }
            }

            Console.WriteLine("\nDisplaying even numbers!");
            for (int i = 0; i < evens.Length; i++) 
            { 
                Console.WriteLine(evens[i]); 
            }
            Console.WriteLine("\nDisplaying odd numbers!");
            for (int i = 0; i < odds.Length; i++)
            {
                Console.WriteLine(odds[i]);
            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
