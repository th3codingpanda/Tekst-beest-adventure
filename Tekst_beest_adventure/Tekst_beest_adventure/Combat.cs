using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Combat
    {
        SlowTyping slowTyping = new SlowTyping();
        bool BattleEnded;
        public Combat(Player aPlayer,Enemy aEnemy){
            slowTyping.SlowlyType($"A {aEnemy.MagicType} {aEnemy.Name} has appeared");
            Task.Delay( 1000 ).Wait();
            PlayerTurn(aPlayer,aEnemy);
        }
        public void PlayerTurn(Player aPlayer, Enemy aEnemy)
        {
            if (!BattleEnded)
            {
                if (aPlayer.HP <= 0)
                {
                    Console.WriteLine("You lost the combat");
                    BattleEnded = true;
                    
                }
                else {
                    Console.Clear();
                    slowTyping.SlowlyType($"Your HP is: {aPlayer.HP} out of {aPlayer.MaxHP}\nYour XP is: {aPlayer.XP}\nEnemy HP is: {aEnemy.HP}");
                    slowTyping.SlowlyType("Player turn");
                    slowTyping.SlowlyType("Choose a move");
                    for (int i = 0; i < aPlayer.moves.Count; i++) {
                        slowTyping.SlightlyFaster($"{i+1}.{aPlayer.moves[0].Name}");
                    }
                    Console.ReadLine();

                    Task.Delay(1000).Wait();
                    EnemyTurn(aPlayer, aEnemy);
                }
               
            }
        }
        public void EnemyTurn(Player aPlayer,Enemy aEnemy) {
            if (aEnemy.HP <= 0)
            {
                slowTyping.SlowlyType("You Won the combat");
                BattleEnded = true;
                

            }
            else {
                Console.Clear();
                slowTyping.SlowlyType("Enemy turn");
                slowTyping.SlowlyType($"Enemy used {aEnemy.MagicType} attack");
                Task.Delay(1000).Wait();
                PlayerTurn(aPlayer, aEnemy);
            }
        }
    }
}
