namespace SoTProgress.Captaincy
{
    public record struct Ship
    {
        public string ShipId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public object SailImage { get; set; }
        public string BackgroundId { get; set; }
        public Alignment[] Alignments { get; set; }
    }
}
