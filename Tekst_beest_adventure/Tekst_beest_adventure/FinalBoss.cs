using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    public class FinalBoss
    {
        public FinalBoss(Player aPlayer)
        {
            Console.Clear();
            SlowTyping slowTyping = SlowTyping.GetInstance();
            slowTyping.SuperFast("P is for priceless, the look upon your faces\r\nE is for extinction, all your puny races \r\nR for rrrevolution, which will be televised \r\nF is for how f**ked you are, now allow me to reprise \r\nE is for eccentric, just listen to my song\r\nC is for completion that I’ve waited for so long \r\nT is for the terror upon you I’ll bestow\r\n\r\nHm hm hm my name is Perfect Cell and I’d like to say...hello");
            Enemy PERFECTCELL = new Enemy("The perfect being PERFECT CELL", 100, 2147483647, Magics.Magic.Perfect_Cell, true, true);
            Move Beam_Attack = new Move(Magics.Magic.Perfect_Cell, 0, 100, $"Beam attack");
            Move Absorb = new Move(Magics.Magic.Perfect_Cell, 0, 100, $"Absorb");
            Move Clone_Attack = new Move(Magics.Magic.Perfect_Cell, 0, 100, $"Clone attack");
            PERFECTCELL.AddMove(Beam_Attack);
            PERFECTCELL.AddMove(Absorb);
            PERFECTCELL.AddMove(Clone_Attack);
            Combat combat = new Combat(aPlayer, PERFECTCELL);
        }
    }
}
