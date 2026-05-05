using System;
using System.Dynamic;

namespace ArraysCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Get the numbers from the user
            int[] myNum = GetNumbers();

            // 2. Get the new array with the doubled values
            int[] myDblNum = DoubleNumbers(myNum);

            // 3. display the original array
            Console.WriteLine("\n--- Original Array ---");
            DisplayArray(myNum);

            // 4. Display the doubled array
            Console.WriteLine("\n--- Doubled Array ---");
            DisplayArray(myDblNum);

            // 5. "Pause" the console so we can see the output
            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();

        }

        // Method to get the number from the user (up to 10)

        // create an array that can hold 10 integers

        // loop to get the numbers from the user

        // if the user enters 0 , break out of the loop

        // read the number and store it in the array

        // Method to take an array, copy it, double each element,
        // and return the copy

        // create a new array that is the exact same size as the original

        // loop through the original array

        // multiply each element by 2 and store it in the new array

        // method to display the contents of an array

        // loop through the array and print each element to the console

    }
}