using Blackjack_Game.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game.Models
{
    /// <summary>
    /// Auteur: Félix-Antoine Voyer
    /// Description: Classe contenant les informations du deck de cartes
    /// Date: 2026-11-16
    /// </summary>
    public class Deck
    {
        public List<Card> Cards { get; set; }

        /// <summary>
        /// Description: Constructeur permettant d'ajouter les cartes au deck
        /// Date: 2026-11-16
        /// </summary>
        public Deck()
        {
            Cards = new List<Card>();

            foreach (Suit s in Enum.GetValues(typeof(Suit)))
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                    Cards.Add(new Card(s, r));
        }

        /// <summary>
        /// Description: Méthode permettant de mélanger les cartes dans la liste
        /// Date: 2026-11-16
        /// </summary>
        public void Shuffle()
        {
            Random rnd = new Random();

            Cards = Cards.OrderBy(x => rnd.Next()).ToList();
        }

        public Card DrawCard()
        {
            Card c = Cards[0];
            Cards.RemoveAt(0);

            return c;
        }
    }
}
