namespace SoTProgress.Leaderboard;

public class Result
{
    public required string GamerTag { get; set; }
    public required int Score { get; set; }
    public required int Rank { get; set; }
    public bool? IsRequestingUser { get; set; }
}

