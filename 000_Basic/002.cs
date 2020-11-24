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
            int sum = 0;
            for ( int i = 1; i <= 20; i++)
            {
                // modulus to get remainder equal to 0
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
