﻿using System;
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
        public void SlightlyFaster(string WhatIsTyped) {
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


    }
}
