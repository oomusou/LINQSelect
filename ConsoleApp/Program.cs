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
        
        private static IEnumerable<R> MyMap<T, R>(IEnumerable<T> data, Func<T, R> func)
        {
            foreach (var item in data)
            {
                yield return func(item);
            }
        }
    }
}