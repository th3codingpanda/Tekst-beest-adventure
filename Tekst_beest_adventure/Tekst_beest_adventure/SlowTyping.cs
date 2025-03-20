
namespace Tekst_beest_adventure
{
    internal class SlowTyping
    {
        private static SlowTyping? instance;
        private SlowTyping()
        {

        }
        public static SlowTyping GetInstance()
        {
            if (instance == null)
            {
                instance = new SlowTyping();
            }
            return instance;
        }
        int Amount = 0;
        public void SlowlyType(string WhatIsTyped)
        {
            Amount = 0;
            foreach (char c in WhatIsTyped)
            {
                Amount++;
                if (Amount != WhatIsTyped.Length)
                {
                    Console.Write(c);
                    Task.Delay(30).Wait();

                }
                else
                {
                    Console.WriteLine(c);
                    Task.Delay(30).Wait();
                }
            }
            return;
        }
        public void SlightlyFaster(string WhatIsTyped)
        {
            Amount = 0;
            foreach (char c in WhatIsTyped)
            {
                Amount++;
                if (Amount != WhatIsTyped.Length)
                {
                    Console.Write(c);
                    Task.Delay(10).Wait();

                }
                else
                {
                    Console.WriteLine(c);
                    Task.Delay(10).Wait();
                }
            }
            return;
        }
        public void SuperFast(string WhatIsTyped)
        {
            Amount = 0;
            foreach (char c in WhatIsTyped)
            {
                Amount++;
                if (Amount != WhatIsTyped.Length)
                {
                    Console.Write(c);
                    Task.Delay(01).Wait();

                }
                else
                {
                    Console.WriteLine(c);
                    Task.Delay(01).Wait();
                }
            }
            return;
        }


    }
}
