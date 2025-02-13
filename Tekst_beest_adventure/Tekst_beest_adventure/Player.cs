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
    internal class Player
    {
        Magics Magics = new Magics();
        public string? Name;
        public int Karma;
        public int MaxHP;
        public int HP;
        public int Mana;
        public int XP;
        public int Level;
        public string? MagicType;

        public Player(string aName,int HPAmount, int XPAmount, int aMagicType)
        {
            Name = aName;
            MaxHP = HPAmount;
            HP = HPAmount;
            XP = XPAmount;
            MagicType = Enum.GetName(typeof(Magics.Magic), aMagicType);
        }
    }
}
