namespace NegativeEddy.SoT.Seasons;

public class SeasonProgress
{
    public DateTime ActiveFrom { get; set; }
    public DateTime ActiveUntil { get; set; }
    public bool IsActive { get; set; }
    public required string ThemeId { get; set; }
    public required List<Tier> Tiers { get; set; }
    public required List<ChallengeGroup> ChallengeGroups { get; set; }
    public required ProgressionPaths ProgressionPaths { get; set; }
    public required AvailablePaths AvailablePaths { get; set; }
    public float LevelProgress { get; set; }
    public int Tier { get; set; }
    public int Version { get; set; }
    public required string Title { get; set; }
    public required string Copy { get; set; }
    public required Images Images { get; set; }
    public required string CdnPath { get; set; }
    public int TotalChallenges { get; set; }
    public int CompleteChallenges { get; set; }
}
