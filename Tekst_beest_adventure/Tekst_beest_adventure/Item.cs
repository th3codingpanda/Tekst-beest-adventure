using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{

    public class Item
    {

        public ItemList.TheItemList Name;
        public int Amount;
        public Item(ItemList.TheItemList aName)
        {
            Name = aName;
            Amount = 1;
        }
    }
}

