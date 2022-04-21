using CommandLine;

namespace NegativeEddy.SoT;

public class CommandLineOptions
{
    [Option(shortName: 'c', longName: "chestfile", HelpText = "file path to Sea of Thieves mychest file")]
    public string ChestFilePath { get; set; }

    [Option(shortName: 'l', longName: "leaderboardfile", HelpText = "file path to Sea of Thieves leaderboard file")]
    public string LeaderboardFilePath { get; set; }

    [Option(shortName: 'a', longName: "adventurefile", HelpText = "file path to Sea of Thieves adventure file")]
    public string AdventureFilePath { get; set; }

    [Option(shortName: 's', longName: "seasonfile", HelpText = "file path to Sea of Thieves progress file")]
    public string SeasonFilePath { get; set; }

    [Option(shortName: 'r', longName: "reputationFile", HelpText = "file path to Sea of Thieves reputation file")]
    public string ReputationFilePath { get; set; }

    [Option(shortName: 'i', longName: "incompleteOnly", Required = false, HelpText = "Only show incompleted goals", Default = false)]
    public bool Incomplete { get; set; }

    public const string HelpString =
@"season or reputation file path missing. (--help for help)

EXAMPLE USAGE: 
SoTProgress.exe --help
SoTProgress.exe -s seasons.json
SoTProgress.exe -s seasons.json -i
SoTProgress.exe -r reputation.json";

}
