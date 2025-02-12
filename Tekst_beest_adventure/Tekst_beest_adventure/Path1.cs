using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Path1
    {
        SlowTyping slowTyping = new SlowTyping();
        public Path1(Stats Player) {
            Console.Clear();
            var rand = new Random();
            int EnemyType = rand.Next(0, 8);
            if (EnemyType < 7)
            {
                Enemy Goblin = new Enemy("Goblin", 10,50, EnemyType,false);
                Combat combat = new Combat(Player,Goblin);
                //Name Hp Xp Type

            }
            else {
                Enemy Goku = new Enemy("Goku", 100,1000, EnemyType, false);
                Combat combat = new Combat(Player, Goku);
                //Name Hp Xp Type

            }
           

        }
    }
}
