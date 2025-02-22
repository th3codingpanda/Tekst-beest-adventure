using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class WeaknessTable
    {
        public static List<List<float>> Table = new List<List<float>>()
        {
            //" Fire = 0 Water = 1 Earth = 2 Air = 3 Dark = 4 Light = 5 WeatherForecasting = 6 Goku = 7"
            {new List<float>{0.5f, 0.5f,2f,2f, 0.5f, 0.5f, 2f, 0.5f } },
            {new List<float>{2f , 0.5f,2f, 0.5f, 0.5f, 0.5f, 2f, 0.5f } },
            {new List<float>{2f, 0.5f, 0.5f, 2f, 0.5f, 0.5f, 2f ,0.5f }  },
            {new List<float>{0.5f, 2f , 0.5f, 2f,0.5f, 0.5f, 2f, 0.5f } },
            {new List<float>{2f, 2f, 2f ,2f , 0.5f, 0.5f, 2f ,0.5f} },
            {new List<float>{2f,2f ,2f ,2f , 0.5f, 0.5f, 2f,0.5f} },
            {new List<float>{ 0.5f, 0.5f, 0.5f, 0.5f, 0.5f, 0.5f, 0.5f, 0.5f, } },
            {new List<float>{4f,4f ,4f ,4f ,4f ,4f ,0.5f } },
        };

        public WeaknessTable() { }
    }
}
