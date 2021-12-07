namespace NegativeEddy.SoT.Reputation;

public class CampaignSet
{
    public string Motto { get; set; }
    public int TitlesTotal { get; set; }
    public int TitlesUnlocked { get; set; }
    public int EmblemsTotal { get; set; }
    public int EmblemsUnlocked { get; set; }
    public Dictionary<string, Campaign> Campaigns { get; set; }
}
