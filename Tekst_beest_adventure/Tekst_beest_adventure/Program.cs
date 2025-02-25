using System.Dynamic;
using System.Xml.Linq;

namespace Tekst_beest_adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player aPlayer = new Player("Raf", 20, 0, 7);
            Path1 path1 = new Path1(aPlayer);
            /*
            Console.WriteLine("Hello, world\r\nProgrammed to work and not to feel\r\nNot even sure that this is real\r\nHello, world\r\nFind my voice\r\nAlthough, it sounds like bits and bytes\r\nMy circuitry is filled with mites\r\nHello, world\r\nOh, will I find a love\r\nOr a power plug?\r\nOh, digitally isolated\r\nOh, creator, please don't leave me waiting\r\nHello, world\r\nProgrammed to work and not to feel\r\nNot even sure that this is real\r\nHello, world");
            string? Name;
            string? Input;
            SlowTyping slowTyping = new SlowTyping();
            Console.Clear();
            slowTyping.SlowlyType("Enter a Name");
            Name = Console.ReadLine();
            if (Name == null) {
            Console.WriteLine("Do not enter null");
            Task.Delay(1000).Wait();
            Main(args);
            return;
            }
            slowTyping.SlowlyType("Choose a MagicType");
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
                    Player aPlayer = new Player(Name, 20, 0, MagicType);
                    slowTyping.SlowlyType($"You have chosen {aPlayer.MagicType}");
                    Task.Delay(1000).Wait();
                    Path1 path1 = new Path1(aPlayer);
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
            }  */
        }
    }
}
