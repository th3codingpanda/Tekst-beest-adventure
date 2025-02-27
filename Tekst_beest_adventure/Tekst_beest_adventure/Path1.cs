using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tekst_beest_adventure.Enemy;
using static Tekst_beest_adventure.Magics;

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
                Enemy Goblin = new Enemy("Goblin", 10,450, (Magic)EnemyType,true ,2);
                Combat combat = new Combat(aPlayer,Goblin);
                //Name Hp Xp Type

            }
            else {
                Enemy Goku = new Enemy("Son Goku", 10000,1000, (Magic)EnemyType, false ,100);
                Combat combat = new Combat(aPlayer, Goku);
                //Name Hp Xp Type

            }
           

        }
    }
}
