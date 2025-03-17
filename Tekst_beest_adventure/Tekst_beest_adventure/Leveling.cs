using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Leveling
    {

        SlowTyping slowTyping = SlowTyping.GetInstance();
        public void CheckXP(Player aPlayer) {
            if (aPlayer.XP >= 1000 * (1 + 0.2f * aPlayer.Level))
            {
                aPlayer.XP -= 1000 * aPlayer.Level;
                aPlayer.Level += 1;
                aPlayer.MaxHP += 10;
                aPlayer.HP = aPlayer.MaxHP;

                
                slowTyping.SlowlyType($"You have leveled up to level: {aPlayer.Level}");
                CheckXP(aPlayer);
                for (int i = 0; i < aPlayer.Moves.Count; i++) {
                    aPlayer.Moves[i].Damage += 2;
                }
                CheckNewMoves checkNewMoves = new CheckNewMoves();
                checkNewMoves.CheckForNewMoves(aPlayer, aPlayer.MagicType);
                if (aPlayer.MagicType != aPlayer.SecondMagicType) {
                    checkNewMoves.CheckForNewMoves(aPlayer, aPlayer.SecondMagicType);
                }
                checkNewMoves.CheckForNewMoves(aPlayer, Magics.Magic.NEUTRAL);
                return;

                
            }
            else {
                slowTyping.SlowlyType($"You need {1000 * (1 + 0.2f  * aPlayer.Level) - aPlayer.XP} XP to level up");

                Task.Delay(500).Wait();


            };
            
        }
    }
}
