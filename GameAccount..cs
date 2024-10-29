using GameNamespace;
using System.Collections.Generic;
using System.Timers;
namespace GameAccountNamesspace


{
    public class GameAccount
    {
        private int rating = 1;

        public string UserName { get; set; }
        public int CurrentRating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value < 1)
                {
                    rating = 1;

                }
                else
                {
                    rating = value;
                }
            }
        }
        public int GamesCount
        {
            get
            {
                return gameHistory.Count;

            }

        }
        public List<Game> gameHistory = new List<Game>();

        public GameAccount(string userName, int currentRating)
        {
            UserName = userName;
            if (currentRating < 0)
            {
                throw new ArgumentException("Count cannot be negative");
            }
            CurrentRating = currentRating;

        }

        public void WinGame(string opponentName, int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentException("Rating cannot be negative");
            }

            CurrentRating += rating;
            gameHistory.Add(new Game(opponentName, "Win", CurrentRating, GamesCount));
        }

        public void LoseGame(string opponentName, int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentException("Rating cannot be negative");
            }

            CurrentRating -= rating; // Рейтинг не може бути меншим за 1
            gameHistory.Add(new Game(opponentName, "Lose", CurrentRating, GamesCount));
        }

        public void GetStats()
        {
            Console.WriteLine($"Stats for {UserName}:");
            Console.WriteLine("|Game ID\t|\tGames Count\t|\tOpponent\t|\tResult\t|\tRating  |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            foreach (var game in gameHistory)
            {
                Console.WriteLine($"|{game.GameId}\t\t|\t{game.GamesCount}\t\t|\t{game.OpponentName}\t\t|\t{game.Result}\t|\t{game.Rating}\t|");
            }

        }
    }
}