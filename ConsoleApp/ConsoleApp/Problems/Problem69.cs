using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    public class Problem69
    {
        public static int GetResult()
        {
            double max = 2;
            var numberOfMax = 2;

            for (var i = 30; i <= 1000000; i = i + 60)
            {
                var phi = Operations.Phi(i);

                if (i * 1.0 / phi <= max)
                {
                    continue;
                }

                Console.Write(i + " - ");
                Console.WriteLine(max);

                max = i * 1.0 / phi;
                numberOfMax = i;
            }

            return numberOfMax;
        }
    }
}
