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
        private static Move Miku_Miku_Beam = new Move(Magic.GOKU_AND_MIKU, 0, 500, "Miku Miku Beam");
        private static Move Spirit_Bomb = new Move(Magic.GOKU_AND_MIKU, 0, 2147483647, "Spirit Bomb");
        private static Move FireTornado = new Move(Magic.NEUTRAL, 0, 10, "FireTornado");
        //" Fire = 1 Water = 2 Earth = 3 Air = 4 Dark = 5 Light = 6 WeatherForecasting = 7 Goku = 8" Neutral = 9
        // -1 because starts at 0
        private static List<List<Move>> TheMoves = new List<List<Move>>()
        {
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{Miku_Miku_Beam,Spirit_Bomb},
        new List<Move>{Tackle}
        };
    public List<Move> CheckList(int aInt) {
            return TheMoves[aInt];

        }
    }
}
