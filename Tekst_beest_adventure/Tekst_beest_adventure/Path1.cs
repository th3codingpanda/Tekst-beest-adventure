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
        SlowTyping slowTyping = SlowTyping.GetInstance();
        public Path1(Player aPlayer)
        {
            while (aPlayer.LastBattleWon == false)
            {
                Console.Clear();
                var rand = new Random();
                Magic EnemyType =(Magic)rand.Next(0, 8);
                if (EnemyType != Magic.GOKU_AND_MIKU)
                {
                    //Name Hp Xp Type evil Damage BossStatus
                    Enemy Goblin = new Enemy($"{EnemyType} Goblin", 10, 450,EnemyType, true, 2, false);
                    Move Attack = new Move(EnemyType, 0, 2, $"Weak {EnemyType} attack");
                    Goblin.AddMove(Attack);
                    Combat combat = new Combat(aPlayer, Goblin);

                    

                }
                else
                {
                    Enemy Goku = new Enemy("Son Goku", 10000, 2147483647, EnemyType, false, 100, true);
                    Move Attack = new Move(EnemyType, 0, 100, $"Weak {EnemyType} attack");
                    Goku.AddMove(Attack);
                    Combat combat = new Combat(aPlayer, Goku);
                    
                }
            }
            slowTyping.SlightlyFaster($"You have beat the tutorial!");
            slowTyping.SlightlyFaster("You have been healed");
            aPlayer.HP = aPlayer.MaxHP;
           
        }
    }
}
