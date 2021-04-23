using System;
using Magic.Deckbuilder.Interfaces;
using Magic.Deckbuilder.Models;
using MagicDeckbuilder.DAL.Repositories;

namespace MagicDeckbuilder.Logic.Entities
{
    public class Card :ICard
    {
        /*
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public int ManaCost { get; set; }
        */

        private CardRepository _cardRepository = new CardRepository();

        public CardListModel CardList()
        {
            throw new NotImplementedException();
        }
    }
}