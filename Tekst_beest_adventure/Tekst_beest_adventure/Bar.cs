using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Bar
    {

        public Bar(Player aPlayer) {
            SlowTyping slowTyping = SlowTyping.GetInstance();
            slowTyping.SlowlyType("You enter the bar");
            while (true) {
                Console.Clear();
                slowTyping.SlightlyFaster("What do you do?\n0 Grab food\n1Get drunk\n2Leave");
                string? Input = Console.ReadLine();
                if (Input == "0")
                {
                    if (aPlayer.PlayerStatus != Status.Statoos.WELL_FED && aPlayer.PlayerStatus != Status.Statoos.Drunk)
                    {
                        slowTyping.SlightlyFaster("You ate very well");
                        aPlayer.UpdateStatus(Status.Statoos.WELL_FED);
                        slowTyping.SlightlyFaster("You're max hp increased by 20");
                        aPlayer.MaxHP += 20;
                        aPlayer.HP += 20;
                    }
                    else {
                        slowTyping.SlightlyFaster("You're too full to eat any more");
                    }
                    Task.Delay(1000).Wait();

                }
                else if (Input == "1") 
                {
                    if (aPlayer.PlayerStatus != Status.Statoos.Drunk) {
                        aPlayer.MaxHP -= 5;
                    }
                    aPlayer.UpdateStatus(Status.Statoos.Drunk);
                   

                    
                }
                else if (Input == "2") 
                {
                return;
                }
            }
        }
    }
}
