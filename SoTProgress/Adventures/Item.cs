namespace SoTProgress.Adventures;

public class Item
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Value { get; set; }
    public required BackgroundImage BackgroundImage { get; set; }
    public required Image Image { get; set; }
    public required string ProgressText { get; set; }
    public int Threshold { get; set; }
    public required string ProgressId { get; set; }
    public required Progress Progress { get; set; }
    public required string EntitlementId { get; set; }
    public bool EntitlementOwned { get; set; }
    public required Entitlement Entitlement { get; set; }
}
