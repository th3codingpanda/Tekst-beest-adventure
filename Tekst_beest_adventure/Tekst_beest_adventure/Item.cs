
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

