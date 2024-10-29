namespace GameNamespace
{
    public class Game
    {
        static private int UnicId = 1 ;
        public int GameId { get; set; } 
        public string OpponentName { get; set; }
        public string Result { get; set; }
        public int Rating { get; set; }
        public int GamesCount { get; set; }

        // Конструктор
        public Game(string opponentName, string result, int rating, int gamesCount)
        {
            OpponentName = opponentName;
            Result = result;
            Rating = rating;
            GamesCount = gamesCount; 
            GameId = UnicId++;
        }
    }
}
