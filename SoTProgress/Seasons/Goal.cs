namespace NegativeEddy.SoT.Seasons;

public class Goal
{
    public required string ProgressId { get; set; }
    public int Threshold { get; set; }
    public required string XPGain { get; set; }
    public required string Title { get; set; }
    public int ProgressValue { get; set; }
}