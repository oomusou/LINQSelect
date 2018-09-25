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

            var result = MyMap(data, Double);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            int Double(int x) => x * 2;
        }
        
        private static IEnumerable<int> MyMap(IEnumerable<int> data, Func<int, int> func)
        {
            var result = new List<int>();

            foreach (var item in data)
            {
                result.Add(func(item));
            }

            return result;
        }
    }
}