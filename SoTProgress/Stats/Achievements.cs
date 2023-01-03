namespace SoTProgress.Stats
{
    public class Achievements
    {
        public required SortedAchievement[] sorted { get; set; }
        public required Achievement[] latest { get; set; }
    }
}
