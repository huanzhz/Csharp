using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // assign a list of 2 integer variables [1,1]
            var fibonacciNumbers = new List<int> { 1, 1 };

            while(fibonacciNumbers.Count < 20)
            {
                // -1 to get the last element of array because it start with zero
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

        }
    }
}