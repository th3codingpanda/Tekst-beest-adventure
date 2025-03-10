using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekst_beest_adventure
{
    internal class Damage
    {
        WeaknessTable weakness = new WeaknessTable();
        public void CalculatePlayerDamage(Move aMove,Player aPlayer ,Enemy aEnemy)
        {
            int TheDamage = aMove.Damage;
            Console.Clear();
            SlowTyping slowTyping = new SlowTyping();
            var rand = new Random();
            float DamageRandom = rand.Next(60, 150);
            DamageRandom = DamageRandom / 100;
            TheDamage = (int)Math.Round(TheDamage * weakness.ReturnWeakness(aMove.MagicType, aEnemy.MagicType) * DamageRandom );
            aEnemy.HP -= TheDamage;
            slowTyping.SlowlyType($"{aEnemy.Name} Took {TheDamage}");
            slowTyping.SlowlyType($"Enemy Hp is: {aEnemy.HP}");

        }
        public void CalculateEnemyDamage(int TheDamage, Player aPlayer, Enemy aEnemy) {
            Console.Clear();
            SlowTyping slowTyping = new SlowTyping();
            var rand = new Random();
            float DamageRandom = rand.Next(60, 150);
            DamageRandom = DamageRandom / 100;
            TheDamage = (int)Math.Round(TheDamage * weakness.ReturnWeakness(aEnemy.MagicType, aPlayer.MagicType) * DamageRandom );
            aPlayer.HP -= TheDamage;
            slowTyping.SlowlyType($"{aPlayer.Name} Took {TheDamage}");
            slowTyping.SlowlyType($"{aPlayer.Name}'s Hp is: {aPlayer.HP}");
        }
    }
}



