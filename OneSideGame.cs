using GameNamespace;

namespace GameNamespace
{
    public class OneSideGame : BaseGame
    {
        public OneSideGame(string opponentName, int rating)
            : base(opponentName, rating) // Викликаємо конструктор базового класу
        {
            // Додаткова логіка, якщо потрібно
        }

      

        public override int CalculateRating()
        {
            return Rating; // Проста реалізація
        }
    }
}
