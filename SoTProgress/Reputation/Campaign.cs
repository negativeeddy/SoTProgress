namespace NegativeEddy.SoT.Reputation;

public class Campaign
{
    public required string Title { get; set; }
    public required string Desc { get; set; }
    public int EmblemsTotal { get; set; }
    public int EmblemsUnlocked { get; set; }
    public required List<Emblem> Emblems { get; set; }
    public bool hasNew { get; set; }
}
