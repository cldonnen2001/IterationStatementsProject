using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            ////exercise 1
            //for (int i = 0; i < 5; i++)  // 1
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)    // 2
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 3
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)   // 4
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 5
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 6
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 7
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 8
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 9
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 10
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 11
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5, i++)  // 12
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 13
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 14
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)  // 15
            //{
            //    Console.WriteLine($"{i}");
           // }

                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
            var numbers = new List<int>();// <> enclosed type of list, list can grow and shrink dynamically, 
                                          // but [] array is static you set the # and it stays.

        //-----START HERE------------------------------------------
        //Create a variable of type int and name it num
        //initialize the variable with a value of 0
                int num = 0;


            // Create a do-while loop and use the template below:
            do
            {
                num++;// Increment num by 1
                numbers.Add(num); // Then add num to the collection - numbers
                                  // Hint: reference num inside of the Add method's parentheses

            } while (num < 100);// <---- While your variable is less than 100

            // Create a while loop
            while (num < 200) // <--- While num is less than 200
            {
                num+= 1; // Increment num by 1
                numbers.Add(num); // Then add num to the collection numbers
                                  //HINT: copy how this was done in the do while loop
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


           foreach (int number in numbers) // Create a foreach loop using the collection - numbers
                                           //In the scope of the foreach loop, print each number in numbers
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");
            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1

            for (int i = 199; i <= numbers.Count; i--)
            {
                Console.WriteLine(numbers[i]);
            }//start for loop here
            {
                // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise
        }
    }
}
