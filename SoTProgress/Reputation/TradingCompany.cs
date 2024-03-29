﻿namespace NegativeEddy.SoT.Reputation;

public record TradingCompany
{
    public required string Motto { get; set; }
    public string? Rank { get; set; }
    public int? Level { get; set; }
    public int? Xp { get; set; }
    public NextCompanyLevel? NextCompanyLevel { get; set; }
    public int? PromotionsUnlocked { get; set; }
    public int? PromotionsTotal { get; set; }
    public int TitlesTotal { get; set; }
    public int TitlesUnlocked { get; set; }
    public int EmblemsTotal { get; set; }
    public int EmblemsUnlocked { get; set; }
    public int? ItemsUnlocked { get; set; }
    public int? ItemsTotal { get; set; }
    public EmblemInfo? Emblems { get; set; }
    public Dictionary<string, Campaign>? Campaigns { get; set; }

}
