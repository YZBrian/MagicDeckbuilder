using System;
using System.Collections.Generic;
using System.Text;
using FeedForward3.DAL;
using MySql.Data.MySqlClient;
using Magic.Deckbuilder.Interfaces;
using Magic.Deckbuilder.Models;

namespace MagicDeckbuilder.DAL.Repositories
{
    public class CardRepository : ICard
    {
        private MySqlDataReader _reader;
        readonly MySqlConnection _databaseConnection = DbConn.connection();

        public CardListModel CardList()
        {
            string query = "SELECT * FROM cards";
            MySqlCommand command = new MySqlCommand(query, _databaseConnection);
            _databaseConnection.Open();
            CardListModel cardList = new CardListModel();

            _reader = command.ExecuteReader();

            if (_reader.HasRows)
            {
                while (_reader.Read())
                {
                    CardModel card = new CardModel(_reader.GetString("name"), _reader.GetInt32("power"), _reader.GetInt32("toughness"), _reader.GetInt32("manacost"));
                    cardList.AddCard(card);
                }
                _reader.Close();
            }
            return cardList;
        }
    }
}