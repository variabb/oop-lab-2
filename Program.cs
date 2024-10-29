using GameAccountNamesspace;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо облікові записи гравців
            GameAccount account1 = new GameAccount("Varia", 1); // об'єкт класу
            GameAccount account2 = new GameAccount("Alex", 1);

            // Імітуємо ігри
            account1.WinGame(account2.UserName, 10);
            account1.WinGame(account2.UserName, 10);
            account2.LoseGame(account1.UserName, 10);

            account1.LoseGame(account2.UserName, 15);
            account2.WinGame(account1.UserName, 15);

            // Виводимо статистику для кожного гравця
            account1.GetStats();
            account2.GetStats();
        }
    }
}
