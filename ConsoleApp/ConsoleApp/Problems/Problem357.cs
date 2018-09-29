using System;
using System.Collections.Generic;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    public class Problem357
    {
        public static long GetResult()
        {
            const int number = 10000;
            long sum = 3;
            var dictionary = new Dictionary<long, List<long>>();

            for (var i = 6; i <= number; i = i + 4)
            {
                List<long> divisors;

                var half = i / 2;

                if (dictionary.ContainsKey(half))
                {
                    divisors = dictionary[half];
                }
                else
                {
                    var dictionaryCopy = new Dictionary<long, List<long>>(dictionary);

                    foreach (var kvp in dictionaryCopy)
                    {
                        dictionary.Add(kvp.Key * half, new List<long>(dictionaryCopy[kvp.Key]) { half });
                    }

                    dictionary.Add(half, new List<long> { 1, half });
                    for (long j = half * half; j <= number / 2; j = j * half)
                    {
                        dictionary.Add(j, new List<long>(dictionary[j / half]) { j });
                    }

                    divisors = new List<long> { 1, half };
                }

                var valid = true;

                foreach (var divisor in divisors)
                {
                    if (Operations.IsPrime(i / divisor + divisor))
                    {
                        continue;
                    }

                    valid = false;
                    break;
                }

                if (valid)
                {
                    sum = sum + i;
                }
            }

            return sum;
        }
    }
}
