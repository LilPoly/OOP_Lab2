using Lab2.GameAccount;

namespace Lab2.Game;

public abstract class Game
{
    protected string TypeGame { get; set; }
    protected List<GameHistory> Results { get; }

    protected readonly Random Random;

    protected Game()
    {
        Results = new List<GameHistory>();
        Random = new Random();
    }
    
    public abstract void PlayGame(Account player1, Account player2, int rating);
}