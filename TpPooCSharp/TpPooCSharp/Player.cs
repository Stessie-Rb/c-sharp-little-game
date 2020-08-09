using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPooCSharp
{
    public class Player
    {
        public int Pv { get; private set; }
        public bool IsAlive {
            get { return Pv > 0; }
        }

        public Player(int points)
        {
            Pv = points;
        }

        public void Attack(EasyMonster monster)
        {
            int playerRoll = RollTheDice();
            int monsterRoll = monster.RollTheDice();
            if (playerRoll >= monsterRoll)
                monster.SufferDamage();
        }

        public void Attack(BossMonster boss)
        {
            int nbPoints = RollTheDice(26);
            boss.SufferDamage(nbPoints);
        }

        public void SufferDamage(int damages)
        {
            if (!Shield())
                Pv -= damages;
        }

        public int RollTheDice()
        {
            return Dice.RollTheDice();
        }
        public int RollTheDice(int value)
        {
            return Dice.RollTheDice(value);
        }

        private bool Shield() 
        {
            return Dice.RollTheDice() <= 2;
        }
    }
}