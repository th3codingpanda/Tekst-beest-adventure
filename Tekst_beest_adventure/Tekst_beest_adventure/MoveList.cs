﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tekst_beest_adventure.Magics;
namespace Tekst_beest_adventure
{
    public class MoveList
    {
        private static Move Tackle = new Move(Magic.NEUTRAL, 0, 3, "Tackle");
        private static Move FireTornado = new Move(Magic.NEUTRAL, 0, 10, "FireTornado");
        private static List<List<Move>> TheMoves = new List<List<Move>>()
        {
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{},
        new List<Move>{Tackle}
        };
    public void CheckList(Player aPlayer) {
            if (TheMoves[(int)aPlayer.MagicType][0].RequiredLevel == aPlayer.Level) {

            }
            

        }
    }
}
