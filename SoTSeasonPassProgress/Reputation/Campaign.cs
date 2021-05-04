using System.Collections.Generic;

namespace NegativeEddy.SoT.Reputation
{
    public class Campaign
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public int EmblemsTotal { get; set; }
        public int EmblemsUnlocked { get; set; }
        public List<Emblem> Emblems { get; set; }
        public bool hasNew { get; set; }
    }

}
