using Lab2.GameAccount;

namespace Lab2.Game;

public class TrainingGame: Game
{
    public TrainingGame()
    {
        TypeGame = nameof(TrainingGame);
    }

    public override void PlayGame(Account player1, Account player2, int rating)
    {
        rating = 0;
        var random = Random.Next(0, 2);

        if (random == 0)
        {
            Results.Add(new GameHistory(player1, player2, rating, WinLose.Win));
            player1.WinGame(TypeGame, Results.Last(), player2);
            player2.LoseGame(TypeGame, Results.Last(), player1);
        }
        else
        {
            Results.Add(new GameHistory(player1, player2, rating, WinLose.Lose));
            player1.LoseGame(TypeGame, Results.Last(), player2);
            player2.WinGame(TypeGame, Results.Last(), player1);
        }
    }
}