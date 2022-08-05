namespace SoTProgress.Captaincy
{
    public record struct Favourite
    {
        public string Type { get; set; }
        public int Index { get; set; }
        public int AlignmentIndex { get; set; }
        public int AccoladeIndex { get; set; }
    }
}
