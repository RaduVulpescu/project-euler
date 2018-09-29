using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    public class Problem92
    {
        public static long GetResult()
        {
            var dict = new Dictionary<long, int>
            {
                { 1, 1 },
                { 89, 89 }
            };

            long numbersThatFinishIn89 = 0;

            for (long i = 2; i < 10000000; ++i)
            {
                if (dict.ContainsKey(i))
                {
                    if (dict[i] == 89)
                    {
                        numbersThatFinishIn89++;
                    }

                    continue;
                }

                var numberToAddInDict = new List<long> { i };

                var x = i;
                var end = false;

                while (end == false)
                {
                    x = GetNextNumber(x);

                    if (dict.ContainsKey(x))
                    {
                        if (dict[x] == 1)
                        {
                            foreach (var number in numberToAddInDict)
                            {
                                dict.Add(number, 1);
                            }

                            end = true;
                        }
                        else if (dict[x] == 89)
                        {
                            foreach (var number in numberToAddInDict)
                            {
                                dict.Add(number, 89);
                            }

                            numbersThatFinishIn89++;

                            end = true;
                        }
                    }
                }
            }

            return numbersThatFinishIn89;
        }

        private static long GetNextNumber(long number)
        {
            long nextNumber = 0;

            while (number != 0)
            {
                var digit = number % 10;

                nextNumber = nextNumber + digit * digit;

                number = number / 10;
            }

            return nextNumber;
        }
    }
}
