namespace SoTProgress.Leaderboard;

public class LeaderBoardCategory
{
    public required List<Band> Bands { get; set; }
    public required User user { get; set; }
    public required DateTime EndDate { get; set; }
}

