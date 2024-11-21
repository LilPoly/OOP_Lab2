using Lab2.GameAccount;

namespace Lab2.Game;

public class GameHistory
{
    public string Id { get; }
    public Account Player1 { get; }
    public Account Player2 { get; }
    public int Rating { get; set; }
    public WinLose WinLoseRes { get; }

    public GameHistory(Account player1, Account player2, int rating, WinLose winLoseRes)
    {
        Id = GetId();
        Player1 = player1;
        Player2 = player2;
        Rating = rating;
        WinLoseRes = WinLoseRes;
    }
    
    private static string GetId()
    {
        return Guid.NewGuid().ToString();
           
    }
}