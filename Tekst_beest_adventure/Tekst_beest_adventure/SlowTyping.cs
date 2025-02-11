using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class SlowTyping
    {
        int Amount = 0;
        public void SlowlyType(string WhatIsTyped) {
            Amount = 0;
            foreach (char c in WhatIsTyped)
            {
                Amount++;
                if (Amount != WhatIsTyped.Length)
                {
                    Console.Write(c);
                    Task.Delay(50).Wait();

                }
                else
                {
                    Console.WriteLine(c);
                    Task.Delay(50).Wait();
                }
            }
            return;
        }
        
    }
}
