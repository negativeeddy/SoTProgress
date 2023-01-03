namespace SoTProgress.Leaderboard;

public class Band
{
    public int Index { get; set; }
    public required Entitlements Entitlements { get; set; }
    public required List<Result> Results { get; set; }
    public bool? IsUnrankedBand { get; set; }
}

