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

            //" Fire = 0 Water = 1 Earth = 2 Air = 3 Dark = 4 Light = 5 WeatherForecasting = 6 Goku = 7"
            {new List<Weakness>{Weakness.Normal, Weakness.Weak , Weakness.Strong , Weakness.Strong ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak } },
            {new List<Weakness>{Weakness.Strong, Weakness.Normal , Weakness.Strong , Weakness.Strong ,Weakness.Normal , Weakness.Normal , Weakness.Goku , Weakness.Weak } },
        };

        public void Returnweakness() { }
    }
}
