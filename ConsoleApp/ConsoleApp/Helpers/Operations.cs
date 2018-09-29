using System;
using System.Collections.Generic;

namespace ProjectEuler.Helpers
{
    public class Operations
    {
        public static int Gcd(int a, int b)
        {
            while (b > 0)
            {
                var r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number < 4)
            {
                return true;
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            if (number < 9)
            {
                return true;
            }

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));
            var f = 5;

            while (f <= squareRoot)
            {
                if (number % f == 0 || number % (f + 2) == 0)
                {
                    return false;
                }

                f = f + 6;
            }

            return true;
        }

        public static bool IsPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number < 4)
            {
                return true;
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            if (number < 9)
            {
                return true;
            }

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));
            var f = 5;

            while (f <= squareRoot)
            {
                if (number % f == 0 || number % (f + 2) == 0)
                {
                    return false;
                }

                f = f + 6;
            }

            return true;
        }

        public static int Phi(int number)
        {
            var array = new int[number];
            var numberOfRelativePrimes = 1;

            for (var i = 2; i < number; ++i)
            {
                if (array[i] != 0)
                {
                    continue;
                }

                if (Gcd(number, i) == 1)
                {
                    numberOfRelativePrimes++;
                }
                else
                {
                    for (var j = i; j < number; j = j + i)
                    {
                        array[j] = 1;
                    }
                }
            }

            return numberOfRelativePrimes;
        }

        public static List<int> GetDivisorsOfNumber(int number)
        {
            var divisors = new List<int> {1 , number};

            for (var i = 2; i <= Math.Sqrt(double.Parse(number.ToString())); ++i)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                    divisors.Add(number / i);
                }
            }

            return divisors;
        }
    }
}
