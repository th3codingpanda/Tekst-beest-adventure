using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tekst_beest_adventure.Magics;

namespace Tekst_beest_adventure
{
    internal class Path1
    {
        SlowTyping slowTyping = new SlowTyping();
        public Path1(Player aPlayer)
        {
            while (aPlayer.LastBattleWon == false)
            {
                Console.Clear();
                var rand = new Random();
                int EnemyType = rand.Next(0, 8);
                if (EnemyType < 7)
                {
                    //Name Hp Xp Type evil Damage BossStatus
                    Enemy Goblin = new Enemy("Goblin", 10, 450, (Magic)EnemyType, true, 2, false);
                    Combat combat = new Combat(aPlayer, Goblin);
                    

                }
                else
                {
                    Enemy Goku = new Enemy("Son Goku", 10000, 1000, (Magic)EnemyType, false, 100, true);
                    Combat combat = new Combat(aPlayer, Goku);
                    
                }
            }
            slowTyping.SlightlyFaster($"You have beat the tutorial!");
            slowTyping.SlightlyFaster("You have been healed");
            aPlayer.HP = aPlayer.MaxHP;
           
        }
    }
}
