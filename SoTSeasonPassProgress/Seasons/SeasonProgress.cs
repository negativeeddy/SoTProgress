using System;
using System.Collections.Generic;

namespace NegativeEddy.SoT.Seasons
{
    public class SeasonProgress
    {
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveUntil { get; set; }
        public bool IsActive { get; set; }
        public string ThemeId { get; set; }
        public List<Tier> Tiers { get; set; }
        public List<ChallengeGroup> ChallengeGroups { get; set; }
        public ProgressionPaths ProgressionPaths { get; set; }
        public AvailablePaths AvailablePaths { get; set; }
        public float LevelProgress { get; set; }
        public int Tier { get; set; }
        public int Version { get; set; }
        public string Title { get; set; }
        public string Copy { get; set; }
        public Images Images { get; set; }
        public string CdnPath { get; set; }
        public int TotalChallenges { get; set; }
        public int CompleteChallenges { get; set; }
    }
}