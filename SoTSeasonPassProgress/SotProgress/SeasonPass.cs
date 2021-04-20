﻿namespace SoTSeasonPassProgress
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class SeasonPass
    {
        public bool Locked { get; set; }
        public bool Owned { get; set; }
        public string EntitlementUrl { get; set; }
        public string EntitlementText { get; set; }
        public string EntitlementDescription { get; set; }
        public string CurrencyType { get; set; }
        public string Title { get; set; }
        public string Copy { get; set; }
        public Images Images { get; set; }
    }
}