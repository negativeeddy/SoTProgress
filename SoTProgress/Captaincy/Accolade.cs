namespace SoTProgress.Captaincy
{
    public record struct Accolade
    {
        public string ProgressId { get; set; }
        public string LocalisedTitle { get; set; }
        public bool IsPinned { get; set; }
        public int MilestoneLevel { get; set; }
        public DateTime? LevelReachedAt { get; set; }
        public int CurrentProgress { get; set; }
        public int Threshold { get; set; }
        public Stat[] Stats { get; set; }
    }
}
