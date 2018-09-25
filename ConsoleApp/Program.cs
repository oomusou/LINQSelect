using static System.Linq.Enumerable;
using static System.Console;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Range(1, 3)
                .Select(Double)
                .ToList()
                .ForEach(WriteLine);

            int Double(int x) => x * 2;
        }
    }
}