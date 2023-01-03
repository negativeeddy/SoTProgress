namespace SoTProgress.Adventures;

public class Section
{
    public required string Description { get; set; }
    public required string ProgressId { get; set; }
    public required Progress Progress { get; set; }
}
