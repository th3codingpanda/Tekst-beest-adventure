
namespace Tekst_beest_adventure
{
    internal class Damage
    {
        WeaknessTable weakness = new WeaknessTable();
        public void CalculateDamage(Move aMove, Player aPlayer, Enemy aEnemy, bool PlayerAttack)
        {
            int TheDamage = aMove.Damage;
            Console.Clear();
            SlowTyping slowTyping = SlowTyping.GetInstance();
            var rand = new Random();
            float DamageRandom = rand.Next(60, 150);
            DamageRandom = DamageRandom / 100;
            if (!PlayerAttack)
            {
                TheDamage = (int)Math.Round(TheDamage * weakness.ReturnWeakness(aMove.MagicType, aPlayer.MagicType, aPlayer.SecondMagicType) * DamageRandom);
                aPlayer.HP -= TheDamage;
                slowTyping.SlowlyType($"{aPlayer.Name} Took {TheDamage}");
                slowTyping.SlowlyType($"{aPlayer.Name}'s HP is:  {aPlayer.HP}");
                Task.Delay(300).Wait();
            }
            else
            {
                TheDamage = (int)Math.Round(TheDamage * weakness.ReturnWeakness(aMove.MagicType, aEnemy.MagicType, aEnemy.MagicType) * DamageRandom);
                aEnemy.HP -= TheDamage;
                slowTyping.SlowlyType($"{aEnemy.Name} Took {TheDamage}");
                slowTyping.SlowlyType($"Enemy Hp is: {aEnemy.HP}");
                Task.Delay(300).Wait();
            }



        }
    }
}



