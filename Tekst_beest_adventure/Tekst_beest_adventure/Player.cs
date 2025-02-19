using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static Tekst_beest_adventure.Magics;

namespace Tekst_beest_adventure
{
    public class Player
    {
        public string? Name;
        public int Karma;
        public int MaxHP;
        public int HP;
        public int Mana;
        public int XP;
        public int Level;
        public Magic MagicType;
        public List<Move> moves = new List<Move>();
        public int LastVisitedInn;
        public Player(string aName,int HPAmount, int XPAmount, int aMagicType)
        {
            Name = aName;
            MaxHP = HPAmount;
            HP = HPAmount;
            XP = XPAmount;
            MagicType = (Magic)aMagicType;
            Level = 1;
            Karma = 0;
            Mana = 20;
            LastVisitedInn = 0;
            
        }
    }
}
