using System;

namespace MagicDeckbuilder.Logic.Entities
{
    public class Card
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public int ManaCost { get; set; }
    }
}