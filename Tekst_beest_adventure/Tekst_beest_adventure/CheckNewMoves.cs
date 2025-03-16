namespace Tekst_beest_adventure
{
    internal class CheckNewMoves
    {
        SlowTyping slowTyping = new SlowTyping();
        public void CheckForNewMoves(Player aPlayer, Magics.Magic aMagic)
        {
            MoveList moveList = new MoveList();
            List<Move> MagicList = moveList.CheckList((int)aPlayer.MagicType);
            
            for (int i = 0; i < MagicList.Count; i++) {
                if (MagicList[i].RequiredLevel == aPlayer.Level) {
                    slowTyping.SlowlyType($"You are learning {MagicList[i].Name}");
                    if (aPlayer.Moves.Count > 4)
                    {
                        aPlayer.Moves.Add(MagicList[i]);
                    }
                    else {
                        Console.Clear();
                        Console.WriteLine("Choose a move to remove");
                        for (int j = 0; j < aPlayer.Moves.Count; j++)
                        {
                            Console.WriteLine($"{i} {aPlayer.Moves[i]}");
                            string? Input = Console.ReadLine();
                            if (Input == null)
                            {
                                CheckForNewMoves(aPlayer, aMagic);

                                return;
                            }
                            try
                            {
                                int InputParse = Int32.Parse(Input);
                                if (InputParse >= 0 && InputParse < 4)
                                {

                                }
                                else
                                {
                                    slowTyping.SlowlyType("Please enter a valid number");
                                    
                                }
                            }
                            catch(FormatException) {
                                CheckForNewMoves(aPlayer , aMagic);
                                return;
                            }
                        }
                    }

                }
            }
        }
    }
}
