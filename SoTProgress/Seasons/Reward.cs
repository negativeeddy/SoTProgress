namespace NegativeEddy.SoT.Seasons;

public class Reward
{
    public bool Locked { get; set; }
    public bool Owned { get; set; }
    public required string EntitlementUrl { get; set; }
    public required string EntitlementText { get; set; }
    public required string EntitlementDescription { get; set; }
    public required string CurrencyType { get; set; }
    public required string Title { get; set; }
    public required string Copy { get; set; }
    public required Images Images { get; set; }
}
