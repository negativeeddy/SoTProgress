using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NegativeEddy.SoT.Reputation
{
    public class ReputationProgress
    {
        public TradingCompany AthenasFortune { get; set; }
        public TradingCompany HuntersCall { get; set; }
        public TradingCompany SeaDogs { get; set; }
        public TradingCompany GoldHoarders { get; set; }
        public TradingCompany OrderOfSouls { get; set; }
        public TradingCompany MerchantAlliance { get; set; }
        public CreatorCrew CreatorCrew { get; set; }
        public CampaignSet BilgeRats { get; set; }
        public CampaignSet TallTales { get; set; }
        public TradingCompany ReapersBones { get; set; }
    }
}
