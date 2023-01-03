namespace SoTProgress.Leaderboard;

// from https://www.seaofthieves.com/api/ledger/global/MerchantAlliance?count=10
public class LeaderBoards
{
    public required LeaderBoard current { get; set; }
    public required LeaderBoard previous { get; set; }
    public required string cdnPath { get; set; }
}

