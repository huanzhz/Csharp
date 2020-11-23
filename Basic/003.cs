using System;
using System.Collections.Generic;

namespace ConsoleApp1   
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> , cup<T> -> cup of tea
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            // var declared as string
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // get the first elemnet in the array list
            Console.WriteLine(names[0]);

            // sort the array
            names.Sort();

            // get the INDEX of array
            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                // get the NAME of the index
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
        }
    }
}
