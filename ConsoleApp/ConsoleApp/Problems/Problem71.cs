using System;

namespace ProjectEuler.Problems
{
    public class Problem71
    {
        public static int GetResult()
        {
            var pForMax = 0;
            var qForMax = 1;

            for (var q = 3; q <= 1000000; ++q)
            {
                var p = (int)Math.Floor((3 * q - 1) * 1.0 / 7);

                if (p * qForMax > pForMax * q)
                {
                    pForMax = p;
                    qForMax = q;
                }
            }

            return pForMax;
        }
    }
}