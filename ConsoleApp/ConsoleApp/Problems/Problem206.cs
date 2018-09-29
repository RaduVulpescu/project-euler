using System.Text.RegularExpressions;

namespace ProjectEuler.Problems
{
    public class Problem206
    {
        // root square of 1929394959697989990 is aprox 1389026623.106

        public static long GetResult()
        {
            long number = 1389026630;
            bool found;

            do
            {
                number = number - 10;

                found = IsValid(number * number);
            } while (found == false || number < 1010101010);

            return number;
        }

        private static bool IsValid(long number)
        {
            var regex = new Regex("^1\\d2\\d3\\d4\\d5\\d6\\d7\\d8\\d9\\d0$");

            return regex.IsMatch(number.ToString());
        }
    }
}
