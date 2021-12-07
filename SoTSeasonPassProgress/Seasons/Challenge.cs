namespace NegativeEddy.SoT.Seasons;

public class Challenge
{
    public string GoalId { get; set; }
    public int Threshold { get; set; }
    public string XPGain { get; set; }
    public string Category { get; set; }
    public List<Goal> Goals { get; set; }
    public string Title { get; set; }
    public string Copy { get; set; }
    public Images Images { get; set; }
    public int ProgressValue { get; set; }
    public float Percentage { get; set; }
    public bool isCompleted { get; set; }
}