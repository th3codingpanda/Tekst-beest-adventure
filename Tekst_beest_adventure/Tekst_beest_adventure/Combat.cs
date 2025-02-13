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
            slowTyping.SlowlyType($"Your HP is: {aPlayer.HP} out of {aPlayer.MaxHP}\nYour XP is: {aPlayer.XP}");
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
                 Console.WriteLine("Choose a move");
                 Console.ReadLine();
                 EnemyTurn(aPlayer, aEnemy);
                }
               
            }
        }
        public void EnemyTurn(Player aPlayer,Enemy aEnemy) {
            if (aEnemy.HP <= 0)
            {
                Console.WriteLine("You Won the combat");
                BattleEnded = true;
                

            }
            else {
                Console.WriteLine("Enemy turn");
                Console.WriteLine($"Enemy used {aEnemy.MagicType} attack");
                PlayerTurn(aPlayer, aEnemy);
            }
        }
    }
}
