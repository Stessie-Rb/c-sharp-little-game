using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPooCSharp
{
    public class EasyMonster
    {
        private const int damage = 10;
        public bool IsAlive { get; private set; }

        public EasyMonster()
        {
            IsAlive = true;
        }
        public virtual void Attack(Player player)
        {
            int monsterRoll = RollTheDice();
            int playerRoll = player.RollTheDice();
            if (monsterRoll > playerRoll)
                player.SufferDamage(damage);
        }

        public void SufferDamage()
        {
            IsAlive = false;
        }

        public int RollTheDice()
        {
            return Dice.RollTheDice();
        }
    }
}