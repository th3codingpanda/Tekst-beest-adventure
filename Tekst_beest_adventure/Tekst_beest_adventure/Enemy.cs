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
        Magics Magics = new Magics();
        public string? Name;
        public string? MagicType;
        public int HP;
        public int XP;
        public int KarmaGain;

        
        public Enemy(string aName, int HPAmount, int XPAmount,int aMagicType,bool IsEvil) {
            Name = aName;
            HP = HPAmount;
            XP = XPAmount;
            MagicType = Enum.GetName(typeof(Magics.Magic), aMagicType);
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
