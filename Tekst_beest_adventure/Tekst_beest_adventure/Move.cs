using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    public class Move
    {
        public Magics.Magic MagicType;
        public int RequiredLevel;
        public int Damage;
        public string? Name;
        public Move(Magics.Magic aMagicType, int TheRequiredLevel,int DamageAmount, string? aName)
        {
            MagicType = aMagicType;
            RequiredLevel = TheRequiredLevel;
            Damage = DamageAmount;
            Name = aName;
        }
    }
}
