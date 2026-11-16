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
    /// Description: Classe contenant les informations d'une carte
    /// Date: 2026-11-16
    /// </summary>
    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
