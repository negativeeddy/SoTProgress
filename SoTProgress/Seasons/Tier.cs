namespace NegativeEddy.SoT.Seasons;

public class Tier
{
    public int Number { get; set; }
    public required string Title { get; set; }
    public required List<Level> Levels { get; set; }
}
