using System.Text.Json.Serialization;

namespace SoTProgress.MyChest;

public class ChestItem
{
    [JsonPropertyName("#Type")]
    public string Type { get; set; }
    [JsonPropertyName("#Name")]
    public string Name { get; set; }
    public Taxonomy Taxonomy { get; set; }
    public string image { get; set; }
    public string title { get; set; }
    public string subtitle { get; set; }
    public bool showText { get; set; }
    public bool wide { get; set; }
}
