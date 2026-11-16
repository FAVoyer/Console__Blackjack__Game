using Blackjack_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game.Services
{
    /// <summary>
    /// Auteur: Félix-Antoine Voyer
    /// Description: Classe contenant la logique du jeu
    /// Date: 2026-11-16
    /// </summary>
    public class GameService
    {
        private Deck _deck;
        private Player _player;
        private Player _dealer;

        /// <summary>
        /// Description: Méthode gérant la logique du début d'une partie
        /// Date: 2026-11-16
        /// </summary>
        public void StartGame()
        {
            _deck = new Deck();
            _deck.Shuffle();

            _player = new Player("Player");
            _dealer = new Player("Dealer");

            _player.DrawCard(_deck);
            _dealer.DrawCard(_deck);
            _player.DrawCard(_deck);
            _dealer.DrawCard(_deck);


            Console.WriteLine("=== Blackjack ===");

            DisplayHand(_dealer);

            if (_dealer.Hand.CalcScore() == 21)
            {
                DisplayResult();
                return;
            }

            PlayPlayerTurn();

            if (_player.Hand.CalcScore() <= 21)
                PlayDealerTurn();

            DisplayResult();
        }

        /// <summary>
        /// Desription: Méthode permettant d'afficher les résultats
        /// Date: 2026-11-16
        /// </summary>
        private void DisplayResult()
        {
            int playerScore = _player.Hand.CalcScore();
            int dealerScore = _dealer.Hand.CalcScore();

            Console.WriteLine("\n=== GAME RESULT ===\n");

            if (playerScore > 21)
                Console.WriteLine("You busted! Dealer wins");
            else if (dealerScore > 21)
                Console.WriteLine("Dealer busted! You win");
            else if (playerScore > dealerScore)
                Console.WriteLine("You win!");
            else if (playerScore < dealerScore)
                Console.WriteLine("Dealer wins!");
            else if (dealerScore == 21)
                Console.WriteLine("Dealer Blackjack! You lose");
            else
                Console.WriteLine("Push!");
        }

        /// <summary>
        /// Description: Méthode gérant la logique du tour du dealer
        /// Date: 2026-11-16
        /// </summary>
        private void PlayDealerTurn()
        {
            Console.WriteLine("\nDealer's turn...");

            while (_dealer.Hand.CalcScore() < 17)
                _dealer.DrawCard(_deck);

            DisplayHand(_dealer);
        }

        /// <summary>
        /// Description: Méthode gérant la logique du tour du joueur
        /// Date: 2026-11-16
        /// </summary>
        private void PlayPlayerTurn()
        {
            while (true)
            {
                DisplayHand(_player);

                int score = _player.Hand.CalcScore();

                if(score > 21)
                {
                    Console.WriteLine("Bust! You lose.");
                    return;
                }

                Console.WriteLine("Hit or Stand? (H/S)");
                string choice = Console.ReadLine()?.ToUpper();

                if (choice == "H")
                    _player.DrawCard(_deck);
                else if (choice == "S")
                    break;
                else
                    Console.WriteLine("Invalid choice");
            }
        }

        /// <summary>
        /// Description: Méthode permettant d'afficher une main
        /// Date: 2026-11-16
        /// </summary>
        /// <param name="player">joueur dont il faut afficher la main</param>
        private void DisplayHand(Player player)
        {
            Console.WriteLine($"\n{player.Name}'s hand:");

            foreach (Card c in player.Hand.Cards)
                Console.WriteLine($"{c.Rank} of {c.Suit}");

            Console.WriteLine($"Score: {player.Hand.CalcScore()}");
        }
    }
}
