using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game.Models
{
    /// <summary>
    /// Auteur: Félix-Antoine Voyer
    /// Description: Classe contenant les informations et actions possible du joueur
    /// Date: 2026-11-16
    /// </summary>
    public class Player
    {
        public string Name { get; set; }
        public Hand Hand { get; set; }

        /// <summary>
        /// Description: Constructeur permettant d'initialiser le nom du joueur
        /// </summary>
        /// <param name="name">nom du joueur</param>
        public Player(string name)
        {
            Name = name;
        }

        public void DrawCard(Deck deck)
        {
            Hand.AddCard(deck.DrawCard());
        }
    }
}
