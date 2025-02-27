using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Damage
    {
        public void CalculatePlayerDamage(int TheDamage, Enemy aEnemy)
        {
            SlowTyping slowTyping = new SlowTyping();
            var rand = new Random();
            float DamageRandom = rand.Next(60, 150);
            DamageRandom = DamageRandom / 100;
            TheDamage = (int)Math.Round(TheDamage * DamageRandom);
            aEnemy.HP -= TheDamage;
            slowTyping.SlowlyType($"{aEnemy.Name} Took {TheDamage}");
            slowTyping.SlowlyType($"Enemy Hp is: {aEnemy.HP}");

        }
        public void CalculateEnemyDamage(int TheDamage, Player aPlayer) {

            SlowTyping slowTyping = new SlowTyping();
            var rand = new Random();
            float DamageRandom = rand.Next(60, 150);
            DamageRandom = DamageRandom / 100;
            TheDamage = (int)Math.Round(TheDamage * DamageRandom);
            aPlayer.HP -= TheDamage;
            slowTyping.SlowlyType($"{aPlayer.Name} Took {TheDamage}");
            slowTyping.SlowlyType($"Enemy Hp is: {aPlayer.HP}");
        }
    }
}



