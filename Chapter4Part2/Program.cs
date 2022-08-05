using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method
{
    internal class Driver
    {
        public static void Main()
        {
            int minValue, maxValue;
            minValue = MathUntils.Min(10, 5);
            maxValue = MathUntils.Max(10, 5);
            Console.WriteLine($"Minimum:{minValue} and Maximum:{maxValue}");
        }

    }
}