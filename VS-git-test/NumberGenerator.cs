using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_git_test
{
    static class NumberGenerator
    {
        public static double GenerateNumber(int initialValue, int finalValue)
        {
            Random random = new Random();
            return initialValue + random.NextDouble() * (finalValue - initialValue);
        }
    }
}
