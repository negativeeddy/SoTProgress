using System.Text.Json.Serialization;

namespace SoTProgress.MyChest
{
    public class MyChest
    {
        public Dictionary<string, ChestItem[]> chestData { get; set; }
        public Dictionary<string,string[]> categoryMap { get; set; }
    }

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

    public class Taxonomy
    {
        public Tag[] Tags { get; set; }
    }

    public class Tag
    {
        [JsonPropertyName("#Name")]
        public string Name { get; set; }
        [JsonPropertyName("#Value")]
        public string Value { get; set; }
    }
}
