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
        public int Damage;
        public bool Boss;

        public Enemy(string aName, int HPAmount, int XPAmount,Magics.Magic aMagicType,bool IsEvil , int DamageAmount ,bool IsBoss) {
            Name = aName;
            HP = HPAmount;
            XP = XPAmount;
            MagicType = aMagicType;
            Damage = DamageAmount;
            Boss = IsBoss;
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
