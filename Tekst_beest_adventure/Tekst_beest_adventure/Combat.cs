﻿
namespace Tekst_beest_adventure
{
    class Combat
    {
        Damage damage = new Damage();

        SlowTyping slowTyping = SlowTyping.GetInstance();
        bool BattleEnded;
        public string? Input;

        public Combat(Player aPlayer, Enemy aEnemy)
        {
            if (aEnemy.Boss)
            {
                slowTyping.SlowlyType("A Boss approaches");
                slowTyping.SlowlyType($"{aEnemy.Name} has appeared before you");
            }
            else
            {
                slowTyping.SlowlyType($"A {aEnemy.Name} has appeared");
            }
            Task.Delay(1000).Wait();
            StartCombat(aPlayer, aEnemy);
        }
        public void StartCombat(Player aPlayer, Enemy aEnemy)
        {
            while (!BattleEnded)
            {
                //Playerturn
                while (true)
                {
                    if (aPlayer.HP <= 0)
                    {
                        slowTyping.SlightlyFaster("You lost the combat");
                        Task.Delay(1000).Wait();
                        BattleEnded = true;
                        aPlayer.HP = aPlayer.MaxHP;
                        aPlayer.LastBattleWon = false;
                        aPlayer.Karma += aEnemy.KarmaGain;
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        slowTyping.SlightlyFaster($"Your HP is: {aPlayer.HP} out of {aPlayer.MaxHP}\nYour XP is: {aPlayer.XP}\nEnemy HP is: {aEnemy.HP}");
                        slowTyping.SlightlyFaster("Player turn");
                        slowTyping.SlightlyFaster("Choose a move");
                        for (int i = 0; i < aPlayer.Moves.Count; i++)
                        {
                            slowTyping.SlightlyFaster($"{i + 1}.{aPlayer.Moves[i].Name}");
                        }
                        Input = Console.ReadLine();
                        if (Input == null)
                        {
                            Console.WriteLine("Please do not enter null");
                            Task.Delay(10000).Wait();
                            continue;
                        }
                        try
                        {
                            int Move = Int32.Parse(Input);
                            Damage damage = new Damage();
                            if (Move > 0 && Move <= aPlayer.Moves.Count)
                            {
                                damage.CalculateDamage(aPlayer.Moves[Move - 1], aPlayer, aEnemy, true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid Number");
                                Task.Delay(1000).Wait();

                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid Number");
                            Task.Delay(1000).Wait();

                        }
                    }

                }
                while (true)
                {
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
                    else
                    {
                        Console.Clear();
                        slowTyping.SlightlyFaster("Enemy turn");
                        var rand = new Random();
                        int Move = rand.Next(0, aEnemy.Moves.Count);
                        slowTyping.SlightlyFaster($"Enemy used {aEnemy.Moves[Move].Name}");
                        Task.Delay(1000).Wait();
                        damage.CalculateDamage(aEnemy.Moves[Move], aPlayer, aEnemy, false);
                        Task.Delay(1000).Wait();
                        break;
                    }
                }
            }
        }
    }
}
               

            
