using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    public class Enemy
    {
        public string? Name;
        public Magics.Magic MagicType;
        public int HP;
        public int XP;
        public int KarmaGain;
        public Enemy(string aName, int HPAmount, int XPAmount,Magics.Magic aMagicType,bool IsEvil) {
            Name = aName;
            HP = HPAmount;
            XP = XPAmount;
            MagicType = aMagicType;
            if (!IsEvil)
            {
                KarmaGain = -100;
            }
            else {
                KarmaGain = 100;
            }
            
        }
    }
}
