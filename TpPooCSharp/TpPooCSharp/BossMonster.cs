using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPooCSharp
{
    public class BossMonster
    {
        public int Pv { get; private set; }
        public bool IsAlive
        {
            get { return Pv > 0; }
        }
        public BossMonster(int points)
        {
            Pv = points;
        }

        public void Attack(Player player)
        {
            int nbPoints = RollDice(26);
            player.SufferDamage(nbPoints);
        }

        public void SufferDamage(int value)
        {
            Pv -= value;
        }

        private int RollDice(int value)
        {
            return Dice.RollTheDice(value);
        }
    }
}