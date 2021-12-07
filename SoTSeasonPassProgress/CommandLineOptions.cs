using CommandLine;

namespace NegativeEddy.SoT;

public class CommandLineOptions
{
    [Option(shortName: 's', longName: "seasonfile", HelpText = "file path to Sea of Seasons progress file")]
    public string SeasonFilePath { get; set; }

    [Option(shortName: 'r', longName: "reputationFile", HelpText = "file path to Sea of Seasons reputation file")]
    public string ReputationFilePath { get; set; }

    [Option(shortName: 'i', longName: "incompleteOnly", Required = false, HelpText = "Only show incompleted goals", Default = false)]
    public bool Incomplete { get; set; }
}
