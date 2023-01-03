namespace SoTProgress.MyChest;

public class MyChest
{
    public required Dictionary<string, ChestItem[]> chestData { get; set; }
    public required Dictionary<string,string[]> categoryMap { get; set; }
}
