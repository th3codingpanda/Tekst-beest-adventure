using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Xml.Linq;
using Tekst_beest_adventure;
namespace Tekst_beest_adventure
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string? Input;
            SlowTyping slowTyping = SlowTyping.GetInstance();
            Player aPlayer;
            string? Name;
            Console.Clear();
            slowTyping.SlowlyType("Enter a Name");
            Name = Console.ReadLine();
            if (Name == null)
            {
                Console.WriteLine("Do not enter null");
                Task.Delay(1000).Wait();
                Main(args);
                return;
            }
            slowTyping.SlowlyType("Choose your first MagicType");
            slowTyping.SlightlyFaster(" Fire = 0\n Water = 1\n Earth = 2\n Air = 3\n Dark = 4\n Light = 5");
            Input = Console.ReadLine();
            if (Input == null)
            {
                Console.WriteLine("Do not enter null");
                Task.Delay(1000).Wait();
                Main(args);
                return;
            }
            try
            {
                int MagicType = Int32.Parse(Input);
                //changes input into an int if possible
                if (MagicType >= 0 && MagicType <= 7)
                {
                    slowTyping.SlowlyType($"You have chosen: {(Magics.Magic)MagicType}");
                    Task.Delay(500).Wait();
                    slowTyping.SlowlyType("Choose your Second MagicType");
                    slowTyping.SlightlyFaster(" Fire = 0\n Water = 1\n Earth = 2\n Air = 3\n Dark = 4\n Light = 5");
                    Input = Console.ReadLine();
                    if (Input == null)
                    {
                        Console.WriteLine("Do not enter null");
                        Task.Delay(1000).Wait();
                        Main(args);
                        return;
                    }
                    try
                    {
                        int SecondMagicType = Int32.Parse(Input);
                        if (SecondMagicType >= 0 && MagicType <= 7)
                        {
                            slowTyping.SlowlyType($"You have chosen: {(Magics.Magic)SecondMagicType}");
                            Task.Delay(500).Wait();
                            Console.Clear();
                            aPlayer = new Player(Name, 20, 0, MagicType, SecondMagicType);
                            Path1 path1 = new Path1(aPlayer);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                            Task.Delay(1000).Wait();
                            Main(args);
                            return;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number");
                        Task.Delay(1000).Wait();
                        Main(args);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    Task.Delay(1000).Wait();
                    Main(args);
                    return;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a valid number");
                Task.Delay(1000).Wait();
                Main(args);
                return;
                //Catches if input can not be turned into an int
            }
            bool EncounterEnded = false;
            while (!EncounterEnded)
            {
                slowTyping.SlowlyType("A chest appears before you");
                if (aPlayer.SearchItems(ItemList.TheItemList.KEY))
                {
                    slowTyping.SlowlyType("0: Open chest");
                    slowTyping.SlowlyType("1: Leave chest");
                    Input = Console.ReadLine();
                    if (Input == null)
                    {
                        Console.WriteLine("Do not enter null");
                        Task.Delay(1000).Wait();
                        Main(args);
                        return;
                    }
                    if (Input == "0" || Input == "1")
                    {
                        if (Input == "0")
                        {
                            aPlayer.RemoveItem(ItemList.TheItemList.KEY, 1);
                            Item Potion = new Item(ItemList.TheItemList.POTION);
                            aPlayer.AddItem(Potion);
                            slowTyping.SlightlyFaster("Do you want to drink the potion?\n0: Yes\n1: No");
                            Input = Console.ReadLine();
                            if (Input == "0")
                            {
                                slowTyping.SlightlyFaster("You're max hp increased by 20");
                                aPlayer.MaxHP += 20;
                                aPlayer.HP += 20;
                                aPlayer.RemoveItem(ItemList.TheItemList.POTION, 1);
                            }

                            EncounterEnded = true;
                        }
                        else
                        {
                            EncounterEnded = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                else
                {
                    slowTyping.SlowlyType("You do not have a key to open the chest");
                    EncounterEnded = true;
                }
            }
            
            EncounterEnded = false;
            Task.Delay(1000).Wait();
            Console.Clear();
            slowTyping.SlightlyFaster("You have been walking for 5 hours");
            aPlayer.UpdateStatus(Status.Statoos.HUNGER);
            slowTyping.SlightlyFaster("You're max hp decreased by 5");
            aPlayer.MaxHP -= 5;
            aPlayer.HP -= 5;
            while (!EncounterEnded)
            {
                slowTyping.SlightlyFaster("You are hungry do you want to go to a bar?\n0: Yes\n1: No");
                Input = Console.ReadLine();
                if (Input == "0" || Input == "1")
                {
                    if (Input == "0")
                    {
                        new Bar(aPlayer);
                        EncounterEnded = true;
                    }
                    else
                    {
                        EncounterEnded = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            //perfect cell boss
            new FinalBoss(aPlayer);
            if (aPlayer.LastBattleWon) {
            Task.Delay(1000).Wait();
                Console.WriteLine("You have saved the world");
                return;
            }
            Task.Delay(1000).Wait();
            Console.WriteLine("You died and the world got taken over :/");
        }
    }
}


//Player aPlayer = new Player("Raf", 20, 0, 7, 7);
//Path1 path1 = new Path1(aPlayer);