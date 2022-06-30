namespace SoTProgress.Leaderboard;

// from https://www.seaofthieves.com/api/ledger/global/MerchantAlliance?count=10
public class LeaderBoards
{
    public LeaderBoard current { get; set; }
    public LeaderBoard previous { get; set; }
    public string cdnPath { get; set; }
}

