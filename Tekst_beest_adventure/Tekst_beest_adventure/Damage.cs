using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Damage
    {
        public Enemy CalculateDamage(int TheDamage, Enemy aEnemy) 
        {
            SlowTyping slowTyping = new SlowTyping();
            var rand = new Random();
            float DamageRandom = rand.Next(60, 150);
            DamageRandom = DamageRandom / 100;
            Console.WriteLine(DamageRandom);
            TheDamage = (int)Math.Round(TheDamage * DamageRandom);
            aEnemy.HP -= TheDamage;
            slowTyping.SlowlyType($"{aEnemy.Name} Took {TheDamage}");
            slowTyping.SlowlyType( $"Enemy Hp is: {aEnemy.HP}");
            return aEnemy;
        }
    }
}
