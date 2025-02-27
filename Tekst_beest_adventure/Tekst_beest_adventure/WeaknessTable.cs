using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
 enum Weakness{
        Weak = 50,
        Normal = 100,
        Strong = 150,
        Goku = 400,
        }
    public class WeaknessTable
    {


        private static List<List<Weakness>> Table = new List<List<Weakness>>()
        {

            //" Fire = 1 Water = 2 Earth = 3 Air = 4 Dark = 5 Light = 6 WeatherForecasting = 7 Goku = 8"
            // -1 because starts at 0
            {new List<Weakness>{Weakness.Normal, Weakness.Weak , Weakness.Normal , Weakness.Strong ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak } },
            {new List<Weakness>{Weakness.Strong, Weakness.Normal , Weakness.Weak, Weakness.Normal ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak } },
            {new List<Weakness>{Weakness.Normal, Weakness.Strong , Weakness.Normal , Weakness.Weak ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak } },
            {new List<Weakness>{Weakness.Weak, Weakness.Normal , Weakness.Strong , Weakness.Normal ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak } },
            {new List<Weakness>{Weakness.Normal, Weakness.Normal , Weakness.Normal , Weakness.Normal ,Weakness.Weak, Weakness.Strong , Weakness.Goku , Weakness.Weak } },
            {new List<Weakness>{Weakness.Normal, Weakness.Normal , Weakness.Normal , Weakness.Normal ,Weakness.Strong , Weakness.Weak , Weakness.Goku , Weakness.Weak } },
            {new List<Weakness>{Weakness.Weak, Weakness.Weak , Weakness.Weak , Weakness.Weak ,Weakness.Weak , Weakness.Weak , Weakness.Goku , Weakness.Weak } },
            {new List<Weakness>{Weakness.Goku, Weakness.Goku , Weakness.Goku , Weakness.Goku ,Weakness.Goku , Weakness.Goku , Weakness.Goku , Weakness.Goku } },
        };

        public float Returnweakness(int AttackingMagic,int DefendingMagic) {
            SlowTyping slowTyping = new SlowTyping();
            float MultiplierWeakness = (float)Table[AttackingMagic][DefendingMagic] /100;
            Console.WriteLine(MultiplierWeakness);
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

            return MultiplierWeakness;
        }
    }
}
