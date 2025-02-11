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
        public int Mana;
        public int XP;
        enum Magic  { 
            Fire = 0,
            Water = 1,
            Earth = 2,
            Air = 3,
            Dark = 4,
            Light = 5,
            Goku = 6,
            Gambling = 777
        }
        
        public Enemy(int aMagicType) {
            MagicType = Enum.GetName(typeof(Magic), aMagicType);
        }
    }
}
