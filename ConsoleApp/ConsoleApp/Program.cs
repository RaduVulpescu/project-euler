using System;
using System.Diagnostics;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    internal class Program
    {
        private static void Main()
        {
            var clock = Stopwatch.StartNew();
            var result = Problem357.GetResult();
            clock.Stop();

            Console.WriteLine(result);
            
            Console.WriteLine($"\nSolution took {clock.Elapsed.TotalMilliseconds} ms");
            Console.ReadKey();
        }
    }
}
