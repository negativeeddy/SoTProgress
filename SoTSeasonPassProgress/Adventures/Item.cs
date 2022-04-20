namespace SoTProgress.Adventures
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public BackgroundImage BackgroundImage { get; set; }
        public Image Image { get; set; }
        public string ProgressText { get; set; }
        public int Threshold { get; set; }
        public string ProgressId { get; set; }
        public Progress Progress { get; set; }
        public string EntitlementId { get; set; }
        public bool EntitlementOwned { get; set; }
        public Entitlement Entitlement { get; set; }
    }
}
