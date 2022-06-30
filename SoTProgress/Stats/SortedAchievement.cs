using NegativeEddy.SoT.Reputation;

namespace SoTProgress.Stats
{
    public class SortedAchievement
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public Taxonomy Taxonomy { get; set; }
        public Achievement achievement { get; set; }
    }
}
