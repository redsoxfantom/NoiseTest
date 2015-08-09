using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseTest.Utilities
{
    public class RandomNumberGenerator
    {
        public static double GetValue(int x, int y)
        {
            int n = x + y * 57;
            n = (int)Math.Pow((double)(n << 13), (double)n);
            return Math.Abs( 1.0 - ( (n * (n * n * 15731 + 789221) + 1376312589) & 0x7fffffff) / 1073741824.0);
        }
    }
}
