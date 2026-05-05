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
        public static int[] GetNumbers()
        {

            // create an array that can hold 10 integers
            int[] numbers = new int[10];

            Console.WriteLine("Please enter up to 10 numbers (enter 0 to stop before 10): ");

            // loop to get the numbers from the user
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter Number " + (i + 1) + ": ");
                string userInput = Console.ReadLine();
                int enteredNum = Convert.ToInt32(userInput);

                // if the user enters 0 , break out of the loop
                if (enteredNum == 0)
                {
                    Console.WriteLine("Stopping early!");
                    break;
                }

                // store it in the array
                numbers[i] = enteredNum;
            }

            return numbers;
        }





        // Method to take an array, copy it, double each element,
        // and return the copy
        public static int[] DoubleNumbers(int[] ogNums)
        {

            // create a new array that is the exact same size as the original
            int[] copiedArray = new int[ogNums.Length];

            // loop through the original array
            for ( int i = 0; i < ogNums.Length; i++)
            {
                // multiply each element by 2 and store it in the new array
                copiedArray[i] = ogNums[i] * 2;
            }

            return copiedArray;
        }
        

        

        

        // method to display the contents of an array
        public static void DisplayArray(int[] numbersArray)
        {

            // loop through the array and print each element to the console
            for (int i = 0; i < numbersArray.Length; i ++)
            {
                Console.WriteLine(numbersArray[i]);
            }
        }
    }
}