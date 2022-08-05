namespace SoTProgress.Captaincy
{
    public record struct Alignment
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string LocalisedTitle { get; set; }
        public int MilestoneSum { get; set; }
        public Accolade[] Accolades { get; set; }
    }
}
