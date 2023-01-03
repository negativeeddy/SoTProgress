using NegativeEddy.SoT.Reputation;

namespace SoTProgress.Stats
{
    public record SortedAchievement
    {
        public required string Type { get; set; }
        public required string Name { get; set; }
        public required Taxonomy Taxonomy { get; set; }
        public required Achievement achievement { get; set; }
    }
}
