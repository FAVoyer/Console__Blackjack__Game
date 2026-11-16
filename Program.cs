using Blackjack_Game.Services;

namespace Blackjack_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameService game = new GameService();
            game.StartGame();

            while (true)
            {
                Console.WriteLine("New Game? (Y/N)");
                string choice = Console.ReadLine()?.ToUpper();
                if (choice == "Y")
                {
                    Console.Clear();
                    game.StartGame();
                }
                else if (choice == "N")
                    break;
                else
                    Console.WriteLine("Invalid input");
            }
        }
    }
}
