
using static Tekst_beest_adventure.Magics;

namespace Tekst_beest_adventure
{
    internal class Path1
    {
        SlowTyping slowTyping = SlowTyping.GetInstance();
        public Path1(Player aPlayer)
        {
            var rand = new Random();
            while (aPlayer.LastBattleWon == false)
            {
                Console.Clear();

                Magic EnemyType = (Magic)rand.Next(0, 8);
                if (EnemyType != Magic.GOKU_AND_MIKU)
                {
                    Enemy Goblin = new Enemy($"{EnemyType} Goblin", 10, 450, EnemyType, true, false);
                    Move Attack = new Move(EnemyType, 0, 2, $"Weak {EnemyType} attack");
                    Goblin.AddMove(Attack);
                    Combat combat = new Combat(aPlayer, Goblin);
                }
                else
                {
                    Enemy Goku = new Enemy("Son Goku", 10000, 2147483647, EnemyType, false, true);
                    Move Attack = new Move(EnemyType, 0, 100, $"Weak {EnemyType} attack");
                    Goku.AddMove(Attack);
                    Combat combat = new Combat(aPlayer, Goku);

                }
            }
            int fiftyfifty = rand.Next(0, 2);
            if (fiftyfifty == 0)
            {
                Item key = new Item(ItemList.TheItemList.KEY);
                aPlayer.AddItem(key);
            }
            slowTyping.SlightlyFaster($"You have beat the tutorial!");
            slowTyping.SlightlyFaster("You have been healed");
            aPlayer.HP = aPlayer.MaxHP;
            Task.Delay(1000).Wait();
            Console.Clear();
        }
    }
}
