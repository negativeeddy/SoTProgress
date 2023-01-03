using System.Text.Json.Serialization;

namespace SoTProgress.MyChest;

public class ChestItem
{
    [JsonPropertyName("#Type")]
    public required string Type { get; set; }
    [JsonPropertyName("#Name")]
    public required string Name { get; set; }
    public required Taxonomy Taxonomy { get; set; }
    public required string image { get; set; }
    public required string title { get; set; }
    public required string subtitle { get; set; }
    public required bool showText { get; set; }
    public required bool wide { get; set; }
}
