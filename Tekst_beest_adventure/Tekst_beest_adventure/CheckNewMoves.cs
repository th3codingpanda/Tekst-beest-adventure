namespace Tekst_beest_adventure
{
    internal class CheckNewMoves
    {
        SlowTyping slowTyping = SlowTyping.GetInstance();
        public void CheckForNewMoves(Player aPlayer, Magics.Magic aMagic)
        {
            MoveList moveList = new MoveList();
            List<Move> MagicList = moveList.CheckList((int)aMagic);
            
            for (int i = 0; i < MagicList.Count; i++) {
                if (MagicList[i].RequiredLevel == aPlayer.Level) {
                    slowTyping.SlowlyType($"You are learning {MagicList[i].Name}");
                    Task.Delay(500).Wait();
                    if (aPlayer.Moves.Count < 4)
                    {
                        aPlayer.Moves.Add(MagicList[i]);
                    }
                    else {
                        Console.Clear();
                        Console.WriteLine("Choose a move to remove");
                        for (int j = 0; j < aPlayer.Moves.Count; j++)
                        {
                            Console.WriteLine($"{j} {aPlayer.Moves[j].Name}");
                        }
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
                                    slowTyping.SlowlyType($"{aPlayer.Moves[InputParse].Name} Replaced with {MagicList[i].Name}");
                                    aPlayer.Moves[InputParse] = MagicList[i];
                                    Task.Delay(1000).Wait();
                                return;
                                }
                                else
                                {
                                    slowTyping.SlowlyType("Please enter a valid number");
                                    CheckForNewMoves(aPlayer, aMagic);
                                    return;
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

