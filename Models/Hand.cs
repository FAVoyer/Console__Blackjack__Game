using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game.Models
{
    /// <summary>
    /// Auteur: Félix-Antoine Voyer
    /// Description: 
    /// Date: 2026-11-16
    /// </summary>
    public class Hand
    {
        public List<Card> Cards { get; set; }

        /// <summary>
        /// Description: Constructeur permettant de créer une liste de carte pour la main du joueur
        /// Date: 2026-11-16
        /// </summary>
        public Hand()
        {
            Cards = new List<Card>();
        }

        /// <summary>
        /// Description: Méthode permettant d'ajouter une carte à la main du joueur
        /// Date: 2026-11-16
        /// </summary>
        /// <param name="card">carte à ajouter</param>
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        /// <summary>
        /// Description: Méthode permettant de calculer le score de la main du joueur
        /// </summary>
        /// <returns>score de la main</returns>
        public int CalcScore()
        {
            int score = 0;
            int aceCount = 0;

            foreach (Card card in Cards)
            {
                if (card.Rank == Enums.Rank.Ace)
                {
                    score += 11;
                    aceCount++;
                }
                else if ((int)card.Rank >= 11)
                    score += 10;
                else
                    score += (int)card.Rank;
            }

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }
    }
}
