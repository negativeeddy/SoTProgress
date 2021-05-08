using System.Collections.Generic;

namespace NegativeEddy.SoT.Reputation
{
    public class TradingCompany
    {
        public string Motto { get; set; }
        public string Rank { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public NextCompanyLevel NextCompanyLevel { get; set; }
        public int PromotionsUnlocked { get; set; }
        public int PromotionsTotal { get; set; }
        public int TitlesTotal { get; set; }
        public int TitlesUnlocked { get; set; }
        public int EmblemsTotal { get; set; }
        public int EmblemsUnlocked { get; set; }
        public int ItemsUnlocked { get; set; }
        public int ItemsTotal { get; set; }
        public EmblemInfo Emblems { get; set; }
    }

}
