using System.Data.Common;
using System.Dynamic;
using System.Xml.Linq;
using Tekst_beest_adventure;
namespace Tekst_beest_adventure
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Player aPlayer = new Player("Raf", 20, 0, 7, 7);
            Path1 path1 = new Path1(aPlayer);
            /*
            Player aPlayer;
            Console.WriteLine("Hello, world\r\nProgrammed to work and not to feel\r\nNot even sure that this is real\r\nHello, world\r\nFind my voice\r\nAlthough, it sounds like bits and bytes\r\nMy circuitry is filled with mites\r\nHello, world\r\nOh, will I find a love\r\nOr a power plug?\r\nOh, digitally isolated\r\nOh, creator, please don't leave me waiting\r\nHello, world\r\nProgrammed to work and not to feel\r\nNot even sure that this is real\r\nHello, world");
                string? Name;
                string? Input;
                SlowTyping slowTyping = SlowTyping.GetInstance();
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
                    Task.Delay(1000).Wait();
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
                            Task.Delay(1000).Wait();
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
                else {
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
            
            FinalBoss finalBoss = new FinalBoss(aPlayer);
            //perfect cell boss
            */
        }
    }
    }


//Item Gun = new Item(ItemList.TheItemList.GUN);
//Item key = new Item(ItemList.TheItemList.KEY);
//Item Key = new Item(ItemList.TheItemList.KEY);
//aPlayer.AddItem(Gun);
//aPlayer.AddItem(Gun);
//aPlayer.AddItem(Gun);
//aPlayer.AddItem(Key);
//aPlayer.AddItem(key);
//aPlayer.ShowItems();
//Console.WriteLine(aPlayer.SearchItems(ItemList.TheItemList.GUN));
//Console.WriteLine(aPlayer.SearchItems(ItemList.TheItemList.KEY));
//aPlayer.RemoveItem(ItemList.TheItemList.KEY, 2);
//aPlayer.ShowItems();
//Task.Delay(1000).Wait();

//{
//Input = Console.ReadLine();
//if (Input == null)
//{
//    Console.WriteLine("Do not enter null");
//    Task.Delay(1000).Wait();
//    Main(args);
//    return;
//}
//try
//{
//    int SecondMagic = Int32.Parse(Input);

//    aPlayer = new Player(Name, 20, 0, MagicType, SecondMagic);
//    slowTyping.SlowlyType($"You have chosen {aPlayer.MagicType}");
//    Task.Delay(1000).Wait();
//    Path1 path1 = new Path1(aPlayer);

//}
//catch (FormatException)
//{

//}