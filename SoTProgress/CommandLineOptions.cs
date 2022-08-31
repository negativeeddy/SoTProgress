using CommandLine;

namespace NegativeEddy.SoT;

public class CommandLineOptions
{
    [Option(shortName: 'C', longName: "captaincyfile", HelpText = "file path to Sea of Thieves captaincy file")]
    public string CaptaincyFilePath { get; set; }

    [Option(shortName: 'c', longName: "chestfile", HelpText = "file path to Sea of Thieves mychest file")]
    public string ChestFilePath { get; set; }

    [Option(shortName: 'l', longName: "leaderboardfile", HelpText = "file path to Sea of Thieves leaderboard file")]
    public string LeaderboardFilePath { get; set; }

    [Option(shortName: 'a', longName: "adventurefile", HelpText = "file path to Sea of Thieves adventure file")]
    public string AdventureFilePath { get; set; }

    [Option(shortName: 't', longName: "statsfile", HelpText = "file path to Sea of Thieves stats file")]
    public string StatsFilePath { get; set; }
    [Option(shortName: 's', longName: "seasonfile", HelpText = "file path to Sea of Thieves progress file")]
    public string SeasonFilePath { get; set; }

    [Option(shortName: 'r', longName: "reputationFile", HelpText = "file path to Sea of Thieves reputation file")]
    public string ReputationFilePath { get; set; }

    [Option(shortName: 'd', longName: "details", Required = false, HelpText = "Show full details when available", Default = false)]
    public bool ShowDetails { get; set; }

    [Option(shortName: 'i', longName: "incompleteOnly", Required = false, HelpText = "Only show incompleted goals", Default = false)]
    public bool Incomplete { get; set; }

    public const string HelpString =
@"Sea of Thieves data file path missing. (--help for help)

EXAMPLE USAGE: 
SoTProgress.exe --help
SoTProgress.exe -s seasons.json
SoTProgress.exe -s seasons.json -i
SoTProgress.exe -r reputation.json
SoTProgress.exe -d -C captaincy.json";
}
