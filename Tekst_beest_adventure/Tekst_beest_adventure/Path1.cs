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
        public Path1(Player aPlayer) {
            Console.Clear();
            var rand = new Random();
            int EnemyType = rand.Next(0, 8);
            if (EnemyType < 7)
            {
                Enemy Goblin = new Enemy("Goblin", 10,50, EnemyType,true);
                Combat combat = new Combat(aPlayer,Goblin);
                //Name Hp Xp Type

            }
            else {
                Enemy Goku = new Enemy("Son Goku", 100,1000, EnemyType, false);
                Combat combat = new Combat(aPlayer, Goku);
                //Name Hp Xp Type

            }
           

        }
    }
}
