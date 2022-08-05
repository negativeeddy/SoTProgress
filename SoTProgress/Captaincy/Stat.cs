namespace SoTProgress.Captaincy
{
    public record struct Stat
    {
        public string LocalisedTitle { get; set; }
        public int Value { get; set; }
        public Substat[] SubStats { get; set; }
    }
}
