namespace ProjectEuler.Problems
{
    public class Problem97
    {
        public static long GetResult()
        {
            long result = 2;

            for (var i = 2; i <= 7830457; ++i)
            {
                result = result * 2;

                result = result % 100000000000;
            }

            result = result * 28433 + 1;

            return result % 10000000000;
        }
    }
}
