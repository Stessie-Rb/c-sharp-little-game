using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPooCSharp
{
    public static class Dice
    {
        private static Random random = new Random();

        public static int RollTheDice()
        {
            return random.Next(1, 7);
        }


        public static int RollTheDice(int value)
        {
            return random.Next(1, value);
        }
    }
}