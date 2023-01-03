using System.Text.Json.Serialization;

namespace NegativeEddy.SoT.Reputation;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
public record Tag
{
    [JsonPropertyName("#Name")]
    public required string Name { get; set; }

    [JsonPropertyName("#Value")]
    public required string Value { get; set; }
}
