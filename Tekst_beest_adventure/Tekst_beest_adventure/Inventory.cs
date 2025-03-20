
namespace Tekst_beest_adventure
{

    public class Inventory
    {
        SlowTyping slowTyping = SlowTyping.GetInstance();

        private List<Item> PlayerInventory = new List<Item>();

        public void InventoryAdd(Item item)
        {
            bool HasItem = false;
            for (int i = 0; i < PlayerInventory.Count; i++)
            {
                if (PlayerInventory[i].Name == item.Name)
                {
                    PlayerInventory[i].Amount++;
                    slowTyping.SlightlyFaster($"Obtained item: {item.Name}");
                    Task.Delay(500).Wait();
                    HasItem = true;
                }
            }
            if (!HasItem)
            {
                PlayerInventory.Add(item);
                slowTyping.SlightlyFaster($"Obtained item: {item.Name}");
                Task.Delay(500).Wait();
            }
        }
        public void InventoryRemove(ItemList.TheItemList aItem, int amount)
        {
            for (int i = 0; i < PlayerInventory.Count; i++)
                if (PlayerInventory[i].Name.ToString() == aItem.ToString() && amount != 0)
                {
                    PlayerInventory[i].Amount -= amount;
                    Console.WriteLine($"Removed {amount} {aItem.ToString()}");
                    Task.Delay(500).Wait();
                    if (PlayerInventory[i].Amount <= 0)
                    {

                        PlayerInventory.Remove(PlayerInventory[i]);
                    }
                }
        }
        public List<Item> InventoryCheck()
        {
            foreach (Item PlayerItems in PlayerInventory)
            {
                Console.WriteLine(PlayerItems.Name + ":" + PlayerItems.Amount);
            }
            return PlayerInventory;
        }
        public bool SpecificCheck(ItemList.TheItemList aItem)
        {

            foreach (Item PlayerItems in PlayerInventory)
            {
                if (PlayerItems.Name.ToString() == aItem.ToString())
                {
                    return true;
                }
            }
            return false;
        }

    }
}
