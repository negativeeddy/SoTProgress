using System.Collections.Generic;

namespace SoTSeasonPassProgress
{
    public class Tier
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public List<Level> Levels { get; set; }
    }
}