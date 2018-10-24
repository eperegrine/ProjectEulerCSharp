using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class PokerHands : EulerTask
    {
        public void Run()
        {
            Console.WriteLine("Gambling is fun");
        }

        enum CardType
        {
            Two= 0, Three=1, Four=2, Five=3, Six=4, Seven=5, Eight=6, Nine=7, Ten=8, Jack=9, Queen=10, King=11, Ace=12
        }

        enum Suit
        {
            Clubs,
            Spades,
            Diamond,
            Hearts
        }

        class Card
        {
            public CardType Type;
            public Suit Suit;
        }

        class Hand
        {
            Card c1;
            Card c2;
            Card c3;
            Card c4;
            Card c5;

            public Hand(Card c1, Card c2, Card c3, Card c4, Card c5)
            {
                this.c1 = c1;
                this.c2 = c2;
                this.c3 = c3;
                this.c4 = c5;
                this.c5 = c5;
            }

            public Card[] CardArray
            {
                get
                {
                    Card[] cards = new Card[] { c1, c2, c3, c4, c5 };
                    return cards.OrderBy(card => card.Type).ToArray();
                }
            }

            public bool IsFlush()
            {
                bool result = true;
                Suit firstSuit = CardArray[0].Suit;

                for (int i = 1; i < CardArray.Length; i++)
                {
                    if (CardArray[i].Suit != firstSuit)
                    {
                        result = false;
                        break;
                    }
                }

                return result;
            }

           /* public bool IsStraightFlush()
            {

                if (IsFlush())
                {
                    //possible
                    CardType t5 = CardType.Five;
                    CardType t6 = ((int)t5)
                }
                else
                {
                    return false;
                }
            }*/

            public bool IsRoyalFlush()
            {
                if (IsFlush())
                {
                    bool TenFound = false;
                    bool JackFound = false;
                    bool QueenFound = false;
                    bool KingFound = false;
                    bool AceFound = false;

                    foreach (Card c in CardArray)
                    {
                        switch (c.Type)
                        {
                            case CardType.Ten:
                                TenFound = true;
                                break;
                            case CardType.Jack:
                                JackFound = true;
                                break;
                            case CardType.Queen:
                                QueenFound = true;
                                break;
                            case CardType.King:
                                KingFound = true;
                                break;
                            case CardType.Ace:
                                AceFound = true;
                                break;
                            default:
                                break;
                        }
                    }

                    return TenFound && JackFound && QueenFound && KingFound && AceFound;

                } else { return false; }
            }
        }
    }
}
