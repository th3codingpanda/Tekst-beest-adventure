using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Combat
    {
        SlowTyping slowTyping = new SlowTyping();
        bool BattleEnded;
        public Combat(Stats Player,Enemy enemy){
            slowTyping.SlowlyType($"A {enemy.MagicType} {enemy.Name} has appeared");
            slowTyping.SlowlyType($"Your HP is: {Player.HP}\nYour XP is: {Player.XP}\n");
            if (!BattleEnded)
            {
                if (Player.HP <=0) {
                    Console.WriteLine("You lost the combat");
                    BattleEnded = true;
                }
            }
            else {
            
            }
        }
    }
}
