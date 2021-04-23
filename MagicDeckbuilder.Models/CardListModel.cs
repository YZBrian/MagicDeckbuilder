using System.Collections.Generic;

namespace Magic.Deckbuilder.Models
{
    public class CardListModel
    {
        private List<CardModel> CardModelsList { get; set; } = new List<CardModel>();

        public void AddCard(CardModel card)
        {
            CardModelsList.Add(card);
        }
    }
}