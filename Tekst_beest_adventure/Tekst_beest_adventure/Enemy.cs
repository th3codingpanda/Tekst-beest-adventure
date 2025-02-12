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
        public string? MagicType;
        public int HP;
        public int XP;
        public int KarmaGain;
        enum Magic  { 
            Fire = 0,
            Water = 1,
            Earth = 2,
            Air = 3,
            Dark = 4,
            Light = 5,
            WeatherForecasting = 6,
            Goku = 7,
        }
        
        public Enemy(string aName, int HPAmount, int XPAmount,int aMagicType,bool IsEvil) {
            Name = aName;
            HP = HPAmount;
            XP = XPAmount;
            MagicType = Enum.GetName(typeof(Magic), aMagicType);
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
