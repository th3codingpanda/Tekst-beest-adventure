using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static Tekst_beest_adventure.Magics;
using static Tekst_beest_adventure.Status;
namespace Tekst_beest_adventure
{
    public class Player
    {
        
        public string? Name;
        public int Karma;
        public int MaxHP;
        public int HP;
        public int XP;
        public int Level;
        public Magic MagicType;
        public Magic SecondMagicType;
        public List<Move> Moves = new List<Move>();
        public int CurrentPath;
        public Statoos Status;
        public bool LastBattleWon;
        public int Coins;
        private Inventory Inv = new Inventory();
        public Player(string aName,int HPAmount, int XPAmount, int aMagicType,int aSecondMagicType)
        {

            Name = aName;
            MaxHP = HPAmount;
            HP = HPAmount;
            XP = XPAmount;
            MagicType = (Magic)aMagicType;
            SecondMagicType = (Magic)aSecondMagicType;
            Level = 0;
            Karma = 0;
            CurrentPath = 0;
            Coins = 0;
            CheckNewMoves checkNewMoves = new CheckNewMoves();
            checkNewMoves.CheckForNewMoves(this,MagicType);
            if (MagicType != SecondMagicType) {
                checkNewMoves.CheckForNewMoves(this, SecondMagicType);
            }
            checkNewMoves.CheckForNewMoves(this, Magic.NEUTRAL);

        }

        public void AddItem(Item aItem)
        {
            Inv.InventoryAdd(aItem);
        }
        public void RemoveItem(ItemList.TheItemList aItem, int aAmount)
        {
            Inv.InventoryRemove(aItem,aAmount);
        }
        public List<Item> ShowItems() {
        return Inv.InventoryCheck();
        }
        public bool SearchItems(ItemList.TheItemList aItem) 
        {
            return Inv.SpecificCheck(aItem);
        }

    }
}
