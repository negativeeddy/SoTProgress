using System.Text.Json.Serialization;

namespace SoTProgress.MyChest
{
    public class Tag
    {
        [JsonPropertyName("#Name")]
        public string Name { get; set; }
        [JsonPropertyName("#Value")]
        public string Value { get; set; }
    }
}
