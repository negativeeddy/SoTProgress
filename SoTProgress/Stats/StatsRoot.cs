using NegativeEddy.SoT.Seasons;

namespace SoTProgress.Stats
{
    public class StatsRoot
    {
        public required Stats stats { get; set; }
        public required Achievements achievements { get; set; }
        public required SeasonProgress[] seasons { get; set; }
    }
}
