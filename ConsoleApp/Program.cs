using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(1, 3);

            var result = new List<int>();

            foreach (var item in data)
            {
                result.Add(item * 2);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}