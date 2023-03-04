using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr_7
{
    public  class Class1
    {
        public static long Factorial(int n)
        {
            long p = 2;
            for (int i = 3; i <= n; i++)
            {
                p = p * i;
            }
            return p;
        }
    }
}
