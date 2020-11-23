using System;       //using system library , System.Console.WriteLine("Hello World");

// https://www.youtube.com/watch?v=qmZ2RVZ4giY&list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN&index=9

// namespace group and organise code, your own function
// default is System has is own function like System.Int 
namespace ConsoleApp1   
{
    class Program
    {
        // Tell the computer program where it start,
        // static is unmoving and unchanging, only one in the program
        // void return value
        // string[] args, option for input to the program
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }
    }
}
