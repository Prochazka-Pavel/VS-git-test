using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_git_test
{
    class Person
    {
        public static string GiveNumberInString()
        {
            var random = new Random();
            var output = random.Next(5, 10).ToString();
            return output;
        }
    }
}
