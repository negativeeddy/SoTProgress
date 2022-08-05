namespace SoTProgress.Captaincy
{

    public record struct CaptaincyInfo
    {
        public Favourite[] Favourites { get; set; }
        public Ship[] Ships { get; set; }
        public Pirate Pirate { get; set; }
        public Paths Paths { get; set; }
    }
}
