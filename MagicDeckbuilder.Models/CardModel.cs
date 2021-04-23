using System.Security.Cryptography;

namespace Magic.Deckbuilder.Models
{
    public class CardModel
    {
        public string Name { get;}
            private int Power { get;}
            private int Toughness { get;}
            private int ManaCost { get;}

            public CardModel(string name, int power, int toughness, int manaCost)
            {
                Name = name;
                Power = power;
                Toughness = toughness;
                ManaCost = manaCost;
            }
        }
    }
