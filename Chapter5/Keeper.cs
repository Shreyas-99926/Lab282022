using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hive
{
    internal class Keeper
    {
        public int Collect(Hive hive)
        {
            int count = 0;
            for (int i = 0; i < hive.cells.Length; i++)
            {
                if (hive.cells[i] == Hive.Full)
                {
                    count++;
                    hive.cells[i] = Hive.Empty;
                }
            }
            return count;
        }
        public void Run()
        {
            Hive h = new Hive(5);
            int count = 0;

            Bee[] bees = new Bee[5];
            for (int i = 0; i < bees.Length; i++)
            {
                bees[i] = new Bee(h);
            }

            while (count < 10)
            {
                for (int i = 0; i < h.cells.Length; i++)
                {
                    for (int j = 0; j < bees.Length; j++)
                    {
                        bees[j].Work();
                    }
                }
                Console.WriteLine("collect {0}", Collect(h));
                count++;
            }
        }
    }
}