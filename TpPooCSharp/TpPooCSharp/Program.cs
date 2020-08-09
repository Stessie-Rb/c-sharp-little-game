using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPooCSharp
{
    class Program
	{
		private static Random random = new Random();

		static void Main(string[] args)
		{
			DisplayMenu();
			ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
			while(consoleKeyInfo.Key != ConsoleKey.D1 && consoleKeyInfo.Key != ConsoleKey.D2
				&& consoleKeyInfo.Key != ConsoleKey.NumPad1 && consoleKeyInfo.Key != ConsoleKey.NumPad2)
            {
				DisplayMenu();
				consoleKeyInfo = Console.ReadKey(true);
            }
			if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
				Game();
			else
				Game2();
		}

		private static void DisplayMenu()
        {
			Console.Clear();
			Console.WriteLine("Choose a game:");
			Console.WriteLine("\t1: Against the monsters ");
			Console.WriteLine("\t2: Against the Boss");
        }

		private static void Game()
		{
			Player gaia = new Player(150);
			int cptEasy= 0;
			int cptHard = 0;
			while (gaia.IsAlive)
			{
				EasyMonster cuteMonster = MonsterFactory();
				while (cuteMonster.IsAlive && gaia.IsAlive)
				{
					gaia.Attack(cuteMonster);
					if (cuteMonster.IsAlive)
						cuteMonster.Attack(gaia);
				}

				if (gaia.IsAlive)
				{
					if (cuteMonster is HardMonster)
						cptHard++;
					else
						cptEasy++;
				}
				else
				{
					Console.WriteLine("oh nooo!, you are dead -_-");
					break;
				}
			}
			Console.WriteLine("Yeah!!! You killed {0} easy monsters and {1} hard monsters. You won {2} points.", cptEasy, cptHard, cptEasy + cptHard * 2);
		}

		private static EasyMonster MonsterFactory()
		{
			if (random.Next(2) == 0)
				return new EasyMonster();
			else
				return new HardMonster();
		}

		private static void Game2()
		{
			Player veganUnicorn = new Player(150);
			BossMonster boss = new BossMonster(250);
			while (veganUnicorn.IsAlive && boss.IsAlive)
			{
				veganUnicorn.Attack(boss);
				if (boss.IsAlive)
					boss.Attack(veganUnicorn);
			}
			if (veganUnicorn.IsAlive)
				Console.WriteLine("Yeah! You saved the princess unicorn!");
			else
				Console.WriteLine("Oh no no no! Game Over -_-");
		}
	}
}
