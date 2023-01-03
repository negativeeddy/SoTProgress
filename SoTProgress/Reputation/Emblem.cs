using System.Text.Json.Serialization;

namespace NegativeEddy.SoT.Reputation;

public record Emblem
{
    public required string Image { get; set; }
    public required string DisplayName { get; set; }
    public required string Description { get; set; }
    public bool Completed { get; set; }
    public int Grade { get; set; }
    public int MaxGrade { get; set; }
    public int Threshold { get; set; }
    public int Value { get; set; }
    public bool HasScalar { get; set; }

    [JsonPropertyName("#Type")]
    public required string Type { get; set; }

    [JsonPropertyName("#Name")]
    public required string Name { get; set; }
    public required Taxonomy Taxonomy { get; set; }
    public bool locked { get; set; }
    public required string image { get; set; }
    public required string title { get; set; }
    public required string subtitle { get; set; }
    public double size { get; set; }
    public bool suppressProgress { get; set; }
    public bool? HasLockedImage { get; set; }
    public bool? New { get; set; }
    public int? Doubloons { get; set; }
}
