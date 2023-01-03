using System.Text.Json.Serialization;

namespace SoTProgress.MyChest;

public class Tag
{
    [JsonPropertyName("#Name")]
    public required string Name { get; set; }
    [JsonPropertyName("#Value")]
    public required string Value { get; set; }
}
