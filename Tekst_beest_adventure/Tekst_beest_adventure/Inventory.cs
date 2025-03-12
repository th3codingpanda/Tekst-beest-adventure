using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{

    public class Inventory
    {

        private List<Item> PlayerInventory = new List<Item>();

        public void InventoryAdd(Item item)
        {
            bool HasItem = false;
            for (int i = 0; i < PlayerInventory.Count; i++)
            {
                if (PlayerInventory[i].Name == item.Name)
                {
                PlayerInventory[i].Amount++;
                    HasItem = true;
                }
            }
            if (!HasItem)
            {
                PlayerInventory.Add(item);
            }
        }
        public void InventoryRemove(string item, int amount)
        {
            for (int i = 0; i < PlayerInventory.Count; i++)
                if (PlayerInventory[i].Name.ToString() == item && amount != 0)
                {
                    PlayerInventory[i].Amount -= amount;
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
        public bool SpecificCheck(string aItem) {

            foreach (Item PlayerItems in PlayerInventory)
            {
                if (PlayerItems.Name.ToString() == aItem) {
                return true;
                }
            }
                return false;
        }

    }
}
