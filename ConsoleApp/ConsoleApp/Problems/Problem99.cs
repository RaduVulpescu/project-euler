using System;
using System.IO;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    public class Problem99
    {
        public static int GetResult()
        {
            var lines = File.ReadAllLines(Constants.FilePath + "p099_base_exp.txt");

            var lineWithMaxValue = 0;
            double maxNumber = 0;

            for (var i = 0; i < lines.Length; ++i)
            {
                var numbers = lines[i].Split(",");
                var baseNumber = double.Parse(numbers[0]);
                var exponentNumber = double.Parse(numbers[1]);

                if (exponentNumber * Math.Log10(baseNumber) > maxNumber)
                {
                    maxNumber = exponentNumber * Math.Log10(baseNumber);
                    lineWithMaxValue = i + 1;
                }
            }

            return lineWithMaxValue;
        }
    }
}
