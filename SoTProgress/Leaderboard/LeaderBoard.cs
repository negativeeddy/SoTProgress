namespace SoTProgress.Leaderboard;

public class LeaderBoard
{
    public required LeaderBoardCategory global { get; set; }
    public required LeaderBoardCategory friends { get; set; }
    public required LeaderBoardCategory top { get; set; }
}

