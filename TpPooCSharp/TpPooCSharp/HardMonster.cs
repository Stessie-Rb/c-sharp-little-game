using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPooCSharp
{
    public class HardMonster : EasyMonster
    {
        private const int spellDamage = 5;

        public override void Attack(Player player)
        {
            base.Attack(player);
            player.SufferDamage(MagicSpell());
        }

        private int MagicSpell()
        {
            int value = Dice.RollTheDice();
            if (value == 6)
                return 0;
            return spellDamage * value;
        }
    }
}