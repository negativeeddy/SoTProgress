namespace SoTProgress.Adventures;

public class Story
{
    public required BackgroundImage BackgroundImage { get; set; }
    public required string Header { get; set; }
    public required Section[] Sections { get; set; }
}
