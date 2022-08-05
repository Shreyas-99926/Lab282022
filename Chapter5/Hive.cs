using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hive
{
    internal class Hive
    {
        public int[] cells;
        public const int Empty = 0;
        public const int Full = 1;

        public Hive(int size)
        {
            cells = new int[size];
        }

    }
}