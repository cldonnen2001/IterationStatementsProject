using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            ////exercise 1
            //for (int i = 0; i < 5; i++)  // 1  int i = 0 is the initilize part    i < 5 is the   conditional(uses a relational operator which is the <)    i++ is the incrementor/decrementor
            //{
            //    Console.WriteLine($"{i}");  // scope/body
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
            var numbers = new List<int>();   //Create a List called "numbers" - DONE!    var makes it implecity or inferred type (type would be determined by the value value is on teh right of the =)
                                             // <> enclosed type of list, list can grow and shrink dynamically, 
                                             // but [] array is static you set the # and it stays.
                                             //-----START HERE------------------------------------------
            int num = 0;//Create a variable of type int and name it num initialize the variable with a value of 0

            // DO WHILE LOOP - maybe used to have at lease one try at a password, scope run than expressoin evaluated

            do // Create a do-while loop and use the template below:  do at leaste once until specific this is match - does the scope first increments by 1 first, than checks teh condition, at least runs once
            {
                num++;// Increment num by 1, in this 1 is the first number
                numbers.Add(num); // Then ADD num to the collection - numbers   Hint: reference num inside of the Add method's parentheses
            } while (num < 100);// <---- While your variable is less than 100, goes back into the scope unitil reaches 100 (will not do 100 unless ahve the <= ), 
                               //while this condition is true I am going to keep going until condition is met or hit break point, while part is out of the scope
                               // conditional is after the scope

            // WHILE LOOP - expression evaluated first than scope run

            while (num < 200) // Create a while loop  // <--- While num is less than 200, a while loop will run 0 of condition not met or more times so checks this to see if true than will or will not run
            {
                num++; // Increment num by 1
                numbers.Add(num); // Then ADD num to the collection numbers //HINT: copy how this was done in the do while loop  "add" is a method  so adding num to the list
            } 
            
            
            Console.WriteLine("Increase:");  // This is to show the user that the numbers will start increasing on the console

                
            //FOREACH LOOP - starts at very begining and goes by one each time until it stops

            foreach (int number in numbers) // Create a foreach loop using the collection - numbers (line 73) (to change both number words hold ctrl button and hit r twice, than type new name
            {
                Console.WriteLine(number);  //In the scope of the foreach loop, print each number in numbers
            }

            // all above addes the numbers using two technics

            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199  (int i =199)
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)  (i <= numbers.Count)
            // AND as long as i is greater than or equal to 0  (when see AND use &&   (&& i>=0)
            // Decrement i by 1  (i--)


            for (int i = 199; i <= numbers.Count && i>= 0; i--)//start for loop here specific number of times, will do the first part than go to scope, than go to next part the conditional than the scope, than the third part i--
            {
                Console.WriteLine(numbers[i]);// place numbers[i] inside of the Console.WriteLine() method  so [i] is a bracket notation this is the increment indicator
            }
             //------------End of exercise
        }
    }
}
