namespace NegativeEddy.SoT.Seasons;

public class ChallengeGroup
{
    public string Id { get; set; }
    public List<Challenge> Challenges { get; set; }
    public string Title { get; set; }
    public string Copy { get; set; }
    public Images Images { get; set; }
    public int ProgressValue { get; set; }
    public int Threshold { get; set; }
    public float? Percentage { get; set; }
    public bool isCompleted { get; set; }
}