using System.Dynamic;

namespace Tekst_beest_adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? Name;
            string? Input;
           SlowTyping slowTyping = new SlowTyping();
            //slowTyping.SlowlyType("Text beest adventure");
            //slowTyping.SlowlyType("By Raf Woud");
            Task.Delay(1000).Wait();
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
                if (MagicType >= 0 && MagicType <= 7)
                {
                    Stats Player = new Stats(Name, 10, 0, MagicType);
                    slowTyping.SlowlyType($"You have chosen {Player.MagicType}");
                    Task.Delay(1000).Wait();
                    Path1 path1 = new Path1(Player);
                }
                else {
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
    }
}
