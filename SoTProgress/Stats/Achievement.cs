namespace SoTProgress.Stats
{
    public class Achievement
    {
        public int Sort { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MediaUrl { get; set; }
        public int Gamerscore { get; set; }
        public long TimeUnlocked { get; set; }
        public bool IsSecret { get; set; }
        public int Progress { get; set; }
    }
}
