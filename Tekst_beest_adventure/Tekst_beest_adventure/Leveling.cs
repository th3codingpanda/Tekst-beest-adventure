using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Leveling
    {

        SlowTyping slowTyping = new SlowTyping();
        public Player CheckXP(Player aPlayer) {
            if (aPlayer.XP >= 1000 * (1 + 0.2f * aPlayer.Level))
            {
                aPlayer.XP -= 1000 * aPlayer.Level;
                aPlayer.Level += 1;
                aPlayer.MaxHP += 10;
                aPlayer.HP = aPlayer.MaxHP;
                aPlayer.Mana = 20;
                
                slowTyping.SlowlyType($"You have leveled up to level: {aPlayer.Level}");
                aPlayer = CheckXP(aPlayer);
                return aPlayer;
            }
            else {
                slowTyping.SlowlyType($"You need {1000 * (1 + 0.2f  * aPlayer.Level) - aPlayer.XP} XP to level up");
                Task.Delay(500).Wait();
                return aPlayer;
            };
            
        }
    }
}
