using Lab2.Game;
using Lab2.GameAccount;

namespace Lab2;

internal static class Program
{
    public static void Main(string[] args)
    {
        var rnd = new Random();
        var Michael = new Account("Michael");
        var Steve = new PremiumAccount("Steve");
        var John = new VipAccount("John");
        
        FabricGame fabricGame = new FabricGame();

        Game.Game classicGame = fabricGame.CreateGame("Classic");
        Game.Game trainingGame = fabricGame.CreateGame("Training");

        var listGames = new List<Game.Game> { classicGame, trainingGame };
        
        
        for (var i = 0; i < 5; i++)
        {
            listGames[0].PlayGame(Michael,Steve,rnd.Next(2,8));
            listGames[0].PlayGame(Steve, John,rnd.Next(2,8));
        }
        
        for (var i = 0; i < 5; i++)
        {
            listGames[1].PlayGame(Michael,Steve, 0);
            listGames[1].PlayGame(Steve, John, 0);
        }

        
        Steve.GetStats();
        John.GetStats();
        Michael.GetStats();

    }
}