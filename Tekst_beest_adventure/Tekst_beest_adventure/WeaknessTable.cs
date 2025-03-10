using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{

    public class WeaknessTable
    {
        enum Weakness
        {
            Weak = 50,
            Normal = 100,
            Strong = 150,
            Goku = 400,
            NEVER_LOSE = 40000000,
        }

        private static List<List<Weakness>> Table = new List<List<Weakness>>()
        {

            //" Fire = 1 Water = 2 Earth = 3 Air = 4 Dark = 5 Light = 6 WeatherForecasting = 7 Goku = 8"
            // -1 because starts at 0
            {new List<Weakness>{Weakness.Normal, Weakness.Weak , Weakness.Normal , Weakness.Strong ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak, Weakness.Normal } },
            {new List<Weakness>{Weakness.Strong, Weakness.Normal , Weakness.Weak, Weakness.Normal ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak, Weakness.Normal } },
            {new List<Weakness>{Weakness.Normal, Weakness.Strong , Weakness.Normal , Weakness.Weak ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak, Weakness.Normal } },
            {new List<Weakness>{Weakness.Weak, Weakness.Normal , Weakness.Strong , Weakness.Normal ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak, Weakness.Normal } },
            {new List<Weakness>{Weakness.Normal, Weakness.Normal , Weakness.Normal , Weakness.Normal ,Weakness.Weak, Weakness.Strong , Weakness.Goku , Weakness.Weak, Weakness.Normal } },
            {new List<Weakness>{Weakness.Normal, Weakness.Normal , Weakness.Normal , Weakness.Normal ,Weakness.Strong , Weakness.Weak , Weakness.Goku , Weakness.Weak, Weakness.Normal } },
            {new List<Weakness>{Weakness.Weak, Weakness.Weak , Weakness.Weak , Weakness.Weak ,Weakness.Weak , Weakness.Weak , Weakness.Goku , Weakness.Weak, Weakness.Normal } },
            {new List<Weakness>{Weakness.Goku, Weakness.Goku , Weakness.Goku , Weakness.Goku ,Weakness.Goku , Weakness.Goku , Weakness.NEVER_LOSE , Weakness.Goku, Weakness.Goku } },
            {new List<Weakness>{Weakness.Normal, Weakness.Normal, Weakness.Normal, Weakness.Goku ,Weakness.Normal, Weakness.Normal, Weakness.Normal, Weakness.Weak, Weakness.Normal } },
        };

        public float ReturnWeakness(Magics.Magic AttackingMagic,Magics.Magic DefendingMagic) {
            SlowTyping slowTyping = new SlowTyping();
            float MultiplierWeakness = (float)Table[(int)AttackingMagic][(int)DefendingMagic] /100;

            if (MultiplierWeakness <= 0.5f) {
                slowTyping.SlowlyType("Not very effective");
            }
            else if (MultiplierWeakness == 1)
            {
                slowTyping.SlowlyType("effective");

            }
            else if (MultiplierWeakness >= 1.5f)
            {
                slowTyping.SlowlyType("Very effective");
            }
            Task.Delay(500).Wait();
            return MultiplierWeakness;
        }
    }
}
