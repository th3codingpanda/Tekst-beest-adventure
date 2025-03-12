using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    public class Item
    {
        public enum TheNames {
        Gun = 0,
        };
        public TheNames Name { get; set; }
        public int Amount;
        public Item(string aName)
        {
            Name = (TheNames)Enum.Parse(typeof(TheNames), aName);
            Amount = 1;
        }
    }
}

