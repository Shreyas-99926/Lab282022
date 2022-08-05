using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method
{
    internal class MathUntils
    {
        public static int Min(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
        public static int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
}