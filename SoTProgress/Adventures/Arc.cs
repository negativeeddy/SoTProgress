namespace SoTProgress.Adventures;

public class Arc
{
    public required Meta Meta { get; set; }
    public required string Title { get; set; }
    public required string Subtitle { get; set; }
    public DateTime Time { get; set; }
    public required string State { get; set; }
    public required Story Story { get; set; }
    public required Deeds Deeds { get; set; }
    public required Mementos Mementos { get; set; }
}
