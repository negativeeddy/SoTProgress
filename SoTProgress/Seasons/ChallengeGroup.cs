namespace NegativeEddy.SoT.Seasons;

public class ChallengeGroup
{
    public required string Id { get; set; }
    public required List<Challenge> Challenges { get; set; }
    public required string Title { get; set; }
    public required string Copy { get; set; }
    public required Images Images { get; set; }
    public int ProgressValue { get; set; }
    public int Threshold { get; set; }
    public float? Percentage { get; set; }
    public bool isCompleted { get; set; }
}