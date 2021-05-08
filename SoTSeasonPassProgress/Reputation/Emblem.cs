using System.Text.Json.Serialization;

namespace NegativeEddy.SoT.Reputation
{
    public class Emblem
    {
        public string Image { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public int Grade { get; set; }
        public int MaxGrade { get; set; }
        public int Threshold { get; set; }
        public int Value { get; set; }
        public bool HasScalar { get; set; }

        [JsonPropertyName("#Type")]
        public string Type { get; set; }

        [JsonPropertyName("#Name")]
        public string Name { get; set; }
        public Taxonomy Taxonomy { get; set; }
        public bool locked { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public double size { get; set; }
        public bool suppressProgress { get; set; }
        public bool? HasLockedImage { get; set; }
        public bool? New { get; set; }
        public int? Doubloons { get; set; }
    }

}
