namespace SoTProgress.Leaderboard;

public class Band
{
    public int Index { get; set; }
    public Entitlements Entitlements { get; set; }
    public List<Result> Results { get; set; }
    public bool? IsUnrankedBand { get; set; }
}

