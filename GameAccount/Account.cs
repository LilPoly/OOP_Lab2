using Lab2.Game;

namespace Lab2.GameAccount;

public class Account
{
    private string UserName { get; }
    private int _currentRating = 1;

    protected int CurrentRating
    {
        get => _currentRating;
        set => _currentRating = value < 1 ? 1 : value;
    }
    
    protected List<PlayerHistory> Results { get; }

    public Account(string username)
    {
        UserName = username;
        Results = new List<PlayerHistory>();
        
    }
    
    public  void GetStats()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n\t\t{"Stats about",65} " + UserName);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(
            "________________________________________________________________________________________________________________________________________________________________\n" +
            "| № |       | Type game  |        |RATING GAME|       |     RESULT     |       |CHANGE|       |RATING|       |BONUS|\n" +
            "----------------------------------------------------------------------------------------------------------------------------------------------------------------");

        foreach (var result in Results)
        {
            Console.WriteLine(
                $"|{PlayerHistory.Number,2} |  -->  |{result.TypeGame,-12}|  -->  |     " +
                $"{result.Rating}     |  -->  |{UserName,5} {result.WinLoseRes,-4} {result.Oponent.UserName,-5}|" +
                $"  -->  |{result.BeforeRating,2} {(result.WinLoseRes == WinLose.Lose ? $"-{result.BeforeRating - result.AfterRating,2}" : $"+{result.AfterRating - result.BeforeRating,2}")}|" +
                $"  -->  |  {result.AfterRating,2}  |  -->  | +{result.Bonus}  |");
            PlayerHistory.Number++;
        }

        PlayerHistory.Number = 1;

        Console.WriteLine(
            "----------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
        Console.ResetColor();
    }

    public virtual void WinGame(string typeGame, GameHistory game, Account player)
    {
        var beforeRating = CurrentRating;
        CurrentRating += game.Rating;
        Results.Add(new PlayerHistory(typeGame, game.Rating, WinLose.Win, player, beforeRating, CurrentRating, 0));
    }

    public virtual void LoseGame(string typeGame, GameHistory game, Account player)
    {
        var beforeRating = CurrentRating;
        CurrentRating -= game.Rating;
        Results.Add(new PlayerHistory(typeGame, game.Rating, WinLose.Lose, player, beforeRating, CurrentRating, 0));
    }
}

