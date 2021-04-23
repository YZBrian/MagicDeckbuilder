using Magic.Deckbuilder.Interfaces;
using MagicDeckbuilder.DAL.Repositories;

namespace Magic.Deckbuilder.Factories
{
    public class CardFactory
    {
        public static ICard CardList()
        {
            return new CardRepository();
        }
    }
}