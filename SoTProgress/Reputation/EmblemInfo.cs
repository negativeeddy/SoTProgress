namespace NegativeEddy.SoT.Reputation;

public record EmblemInfo
{
    public int EmblemsTotal { get; set; }
    public int EmblemsUnlocked { get; set; }
    public required List<Emblem> Emblems { get; set; }
}
