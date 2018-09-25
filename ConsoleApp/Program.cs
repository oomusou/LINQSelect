using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Enumerable
                .Range(1, 3)
                .MyMap(Double)
                .ToList()
                .ForEach(Console.WriteLine);
                
            int Double(int x) => x * 2;
        }
        
        private static IEnumerable<R> MyMap<T, R>(this IEnumerable<T> data, Func<T, R> func)
        {
            foreach (var item in data)
            {
                yield return func(item);
            }
        }
    }
}