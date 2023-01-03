namespace NegativeEddy.SoT.Seasons;

public class Challenge
{
    public required string GoalId { get; set; }
    public int Threshold { get; set; }
    public required string XPGain { get; set; }
    public required string Category { get; set; }
    public required List<Goal> Goals { get; set; }
    public required string Title { get; set; }
    public required string Copy { get; set; }
    public required Images Images { get; set; }
    public int ProgressValue { get; set; }
    public float Percentage { get; set; }
    public bool isCompleted { get; set; }
}