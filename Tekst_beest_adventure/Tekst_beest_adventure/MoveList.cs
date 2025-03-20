using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Tekst_beest_adventure.Magics;
namespace Tekst_beest_adventure
{
    public class MoveList
    {
        private static Move Tackle = new Move(Magic.NEUTRAL, 0, 3, "Tackle");
        private static Move Volcanic_Explosion = new Move(Magic.FIRE, 0, 5, "VOLCANIC EXPLOSION");
        private static Move Tsunami = new Move(Magic.WATER, 0, 5, "TSUNAMI");
        private static Move Earth_Shatter = new Move(Magic.EARTH, 0, 5, "SHATTER THE EARTH");
        private static Move Tornado = new Move(Magic.AIR, 0, 5, "TORNADO");
        private static Move Fear_The_Darkness = new Move(Magic.DARK, 0, 5, "FEAR THE DARKNESS");
        private static Move Divine_Light_Sword = new Move(Magic.LIGHT, 0, 5, "DIVINE LIGHT SWORD");
        private static Move Forecasting = new Move(Magic.WEATHERFORECASTING, 0, 0, "Forecast the weather");
        private static Move Miku_Miku_Beam = new Move(Magic.GOKU_AND_MIKU, 0, 500, "Miku Miku Beam");
        private static Move Spirit_Bomb = new Move(Magic.GOKU_AND_MIKU, 0, 2147483647, "Spirit Bomb");
        //" Fire = 1 Water = 2 Earth = 3 Air = 4 Dark = 5 Light = 6 WeatherForecasting = 7 Goku_and_miku = 8" Neutral = 9
        // -1 because starts at 0
        private static List<List<Move>> TheMoves = new List<List<Move>>()
        {
        new List<Move>{Volcanic_Explosion},
        new List<Move>{Tsunami},
        new List<Move>{Earth_Shatter},
        new List<Move>{Tornado},
        new List<Move>{Fear_The_Darkness},
        new List<Move>{Divine_Light_Sword},
        new List<Move>{Forecasting},
        new List<Move>{Miku_Miku_Beam,Spirit_Bomb},
        new List<Move>{Tackle}
        };
        public List<Move> CheckList(int aInt)
        {
            return TheMoves[aInt];

        }
    }
}
