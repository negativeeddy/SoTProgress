namespace SoTProgress.MyChest;

public class MyChest
{
#pragma warning disable IDE1006 // Naming Styles - needs to match JSON properties
    public required Dictionary<string, ChestItem[]> chestData { get; set; }
    public required Dictionary<string,string[]> categoryMap { get; set; }
#pragma warning restore IDE1006 // Naming Styles
}
