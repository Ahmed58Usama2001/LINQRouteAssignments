using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public static class IntExtensions
    {
        public static int Reverse(this int num)
        {
            int rem,result=0;
            while(num > 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num /= 10;
            }
            return result;
        }

    }
}
