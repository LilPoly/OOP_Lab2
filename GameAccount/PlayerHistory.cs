namespace Lab2.GameAccount;

public class PlayerHistory
{
    public static int Number = 1;
    public string TypeGame { get; }
    
    private static int _count_id = 1;
    public int Player_id { get; }
    public int Rating { get; }
    public WinLose WinLoseRes { get; }
    public Account Oponent { get; }
    public int BeforeRating { get; }
    public int AfterRating { get; }
    public int Bonus { get; }
    
    public PlayerHistory(string typeGame, int rating, WinLose winLoseRes,
        Account oponent, int beforeRating, int afterRating, int bonus)
    {
        TypeGame = typeGame;
        Player_id = _count_id++;
        Rating = rating;
        WinLoseRes = winLoseRes;
        Oponent = oponent;
        BeforeRating = beforeRating;
        AfterRating = afterRating;
        Bonus = bonus;
    }
}