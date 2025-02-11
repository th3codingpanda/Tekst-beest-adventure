using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Path1
    {
        enum ErrorCode : int
        {
            None = 0,
            Unknown = 1,
            ConnectionLost = 100,
            OutlierReading = 200,
            PageNotFound = 404
        }
        public int error = (int)ErrorCode.Unknown;
        public Path1() {
            SlowTyping slowTyping = new SlowTyping();
            slowTyping.SlowlyType("Write down the word thats below this");
            slowTyping.SlowlyType("captha");
            Enemy enemy = new Enemy(6);
            slowTyping.SlowlyType($"Integral value of {enemy.MagicType}");
            Console.ReadLine();
        }
    }
}
