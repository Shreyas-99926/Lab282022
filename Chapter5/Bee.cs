using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hive
{
    internal class Bee
    {
        const int searching = 1;
        const int gathering = 2;
        const int returning = 3;
        const int depositing = 4;
        int state;
        private Random random = new Random();
        public Hive hive;

        public Bee(Hive hive)
        {
            this.hive = hive;
            state = searching;
        }
        public void Work()
        {
            switch (state)
            {
                case searching:
                    {
                        Console.Write("S");
                        if (random.Next(5) == 0)
                            state = gathering;
                        break;
                    }
                case gathering:
                    {
                        Console.Write("G");
                        state = returning;
                        break;
                    }
                case returning:
                    {
                        Console.Write("R");
                        state = depositing;
                        break;
                    }
                case depositing:
                    {
                        Console.Write("D");
                        int i = random.Next(hive.cells.Length);
                        if (hive.cells[i] == Hive.Empty)
                        {
                            hive.cells[i] = Hive.Full;
                            state = searching;
                        }
                        break;
                    }

            }

        }
    }
}