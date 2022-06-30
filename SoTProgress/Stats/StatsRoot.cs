using NegativeEddy.SoT.Seasons;

namespace SoTProgress.Stats
{
    public class StatsRoot
    {
        public Stats stats { get; set; }
        public Achievements achievements { get; set; }
        public SeasonProgress[] seasons { get; set; }
    }
}
