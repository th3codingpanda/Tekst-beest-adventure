using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
     class Combat
    {
        SlowTyping slowTyping = new SlowTyping();
        bool BattleEnded;
        public string? Input;

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
                    slowTyping.SlightlyFaster("You lost the combat");
                    slowTyping.SlightlyFaster("Going Back to last checkpoint");
                    Task.Delay( 1000 ).Wait();
                    BattleEnded = true;
                    aPlayer.HP = aPlayer.MaxHP;
                    aPlayer.LastBattleWon = false;
                    return;


                }
                else {
                    Console.Clear();
                    slowTyping.SlightlyFaster($"Your HP is: {aPlayer.HP} out of {aPlayer.MaxHP}\nYour XP is: {aPlayer.XP}\nEnemy HP is: {aEnemy.HP}");
                    slowTyping.SlightlyFaster("Player turn");
                    slowTyping.SlightlyFaster("Choose a move");
                    for (int i = 0; i < aPlayer.moves.Count; i++) {
                        slowTyping.SlightlyFaster($"{i+1}.{aPlayer.moves[i].Name}");
                    }
                    Input = Console.ReadLine();
                    if (Input == null) {
                        Console.WriteLine("Please do not enter null");
                        Task.Delay(10000).Wait();
                        PlayerTurn(aPlayer, aEnemy);
                        return;
                    }
                    try {
                       int Move = Int32.Parse(Input);
                       Damage damage = new Damage();
                        if (Move > 0 && Move <= aPlayer.moves.Count)
                        {
                            damage.CalculatePlayerDamage(aPlayer.moves[Move-1].Damage,aPlayer, aEnemy);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid Number");
                            Task.Delay(1000).Wait();
                            PlayerTurn(aPlayer, aEnemy);
                            return;

                        }
                    }
                    catch(FormatException) {
                        Console.WriteLine("Please enter a valid Number");
                        Task.Delay(1000).Wait();
                        PlayerTurn(aPlayer, aEnemy);
                        return;
                    }

                    Task.Delay(1000).Wait();
                    EnemyTurn(aPlayer, aEnemy);
                }
               
            }
        }
        public void EnemyTurn(Player aPlayer,Enemy aEnemy) {
            if (aEnemy.HP <= 0)
            {
                slowTyping.SlightlyFaster("You Won the combat");
                slowTyping.SlightlyFaster($"Xp gotten: {aEnemy.XP}");
                aPlayer.XP += aEnemy.XP;
                Task.Delay(500).Wait();
                Leveling leveling = new Leveling();
                leveling.CheckXP(aPlayer);
                BattleEnded = true;
                aPlayer.LastBattleWon = true;
                return;
                

            }
            else {
                Console.Clear();
                slowTyping.SlowlyType("Enemy turn");
                slowTyping.SlowlyType($"Enemy used {aEnemy.MagicType} attack");
                Damage damage = new Damage();
                damage.CalculateEnemyDamage(aEnemy.Damage, aPlayer, aEnemy);
                Task.Delay(1000).Wait();
                PlayerTurn(aPlayer, aEnemy);
                
            }
        }
    }
}
