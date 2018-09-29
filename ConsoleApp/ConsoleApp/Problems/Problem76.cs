namespace ProjectEuler.Problems
{
    public class Problem76
    {
        public static int GetResult()
        {
            var ways = new int[101];
            ways[0] = 1;

            for (var i = 1; i <= 99; i++)
            {
                for (var j = i; j <= 100; j++)
                {
                    ways[j] = ways[j] + ways[j - i];
                }
            }

            return ways[100];
        }
    }
}
