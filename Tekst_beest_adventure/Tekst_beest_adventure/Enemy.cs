
namespace Tekst_beest_adventure
{
    public class Enemy
    {
        public string? Name;
        public Magics.Magic MagicType;
        public int HP;
        public int XP;
        public int KarmaGain;
        public bool Boss;
        public List<Move> Moves = new List<Move>();

        public Enemy(string aName, int HPAmount, int XPAmount, Magics.Magic aMagicType, bool IsEvil, bool IsBoss)
        {
            Name = aName;
            HP = HPAmount;
            XP = XPAmount;
            MagicType = aMagicType;
            Boss = IsBoss;
            if (IsEvil)
            {
                KarmaGain = 100;
            }
            else
            {
                KarmaGain = -100;
            }

        }
        public void AddMove(Move aMove)
        {
            Moves.Add(aMove);
        }

    }
}
