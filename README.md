# ArraysCollection: Number Doubler

## Description
This is a simple C# Console Application designed to demonstrate the fundamentals of arrays, loops, and methods. The program allows a user to input up to 10 numbers, doubles each of those numbers, and then displays both the original list and the newly doubled list.

## Features
* **Interactive Input:** Prompts the user to enter up to 10 integers.
* **Early Exit:** Allows the user to stop entering numbers early by typing `0`.
* **Array Manipulation:** Safely copies an array and modifies the elements without altering the original data.
* **Clear Output:** Displays the data cleanly in the console window.

## Code Structure
The application logic is organized into three main helper methods, keeping the `Main` method clean and readable:
* `GetNumbers()`: Handles the `Console.ReadLine()` loop and stores user input into an integer array. Unfilled slots default to 0.
* `DoubleNumbers(int[] originalNums)`: Takes an array as a parameter, iterates through it, and returns a new array with all values multiplied by 2.
* `DisplayArray(int[] numbersArray)`: A reusable method that loops through any given integer array and prints its contents to the console.

## How to Run
1. Open the solution in Visual Studio or your preferred C# IDE.
2. Ensure the namespace `ArraysCollection` is set as your startup project.
3. Build and Run the application.
4. Follow the prompt instructions in the console window to enter your numbers.
