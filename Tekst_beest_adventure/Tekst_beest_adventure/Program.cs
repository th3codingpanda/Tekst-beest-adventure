namespace Tekst_beest_adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SlowTyping slowTyping = new SlowTyping();
            slowTyping.SlowlyType("Text beest adventure");
            slowTyping.SlowlyType("By Raf Woud");
            Task.Delay(1000).Wait();
            Console.Clear();
            Path1 path1 = new Path1();

            
        }
    }
}
