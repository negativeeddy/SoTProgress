namespace SoTProgress.Leaderboard;

public class Entitlement
{
    public bool Owned { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}


public class Entitlements
{
    public Entitlement Next { get; set; }
    public Entitlement Current { get; set; }
    public Entitlement Previous { get; set; }
}

public class Result
{
    public string GamerTag { get; set; }
    public int Score { get; set; }
    public int Rank { get; set; }
    public bool? IsRequestingUser { get; set; }
}

public class Band
{
    public int Index { get; set; }
    public Entitlements Entitlements { get; set; }
    public List<Result> Results { get; set; }
    public bool? IsUnrankedBand { get; set; }
}

public class User
{
    public int band { get; set; }
    public int rank { get; set; }
    public int score { get; set; }
    public int toNextRank { get; set; }
}

public class LeaderBoardCategory
{
    public List<Band> Bands { get; set; }
    public User user { get; set; }
    public DateTime EndDate { get; set; }
}

public class LeaderBoard
{
    public LeaderBoardCategory global { get; set; }
    public LeaderBoardCategory friends { get; set; }
    public LeaderBoardCategory top { get; set; }
}

public class LeaderBoards
{
    public LeaderBoard current { get; set; }
    public LeaderBoard previous { get; set; }
    public string cdnPath { get; set; }
}

