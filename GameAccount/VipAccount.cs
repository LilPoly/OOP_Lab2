using Lab2.Game;

namespace Lab2.GameAccount;

public class VipAccount: Account
{
    public VipAccount(string userName) : base(userName)
    {
    }

    public override void WinGame(string typeGame, GameHistory game, Account player)
    {
        var beforeRating = CurrentRating;
        CurrentRating += game.Rating * 2;

        Results.Add(new PlayerHistory(typeGame, game.Rating, WinLose.Win, player, beforeRating, CurrentRating, game.Rating));
    }

    public override void LoseGame(string typeGame, GameHistory game, Account player)
    {
        var bonus = 0;
        
        var beforeRating = CurrentRating;
        CurrentRating -= game.Rating / 2;
        Results.Add(new PlayerHistory(typeGame, game.Rating, WinLose.Lose, player, beforeRating, CurrentRating, bonus));
    }
}